using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfGenericRepository<Car, RentalContext>, ICarDal
    {
        public List<CarDto> GetCarDetails()
        {
            using (RentalContext context = new RentalContext())
            {
                var result = from p in context.Cars
                             join c in context.Brands
                             on p.BrandId equals c.Id
                             join a in context.Colors
                             on p.ColorId equals a.Id
                             select new CarDto
                             {
                                 CarName = p.CarName,
                                 BrandName = c.BrandName,
                                 ColorName = a.ColorName,
                                 DailyPrice = p.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
