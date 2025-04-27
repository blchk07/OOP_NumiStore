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

        private static readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            //ReferenceHandler = ReferenceHandler.Preserve
        };

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
            if (Admins.Any(a => a.Email == admin.Email || a.Login == admin.Login)) return false;

            Admins.Add(admin);
            return true;
        }

        public bool AddCustomer(Customer customer)
        {
            if (customer == null) return false;
            if (Customers.Any(c => c.Email == customer.Email || c.Login == customer.Login)) return false;

            Customers.Add(customer);
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
                if (data.Trim() != "")
                {
                    Admins = JsonSerializer.Deserialize<List<Admin>>(data, _jsonOptions) ?? new List<Admin>();
                    return;
                }
            }
            Admins = new List<Admin>();
        }

        private void ReadCustomersFromFile()
        {
            if (File.Exists(customerPath))
            {
                string data = File.ReadAllText(customerPath);
                if (data.Trim() != "")
                {
                    Customers = JsonSerializer.Deserialize<List<Customer>>(data, _jsonOptions) ?? new List<Customer>();
                    return;
                }
            }
            Customers = new List<Customer>();
        }

        private void SaveToFile<T>(string path, List<T> list)
        {
            try
            {
                string data = JsonSerializer.Serialize(list, _jsonOptions);
                File.WriteAllText(path, data);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка під час збережння у файл. {path}:\n{ex.Message}", "Помилка збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //public void GenerateTestDataForAdmin()
        //{
        //    //if (Admins != null)
        //    //{
        //    //    DialogResult result = MessageBox.Show(
        //    //        "Файл адмінів містить дані. Ви впевнені що ви хочете перезаписати файл новими даними?",
        //    //        "Підтвердження",
        //    //        MessageBoxButtons.YesNo
        //    //    );
        //    //    if (result == DialogResult.No) return;
        //    //}
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        AddAdmin(new()
        //        {
        //            Login = $"t{i}",
        //            Password = $"q{i}",
        //            Email = $"test.email{i}@gmail.com",
        //            Name = $"TestName{i}",
        //            Surname = $"TestSurname{i}",
        //            Address = $"{i} Apple Road"
        //        });
        //    }
        //    SaveToFile(adminPath, Admins);
        //}

        //public void GenerateTestDataForCustomer()
        //{
        //    //if (Customers != null)
        //    //{
        //    //    DialogResult result = MessageBox.Show(
        //    //        "Файл покупців містить дані. Ви впевнені що ви хочете перезаписати файл новими даними?",
        //    //        "Підтвердження",
        //    //        MessageBoxButtons.YesNo
        //    //    );
        //    //    if (result == DialogResult.No) return;
        //    //}
        //    for (int i = 6; i <= 10; i++)
        //    {
        //        AddCustomer(new()
        //        {
        //            Login = $"t{i}",
        //            Password = $"q{i}",
        //            Email = $"test.email{i}@gmail.com",
        //            Name = $"TestName{i}",
        //            Surname = $"TestSurname{i}",
        //            Address = $"{i} Apple Road"
        //        });
        //    }
        //    SaveToFile(customerPath, Customers);
        //}
    }
}
