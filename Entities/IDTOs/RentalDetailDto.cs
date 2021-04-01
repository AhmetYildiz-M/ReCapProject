using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.IDTOs
{
    public class RentalDetailDto : IDto
    {
        public string CustomerName { get; set; }
        public string CompanyName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal SumTotalPrice { get; set; }


    }
}
