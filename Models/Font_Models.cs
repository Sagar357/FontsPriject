using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FontsPriject.Models
{
    public class Font_Models
    {
        public int fontId { get; set; }
        public string fontFamily { get; set; }
    }

    public class Font_List
    {
        public Font_List()
        {
            this.list = new List<Font_Models>();
        }
        public List<Font_Models> list { get; set; }
        public string text { get; set; }
        public string message { get; set; }
    }
}

       /* public class Font_Size()
       {
    public font_Size()
    {
    this.size= new size<Font_Size>();
        }
    public size<Font_Models> size {get;set;}
       public string text {get:set;}
       public string message {get:set;}
       }


    }
}*/
