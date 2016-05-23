using System.Collections.Generic;
using System.Xml.Linq;

namespace PicasaAPI
{
    public class RequestManager
    {
        public static IEnumerable<XElement> GetAlbums(string username)
        {
            var userUrl = "https://picasaweb.google.com/data/feed/api/user/default";
            return PicasaXmlProvider.GetEntries(userUrl, username);
        }

        public static IEnumerable<XElement> GetMedia(string username, string albumId)
        {
            var albumUrl = string.Format("https://picasaweb.google.com/data/feed/api/user/default/albumid/{0}?imgmax=1024", albumId);
            return PicasaXmlProvider.GetEntries(albumUrl, username);
        }
    }
}
