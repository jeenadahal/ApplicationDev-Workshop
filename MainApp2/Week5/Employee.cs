using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MainApp2.Week5
{
    internal class Employee
    {
        public static void EmployeeList()
        {
            List<EmployeeModel> list = new List<EmployeeModel>
            {
                new EmployeeModel{ FirstName = "Jeena", LastName = "Dahal", Designation = "Business Analyst", PhoneNumber = "123456", Email = "ashma@gmail.com", Address="Kathmandu", HiredDate = DateTime.Now, Salary = 50000, IsManager = true},
                new EmployeeModel{ FirstName = "Anusha", LastName = "Maharjan", Designation = "Branch Manager", PhoneNumber = "13456", Email = "anusha@gmail.com", Address="Pokhara", HiredDate = DateTime.Now, Salary = 55000, IsManager = true},
                new EmployeeModel{ FirstName = "Jack", LastName = "Connor", Designation = "Sales Person", PhoneNumber = "125356", Email = "jack@gmail.com", Address="Kathmandu", HiredDate = DateTime.Now, Salary = 20000, IsManager = false},
                new EmployeeModel{ FirstName = "Charlie", LastName = "William", Designation = "Sales Person", PhoneNumber = "132156", Email = "charlie@gmail.com", Address="Kathmandu", HiredDate = DateTime.Now, Salary = 20000, IsManager = false},
                new EmployeeModel{ FirstName = "Jennifer", LastName = "Lopez", Designation = "Sales Person", PhoneNumber = "094456", Email = "jennifer@gmail.com", Address="Kathmandu", HiredDate = DateTime.Now, Salary = 20000, IsManager = false},
                new EmployeeModel{ FirstName = "John", LastName = "Smith", Designation = "Sales Person", PhoneNumber = "123286", Email = "john@gmail.com", Address="Solukhumbu", HiredDate = DateTime.Now, Salary = 30000, IsManager = false},
                new EmployeeModel{ FirstName = "Maria", LastName = "Wilson", Designation = "HR Manager", PhoneNumber = "048323", Email = "maria@gmail.com", Address="Biratnagar", HiredDate = DateTime.Now, Salary = 45000, IsManager = true},
                new EmployeeModel{ FirstName = "Jack", LastName = "Dawson", Designation = "Sales Person", PhoneNumber = "539232", Email = "jack@gmail.com", Address="Jhapa", HiredDate = DateTime.Now, Salary = 15000, IsManager = false},
                new EmployeeModel{ FirstName = "Taylor", LastName = "Swift", Designation = "Trainee", PhoneNumber = "643211", Email = "taylor@gmail.com", Address="Kathmandu", HiredDate = DateTime.Now, Salary = 5000, IsManager = false},
                new EmployeeModel{ FirstName = "Mark", LastName = "Thomson", Designation = "Clerk", PhoneNumber = "948372", Email = "mark@gmail.com", Address="Pokhara", HiredDate = DateTime.Now, Salary = 15000, IsManager = false}
            };


            // searching by firstname
            Console.WriteLine("----------------------------- Search Employee by First Name -----------------------------");

            Console.WriteLine("Enter employee's first name: ");
            string first_name = Console.ReadLine();

            List<EmployeeModel> searchEmployee = list.Where(x => x.FirstName == first_name).ToList();

            foreach (var employee in searchEmployee)
            {
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("Full Name: " + employee.FirstName + " " + employee.LastName + "\n" +
                    "Designation: " + employee.Designation + "\n" +
                    "Phone Number: " + employee.PhoneNumber + "\n" +
                    "Email: " + employee.Email + "\n" +
                    "Address: " + employee.Address + "\n" +
                    "Hired Date: " + employee.HiredDate.ToLongDateString() + "\n" +
                    "Salary: " + employee.Salary + "\n" 
                    );
                Console.WriteLine("-------------------------------------------------------------");

                // Writing search result in file - Serialize
                string filename = "searchByFirstName.json";
                string jsonString = JsonSerializer.Serialize(searchEmployee);
                File.WriteAllText(filename, jsonString);
            }

            Console.WriteLine("----------------------------- Search Employee by First Name -----------------------------");






            





            // searching by designation
            Console.WriteLine("----------------------------- Search Employee by Designation -----------------------------");

            Console.WriteLine("Enter employee's designation: ");
            string designation = Console.ReadLine();

            List<EmployeeModel> searchEmployee2 = list.Where(x => x.Designation == designation).ToList();

            foreach (var employee in searchEmployee2)
            {
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("Full Name: " + employee.FirstName + " " + employee.LastName + "\n" +
                    "Designation: " + employee.Designation + "\n" +
                    "Phone Number: " + employee.PhoneNumber + "\n" +
                    "Email: " + employee.Email + "\n" +
                    "Address: " + employee.Address + "\n" +
                    "Hired Date: " + employee.HiredDate.ToLongDateString() + "\n" +
                    "Salary: " + employee.Salary + "\n"
                    );
                Console.WriteLine("-------------------------------------------------------------");

                // Writing search result in file - Serialize
                string filename2 = "searchByDesignation.json";
                string jsonString2 = JsonSerializer.Serialize(searchEmployee2);
                File.WriteAllText(filename2, jsonString2);
                Console.WriteLine(jsonString2);
            }

            Console.WriteLine("----------------------------- Search Employee by Designation -----------------------------");






            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");






            // sorting by salary
            Console.WriteLine("----------------------------- Sort Employee by Salary -----------------------------");

            Console.WriteLine("------ Ascending Order ------");

            List<EmployeeModel> ascSort = list.OrderBy(x => x.Salary).ToList();
            Console.WriteLine("Full Name " + "          " + "Designation" + "       " + "Salary" + "\n");
            foreach (var employee in ascSort)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + "        " +employee.Designation + "         " + employee.Salary +"\n");
            }

            Console.WriteLine("------ Ascending Order ------");




            Console.WriteLine("\n");




            Console.WriteLine("------ Descending Order ------");
            List<EmployeeModel> descSort = list.OrderByDescending(x => x.Salary).ToList();
            Console.WriteLine("Full Name " + "          " + "Designation" + "       " + "Salary" + "\n");
            foreach (var employee in descSort)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + "        " + employee.Designation + "         " + employee.Salary + "\n");
            }
            Console.WriteLine("------ Descending Order ------");

            Console.WriteLine("----------------------------- Sort Employee by Salary -----------------------------");
        }
    }
}
