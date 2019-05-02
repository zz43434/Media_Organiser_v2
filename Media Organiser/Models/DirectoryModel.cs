using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Organiser.Models
{
    public class DirectoryModel
    {
        public string DirectoryName { get; set; }
        public BindingList<MediaFileModel> MediaFiles { get; set; }

        public DirectoryModel(string name, BindingList<MediaFileModel> files)
        {
            DirectoryName = name;
            MediaFiles = files;
        }
    }
}
