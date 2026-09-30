using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace ConsoleApp1
{
    internal class Customer
    {
        private string Name;
        private string Email;
        private string Phone;
        private string Address;

        public Customer()
        {
            Name= string.Empty;
            Email= string.Empty;
            Phone= string.Empty;
            Address= string.Empty;
        }
        public Customer(string name, string email, string phone,string address) { 
            Name  = name;
            Email = email;
            Phone = phone;
            Address = address;
            Console.WriteLine($"Customer details:\nname:{Name},\nemail:{Email},\nphone:{Phone},\naddress:{Address}");
        }

    }
}
