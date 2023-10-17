using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AsianTouristSpots.Pages
{
    public class ThailandModel : PageModel
    {
        private readonly ILogger<ThailandModel> _logger;

        public ThailandModel(ILogger<ThailandModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Variable11"] = "The history of Bangkok dates at least back to the early 15th century, to when it was a village on the west bank of the Chao Phraya River, under the rule of Ayutthaya.";
            ViewData["Variable12"] = "Its Old City area still retains vestiges of walls and moats from its history as a cultural and religious center. It’s also home to hundreds of elaborate Buddhist temples, including 14th-century Wat Phra Singh and 15th-century Wat Chedi Luang, adorned with carved serpents.";
            ViewData["Variable13"] = "Phuket Town was created by colonists from India in the first century B.C.—that's thousands of years ago! In the 3rd century A.D.";
            ViewData["Variable14"] = "Initially inhabited by fishermen from the Malay Peninsula and Southern China, Ko Samui was isolated and self-sufficient with its fishing and coconut plantations.";
            ViewData["Variable15"] = "Phi Phi Don was initially populated by Thai Malay fishermen during the late-1940s, and later became a coconut plantation.";
        }
    }
}