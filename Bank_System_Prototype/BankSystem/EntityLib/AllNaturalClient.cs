﻿using System;
using System.Collections.Generic;

#nullable disable

namespace EntityLib
{
    public partial class AllNaturalClient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Reputation { get; set; }
        public string Department { get; set; }
        public int AccountNumber { get; set; }
        public decimal AmountOfMoney { get; set; }
        public decimal CheckContribution { get; set; }
        public decimal CheckDebt { get; set; }
    }
}