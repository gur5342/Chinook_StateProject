namespace Chinook.Data
{
    partial class Album : Entity
    {
        public override string ToText()//부분 클래스가 아니라 ToString()을 override할 수 없는 경우, ToText라는 함수를 새로 만들자. -> ConsoleUI program.cs로 가면
        {
            return Title;
        }
        //public override string ToString()
        //{
        //    return Title;
        //}
        public string ArtistName { get; set; } // ArtistId가 아닌 Artist의 Name을 출력하기 위함.
    }
}
