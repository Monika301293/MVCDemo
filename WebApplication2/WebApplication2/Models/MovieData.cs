using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class MovieData
    {
        public string Id;
        public string Name;
        public string releaseYear;
        public string imageUrl;
        public Category category;

        public enum Category
        {
            Drama = 0,
            Triller = 1,
            Romance =2,
            Action =3
        }
    }
}