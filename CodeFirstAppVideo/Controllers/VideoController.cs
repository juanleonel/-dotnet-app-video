using CodeFirstAppVideo.Domain.Interfaces;
using CodeFirstAppVideo.Domain.Models;
using CodeFirstAppVideo.Helpers.BaseController;
using CodeFirstAppVideo.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeFirstAppVideo.Web.Controllers
{
    public class VideoController : BaseController
    {
        private readonly IVideo _video;
        private readonly IGenre _genre;
        public VideoController(IVideo video, IGenre genre)
        {
            _video = video;
            _genre = genre;
        }

        public ActionResult Index()
        {
            //ViewBag.Messages = new[] {
            //        new Alerts("success", "Success!", "The object was added successfully!"),
            //        //new Alerts("warning", "Warning!", "The object was added with a warning!"),
            //        //new Alerts("danger", "Danger!", "The object was not added!")
            //    };

            var videos = _video.GetAll();
            var models = ParseVideos_VideoViewModels(videos.ToList());
            
            return View(models);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new VideoViewModel();
            model.Genres = _genre.GenreForSelect();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VideoViewModel model)
        {
            try
            {
                Video video = new Video()
                {
                    Name = model.Name,
                    Description = model.Description,
                    Price = model.Price,
                    CreateAt = DateTime.Now,
                    GenreId = model.GenreId,
                    Available = true
                };
                
                _video.Crate(video);


                MessageSuccess("The object was added successfully!");
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var video = _video.GetById(id);

            if (video == null) return RedirectToAction(nameof(Index));
             
            var model = ParseVideo_VideoViewModel(video);
            model.Genres = _genre.GenreForSelect();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VideoViewModel model)
        {
            try
            {
                var video = _video.GetById(model.VideoId);

                if (video == null) return View(new VideoViewModel());
                 
                video.Name = model.Name;
                video.Description = model.Description;
                video.Price = model.Price;
                video.GenreId = model.GenreId;
                video.Available = model.Available;
                 
                _video.Update(video);
                MessageSuccess("The object was edit successfully!");
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                var result = _video.UnAvailable(id);
                if (result)
                {
                    MessageSuccess("The object was delete successfully!");
                }
                else {
                    MessageDanger("The object not was delete!");
                }
                 
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private List<VideoViewModel> ParseVideos_VideoViewModels(List<Video> videos)
        {
            var models = videos.Select(x => ParseVideo_VideoViewModel(x) ).ToList();
             
            return models;
        }

        private VideoViewModel ParseVideo_VideoViewModel(Video video) {

            var videoViewModel = new VideoViewModel() { 
                VideoId = video.VideoId,
                Name = video.Name,
                Description = video.Description,
                Price = video.Price,
                GenreId = video.GenreId,
                Available = video.Available,
            };

            return videoViewModel;
        }

        private List< Video> ParseVideoViewModels_Videos(List<VideoViewModel> models)
        {
            var videos = models.Select(x => ParseVideoViewModel_Video(x) ).ToList();

            return videos;
        }

        private Video ParseVideoViewModel_Video(VideoViewModel model)
        {

            var video = new Video()
            {
                VideoId = model.VideoId,
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                GenreId = model.GenreId,
                Available = model.Available,
            };

            return video;
        }
    }
}