using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace OOP_NumiStore.Models
{
    class UsersManager
    {
        private const string adminPath = @"json\admins.json";
        private const string customerPath = @"json\customers.json"; 
        public List<Admin> Admins { get; private set; } = new List<Admin>();
        public List<Customer> Customers { get; private set; } = new List<Customer>();

        private static readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            //ReferenceHandler = ReferenceHandler.Preserve
        };

        public UsersManager()
        {
            ReadAdminsFromFile();
            ReadCustomersFromFile();
        }

        public Admin? RegisterAdmin(string login, string password, string email, string name, string surname, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
            {
                errorMessage = "Деякі поля незаповнені.";
                return null;
            }

            if (Customers.Any(a => a.Login == login) || Admins.Any(a => a.Login == login))
            {
                errorMessage = "Користувач з таким логіном вже існує.";
                return null;
            }

            if (Customers.Any(a => a.Email == email) || Admins.Any(a => a.Email == email))
            {
                errorMessage = "Користувач з такою електронною поштою вже існує.";
                return null;
            }

            Admin admin = new Admin()
            {
                Login = login,
                Password = password,
                Email = email,
                Name = name,
                Surname = surname
            };

            if (!AddAdmin(admin))
            {
                errorMessage = "Помилка при додаванні адміністратора.";
                return null;
            }

            SaveToFile(adminPath, Admins);

            errorMessage = null;
            return admin;
        }

        public Customer? RegisterCustomer(string login, string password, string email, string name, string surname, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
            {
                errorMessage = "Деякі поля незаповнені.";
                return null;
            }

            if (Customers.Any(a => a.Login == login) || Admins.Any(a => a.Login == login))
            {
                errorMessage = "Користувач з таким логіном вже існує.";
                return null;
            }

            if (Customers.Any(a => a.Email == email) || Admins.Any(a => a.Email == email))
            {
                errorMessage = "Користувач з такою електронною поштою вже існує.";
                return null;
            }

            Customer customer = new Customer()
            {
                Login = login,
                Password = password,
                Email = email,
                Name = name,
                Surname = surname
            };

            if (!AddCustomer(customer))
            {
                errorMessage = "Помилка при додаванні адміністратора.";
                return null;
            }

            SaveToFile(customerPath, Customers);

            errorMessage = null;
            return customer;
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
        //            Surname = $"TestSurname{i}"
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
        //            Surname = $"TestSurname{i}"
        //        });
        //    }
        //    SaveToFile(customerPath, Customers);
        //}
    }
}
