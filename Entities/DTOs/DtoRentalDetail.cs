﻿using Core.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class DtoRentalDetail:IDto
    {
        public int Id { get; set; }
        public string Descripton { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
