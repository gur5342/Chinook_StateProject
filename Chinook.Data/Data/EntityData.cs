using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Chinook.Data
{
    public class EntityData<T> /*where T : class*/ where T : Entity //T는 Replacable, value type(값 타입)도 들어올 수 있다 -> Set<T>()는 T가 참조 타입이어야 한다는 제약 조건이 있음. -> 여기서 참조타입만 T에 들어올 수 있다는 제약 조건을 걸어주지 않으면 오류. where T:Class(참조타입의 대표가 Class이므로 그냥 Class를 쓰는 것.)
    {
        public string ToLongText()
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                List<T> list = context.Set<T>().ToList();

                //string result = "";

                //foreach (T entity in list)  // 동작은 하겠지만 entity의 개수가 많으면 많을 수록 비효율적.
                //{
                //    result += entity.ToString();
                //    result += ", ";
                //}

                StringBuilder builder = new StringBuilder();

                foreach (T entity in list)
                {
                    //builder.Append(entity.ToString());  
                    builder.Append(entity.ToText());//부분 클래스가 아니라 ToText()를 정의한 경우 -> EntityData<T>의 T는 참조타입이어야 한다는 제약조건이 있는데 모든 참조타입이 ToText()라는 메서드를 가진 것이 아니므로 오류. where T:Class가 아닌 where T:Entity로 제약조건을 바꾸고 Entity에 ToText()를 선언한 후 Artist와 Album이 Entity를 상속받으면 됨.
                    builder.Append(", ");
                }
                return builder.ToString();
            }
        }
        public int GetCount()
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                return context.Set<T>().Count();
            }
        }
        public int GetCount(Expression<Func<T, bool>> predicate)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                return context.Set<T>().Count(predicate);
            }
        }

        //public List<TResult> Select<TResult>(Expression<Func<T, TResult>> selector) //TResult는 R과 같은 이름으로 바꿔 쓸 수 있다.
        //{
        //    using (ChinookEntities context = new ChinookEntities())
        //    {
        //        return context.Set<T>().Select(selector).ToList();
        //    }
        //}

        ////Action<string>
        //private void PrintLog(string log)
        //{
        //    Console.WriteLine(log);
        //}
        public List<R> Select<R>(Expression<Func<T, R>> selector, Expression<Func<T, bool>> predicate = null)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                //context.Database.Log = PrintLog;

                IQueryable<T> query = context.Set<T>();

                if (predicate != null)
                    query = query.Where(predicate);

                return query.Select(selector).ToList();
                //return context.Set<T>().Select(selector).ToList();
            }
        }
        //public List<T> GetAll()
        //{
        //    using (ChinookEntities context = new ChinookEntities())
        //    {
        //        return context.Set<T>().ToList();
        //    }
        //}
        public List<T> GetAll(Expression<Func<T, bool>> predicate = null) //predicate의 기본값이 null
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                //이 부분을 쓰면 위의 GetAll은 필요 없다.
                IQueryable<T> query = context.Set<T>();

                if (predicate != null)
                    query = query.Where(predicate);

                //
                return query.ToList();
            }
        }

        public void Insert(T entity) //artist, album..등 나중에 다 상위 클래스로 올릴 것이므로 artist가 아니라 entity로 미리 정해놓음.
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                context.Set<T>().Add(entity); //이건 추가만 한 거고 데이터베이스에 반영하는 건 아래.
                //context.Entry(entity).State = System.Data.Entity.EntityState.Added;
                //todo : 예외 처리
                context.SaveChanges(); // 데이터베이스에 추가한 entity를 반영하는 코드.
            }
        }
        public void Update(T entity)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified; //context의.entity라는 Entry의. 상태에 = 변경된 상태값을 대입.
                //todo : 예외 처리
                context.SaveChanges();
            }
        }
        public void Delete(T entity)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                //todo : 예외 처리
                context.SaveChanges();
            }
        }
    }
}
