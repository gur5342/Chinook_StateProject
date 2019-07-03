using Chinook.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chinook.ConsoleUI
{
    public static class Extension // static class : '이 클래스는 정적(static) 멤버만 들어있다.'
    {
        // 확장 메서드(extension method)
        public static bool IsEven(this int n) // 마치 int라는 타입의 멤버 함수인 것 처럼 동작한다는 뜻. int는 Int32(구조체)-.NET Framework에 속함. **LINQ의 핵심 문법**
        {
            return n % 2 == 0;
        }
    }
    class Program
    {
        //// Func<int,bool>
        //static bool IsEven_(int x)
        //{
        //    return x % 2 == 0;
        //}
        static void Main(string[] args)
        {
            ////select ArtistId from Artist
            //ArtistData ad = new ArtistData();

            ////List<string> list = ad1.Select(x => x.Name); //x=>x.Name은 string 반환
            ////List<string> list = ArtistData.Instance.Select(x => x.Name);
            ////foreach(string name in list)
            ////    Console.WriteLine(name);

            ////ArtistData ad2 = new ArtistData();
            ////List<int> list2 = ad2.Select(x => x.ArtistId); //x=>x.ArtistId는 int 반환. Select라는 메서드가 generic으로 들어갈 수 있다면 모든 타입에서 쓸 수 있다는 점이 대단한 점.
            ////List<int> list2 = ArtistData.Instance.Select(x => x.ArtistId);
            ////foreach (int artistId in list2)
            ////    Console.WriteLine(artistId);

            ////List<int> list3 = AlbumData.Instance.Select(x => x.AlbumId);
            ////foreach (int albumId in list3)
            ////    Console.WriteLine(albumId);
            ////return;
            ////ArtistData ad = new ArtistData();
            ////List<Artist> list = ad.GetAll(x => x.ArtistId < 5); // x=>x.ArtistId<5는 bool 반환.
            ////foreach(var artist in list)
            ////{
            ////    Console.WriteLine(artist.ToText());
            ////}
            ////return;
            //string longText = ad.ToLongText();
            //// "1.AC/EC, 2:Accept, 3:Aerosmith"

            //Console.WriteLine(longText);

            //var albumData = new AlbumData();
            //string longText2 = albumData.ToLongText();

            //Console.WriteLine(longText2);
            //Console.WriteLine(ad.GetCount());
            //Console.WriteLine(ad.GetCount(x=>x.Name.Contains("queen")));
            ////int[] ar = new int[3];
            ////int c = ar.Count();//ar.Length()와 같은 역할. Count()는 확장 메서드로 제공되는 것.
            //int[] ar = new int[]{ 3, 5, 1, 2 };
            ////int countOfEven = ar.Count(x=> x%2==0); // 아래처럼 메서드를 따로 만들어서 쓰는 것도 가능하지만 람다식이 더 간단함.
            //int countOfEven = ar.Count(IsEven_);

            //int i = 3;

            //Console.WriteLine(i.IsEven());
            //Console.WriteLine(Extension.IsEven(i));

            //////데이터베이스에 연결이 제대로 되었는지 확인하는 코드
            ////ChinookEntities context = new ChinookEntities();
            ////int count = context.Artists.Count(); //Count는 내장된 메서드
            ////context.Dispose(); // 반드시 닫아줘야 함. 하지 않으면 조금씩 메모리 누수
            ////Console.WriteLine(count);

            //using (ChinookEntities context = new ChinookEntities()) // dispose를 따로 해주지 않아도 되는 문법.
            //{
            //    int count = context.Artists.Count(); //Count는 내장된 메서드
            //    Console.WriteLine(count);
            //}

            //-------------------------------DataRepository---------------------------------------------------------------------------------------------------
            //string albumName = "the";
            //int minArtistId = 5;
            //int maxArtistId = 100;
            ////List<Album> albums = DataRepository.Album.GetAll(x =>
            ////                        x.Title.Contains(albumName) &&
            ////                        x.ArtistId >= minArtistId &&
            ////                        x.ArtistId <= maxArtistId);

            //List<Album> albums = DataRepository.Album.Search(albumName, minArtistId, maxArtistId);

            //List<string> list = DataRepository.Artist.Select(x => x.Name, x => x.ArtistId < 5);
            //foreach (string name in list)
            //    Console.WriteLine(name);

            //List<int> list2 = DataRepository.Artist.Select(x => x.ArtistId);
            //foreach (int artistId in list2)
            //    Console.WriteLine(artistId);

            //List<int> list3 = DataRepository.Album.Select(x => x.AlbumId);
            //foreach (int albumId in list3)
            //    Console.WriteLine(albumId);

            //----------------------------------20190531------------------------------------------------
            var albums = DataRepository.Album.Search(null, null);
            Console.WriteLine(albums.Count);

            albums = DataRepository.Album.Search("The", null);
            Console.WriteLine(albums.Count);

            albums = DataRepository.Album.Search("The", 1);
            Console.WriteLine(albums.Count);
        }
    }
}
