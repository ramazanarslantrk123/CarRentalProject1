using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetByCarId(int carId);
        IDataResult<List<Brand>> GetByBranId(int brandId);
        IDataResult<List<Color>> GetByColorId(int colorId);

    }
}
