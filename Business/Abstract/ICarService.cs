using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();//
        IDataResult<List<CarDto>> GetCarDetails();
        IDataResult<Car> GetByCarId(int carId);//
        IDataResult<List<Car>> GetByBrandId(int brandId);//
        IDataResult<List<Car>> GetByColorId(int colorId);//
        IDataResult<List<Car>> GetAllByModelYear(int min, int max);//
        IDataResult<List<Car>> GetByDailyPrice(short min, short max);//
        IResult Add(Car car);//
        IResult Delete(Car car);//
        IResult Update(Car car);//

    }
}
