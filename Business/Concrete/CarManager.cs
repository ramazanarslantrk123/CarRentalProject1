using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;
        //private readonly Messages _messages;

        public CarManager(ICarDal carDal/*,Messages messages*/)
        {
            _carDal = carDal;
            //_messages = messages;

        }

        public IResult Add(Car car)
        {
            var result = new CarValidator();
            if (result == null)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
            }

            return new ErrorResult(Messages.CarNameInvalid);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(Messages.CarListed, _carDal.GetAll());
        }

        public IDataResult<List<Car>> GetAllByModelYear(int min, int max)
        {
            return new SuccessDataResult<List<Car>>
                (Messages.CarListedByModelYear, _carDal.GetAll
                (a => a.ModelYear >= min && a.ModelYear <= max));
        }

        public IDataResult<List<Car>> GetByBrandId(int brandId)
        {
            var data = _carDal.GetAll(c => c.BrandId == brandId);
            if (data != null)
            {
                return new SuccessDataResult<List<Car>>(Messages.BrandById, data); ;
            }
            return new ErrorDataResult<List<Car>>(Messages.Error);
        }

        public IDataResult<Car> GetByCarId(int carId)
        {
            var data = _carDal.Get(a => a.Id == carId);
            if (data != null)
            {
                return new SuccessDataResult<Car>(Messages.GetByCarId, data);
            }
            return new ErrorDataResult<Car>(Messages.Error);
        }

        public IDataResult<List<Car>> GetByColorId(int colorId)
        {
            var data = _carDal.GetAll(p => p.ColorId == colorId);
            if (data != null)
            {
                return new SuccessDataResult<List<Car>>(Messages.GetByColorId, data);
            }
            return new ErrorDataResult<List<Car>>(Messages.Error);
        }

        public IDataResult<List<Car>> GetByDailyPrice(short min, short max)
        {//Kontrollerini sağlamayı unutma bir çok kotrolü var validation eklemeyi unutma !!!
            var data = _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
            if (data != null)
            {
                return new SuccessDataResult<List<Car>>(Messages.GetByDailyPrice, data);
            }
            return new ErrorDataResult<List<Car>>(Messages.Error);
        }

        public IDataResult<List<CarDto>> GetCarDetails()
        {
            var data = _carDal.GetCarDetails();
            if (data != null)
            {
                return new SuccessDataResult<List<CarDto>>(Messages.GetCarDetail, data);
            }
            return new ErrorDataResult<List<CarDto>>(Messages.Error);
        }

        public IResult Update(Car car)
        {
            if (car.CarName.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Update(car);
                return new SuccessResult(Messages.CarUpdated);
            }
            return new ErrorResult("Araba Başarı ile güncellenemedi");
        }
    }
}
