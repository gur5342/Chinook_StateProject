namespace Chinook.Data
{
    public partial class Artist : Entity
    {
        public override string ToText()//부분 클래스가 아니라 ToString()을 override할 수 없는 경우, ToText라는 함수를 새로 만들자.
        {
            return $"{ArtistId}:{Name}";
        }
        //public override string ToString()
        //{
        //    return $"{ArtistId}:{Name}";
        //}
    }
}
