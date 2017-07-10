using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Movie
    {
        private string title;
        private string category;

        public Movie(string title, string category)
        {
            this.title = title;
            this.category = category;
        }
        public string getTitle()
        {
            return title;
        }
        public string getCategory()
        {
            return category;
        }
    }
}
