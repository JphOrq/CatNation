using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CatNation_ASP.Net_Core_MVC_.Models;

namespace CatNation_ASP.Net_Core_MVC_.Controllers
{
    public class VideoController : Controller
    {
        public IActionResult Index()
        {
            var videos = new List<VideoModel>()
            {
                new VideoModel()
                {
                    Id = "Ala-Eh",
                    Name = "Ala-Eh",
                    Description = "Inampon galing Batangas.",
                    VideoURL = "https://www.youtube.com/embed/Jk83I-z6C98"
                },
                new VideoModel()
                {
                    Id = "Imang",
                    Name = "Imang",
                    Description = "Ang timangshi.",
                    VideoURL = "https://www.youtube.com/embed/JxS5E-kZc2s"
                },
                new VideoModel()
                {
                    Id = "Lala",
                    Name = "Lala",
                    Description = "Anak nila Ash at Catriona.",
                    VideoURL = "https://www.youtube.com/embed/ja1sXvNCyO0"
                },
                new VideoModel()
                {
                    Id = "Matty",
                    Name = "Matty",
                    Description = "Ang Matinggi.",
                    VideoURL = "https://www.youtube.com/embed/eBEn2zxgtQ4"
                },
                new VideoModel()
                {
                    Id = "Stormy",
                    Name = "Stormy",
                    Description = "Ang Storminggi.",
                    VideoURL = "https://www.youtube.com/embed/x5Fugv2eUXA"
                },
                new VideoModel()
                {
                    Id = "Tujong",
                    Name = "Tujong",
                    Description = "Anak nila Yobang at Lala.",
                    VideoURL = "https://www.youtube.com/embed/NsUWXo8M7UA"
                },
                new VideoModel()
                {
                    Id = "Yobang",
                    Name = "Yobang",
                    Description = "Inampon din galing naman sa Robinson Mall.",
                    VideoURL = "https://www.youtube.com/embed/q60RVOoSXc8"
                },
                new VideoModel()
                {
                    Id = "Yuna",
                    Name = "Yuna",
                    Description = "Yunang masungit.",
                    VideoURL = "https://www.youtube.com/embed/SkRRROkRdzQ"
                },
                new VideoModel()
                {
                    Id = "Emo",
                    Name = "Emo",
                    Description = "Maamong warfreak.",
                    VideoURL = "https://www.youtube.com/embed/tP98Y2LLLN0"
                }
            };

            return View(videos);
        }
    }
}