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
        public string Category { get; set; }

        public MediaFileModel(string name, string type, string path, string comment = "", string category = "")
        {
            Name = name;
            Type = type;
            Path = path;
            Comment = comment;
            Category = category;
        }

        public MediaFileModel()
        {
        }
    }
}
