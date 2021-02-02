using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IColorDal
    {
        List<Colors> GetColors();
        List<Colors> GetById(int colorId);
        void Add(Colors color);
        void Update(Colors color);
        void Delete(Colors color);
    }
}
