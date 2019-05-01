using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Organiser.Models
{
    public class MediaFileModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }
        public string Comment { get; set; }
        public CategoryModel Category { get; set; }
    }
}
