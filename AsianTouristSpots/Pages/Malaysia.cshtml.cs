using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AsianTouristSpots.Pages
{
    public class MalaysiaModel : PageModel
    {
        private readonly ILogger<MalaysiaModel> _logger;

        public MalaysiaModel(ILogger<MalaysiaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Variable16"] = "The site planning for PETRONAS Twin Towers began in January 1992, led by distinguished architect Cesar Pelli along with Deejay Cerico, J.C. Guinto and Dominic Saibo.";
            ViewData["Variable17"] = "The limestone forming Batu Caves is said to be around 400 million years old. Some of the cave entrances were used as shelters by the indigenous Temuan people (a tribe of Orang Asli). As early as 1860, Chinese settlers began excavating guano for fertilising their vegetable patches.";
            ViewData["Variable18"] = "KL Tower is managed by Menara Kuala Lumpur Sdn. Bhd., a wholly owned subsidiary of the Telekom Malaysia Group.";
            ViewData["Variable19"] = "The park began operations in 1992 and was officiated by the then Prime Minister of Malaysia, Tun Mahathir bin Mohamad, on 29 April 1993.";
            ViewData["Variable20"] = "Taman Negara is known for its stunning natural beauty, with lush green forests, cascading waterfalls, and diverse wildlife.";
        }
    }
}