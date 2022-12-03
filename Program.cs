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
            /*
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
                LineNumber line = new LineNumber { Order_line_number = 15, Count = 5, ProductId = 12, Order = order};


                db.LineNumber.Add(line);

                db.SaveChanges();
            }

            Console.WriteLine("Вторая работа с таблицей LineNumber. Добавление");
            using (ApplicationContext db = new ApplicationContext())
            {
                LineNumber test2 = new LineNumber { Order_line_number = 14, Count = 5, ProductId = 12 };
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
                LineNumber? updline = (from LineNumber in db.LineNumber where LineNumber.Order_line_number == 14 select LineNumber).First();
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
                LineNumber? deluser = (from lineNumber in db.LineNumber where lineNumber.Order_line_number == 14 select lineNumber).First();
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

            } */


            /**************Простая проекция*/
            Console.WriteLine("Простая проекция");
            using (ApplicationContext db = new ApplicationContext())
                {
                    /*  var orders = from p in db.Order.ToArray()
                                    select p.Id; */
                    var orders = db.Order.ToArray().Select(p => p.Id);
                    foreach (var p in orders)
                    {
                        Console.WriteLine(p);
                    }


                }


            /**************Анонимный объект*/
            Console.WriteLine("Анонимный объект");
            using (ApplicationContext db = new ApplicationContext())
                {
                /*var orders = from p in db.Order.ToArray()
                            select new
                            {
                                Status = p.Status + "(New obj)",
                                Id = p.Id * 2
                            }; */
                var orders = db.Order.ToArray().Select(p => new
                    {
                        Status = p.Status + "(New obj)",
                        Id = p.Id * 2
                    });
                    foreach (var p in orders)
                    {
                        Console.WriteLine(p.Status + " " + p.Id);
                    }

                }


            Console.WriteLine("Переменные в операторах Linq");/************Переменные в операторах Linq*/

            using (ApplicationContext db = new ApplicationContext())
                        {
                            var orders = from p in db.Order.ToArray()
                                        let id = p.Id * 2
                                        select new
                                        {
                                            Status = p.Status + "(New obj)",
                                            Id = id
                                        };

                            foreach (var p in orders)
                            {
                                Console.WriteLine(p.Status + " " + p.Id);
                            }

                        }

            /************Декартово произведение*/
            Console.WriteLine("Декартово произведение");
            using (ApplicationContext db = new ApplicationContext())
                        {
                           var orders = from u in db.Order.ToArray()
                                        from c in db.LineNumber.ToArray()
                                        select new
                                        {
                                            Status = u.Status,
                                            Number = c.Count
                                        };
                 //var orders = db.Order.ToArray(). (db.LineNumber.ToArray(), (u, c) => new { Status = u.Status, Number = c.Count });
                foreach (var p in orders)
                            {
                                Console.WriteLine(p.Status + " " + p.Number);
                            }

                        }


                Console.WriteLine("Фильтрация коллекции");
            using (ApplicationContext db = new ApplicationContext())
                        {
                /* var orders = from p in db.Order.ToArray()
                             where p.Id <= 6
                             select p.Status;*/
                var orders = db.Order.ToArray().Where(p => p.Id <= 6).Select(p => p.Status);
                            foreach (var p in orders)
                            {
                                Console.WriteLine(p);
                            }


                        }


            Console.WriteLine("Сортировка коллекции");
            using (ApplicationContext db = new ApplicationContext())
                        {

                /*  var orders = from u in db.Order.ToArray()
                               orderby u.Status
                               select u;  */


                var orders = db.Order.ToArray().OrderBy(u => u.Status);
                            foreach (var p in orders)
                            {
                                Console.WriteLine(p.Status);
                            }

                        }

            Console.WriteLine("Объединение таблиц");
            using (ApplicationContext db = new ApplicationContext())
                        {

                /*    var orders = from u in db.Order.ToArray() join
                                    c in db.LineNumber.ToArray() on u.ProductId equals c.Id
                                    select new { user = u.Fio, company = c.Name };

                    */
                var orders = db.Order.ToArray().Join(db.LineNumber.ToArray(), u => u.Id, c => c.Order_line_number, (u, c) => new { order = u.Status, number = c.Count });
                            foreach (var p in orders)
                            {
                                Console.WriteLine(p.order + " " + p.number);
                            }

                        }

                Console.WriteLine("Загрузка связанных данных");
            using (ApplicationContext db = new ApplicationContext())
                        {


                            var orders = db.Order.Include(u => u.LineNumbers).ToArray();



                            foreach (var p in orders)
                            {
                                Console.WriteLine(p.Status + " " + p.LineNumbers?.Count);
                            }

                        }

            Console.WriteLine("Извлечение определенного числа элементов");
            using (ApplicationContext db = new ApplicationContext())
            {
                var orders = db.Order.ToArray().Take(2);
                foreach (var p in orders)
                {
                    Console.WriteLine(p.Status);
                }
            }

            Console.WriteLine("Последовательное объединение таблиц");
            using (ApplicationContext db = new ApplicationContext())
            {

                var orders = db.Order.ToArray().Zip(db.LineNumber.ToArray());
                foreach (var p in orders)
                {
                    Console.WriteLine($"{p.First.Id} - {p.Second.Order_line_number}");
                }

            }
            
            Console.WriteLine("SelectMany");
            using (ApplicationContext db = new ApplicationContext())
            {
                var order = db.Order.SelectMany(c => db.LineNumber, (c, emp) => new { Stat = c.Status, ID = c.Id, Count = emp.Count });
                Console.WriteLine(order.Count());
                foreach (var p in order)
                {
                    Console.WriteLine($"{p.ID} {p.Stat} {p.Count}");

                }
            }
            

        }
    }
}