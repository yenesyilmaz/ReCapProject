using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add()
        {
            throw new NotImplementedException();
        }


        IDataResult<List<Brand>> IBrandService.GetBrands()
        {
            throw new NotImplementedException();
        }
    }
}
