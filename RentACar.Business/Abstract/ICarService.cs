using Core.Utilities.Results;
using RentACar.Entities.Concrete;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<CarDetailsDTO>> GetCarDetails();
    }
}
