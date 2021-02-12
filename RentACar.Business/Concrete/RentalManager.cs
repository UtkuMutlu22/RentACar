using Core.Utilities.Results;
using RentACar.Business.Abstract;
using RentACar.Business.Constants;
using RentACar.DataAccess.Abstract;
using RentACar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate==null)
            {
                _rentalDal.Add(rental);
                rental.RentDate = DateTime.Now;
                return new SuccessResult();
            }
            else
            {
                return new ErrorResult(Messages.InvalidField);
            }
        }


        
    }
}
