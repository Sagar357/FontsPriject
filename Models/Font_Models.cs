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
    public class FontContact
    {
            public int CustomerId { get; set; }
            public string CustomerName { get; set; }
            public string CustomerMobile { get; set; }
            public string CustomerMessage { get; set; }
            public string CustomerEmail { get; set; }
            public string CreatedDate { get; set; }
            public string ModifiedDate { get; set; }
            public string IsActive { get; set; }


    }

    //public class Sitemap_Model
    //{
    //    public string Url { get; set; }
    //    public string ModifiedDate { get; set; }
    //    public string Priority { get; set; }

    //}

    //public class Sitemap_List
    //{
    //    public Sitemap_List()
    //    {
    //        this.list = new List<Sitemap_Model>();
    //    }
    //    public List<Sitemap_Model> list { get; set; }

    //}
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
