using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AsianTouristSpots.Pages
{
    public class PhilippinesModel : PageModel
    {
        private readonly ILogger<PhilippinesModel> _logger;

        public PhilippinesModel(ILogger<PhilippinesModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Variable1"] = "The defense fortress is located in Intramuros, the walled city of Manila.The fort is one of the most important historical sites in Manila.";
            ViewData["Variable2"] = "In 1913, Luneta Park was changed to “Rizal Park”. The park remains a flagship of freedom and courage as numerous political rallies, oath takings, and national events are held within the park.";
            ViewData["Variable3"] = "The Banaue Rice Terraces are located on the mountains of Ifugao and were carved there about 2,000 years ago by the ancestors of the present day Philippines.";
            ViewData["Variable4"] = "Boracay is a small island in the central Philippines. It's known for its resorts and beaches. Along the west coast, White Beach is backed by palm trees, bars and restaurants.";
            ViewData["Variable5"] = "Vigan is a city in the Philippines, on the west coast of Luzon island. It's known for its preserved Spanish colonial and Asian architecture. ";
        }
    }
}