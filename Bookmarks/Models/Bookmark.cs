
using System.Text.Json;

namespace Bookmarks.Models
{
    public class Bookmark
    {
        public string Name { get; set; }
        public string Url { get; set; }

        public override string ToString() => JsonSerializer.Serialize(this);
    }
}
