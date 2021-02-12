using Core.Utilities.Results;
using RentACar.Business.Abstract;
using RentACar.Business.Constants;
using RentACar.DataAccess.Abstract;
using RentACar.Entities.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.AddCustomer);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.DeletedCustomer);
        }

        public IDataResult<Customer> Get(int customerId)
        {
            
            return new SuccessDataResult<Customer>(_customerDal.Get(customer=>customer.UserId==customerId));
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return
                 new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }
        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult();
        }
    }
}
