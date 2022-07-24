using Bookmarks.Models;
using System.Text.Json;

namespace Bookmarks.Services
{
    public class BookmarkDataService
    {
        public BookmarkDataService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string FileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "bookmarks.json"); }
        }

        public IEnumerable<Bookmark> GetAllBookmarks()
        {
            using (var jsonFileReader = File.OpenText(FileName))
            {
                return JsonSerializer.Deserialize<Bookmark[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}
