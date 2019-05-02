using Media_Organiser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Organiser.Data
{
    public class ConfigData
    {
        public ConfigData()
        {    
        }

        public List<DirectoryModel> directories = new List<DirectoryModel>();
        public List<PlaylistModel> playlists = new List<PlaylistModel>();
        public List<CategoryModel> categories = new List<CategoryModel>();

    }
}
