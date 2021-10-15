using CodeFirstAppVideo.Domain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstAppVideo.Domain.Interfaces
{
    public interface IGenre
    {
        Genre Crate(Genre video);
        Genre Update(Genre video);
        bool Delete(int videoId);
        Genre GetById(int videoId);
        IEnumerable<Genre> GetAll();
        IEnumerable<SelectListItem> GenreForSelect();
    }
}
