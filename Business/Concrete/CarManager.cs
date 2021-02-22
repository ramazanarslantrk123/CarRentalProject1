using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;
        private readonly Messages _messages;

        public CarManager(ICarDal carDal,Messages messages)
        {
            _carDal = carDal;
            _messages = messages;
            
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_messages.CarListed,_carDal.GetAll() );
        }

        public IDataResult<List<Car>> GetByBranId(int brandId)
        {
            var data = _carDal.GetAll(c => c.BrandId == brandId);
            if (data != null)
            {
               return new SuccessDataResult<List<Car>>(_messages.BrandById, data); ;
            }
            return new ErrorDataResult<List<Car>>(_messages.Error);
        }

        public IDataResult<Car> GetByCarId(int carId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Color>> GetByColorId(int colorId)
        {
            throw new NotImplementedException();
        }
    }
}
