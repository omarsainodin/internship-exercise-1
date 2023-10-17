using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AsianTouristSpots.Pages
{
    public class IndiaModel : PageModel
    {
        private readonly ILogger<IndiaModel> _logger;

        public IndiaModel(ILogger<IndiaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Variable6"] = "The name of the city, Mumbai is derived from patron deity the Mother Goddess Mumba Devi, worshiped by the earliest inhabitants the Kolis.";
            ViewData["Variable7"] = "Goa is a state in western India with coastlines stretching along the Arabian Sea. Its long history as a Portuguese colony prior to 1961 is evident in its preserved 17th-century churches and the area’s tropical spice plantations.";
            ViewData["Variable8"] = "Jaipur was founded in 1727 by the Kachhwaha Rajput ruler Jai Singh II, the ruler of Amer, after whom the city is named.";
            ViewData["Variable9"] = "The city's nucleus was a settlement around a mud fort, built in 1537 by a local chief, Kempe Gowda.";
            ViewData["Variable10"] = "Udaipur was founded in 1559, by Maharana Udai Singh II in the fertile circular Girwa Valley to the southwest of Nagda, on the Banas River. The city was established as the new capital of the Mewar kingdom.";
        }
    }
}