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

        public IDataResult<List<Brand>> GetByBranId(int brandId)
        {
            //if (brandId!=null)
            //{
            //    return new DataResult<List<Brand>>(_messages.BrandById, _carDal.Get(c=>c.BrandId==brandId));

            //}
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
