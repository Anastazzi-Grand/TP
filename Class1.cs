﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Practica_3sem
{
    public class Order
    {
        [Key]
        public byte Order_number { get; set; }

        public byte Client_ID { get; set; }

        public DateTime Order_date { get; set; }

        public string Status { get; set; }

        public DateTime Date_of_execution { get; set; }

        public decimal Payment { get; set; }

        public byte Cook_Employee_ID { get; set; }

        public byte Operator_Employee_ID { get; set; }

    }
}
