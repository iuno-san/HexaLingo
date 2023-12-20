// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const swiper = new Swiper('.mySwiper', {
    slidesPerView: 3,
    spaceBetween: 10,
    pagination: {
        el: '.swiper-pagination',
        clickable: true,
    },
    navigation: {
        nextEl: '.swiper-button-next',
        prevEl: '.swiper-button-prev',
    },
    breakpoints: {
        320: {
            slidesPerView: 1,
        },
        768: {
            slidesPerView: 2,
            spaceBetween: 20,
        },
        992: {
            slidesPerView: 3,
            spaceBetween: 20,
        },
    },
    freeMode: true,
});



// site.js

/*document.addEventListener("DOMContentLoaded", function () {
    // Pobierz przycisk i styl arkusza CSS
    const toggleDarkModeButton = document.getElementById("toggleDarkMode");
    const darkModeStylesheet = document.getElementById("darkModeStylesheet");

    // Dodaj obsługę kliknięcia przycisku
    toggleDarkModeButton.addEventListener("click", function () {
        // Przełącz klasę na body, aby włączyć/wyłączyć tryb ciemny
        document.body.classList.toggle("dark-mode");

        // Zapisz preferencje użytkownika w lokalnym składowisku
        const isDarkModeEnabled = document.body.classList.contains("dark-mode");
        localStorage.setItem("darkModeEnabled", isDarkModeEnabled);
    });

    // Sprawdź preferencje użytkownika w lokalnym składowisku
    const isDarkModePreferred = localStorage.getItem("darkModeEnabled") === "true";

    // Jeśli preferencje wskazują na tryb ciemny, włącz go domyślnie
    if (isDarkModePreferred) {
        document.body.classList.add("dark-mode");
    }
});*/

document.addEventListener("DOMContentLoaded", function () {
    // Pobierz przycisk, styl arkusza CSS i ikonę dark mode
    const toggleDarkModeButton = document.getElementById("toggleDarkMode");
    const darkModeStylesheet = document.getElementById("darkModeStylesheet");
    const darkModeIcon = document.getElementById("darkModeIcon");

    // Dodaj obsługę kliknięcia przycisku
    toggleDarkModeButton.addEventListener("click", function () {
        // Przełącz klasę na body, aby włączyć/wyłączyć tryb ciemny
        document.body.classList.toggle("dark-mode");

        // Zmień ikonę w zależności od aktualnego trybu
        const isDarkModeEnabled = document.body.classList.contains("dark-mode");
        if (isDarkModeEnabled) {
            darkModeIcon.src = "/img/icons/light_mode.png";
        } else {
            darkModeIcon.src = "/img/icons/dark_mode.png";
        }

        // Zapisz preferencje użytkownika w lokalnym składowisku
        localStorage.setItem("darkModeEnabled", isDarkModeEnabled);
    });

    // Sprawdź preferencje użytkownika w lokalnym składowisku
    const isDarkModePreferred = localStorage.getItem("darkModeEnabled") === "true";

    // Jeśli preferencje wskazują na tryb ciemny, włącz go domyślnie
    if (isDarkModePreferred) {
        document.body.classList.add("dark-mode");
        darkModeIcon.src = "/img/icons/light_mode.png";
    }
});


$(document).ready(function () {
    var currentPage = '@currentPage';
    $('.nav-link').each(function () {
        var action = $(this).attr('asp-action');
        var controller = $(this).attr('asp-controller');

        // Tworzymy pełną ścieżkę dla linku "Moje słówka"
        var fullPath = controller && action ? '/' + controller + '/' + action : action;

        if (fullPath === currentPage) {
            $(this).addClass('active');
        }
    });
});


document.addEventListener('DOMContentLoaded', function () {
    var navbarToggle = document.querySelector('.navbar-toggle');
    var navbarMenu = document.querySelector('.navbar-menu');

    navbarToggle.addEventListener('click', function () {
        navbarToggle.classList.toggle('active');
        navbarMenu.classList.toggle('active');
    });
});


$(document).ready(function () {
    $(".search").keyup(function () {
        var searchTerm = $(".search").val().toLowerCase();

        $(".swiper-slide").each(function () {
            var word = $(this);
            var textToSearch = word.text().toLowerCase();

            if (textToSearch.indexOf(searchTerm) === -1) {
                word.hide();
            }
            else {
                word.show();
            }
        });

        var visibleCount = $('.swiper-slide:visible').length;
        $('.counter').text(visibleCount + ' Znalezionych słówek');

        if (visibleCount === 0) {
            $('.no-result').show();
        } else {
            $('.no-result').hide();
        }
    });
});