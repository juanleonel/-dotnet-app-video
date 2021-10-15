using CodeFirstAppVideo.Domain.Interfaces;
using CodeFirstAppVideo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CodeFirstAppVideo.Domain.DataAccess
{
    public class VideoDA : IVideo
    {
        private readonly IDbConnection _db;
        private VideoContext _videoContext;
        public VideoDA(VideoContext videoContext, IDbConnection db)  
        {
            _videoContext = videoContext;
            _db = db;
        }
        public Video Crate(Video video)
        {
            try
            {
                _videoContext.Add(video);
                _videoContext.SaveChanges();
                return video;
            }
            catch (Exception)
            {
                throw;
            }         
        }

        public bool Delete(int videoId)
        {
            try
            {
                var video = GetById(videoId);
                _videoContext.Set<Video>().Remove(video);
                _videoContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<Video> GetAll()
        {
            return _videoContext.Video.ToList();
        }

        public Video GetById(int videoId)
        {
            return _videoContext.Set<Video>().Where(x => x.VideoId == videoId).FirstOrDefault();
        }

        public bool UnAvailable(int videoId)
        {
            try
            {
                var video = GetById(videoId);

                if (video == null) return false;

                video.Available = false;
                Update(video);

                return true;
            }
            catch (Exception)
            {
                return false;
            }            
        }

        public Video Update(Video video)
        {
            try
            {
                _videoContext.Set<Video>().Update(video);
                _videoContext.SaveChanges();
                return video;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
