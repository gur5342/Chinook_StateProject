using System;
using System.Collections.Generic;
using System.Linq;

namespace Chinook.Data
{
    public class AlbumData : EntityData<Album>
    {

        //public AlbumData()
        //{
        //}

        //public static AlbumData _instance;

        //public static AlbumData Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //            _instance = new AlbumData();

        //        return _instance;
        //    }
        //}
        public Album GetByPK(int albumId)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                return context.Albums.FirstOrDefault(x => x.AlbumId == albumId);
            }
        }

        public List<Album> GetStateOrderByName()
        {
            throw new NotImplementedException();
        }

        public List<Album> GetCityOrderByName()
        {
            throw new NotImplementedException();
        }

        public void DeleteByPK(int albumId)
        {
            Album entity = GetByPK(albumId);

            if (entity == null)
                return;

            Delete(entity);
        }

        public List<Album> GetAllOrderByName()
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                var query = from x in context.Albums
                            orderby x.Title
                            select x;

                return query.ToList();
            }
        }

        public List<Album> Search(string albumTitle, int minArtistId, int maxArtistId)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                IQueryable<Album> query = from x in context.Albums
                                          select x;

                //lazy execution 지연된 실행

                if (albumTitle != null)
                    query = query.Where(x => x.Title.Contains(albumTitle));

                //if (string.IsNullOrEmpty(albumTitle) == false)
                //    query = query.Where(x => x.Title.Contains(albumTitle));

                if (minArtistId != 0)
                    query = query.Where(x => x.ArtistId >= minArtistId);

                if (maxArtistId != 0)  //0이라면 where문이 안붙음
                    query = query.Where(x => x.ArtistId <= maxArtistId);

                return query.ToList();
            }
        }
        public List<Album> Search(string albumTitle, /*Nullable<int> artistId*/ int? artistId)
        {
            using (ChinookEntities context = new ChinookEntities())
            {

                //Dictionary<int, string> dict = new Dictionary<int, string>();
                //var dict = new Dictionary<int, string>();

                Dictionary<int, string> artistNames = context.Artists.ToDictionary(x => x.ArtistId, x => x.Name);

                //List<Artist> artists = context.Artists.ToList();

                IQueryable<Album> query = from x in context.Albums
                                          select x;

                //lazy execution 지연된 실행

                //if (albumTitle != null)
                //    query = query.Where(x => x.Title.Contains(albumTitle));

                if (string.IsNullOrEmpty(albumTitle) == false)
                    query = query.Where(x => x.Title.Contains(albumTitle));

                //if(artistId != null) -> artistId는 int이기 때문에 null일 수 없다. -> int? 사용, HasValue 사용
                if (artistId.HasValue)
                    query = query.Where(x => x.ArtistId == artistId);

                //return query.ToList();
                var albums = query.ToList();

                foreach (var album in albums)
                    //album.ArtistName = artists.Find(x => x.ArtistId == album.ArtistId).Name;
                    album.ArtistName = artistNames[album.ArtistId]; //Dictionary

                return albums;
            }
        }
    }
}

