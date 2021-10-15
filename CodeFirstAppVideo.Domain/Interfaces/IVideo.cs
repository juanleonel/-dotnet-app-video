using CodeFirstAppVideo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstAppVideo.Domain.Interfaces
{
    public interface IVideo
    {
        Video Crate(Video video);
        Video Update(Video video);
        bool Delete(int videoId);
        bool UnAvailable(int videoId);
        Video GetById(int videoId);
        IEnumerable<Video> GetAll();
    }
}
