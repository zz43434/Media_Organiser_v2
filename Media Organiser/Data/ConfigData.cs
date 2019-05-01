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
        public List<DirectoryModel> directories = new List<DirectoryModel>();
        string[] filePaths;
        public List<PlaylistModel> playlists = new List<PlaylistModel>();
        public List<CategoryModel> categories = new List<CategoryModel>();

        public static List<DirectoryModel> getDirectories()
        {
            return directories;
        }

        public string[] getFilePaths()
        {
            return filePaths;
        }

        public List<PlaylistModel> getPlaylists()
        {
            return playlists;
        }

        public List<CategoryModel> getCategories()
        {
            return categories;
        }

    }
}
