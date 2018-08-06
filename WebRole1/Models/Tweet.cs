using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRole1.Models
{
    public class Tweet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Content { get; set; }
    }
}