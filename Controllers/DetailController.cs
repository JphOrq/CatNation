using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CatNation_ASP.Net_Core_MVC_.Models;

namespace CatNation_ASP.Net_Core_MVC_.Controllers
{
    public class DetailController : Controller
    {
        public IActionResult Index(string id, string pageType)
        {
            var characters = new List<CharacterModel>()
            {
                new CharacterModel()
                {
                    Id = "Ala-Eh",
                    Name = "Ala-Eh",
                    Description = "Inampon galing Batangas.",
                },
                new CharacterModel()
                {
                    Id = "Imang",
                    Name = "Imang",
                    Description = "Ang timangshi.",
                },
                new CharacterModel()
                {
                    Id = "Lala",
                    Name = "Lala",
                    Description = "Anak nila Ash at Catriona.",
                },
                new CharacterModel()
                {
                    Id = "Matty",
                    Name = "Matty",
                    Description = "Ang Matinggi.",
                },
                new CharacterModel()
                {
                    Id = "Stormy",
                    Name = "Stormy",
                    Description = "Ang Storminggi.",
                },
                new CharacterModel()
                {
                    Id = "Tujong",
                    Name = "Tujong",
                    Description = "Anak nila Yobang at Lala.",
                },
                new CharacterModel()
                {
                    Id = "Yobang",
                    Name = "Yobang",
                    Description = "Inampon din galing naman sa Robinson Mall.",
                },
                new CharacterModel()
                {
                    Id = "Yuna",
                    Name = "Yuna",
                    Description = "Yunang masungit.",
                },
                new CharacterModel()
                {
                    Id = "Emo",
                    Name = "Emo",
                    Description = "Maamong warfreak.",
                }
            };

            var detail = characters.FirstOrDefault(c => c.Id == id);
            ViewBag.PageType = pageType;

            return View(detail);
        }
    }
}