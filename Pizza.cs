using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Practica_3sem
{
    public class Pizza
    {
        [Column("Product_ID")]
        public byte? Id { get; set; }

        public string? Title { get; set; }

        public decimal? Price { get; set; }

        public string? Unit_of_measurement { get; set; }

    }
}
