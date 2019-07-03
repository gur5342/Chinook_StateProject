using System;
using System.Collections.Generic;
using System.Linq;

namespace Chinook.Data  //기본적으로는 Chinook.Data.Data로 폴더 이름까지 다 써주는 것이 원칙이지만, Chinook.tt에 Artist의 namespace가 Chinook.Data로 고정되어 바꿀 수 없으므로 맞춰주는 것.
{
    public class ArtistData : EntityData<Artist> //generic을 쓰면 <T>의 자리에 Artist가 들어가야 함. ArtistData의 경우 EntityData class에서 T값에 Artist가 들어간다.
    {

        //public ArtistData()
        //{
        //}

        //public static ArtistData _instance;

        //public static ArtistData Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //            _instance = new ArtistData();

        //        return _instance;
        //    }
        //}
        public List<Artist> GetAllOrderByName()
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                var query = from x in context.Artists
                            orderby x.Name
                            select x;

                return query.ToList();

                //return context.Artists.OrderBy ~~~ FirstOrDefault(x => x.ArtistId == artistId);    
            }
        }
        public Artist GetByPK(int artistId) //GetByPK랑 DeleteByPK는 매개변수가 각각 다르므로 EntityData로 못 올림.
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                return context.Artists.FirstOrDefault(x => x.ArtistId == artistId);    // First : 조건을 만족시키는 것이 없으면 예외를 던짐. FirstOrDefault : 조건을 만족시키는 것이 없으면 Default가 반환. Artist의 Default값은 null(Artist가 class이므로). x는 각 entity.
            }
        }
        public void DeleteByPK(int artistId)    //GetByPK로 DB에 한 번 갔다가 entity가 null이 아니라면 Delete로 다시 DB에 다시 가므로 성능면에서 비효율적이지만, DeleteByPK가 자주 쓰이지 않는 경우 복잡도를 낮출 수 있다면 이렇게 써도 크게 상관 없음.
        {                                       //다만 많이 쓰인다면 복잡도가 조금 높더라도 성능을 우선시해야 함. -> 성능 검사 툴 : profiler
            Artist entity = GetByPK(artistId);

            if (entity == null)
                return;

            Delete(entity);
        }

    }
}
