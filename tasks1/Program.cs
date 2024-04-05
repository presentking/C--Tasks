using System;
using System.Collections.Generic;

class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public DateTime DateAdded { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Customer> customers = new List<Customer>();

        while (true)
        {
            Console.WriteLine("Введите информацию о клиенте(ID, Name, Address, DateAdded):");
            string input = Console.ReadLine();

            if (input.ToLower() == "Выход")
            {
                break;
            }

            string[] values = input.Split(',');

            if (values.Length != 4)
            {
                Console.WriteLine("Неверный Ввод. Пожалуйста, попробуйте еще раз.");
                continue;
            }

            Customer customer = new Customer
            {
                Id = int.Parse(values[0]),
                Name = values[1],
                Address = values[2],
                DateAdded = DateTime.Parse(values[3])
            };

            customers.Add(customer);
            customers.Sort((x, y) => x.DateAdded.CompareTo(y.DateAdded));

            Console.WriteLine("Клиент добавлен в список.");
        }

        Console.WriteLine("Список клиентов в порядке очереди: ");
        foreach (Customer customer in customers)
        {
            Console.WriteLine($"{customer.Id}, {customer.Name}, {customer.Address}, {customer.DateAdded}");
        }
    }
}