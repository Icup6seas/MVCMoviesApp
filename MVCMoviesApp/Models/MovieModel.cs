using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMoviesApp
{
    public class MovieModel
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int YearRelease { get; set; }
        public bool InCollection { get; set; } = true;
    }
}