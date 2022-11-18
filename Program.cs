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
            Console.WriteLine("первая работа с таблицей Order");
            using (ApplicationContext db = new ApplicationContext())
            {
                var orders = db.Order.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Order u in orders)
                {
                    Console.WriteLine(u.Id + " - " + u.Client_ID + " - " + u.Order_date + " - " + u.Status + " - " + u.Date_of_execution + " - " + u.Payment + " - " + u.Cook_Employee_ID + " - " + u.Operator_Employee_ID);
                }
            }

            Console.WriteLine("первая работа с таблицей Order. Добавление");
            using (ApplicationContext db = new ApplicationContext())
            {
                Order test = new Order { Id = 5, Client_ID = 12,  Order_date = DateTime.Now, Status = "212", Date_of_execution = DateTime.Now, Payment = 120000, Cook_Employee_ID = 12, Operator_Employee_ID = 12};
                db.Order.Add(test);
                db.SaveChanges();
                var users = db.Order.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Order u in users)
                {
                    Console.WriteLine(u.Id + " - " + u.Client_ID + " - " + u.Order_date + " - " + u.Status + " - " + u.Date_of_execution + " - " + u.Payment + " - " + u.Cook_Employee_ID + " - " + u.Operator_Employee_ID);
                }

            }

            Console.WriteLine("первая работа с таблицей Order. Изменение");
            using (ApplicationContext db = new ApplicationContext())
            {
                Order? updorder = (from order in db.Order where order.Id == 5 select order).First();
                if (updorder != null)
                {
                    updorder.Client_ID = (byte)(updorder.Payment / 10000);
                    db.SaveChanges();
                }
                var orders = db.Order.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Order u in orders)
                {
                    Console.WriteLine(u.Id + " - " + u.Client_ID + " - " + u.Order_date + " - " + u.Status + " - " + u.Date_of_execution + " - " + u.Payment + " - " + u.Cook_Employee_ID + " - " + u.Operator_Employee_ID);
                }

            }

            Console.WriteLine("первая работа с таблицей Order. Удаление");
            using (ApplicationContext db = new ApplicationContext())
            {
                Order? deluser = (from order in db.Order where order.Id == 5 select order).First();
                if (deluser != null)
                {
                    db.Order.Remove(deluser);
                    db.SaveChanges();
                }
                var orders = db.Order.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Order u in orders)
                {
                    Console.WriteLine(u.Id + " - " + u.Client_ID + " - " + u.Order_date + " - " + u.Status + " - " + u.Date_of_execution + " - " + u.Payment + " - " + u.Cook_Employee_ID + " - " + u.Operator_Employee_ID);
                }

            }

            Console.WriteLine("Вторая работа. Order - главная таблица, LineNumber - зависимая");
            using (ApplicationContext db = new ApplicationContext())
            {
                var lineNumbers = db.LineNumber.ToArray();
                var order = db.Order.Where(c => c.Id == 12).FirstOrDefault();
                LineNumber line = new LineNumber { Order_line_number = 8, Count = 5, ProductId = 12, Order = order};


                db.LineNumber.Add(line);

                db.SaveChanges();
            }

            Console.WriteLine("Вторая работа с таблицей LineNumber. Добавление");
            using (ApplicationContext db = new ApplicationContext())
            {
                LineNumber test2 = new LineNumber { Order_line_number = 7, Count = 5, ProductId = 12 };
                db.LineNumber.Add(test2);
                db.SaveChanges();
                var users = db.LineNumber.ToArray();
                Console.WriteLine("Список объектов");
                foreach (LineNumber u in users)
                {
                    Console.WriteLine(u.Order_line_number + " - " + u.Count + " - " + u.ProductId);
                }

            }

            Console.WriteLine("Вторая работа с таблицей LineNumber. Изменение");
            using (ApplicationContext db = new ApplicationContext())
            {
                LineNumber? updline = (from LineNumber in db.LineNumber where LineNumber.Order_line_number == 7 select LineNumber).First();
                if (updline != null)
                {
                    updline.Count = (byte)(updline.Order_line_number / 2);
                    db.SaveChanges();
                }
                var lines = db.LineNumber.ToArray();
                Console.WriteLine("Список объектов");
                foreach (LineNumber u in lines)
                {
                    Console.WriteLine(u.Order_line_number + " - " + u.Count + " - " + u.ProductId);
                }

            }

            Console.WriteLine("Вторая работа с таблицей LineNumber. Удаление");
            using (ApplicationContext db = new ApplicationContext())
            {
                LineNumber? deluser = (from lineNumber in db.LineNumber where lineNumber.Order_line_number == 7 select lineNumber).First();
                if (deluser != null)
                {
                    db.LineNumber.Remove(deluser);
                    db.SaveChanges();
                }
                var lines = db.LineNumber.ToArray();
                Console.WriteLine("Список объектов");
                foreach (LineNumber u in lines)
                {
                    Console.WriteLine(u.Order_line_number + " - " + u.Count + " - " + u.ProductId);
                }

            }

           
        }
    }
}