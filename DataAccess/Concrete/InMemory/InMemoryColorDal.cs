using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Colors> _colors;
        public InMemoryColorDal()
        {
            _colors = new List<Colors>
            {
                new Colors {ColorId = 1, ColorName = "Black"},
                new Colors {ColorId = 2, ColorName = "White"},
                new Colors {ColorId = 3, ColorName = "Orange"},
                new Colors {ColorId = 4, ColorName = "Blue"},
                new Colors {ColorId = 5, ColorName = "Red"},
            };
        }
        public void Add(Colors color)
        {
            _colors.Add(color);
        }

        public void Delete(Colors color)
        {
            Colors colorsToDelete = _colors.SingleOrDefault(c => c.ColorId == color.ColorId);

            _colors.Remove(colorsToDelete);
        }

        public List<Colors> GetColors()
        {
            return _colors;
        }

        public List<Colors> GetById(int colorId)
        {
            return _colors.Where(c => c.ColorId == colorId).ToList();
        }

        public void Update(Colors color)
        {
            Colors colorsToUpdate = _colors.SingleOrDefault(c => c.ColorId == color.ColorId);
            colorsToUpdate.ColorName = color.ColorName;
        }

        public List<Colors> GetAll(Expression<Func<Colors, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Colors Get(Expression<Func<Colors, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
