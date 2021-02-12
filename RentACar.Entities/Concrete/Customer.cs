using Core.Entities;
using RentACar.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Entities.Concrete
{
    public class Customer:User,IEntity
    {
        public string CompanyName { get; set; }
    }
}
