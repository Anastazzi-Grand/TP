using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3sem
{
    public class Client
    {
        [Key]
        public byte ID { get; set; }

        public string? Full_Name { get; set; }

        public string? Address { get; set; }

        public string? Telephone { get; set; }

    }
}
