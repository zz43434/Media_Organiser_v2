using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Organiser.Models
{
    public class PlaylistModel
    {
        public string PlaylistName { get; set; }
        public List<MediaFileModel> MediaFiles { get; set; }

        public PlaylistModel(string name, List<MediaFileModel> files)
        {
            PlaylistName = name;
            MediaFiles = files; 
        }
    }
}
