using HexaLingo.Data;
using HexaLingo.Models;
using HexaLingo.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;


namespace HexaLingo.Controllers
{
    public class WordController : Controller
    {
        private readonly HexaLingoDbContext _context;
        private readonly ILogger<WordController> _logger;

        public WordController(HexaLingoDbContext context, ILogger<WordController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                _logger.LogInformation("Attempting to retrieve data from the database.");

                var words = await _context.Words.ToListAsync();

                return View(words);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error retrieving data from the database: {ex.Message}");
                throw; // Re-throw the exception to see it in the console.
            }
        }

        public IActionResult AddToFavorite(int id)
        {
            var word = _context.Words.Find(id);

            if (word != null)
            {
                // Odwróć stan ulubionego
                word.IsFavorite = !word.IsFavorite;
                _context.SaveChanges();
            }

            // Zwróć informacje o tym, czy słówko jest ulubione
            return Json(new { isFavorite = word.IsFavorite });

            /*return RedirectToAction("SavedWords");*/
        }


        public IActionResult SavedWords()
        {
            // Pobierz zapisane słówka użytkownika
            var savedWords = _context.Words.Where(w => w.IsFavorite).ToList();

            return View(savedWords);
        }

        public IActionResult English()
        {
            var greetings = _context.Words.Where(w => w.Category == "Greetings" && w.Language == "English").ToList();
            var basicphrases = _context.Words.Where(w => w.Category == "BasicPhrases" && w.Language == "English").ToList();
            var weather = _context.Words.Where(w => w.Category == "Weather" && w.Language == "English").ToList();
            var family = _context.Words.Where(w => w.Category == "Family" && w.Language == "English").ToList();
            var work = _context.Words.Where(w => w.Category == "Work" && w.Language == "English").ToList();
            var numbers = _context.Words.Where(w => w.Category == "Numbers" && w.Language == "English").ToList();
            var colors = _context.Words.Where(w => w.Category == "Colors" && w.Language == "English").ToList();
            var food = _context.Words.Where(w => w.Category == "Food" && w.Language == "English").ToList();
            var time = _context.Words.Where(w => w.Category == "Time" && w.Language == "English").ToList();
            var shopping = _context.Words.Where(w => w.Category == "Shopping" && w.Language == "English").ToList();
            var travel = _context.Words.Where(w => w.Category == "Travel" && w.Language == "English").ToList();
            var body = _context.Words.Where(w => w.Category == "Body" && w.Language == "English").ToList();
            var schooleducation = _context.Words.Where(w => w.Category == "SchoolEducation" && w.Language == "English").ToList();
            var sport = _context.Words.Where(w => w.Category == "Sport" && w.Language == "English").ToList();
            var emotions = _context.Words.Where(w => w.Category == "Emotions" && w.Language == "English").ToList();
            var transportation = _context.Words.Where(w => w.Category == "Transportation" && w.Language == "English").ToList();
            var directionsplaces = _context.Words.Where(w => w.Category == "DirectionsPlaces" && w.Language == "English").ToList();
            var leisureentertainment = _context.Words.Where(w => w.Category == "LeisureEntertainment" && w.Language == "English").ToList();
            var homeliving = _context.Words.Where(w => w.Category == "HomeLiving" && w.Language == "English").ToList();
            var clothesfashion = _context.Words.Where(w => w.Category == "ClothesFashion" && w.Language == "English").ToList();
            var technology = _context.Words.Where(w => w.Category == "Technology" && w.Language == "English").ToList();
            var health = _context.Words.Where(w => w.Category == "Health" && w.Language == "English").ToList();
            var animals = _context.Words.Where(w => w.Category == "Animals" && w.Language == "English").ToList();
            var socialrelations = _context.Words.Where(w => w.Category == "SocialRelations" && w.Language == "English").ToList();
            var goalsdreams = _context.Words.Where(w => w.Category == "GoalsDreams" && w.Language == "English").ToList();
            var holidaysoccasions = _context.Words.Where(w => w.Category == "HolidaysOccasions" && w.Language == "English").ToList();



            var englishViewModel = new EnglishViewModel
            {
                Greetings = greetings,
                BasicPhrases = basicphrases,
                Weather = weather,
                Family = family,
                Work = work,
                Numbers = numbers,
                Colors = colors,
                Food = food,
                Time = time,
                Shopping = shopping,
                Travel = travel,
                Body = body,
                SchoolEducation = schooleducation,
                Sport = sport,
                Emotions = emotions,
                Transportation = transportation,
                DirectionsPlaces = directionsplaces,
                LeisureEntertainment = leisureentertainment,
                HomeLiving = homeliving,
                ClothesFashion = clothesfashion,
                Technology = technology,
                Health = health,
                Animals = animals,
                SocialRelations = socialrelations,
                GoalsDreams = goalsdreams,
                HolidaysOccasions = holidaysoccasions
            };

            return View(englishViewModel);
        }

        public IActionResult Spanish()
        {
            var greetings = _context.Words.Where(w => w.Category == "Greetings" && w.Language == "Spanish").ToList();
            var basicphrases = _context.Words.Where(w => w.Category == "BasicPhrases" && w.Language == "Spanish").ToList();
            var weather = _context.Words.Where(w => w.Category == "Weather" && w.Language == "Spanish").ToList();
            var family = _context.Words.Where(w => w.Category == "Family" && w.Language == "Spanish").ToList();
            var work = _context.Words.Where(w => w.Category == "Work" && w.Language == "Spanish").ToList();
            var numbers = _context.Words.Where(w => w.Category == "Numbers" && w.Language == "Spanish").ToList();
            var colors = _context.Words.Where(w => w.Category == "Colors" && w.Language == "Spanish").ToList();
            var food = _context.Words.Where(w => w.Category == "Food" && w.Language == "Spanish").ToList();
            var time = _context.Words.Where(w => w.Category == "Time" && w.Language == "Spanish").ToList();
            var shopping = _context.Words.Where(w => w.Category == "Shopping" && w.Language == "Spanish").ToList();
            var travel = _context.Words.Where(w => w.Category == "Travel" && w.Language == "Spanish").ToList();
            var body = _context.Words.Where(w => w.Category == "Body" && w.Language == "Spanish").ToList();
            var schooleducation = _context.Words.Where(w => w.Category == "SchoolEducation" && w.Language == "Spanish").ToList();
            var sport = _context.Words.Where(w => w.Category == "Sport" && w.Language == "Spanish").ToList();
            var emotions = _context.Words.Where(w => w.Category == "Emotions" && w.Language == "Spanish").ToList();
            var transportation = _context.Words.Where(w => w.Category == "Transportation" && w.Language == "Spanish").ToList();
            var directionsplaces = _context.Words.Where(w => w.Category == "DirectionsPlaces" && w.Language == "Spanish").ToList();
            var leisureentertainment = _context.Words.Where(w => w.Category == "LeisureEntertainment" && w.Language == "Spanish").ToList();
            var homeliving = _context.Words.Where(w => w.Category == "HomeLiving" && w.Language == "Spanish").ToList();
            var clothesfashion = _context.Words.Where(w => w.Category == "ClothesFashion" && w.Language == "Spanish").ToList();
            var technology = _context.Words.Where(w => w.Category == "Technology" && w.Language == "Spanish").ToList();
            var health = _context.Words.Where(w => w.Category == "Health" && w.Language == "Spanish").ToList();
            var animals = _context.Words.Where(w => w.Category == "Animals" && w.Language == "Spanish").ToList();
            var socialrelations = _context.Words.Where(w => w.Category == "SocialRelations" && w.Language == "Spanish").ToList();
            var goalsdreams = _context.Words.Where(w => w.Category == "GoalsDreams" && w.Language == "Spanish").ToList();
            var holidaysoccasions = _context.Words.Where(w => w.Category == "HolidaysOccasions" && w.Language == "Spanish").ToList();


            var spanishViewModel = new SpanishViewModel
            {
                Greetings = greetings,
                BasicPhrases = basicphrases,
                Weather = weather,
                Family = family,
                Work = work,
                Numbers = numbers,
                Colors = colors,
                Food = food,
                Time = time,
                Shopping = shopping,
                Travel = travel,
                Body = body,
                SchoolEducation = schooleducation,
                Sport = sport,
                Emotions = emotions,
                Transportation = transportation,
                DirectionsPlaces = directionsplaces,
                LeisureEntertainment = leisureentertainment,
                HomeLiving = homeliving,
                ClothesFashion = clothesfashion,
                Technology = technology,
                Health = health,
                Animals = animals,
                SocialRelations = socialrelations,
                GoalsDreams = goalsdreams,
                HolidaysOccasions = holidaysoccasions
            };

            return View(spanishViewModel);
        }

        public IActionResult Germanish()
        {
            var greetings = _context.Words.Where(w => w.Category == "Greetings" && w.Language == "Germanish").ToList();
            var basicphrases = _context.Words.Where(w => w.Category == "BasicPhrases" && w.Language == "Germanish").ToList();
            var weather = _context.Words.Where(w => w.Category == "Weather" && w.Language == "Germanish").ToList();
            var family = _context.Words.Where(w => w.Category == "Family" && w.Language == "Germanish").ToList();
            var work = _context.Words.Where(w => w.Category == "Work" && w.Language == "Germanish").ToList();
            var numbers = _context.Words.Where(w => w.Category == "Numbers" && w.Language == "Germanish").ToList();
            var colors = _context.Words.Where(w => w.Category == "Colors" && w.Language == "Germanish").ToList();
            var food = _context.Words.Where(w => w.Category == "Food" && w.Language == "Germanish").ToList();
            var time = _context.Words.Where(w => w.Category == "Time" && w.Language == "Germanish").ToList();
            var shopping = _context.Words.Where(w => w.Category == "Shopping" && w.Language == "Germanish").ToList();
            var travel = _context.Words.Where(w => w.Category == "Travel" && w.Language == "Germanish").ToList();
            var body = _context.Words.Where(w => w.Category == "Body" && w.Language == "Germanish").ToList();
            var schooleducation = _context.Words.Where(w => w.Category == "SchoolEducation" && w.Language == "Germanish").ToList();
            var sport = _context.Words.Where(w => w.Category == "Sport" && w.Language == "Germanish").ToList();
            var emotions = _context.Words.Where(w => w.Category == "Emotions" && w.Language == "Germanish").ToList();
            var transportation = _context.Words.Where(w => w.Category == "Transportation" && w.Language == "Germanish").ToList();
            var directionsplaces = _context.Words.Where(w => w.Category == "DirectionsPlaces" && w.Language == "Germanish").ToList();
            var leisureentertainment = _context.Words.Where(w => w.Category == "LeisureEntertainment" && w.Language == "Germanish").ToList();
            var homeliving = _context.Words.Where(w => w.Category == "HomeLiving" && w.Language == "Germanish").ToList();
            var clothesfashion = _context.Words.Where(w => w.Category == "ClothesFashion" && w.Language == "Germanish").ToList();
            var technology = _context.Words.Where(w => w.Category == "Technology" && w.Language == "Germanish").ToList();
            var health = _context.Words.Where(w => w.Category == "Health" && w.Language == "Germanish").ToList();
            var animals = _context.Words.Where(w => w.Category == "Animals" && w.Language == "Germanish").ToList();
            var socialrelations = _context.Words.Where(w => w.Category == "SocialRelations" && w.Language == "Germanish").ToList();
            var goalsdreams = _context.Words.Where(w => w.Category == "GoalsDreams" && w.Language == "Germanish").ToList();
            var holidaysoccasions = _context.Words.Where(w => w.Category == "HolidaysOccasions" && w.Language == "Germanish").ToList();


            var germanishViewModel = new GermanishViewModel
            {
                Greetings = greetings,
                BasicPhrases = basicphrases,
                Weather = weather,
                Family = family,
                Work = work,
                Numbers = numbers,
                Colors = colors,
                Food = food,
                Time = time,
                Shopping = shopping,
                Travel = travel,
                Body = body,
                SchoolEducation = schooleducation,
                Sport = sport,
                Emotions = emotions,
                Transportation = transportation,
                DirectionsPlaces = directionsplaces,
                LeisureEntertainment = leisureentertainment,
                HomeLiving = homeliving,
                ClothesFashion = clothesfashion,
                Technology = technology,
                Health = health,
                Animals = animals,
                SocialRelations = socialrelations,
                GoalsDreams = goalsdreams,
                HolidaysOccasions = holidaysoccasions
            };

            return View(germanishViewModel);
        }

        public IActionResult Italianish()
        {
            var greetings = _context.Words.Where(w => w.Category == "Greetings" && w.Language == "Italianish").ToList();
            var basicphrases = _context.Words.Where(w => w.Category == "BasicPhrases" && w.Language == "Italianish").ToList();
            var weather = _context.Words.Where(w => w.Category == "Weather" && w.Language == "Italianish").ToList();
            var family = _context.Words.Where(w => w.Category == "Family" && w.Language == "Italianish").ToList();
            var work = _context.Words.Where(w => w.Category == "Work" && w.Language == "Italianish").ToList();
            var numbers = _context.Words.Where(w => w.Category == "Numbers" && w.Language == "Italianish").ToList();
            var colors = _context.Words.Where(w => w.Category == "Colors" && w.Language == "Italianish").ToList();
            var food = _context.Words.Where(w => w.Category == "Food" && w.Language == "Italianish").ToList();
            var time = _context.Words.Where(w => w.Category == "Time" && w.Language == "Italianish").ToList();
            var shopping = _context.Words.Where(w => w.Category == "Shopping" && w.Language == "Italianish").ToList();
            var travel = _context.Words.Where(w => w.Category == "Travel" && w.Language == "Italianish").ToList();
            var body = _context.Words.Where(w => w.Category == "Body" && w.Language == "Italianish").ToList();
            var schooleducation = _context.Words.Where(w => w.Category == "SchoolEducation" && w.Language == "Italianish").ToList();
            var sport = _context.Words.Where(w => w.Category == "Sport" && w.Language == "Italianish").ToList();
            var emotions = _context.Words.Where(w => w.Category == "Emotions" && w.Language == "Italianish").ToList();
            var transportation = _context.Words.Where(w => w.Category == "Transportation" && w.Language == "Italianish").ToList();
            var directionsplaces = _context.Words.Where(w => w.Category == "DirectionsPlaces" && w.Language == "Italianish").ToList();
            var leisureentertainment = _context.Words.Where(w => w.Category == "LeisureEntertainment" && w.Language == "Italianish").ToList();
            var homeliving = _context.Words.Where(w => w.Category == "HomeLiving" && w.Language == "Italianish").ToList();
            var clothesfashion = _context.Words.Where(w => w.Category == "ClothesFashion" && w.Language == "Italianish").ToList();
            var technology = _context.Words.Where(w => w.Category == "Technology" && w.Language == "Italianish").ToList();
            var health = _context.Words.Where(w => w.Category == "Health" && w.Language == "Italianish").ToList();
            var animals = _context.Words.Where(w => w.Category == "Animals" && w.Language == "Italianish").ToList();
            var socialrelations = _context.Words.Where(w => w.Category == "SocialRelations" && w.Language == "Italianish").ToList();
            var goalsdreams = _context.Words.Where(w => w.Category == "GoalsDreams" && w.Language == "Italianish").ToList();
            var holidaysoccasions = _context.Words.Where(w => w.Category == "HolidaysOccasions" && w.Language == "Italianish").ToList();


            var italianishViewModel = new ItalianishViewModel
            {
                Greetings = greetings,
                BasicPhrases = basicphrases,
                Weather = weather,
                Family = family,
                Work = work,
                Numbers = numbers,
                Colors = colors,
                Food = food,
                Time = time,
                Shopping = shopping,
                Travel = travel,
                Body = body,
                SchoolEducation = schooleducation,
                Sport = sport,
                Emotions = emotions,
                Transportation = transportation,
                DirectionsPlaces = directionsplaces,
                LeisureEntertainment = leisureentertainment,
                HomeLiving = homeliving,
                ClothesFashion = clothesfashion,
                Technology = technology,
                Health = health,
                Animals = animals,
                SocialRelations = socialrelations,
                GoalsDreams = goalsdreams,
                HolidaysOccasions = holidaysoccasions
            };

            return View(italianishViewModel);
        }

        public IActionResult French()
        {
            var greetings = _context.Words.Where(w => w.Category == "Greetings" && w.Language == "French").ToList();
            var basicphrases = _context.Words.Where(w => w.Category == "BasicPhrases" && w.Language == "French").ToList();
            var weather = _context.Words.Where(w => w.Category == "Weather" && w.Language == "French").ToList();
            var family = _context.Words.Where(w => w.Category == "Family" && w.Language == "French").ToList();
            var work = _context.Words.Where(w => w.Category == "Work" && w.Language == "French").ToList();
            var numbers = _context.Words.Where(w => w.Category == "Numbers" && w.Language == "French").ToList();
            var colors = _context.Words.Where(w => w.Category == "Colors" && w.Language == "French").ToList();
            var food = _context.Words.Where(w => w.Category == "Food" && w.Language == "French").ToList();
            var time = _context.Words.Where(w => w.Category == "Time" && w.Language == "French").ToList();
            var shopping = _context.Words.Where(w => w.Category == "Shopping" && w.Language == "French").ToList();
            var travel = _context.Words.Where(w => w.Category == "Travel" && w.Language == "French").ToList();
            var body = _context.Words.Where(w => w.Category == "Body" && w.Language == "French").ToList();
            var schooleducation = _context.Words.Where(w => w.Category == "SchoolEducation" && w.Language == "French").ToList();
            var sport = _context.Words.Where(w => w.Category == "Sport" && w.Language == "French").ToList();
            var emotions = _context.Words.Where(w => w.Category == "Emotions" && w.Language == "French").ToList();
            var transportation = _context.Words.Where(w => w.Category == "Transportation" && w.Language == "French").ToList();
            var directionsplaces = _context.Words.Where(w => w.Category == "DirectionsPlaces" && w.Language == "French").ToList();
            var leisureentertainment = _context.Words.Where(w => w.Category == "LeisureEntertainment" && w.Language == "French").ToList();
            var homeliving = _context.Words.Where(w => w.Category == "HomeLiving" && w.Language == "French").ToList();
            var clothesfashion = _context.Words.Where(w => w.Category == "ClothesFashion" && w.Language == "French").ToList();
            var technology = _context.Words.Where(w => w.Category == "Technology" && w.Language == "French").ToList();
            var health = _context.Words.Where(w => w.Category == "Health" && w.Language == "French").ToList();
            var animals = _context.Words.Where(w => w.Category == "Animals" && w.Language == "French").ToList();
            var socialrelations = _context.Words.Where(w => w.Category == "SocialRelations" && w.Language == "French").ToList();
            var goalsdreams = _context.Words.Where(w => w.Category == "GoalsDreams" && w.Language == "French").ToList();
            var holidaysoccasions = _context.Words.Where(w => w.Category == "HolidaysOccasions" && w.Language == "French").ToList();


            var frenchViewModel = new FrenchViewModel
            {
                Greetings = greetings,
                BasicPhrases = basicphrases,
                Weather = weather,
                Family = family,
                Work = work,
                Numbers = numbers,
                Colors = colors,
                Food = food,
                Time = time,
                Shopping = shopping,
                Travel = travel,
                Body = body,
                SchoolEducation = schooleducation,
                Sport = sport,
                Emotions = emotions,
                Transportation = transportation,
                DirectionsPlaces = directionsplaces,
                LeisureEntertainment = leisureentertainment,
                HomeLiving = homeliving,
                ClothesFashion = clothesfashion,
                Technology = technology,
                Health = health,
                Animals = animals,
                SocialRelations = socialrelations,
                GoalsDreams = goalsdreams,
                HolidaysOccasions = holidaysoccasions
            };

            return View(frenchViewModel);
        }



    }
}
