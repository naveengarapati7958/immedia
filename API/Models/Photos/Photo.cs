using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Photos
{
    public class Photo
    {
        public Response response { get; set; }
    }

    public class Response
    {
        public Photos photos { get; set; }
    }

    public class Photos
    {
        public Items[] items { get; set; }
    }

    public class Items
    {
        public string id { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
        public string width { get; set; }
        public string height { get; set; }

    }


}
