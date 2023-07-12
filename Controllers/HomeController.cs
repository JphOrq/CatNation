using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CatNation_ASP.Net_Core_MVC_.Models;

namespace CatNation_ASP.Net_Core_MVC_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var featuredPosts = new List<FeaturedViewModel>
            {
                new FeaturedViewModel() {
                    Id = "Ala-Eh",
                    Header = "Characters",
                    Title = "Ala-Eh",
                    PostedDate = DateTime.Now,
                    Description = "Inampon galing Batangas.",
                    ImageUrl = "Ala-Eh.jpg"
                },
                new FeaturedViewModel() {
                    Id = "Imang",
                    Header = "Characters",
                    Title = "Imang",
                    PostedDate = DateTime.Now,
                    Description = "Ang timangshi.",
                    ImageUrl = "Imang.jpg"
                },
                new FeaturedViewModel() {
                    Id = "Lala",
                    Header = "Characters",
                    Title = "Lala",
                    PostedDate = DateTime.Now,
                    Description = "Anak nila Ash at Catriona.",
                    ImageUrl = "Lala.jpg"
                },
                new FeaturedViewModel() {
                    Id = "Matty",
                    Header = "Characters",
                    Title = "Matty",
                    PostedDate = DateTime.Now,
                    Description = "Ang Matinggi.",
                    ImageUrl = "Matty.jpg"
                },
                new FeaturedViewModel() {
                    Id = "Stormy",
                    Header = "Characters",
                    Title = "Stormy",
                    PostedDate = DateTime.Now,
                    Description = "Ang Storminggi.",
                    ImageUrl = "Stormy.jpg"
                },
                new FeaturedViewModel() {
                    Id = "Tujong",
                    Header = "Characters",
                    Title = "Tujong",
                    PostedDate = DateTime.Now,
                    Description = "Anak nila Yobang at Lala.",
                    ImageUrl = "Tujong.jpg"
                },
                new FeaturedViewModel() {
                    Id = "Yobang",
                    Header = "Characters",
                    Title = "Yobang",
                    PostedDate = DateTime.Now,
                    Description = "Inampon din galing naman sa Robinson Mall.",
                    ImageUrl = "Yobang.jpg"
                },
                new FeaturedViewModel() {
                    Id = "Yuna",
                    Header = "Characters",
                    Title = "Yuna",
                    PostedDate = DateTime.Now,
                    Description = "Yunang masungit.",
                    ImageUrl = "Yuna.jpg"
                }
            };

            return View(featuredPosts);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View("Private");
        }
    }
}