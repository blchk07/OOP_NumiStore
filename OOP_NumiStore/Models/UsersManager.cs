using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json;
using System.Text.Json.Serialization;

namespace OOP_NumiStore.Models
{
    class UsersManager
    {
        private readonly string adminPath;
        private readonly string customerPath; 
        public List<Admin> Admins { get; private set; } = new List<Admin>();
        public List<Customer> Customers { get; private set; } = new List<Customer>();

        private static readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions { WriteIndented = true };

        public UsersManager()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.Parent.FullName;
            adminPath = Path.Combine(projectDirectory, "admins.json");
            customerPath = Path.Combine(projectDirectory, "customers.json");

            ReadAdminsFromFile();
            ReadCustomersFromFile();
        }

        public bool AddAdmin(Admin admin)
        {
            if (admin == null) return false;
            if (Admins.Any(u => u.Email == admin.Email || u.Login == admin.Login)) return false;

            Admins.Add(admin);
            AdminsToJson();
            return true;
        }

        public bool AddCustomer(Customer customer)
        {
            if (customer == null) return false;
            if (Customers.Any(u => u.Email == customer.Email || u.Login == customer.Login)) return false;

            Customers.Add(customer);
            CustomersToJson();
            return true;
        }

        public Admin? LoginAdmin(string login, string password)
        {
            Admin? admin = Admins.Find(u => u.Login == login &&  u.Password == password);
            return admin;
        }
        public Customer? LoginCustomer(string login, string password)
        {
            Customer? customer = Customers.Find(u => u.Login == login && u.Password == password);
            return customer;
        }

        public User? Login(string login, string password, out string errorMessage)
        {
            errorMessage = null;

            var admin = LoginAdmin(login, password);
            if (admin != null)
                return admin;

            var customer = LoginCustomer(login, password);
            if (customer != null)
                return customer;

            errorMessage = "Неправильний логін або пароль.";
            return null;
        }

        private void ReadAdminsFromFile()
        {
            if (File.Exists(adminPath))
            {
                string data = File.ReadAllText(adminPath);
                Admins = JsonSerializer.Deserialize<List<Admin>>(data, _jsonOptions) ?? new List<Admin>();
                return;
            }
            Admins = new List<Admin>();
        }

        private void AdminsToJson()
        {
            string data = JsonSerializer.Serialize(Admins, _jsonOptions);
            File.WriteAllText(adminPath, data);
        }

        private void ReadCustomersFromFile()
        {
            if (File.Exists(customerPath))
            {
                string data = File.ReadAllText(customerPath);
                Customers = JsonSerializer.Deserialize<List<Customer>>(data, _jsonOptions) ?? new List<Customer>();
                return;
            }
            Customers = new List<Customer>();
        }

        private void CustomersToJson()
        {
            string data = JsonSerializer.Serialize(Customers, _jsonOptions);
            File.WriteAllText(customerPath, data);
        }
    }
}
