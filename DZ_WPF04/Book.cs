using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_WPF04
{
    [Serializable]
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public string Description { get; set; }
    }
}
