using Microsoft.AspNetCore.Mvc;

namespace HexaLingo.Controllers
{
    public class DarkModeController : Controller
    {
        public IActionResult SetDarkModePreference(bool isDarkMode)
        {
            // Zapisz preferencje w bazie danych lub ciasteczku
            // ...

            return RedirectToAction("Index", "Home");
        }
    }
}
