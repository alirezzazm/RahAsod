using DataLayer.Models.Admin;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repositories
{
   public interface IAdminRepository :IDisposable
    {
        //Slider
        bool AddPhoto(Slider sliderPhoto);
        IEnumerable<string> PhotoName();




        void save();
    }
}
