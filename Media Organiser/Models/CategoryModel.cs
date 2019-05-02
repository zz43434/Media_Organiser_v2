using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Organiser.Models
{
    public class CategoryModel
    {
        public string CategoryName { get; set; }

        public CategoryModel(string name)
        {
            CategoryName = name;
        }
    }
}
