using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{ 
    public class TrackData : EntityData<Track>
    {
        public Track GetByPK(int trackId)           //GetByPK와 DeleteByPK가 entity마다 형태가 동일하므로 상위 클래스인 EntityData로 올릴 수 있다고 생각할 수도 있지만, PK는 entity마다 달라질 수 있다. playlist만 해도 PK가 int 타입 2개 -> 상위클래스로 올릴 수 없다.
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                return context.Tracks.FirstOrDefault(x => x.TrackId == trackId);
            }
        }
        public void DeleteByPK(int trackId)
        {
            Track entity = GetByPK(trackId);

            if (entity == null)
                return;

            Delete(entity);
        }

        public List<Track> Search(string trackName, int? artistId, int? albumId, decimal? minUnitPrice, decimal? maxUnitPrice)
        {

            //tuple
            //anonymous class
            ////var m1 = new { HP = 1, X = 2, Y = 3 };
            ////Console.WriteLine(m1.HP);
            ////Console.WriteLine(m1.X);

            using (ChinookEntities context = new ChinookEntities())
            {
                context.Database.Log = x => Debug.WriteLine(x); //

                // Track에는 Artist
                //Dictionary<int, string> artists = context.Artists.ToDictionary(x => x.ArtistId, x => x.Name);

                var artists = context.Artists.ToDictionary(x => x.ArtistId, x => x.Name); //AlbumId와 Title 쌍으로 이루어진 데이터를 artists로 가져옴.
                var albums = context.Albums.ToDictionary(x => x.AlbumId, x => x.Title); //AlbumId와 Title 쌍으로 이루어진 데이터를 albums로 가져옴.
                var genres = context.Genres.ToDictionary(x => x.GenreId, x => x.Name); 
                var mediaTypes = context.MediaTypes.ToDictionary(x => x.MediaTypeId, x => x.Name);
                // 이렇게 따로따로 쿼리를 날리면 빠르지만 쿼리를 날리는 컴퓨터의 메모리에 부담.

                var query = from x in context.Tracks
                                //select x; 그냥 x는 Track만 담음. -> 새로운 타입이 필요함 -> 익명 클래스
                            select new
                            {
                                ArtistId = x.Album.ArtistId,
                                Track = x
                            };

                //if(string.IsNullOrEmpty(trackName))
                if (trackName.IsNullOrEmpty() == false)
                    //query = query.Where(x => x.Name.Contains(trackName)); 여기서 x는 ArtistId와 Track을 동시에 담는 타입이므로 x.Name은 틀린 표현.
                    query = query.Where(x => x.Track.Name.Contains(trackName));

                if (albumId.HasValue) //if(albumId != null)과 같음
                    //query = query.Where(x => x.AlbumId == albumId.Value); // AlbumId는 int, albumId는 nullalble int
                    query = query.Where(x => x.Track.AlbumId == albumId.Value);
                if (minUnitPrice.HasValue)
                    //query = query.Where(x => x.UnitPrice >= minUnitPrice);
                    query = query.Where(x => x.Track.UnitPrice >= minUnitPrice);
                if (maxUnitPrice.HasValue)
                    //query = query.Where(x => x.UnitPrice <= maxUnitPrice);
                    query = query.Where(x => x.Track.UnitPrice <= maxUnitPrice);
                //var tracks = query.ToList(); // 여기서 쿼리가 날라가고 그걸 tracks에 담음(그냥 return하지 않고 tracks에 담는 이유는 다음 시간에 쓰기 위함.)
                var list = query.ToList(); //타입이 track만 담는 것이 아니므로 tracks는 올바르지 않은 이름. 위에는 쿼리를 조립하는 과정이고 .ToList()나 .ToDictionary를 하면 쿼리를 날리는 것.

                // 바로 그 다음시간 코드
                foreach(var x in list)
                {
                    //track.ArtistName = artists[track.ArtistId]; //에러. track에는 ArtistId값이 없다. -> Track에서 AlbumId를 통해 Album에 가서 ArtistId를 통해 Artist로 가 Name을 가져와야 함.

                    //track.AlbumTitle = track.AlbumId.HasValue ? albums[track.AlbumId.Value] : string.Empty; // 삼항 연산자는 권장하지 않음.
                    //if (track.AlbumId.HasValue) //AlbumId가 nullalble.
                    //    track.AlbumTitle = albums[track.AlbumId.Value];
                    //else
                    //    track.AlbumTitle = string.Empty;

                    //if (track.GenreId.HasValue) //GenreId가 nullalble.
                    //    track.GenreName = genres[track.GenreId.Value];
                    //else
                    //    track.GenreName = string.Empty;
                    if (x.Track.AlbumId.HasValue)
                        x.Track.AlbumTitle = albums[x.Track.AlbumId.Value];
                    else
                        x.Track.AlbumTitle = string.Empty;

                    if (x.Track.GenreId.HasValue)
                        x.Track.GenreName = genres[x.Track.GenreId.Value];
                    else
                        x.Track.GenreName = string.Empty;
                    x.Track.MediaTypeName = mediaTypes[x.Track.MediaTypeId];

                    x.Track.ArtistName = artists[x.ArtistId];
                }
                //

                List<int> intList = new List<int> { 3, 5, 1, 2 };
                List<string> stringList = intList.ConvertAll(x => x.ToString());
                // "3" "5" "1" "2"

                return list.ConvertAll(x => x.Track); // 아래와 같은 뜻(람다식)

                //List<Track> tracks = new List<Track>();
                //foreach (var x in list)
                //    tracks.Add(x.Track);

                //return tracks;

            }
        }
        public List<Track> Search2(string trackName, int? artistId, int? albumId, decimal? minUnitPrice, decimal? maxUnitPrice) //쿼리를 한 번에 날림.
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                context.Database.Log = x => Debug.WriteLine(x); //

                var query = from x in context.Tracks
                            select new
                            {
                                ArtistName = x.Album.Artist.Name,
                                GenreName = x.Genre.Name,
                                AlbumTitle = x.Album.Title,
                                MediaTypeName = x.MediaType.Name,
                                Track = x
                            };
                //이 방식으로 쿼리를 한 번에 처리하면 JOIN문이 수행됨 -> JOIN문은 Track의 데이터가 1000개, Album이 100개일 때 둘을 조인하면 연산을 1000*100번 수행해야함. Join이 많아질 수록 급격히 느려짐.
                if (trackName.IsNullOrEmpty() == false)
                    query = query.Where(x => x.Track.Name.Contains(trackName));
                if (albumId.HasValue) 
                    query = query.Where(x => x.Track.AlbumId == albumId.Value);
                if (minUnitPrice.HasValue)
                    query = query.Where(x => x.Track.UnitPrice >= minUnitPrice);
                if (maxUnitPrice.HasValue)
                    query = query.Where(x => x.Track.UnitPrice <= maxUnitPrice);
                var list = query.ToList();  

                foreach (var x in list)
                {
                    x.Track.ArtistName = x.ArtistName;
                    x.Track.AlbumTitle = x.AlbumTitle;
                    x.Track.GenreName = x.GenreName;
                    x.Track.MediaTypeName = x.MediaTypeName;
                }
                //

                List<int> intList = new List<int> { 3, 5, 1, 2 };
                List<string> stringList = intList.ConvertAll(x => x.ToString());
                // "3" "5" "1" "2"

                return list.ConvertAll(x => x.Track); // 아래와 같은 뜻(람다식)

                //List<Track> tracks = new List<Track>();
                //foreach (var x in list)
                //    tracks.Add(x.Track);

                //return tracks;

            }
        }

    }
    // string.IsNullOrEmpty(trackName)을 trackName.IsNullOrEmpty와 같이 더 직관적으로 쓸 수 있게 하기 위한 확장 메서드
    static class Extension
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}
