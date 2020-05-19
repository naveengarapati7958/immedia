using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class PhotoDetails
    {
        public Response response { get; set; }
        public class Response
        {
            public Photo photo { get; set; }
        }
        public class Photo
        {
            public string id { get; set; }
            public string createdAt { get; set; }
            public Source source { get; set; }
            public string prefix { get; set; }
            public string suffix { get; set; }
            public string width { get; set; }
            public string height { get; set; }
        }
        public class Source
        {
            public string name { get; set; }
            public string url { get; set; }
        }

    }
}
