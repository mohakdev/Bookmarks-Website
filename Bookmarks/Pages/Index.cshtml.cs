using Microsoft.AspNetCore.Mvc;
using Bookmarks.Services;
using Bookmarks.Models;

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bookmarks.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public BookmarkDataService _bookmarkDataService;
        public IEnumerable<Bookmark> Bookmark { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, BookmarkDataService bookmarkData)
        {
            _logger = logger;
            _bookmarkDataService = bookmarkData;
        }

        public void OnGet()
        {
            Bookmark = _bookmarkDataService.GetAllBookmarks();
        }
    }
}