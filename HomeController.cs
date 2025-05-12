using BookShoppingCartMvcUI.Models;
using BookShoppingCartMvcUI.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static System.Reflection.Metadata.BlobBuilder;
using System.IO;

namespace BookShoppingCartMvcUI.Controllers
{
    public class HomeController : Controller
    {
        // Logger for logging messages or errors
        private readonly ILogger<HomeController> _logger;

        // Repository for handling home-related data operations
        private readonly IHomeRepository _homeRepository;

        // Constructor to initialize the HomeController with the logger and repository
        public HomeController(ILogger<HomeController> logger, IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
            _logger = logger;
        }


        // This method is an asynchronous action method that handles the default "Index" page request.
        // It takes optional parameters: 'sterm' (search term) and 'genreId' (genre identifier).
        public async Task<IActionResult> Index(string sterm = "", int genreId = 0)
        {
            // Call the GetBooks method of the _homeRepository asynchronously to retrieve a list of books
            // based on the provided search term ('sterm') and genre ID ('genreId').
            IEnumerable<Book> books = await _homeRepository.GetBooks(sterm, genreId);

            // Call the Genres method of the _homeRepository asynchronously to retrieve a list of genres.
            IEnumerable<Genre> genres = await _homeRepository.Genres();

            // Create a new instance of the BookDisplayModel, initializing it with the retrieved books, genres,
            // search term, and genre ID.
            BookDisplayModel bookModel = new BookDisplayModel()
            {
                Books = books,
                Genres = genres,
                STerm = sterm,
                GenreId = genreId
            };

            // Return the Index view with the populated BookDisplayModel.
            return View(bookModel);
        }


        // This method handles requests to the Privacy page
        public IActionResult Privacy()
        {
            // Return the Privacy view to the user
            return View();
        }

        // This method handles requests to the Error page
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Create an instance of ErrorViewModel and set its RequestId property to the current Activity's Id,
            // or if it is null, set it to the HttpContext's TraceIdentifier
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}