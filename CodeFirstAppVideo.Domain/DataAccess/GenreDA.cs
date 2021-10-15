using CodeFirstAppVideo.Domain.Interfaces;
using CodeFirstAppVideo.Domain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CodeFirstAppVideo.Domain.DataAccess
{
    public class GenreDA: IGenre
    {
        private readonly IDbConnection _db;
        private VideoContext _videoContext;
        public GenreDA(VideoContext videoContext, IDbConnection db)
        {
            _videoContext = videoContext;
            _db = db;
        }

        public Genre Crate(Genre genre)
        {
            try
            {
                _videoContext.Add(genre);
                _videoContext.SaveChanges();
                return genre;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(int genreId)
        {
            try
            {
                var video = GetById(genreId);
                _videoContext.Set<Genre>().Remove(video);
                _videoContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<SelectListItem> GenreForSelect()
        {
            var result = GetAll()                       
                  .Select(x => new SelectListItem()
                  {
                      Value = x.GenreId.ToString(),
                      Text = x.Name,
                  }).ToList();
            return new SelectList(result, "Value", "Text");
        }

        public IEnumerable<Genre> GetAll()
        {
            return _videoContext.Genre.Where(x => x.Available).ToList();
        }

        public Genre GetById(int genreId)
        {
            return _videoContext.Set<Genre>().Where(x => x.GenreId == genreId).FirstOrDefault();
        }

        public Genre Update(Genre genre)
        {
            try
            {
                _videoContext.Set<Genre>().Update(genre);
                _videoContext.SaveChanges();
                return genre;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
