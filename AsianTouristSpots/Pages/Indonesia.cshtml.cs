using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AsianTouristSpots.Pages
{
    public class IndonesiaModel : PageModel
    {
        private readonly ILogger<IndonesiaModel> _logger;

        public IndonesiaModel(ILogger<IndonesiaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Variable21"] = "The History of Bali covers a period from the Paleolithic to the present, and is characterized by migrations of people and cultures from other parts of Asia.";
            ViewData["Variable22"] = "Ubud has a known history back to the eighth century when the Javanese Hindu priest Rsi Marhandya came to Bali from Java, and meditated at the confluence of the two Wos rivers at Campuan, just west of the modern-day town center.";
            ViewData["Variable23"] = "The city's official history, however, starts in 1527, when the sultan of Bantam defeated the Portuguese there and called the place Jayakerta";
            ViewData["Variable24"] = "Borobudur, also transcribed Barabudur is a 9th-century Mahayana Buddhist temple in Magelang Regency, not far from the city of Magelang and the town of Muntilan, in Central Java, Indonesia.";
            ViewData["Variable25"] = "The Sacred Monkey Forest Sanctuary is located on spiritually-significant ground, constructed around 3 Hindu temples dating back to the 14th century.";
        }
    }
}