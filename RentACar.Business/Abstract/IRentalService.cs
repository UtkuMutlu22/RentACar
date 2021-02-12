using Core.Utilities.Results;
using RentACar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
       
    }
}
