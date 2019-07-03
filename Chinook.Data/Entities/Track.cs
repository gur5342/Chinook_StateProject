using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public partial class Track : Entity
    {
        public override string ToText()
        {
            return Name;
        }

        public string AlbumTitle { get; internal set; } // TrackSearchControl에서 AlbumId 열을 통해 Title을 보여주기 위한 코드.

        public string ArtistName { get; internal set; } // TrackSearchControl에서 ArtistId 열을 통해 Name을 보여주기 위한 코드.

        public string MediaTypeName { get; internal set; } // TrackSearchControl에서 MediaType 열을 통해 Name을 보여주기 위한 코드.

        public string GenreName { get; internal set; } // TrackSearchControl에서 GenreId 열을 통해 Name을 보여주기 위한 코드.

        public string GetLength()   // 메서드를 사용하면 바인딩에서 사용할 수 없다. 바인딩에선 자동이든 아니든 프로퍼티여야 한다. // 34719 -> 5'43''
        {
            int value = Milliseconds / 1000; //343
            return $"{value / 60}'{value % 60}";
        }

        public string Length // 34719 -> 5'43''
        {
            get
            {
                int value = Milliseconds / 1000; //343
                return $"{value / 60}'{value % 60}''";
            }
        }
    }

}
