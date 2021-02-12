using Core.DataAccess;
using RentACar.Entities.Concrete;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailsDTO> GetCarDetails();
    }
}
