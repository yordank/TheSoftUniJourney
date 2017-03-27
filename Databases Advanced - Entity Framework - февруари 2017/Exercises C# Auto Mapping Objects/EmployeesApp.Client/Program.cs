using AutoMapper;
using EmployeesApp.Models;
using System;
using EmployeesApp.Models.Dtos;
using System.Collections.Generic;
using EmployeesApp.Data;
using System.Linq;
using AutoMapper.QueryableExtensions;

namespace EmployeesApp.Client
{
    class Program
    {
     
        static void Main(string[] args)
        {
            ConfigureAutoMapper();

            //_1_problem();
            //_2_problem();
            //_3_problem();

        }

        private static void _3_problem()
        {
            InitializeDatabase();

            IEnumerable<Employee> managers = CreateManagers();

            SeedDatabase(managers);

            using (var context = new EmployeesContext())
            {
                var employees = context
                    .Employees
                    .Where(x => x.Birthday.Value.Year < 1990)
                    .OrderByDescending(x => x.Salary)
                    .ProjectTo<EmployeeDTO>()
                    .ToList();
                foreach (var emp in employees)
                {
                    Console.WriteLine($"{emp.FirstName} {emp.LastName} {emp.Salary:f2} - Manager: {emp.ManagerLastName ?? "[no manager]"}");
                }
            }
        }

        private static void SeedDatabase(IEnumerable<Employee> managers)
        {
            using (var context = new EmployeesContext())
            {
                context.Employees.AddRange(managers);
                context.SaveChanges();
            }


        }

        private static void InitializeDatabase()
        {
            using (var context=new EmployeesContext())
            {
                context.Database.Initialize(true);
            }

        }

        private static void _2_problem()
        {
            IEnumerable<Employee> managers = CreateManagers();

            IEnumerable<ManagerDTO> managersDTO = Mapper.Map<IEnumerable<Employee>, IEnumerable<ManagerDTO>>(managers);

            foreach (ManagerDTO manager in managersDTO)
            {
                Console.WriteLine(manager.ToString());
            }
        }

        private static void _1_problem()
        {
            Employee emp = new Employee()
            {
                FirstName = "Ivan",
                LastName = "Petrov",
                Address = "Sofiya",
                Salary = 1000,
                Birthday = new DateTime(1990, 2, 3)
            };

            EmployeeDTO dto = Mapper.Map<EmployeeDTO>(emp);

            Console.WriteLine($"{dto.FirstName} {dto.LastName} {dto.Salary}");
        }

        private static void ConfigureAutoMapper()
        {
            Mapper.Initialize(action => {
                action.CreateMap<Employee, EmployeeDTO>();
                action.CreateMap<Employee, ManagerDTO>()
                .ForMember(dto => dto.SubordinatesCount,configExpression=>configExpression.MapFrom(e=>e.Subordinates.Count));

            });
           

        }

        private static List<Employee> CreateManagers()
        {
            var managers = new List<Employee>();


            for (int j = 0; j < 3; j++)
            {
       
                var manager = new Employee()
                {
                    FirstName = "Pesho"+j,
                    LastName = "Petrov"+j,
                    Address = "Varna",
                    Birthday = new DateTime(1981,3,3),
                    isOnHoliday = false,
                    Salary=2000+j

                };

                for (int i = 0; i < 10; i++)
                {
                    Employee emp = new Employee()
                    {
                        FirstName = "Ivan" + i,
                        LastName = "Ivanov",
                        Salary = 1000 + i,
                        manager = manager,
                        Birthday=new DateTime(1985,3,3)

                    };
                    manager.Subordinates.Add(emp);
                }

                managers.Add(manager);

          }

            return managers;
           
        }
    }
}
