using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3sem
{
    public class LineNumber
    {
        [Key]
        public byte Order_line_number { get; set; }

        public byte? Count { get; set; }

        [Column("Product_ID")]
        public byte? ProductId { get; set; }

        [Column("Order_number")]
        public byte? OrderId { get; set; }

        public Order? Order { get; set; }


    }

}
