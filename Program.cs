using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Practica_3sem
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var orders = db.Orders.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Order u in orders)
                {
                    Console.WriteLine(u.Order_number + " - " + u.Client_ID + " - " + u.Order_date + " - " + u.Status + " - " + u.Date_of_execution + " - " + u.Payment + " - " + u.Cook_Employee_ID + " - " + u.Operator_Employee_ID);
                }
            }
        }
    }
}