using Microsoft.EntityFrameworkCore;
using TestEFCore.ConnectionData;
using TestEFCore.Models;
namespace TestEFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using var context = new AppDbContext();
            var emps = new List<Employee>
            {
                new Employee {Fname="Adel",Lname="Mohamed",PhoneNumber = "01082254939",Email="adel.mohamed@gmail.com",Salary = 3000m ,DepartmentId = 1},
                new Employee {Fname="Ali",Lname="Said",PhoneNumber = "01143254976",Email="ali.said@gmail.com",Salary = 4000m,DepartmentId = 4},
                new Employee {Fname="Ahmed",Lname="Khaled",PhoneNumber = "01003218738",Email="ahmed.khaled@gmail.com",Salary = 5000m,DepartmentId = 2},
                new Employee {Fname="Kamal",Lname="Morsey",PhoneNumber = "01143103254",Email="kamal.morsy@gmail.com",Salary = 3000m, DepartmentId = 1},
                new Employee {Fname="Nader",Lname="Abas",PhoneNumber = "01543201931",Email="nader.abas@gmail.com",Salary = 2000m , DepartmentId = 3},
                new Employee {Fname="Maher",Lname="Mohamed",PhoneNumber = "01143994997",Email="maher.mohamed@gmail.com",Salary = 6000m , DepartmentId = 3},
                new Employee {Fname="Emad",Lname="Hamdy",PhoneNumber = "01043259170",Email="emad.hamdy@gmail.com",Salary = 8000m , DepartmentId = 2},
                new Employee {Fname="Saad",Lname="Ali",PhoneNumber = "01143232132",Email="saad.ali@gmail.com",Salary = 1000m , DepartmentId = 2},
                new Employee {Fname="Mariam",Lname="Kamal",PhoneNumber = "01199254935",Email="mariam.kamal@gmail.com",Salary = 7000m , DepartmentId = 4},
                new Employee {Fname="Mona",Lname="Zaky",PhoneNumber = "01043200910",Email="mona.zaky@gmail.com",Salary = 2000m , DepartmentId = 3},
                new Employee { Fname = "Ahmed", Lname = "Hassan", PhoneNumber = "01012345678", Email = "ahmed.hassan@gmail.com", Salary = 2500m, DepartmentId = 2 },
                new Employee { Fname = "Laila", Lname = "Saad", PhoneNumber = "01087654321", Email = "laila.saad@gmail.com", Salary = 3000m, DepartmentId = 4 },
                new Employee { Fname = "Khaled", Lname = "Ali", PhoneNumber = "01009876543", Email = "khaled.ali@gmail.com", Salary = 2200m, DepartmentId = 1 },
                new Employee { Fname = "Salma", Lname = "Youssef", PhoneNumber = "01056473829", Email = "salma.youssef@gmail.com", Salary = 2800m, DepartmentId = 4 },
                new Employee { Fname = "Yasser", Lname = "Mohamed", PhoneNumber = "01019283746", Email = "yasser.mohamed@gmail.com", Salary = 2700m, DepartmentId = 3 },
                new Employee { Fname = "Sara", Lname = "Nasser", PhoneNumber = "01029384756", Email = "sara.nasser@gmail.com", Salary = 2400m, DepartmentId = 2 },
                new Employee { Fname = "Omar", Lname = "Hussein", PhoneNumber = "01038475692", Email = "omar.hussein@gmail.com", Salary = 2600m, DepartmentId = 4 },
                new Employee { Fname = "Nadia", Lname = "Fahmy", PhoneNumber = "01047586921", Email = "nadia.fahmy@gmail.com", Salary = 3200m, DepartmentId = 1 },
                new Employee { Fname = "Mohamed", Lname = "Ibrahim", PhoneNumber = "01059638274", Email = "mohamed.ibrahim@gmail.com", Salary = 3100m, DepartmentId = 2 },
                new Employee { Fname = "Fatma", Lname = "Kamel", PhoneNumber = "01067849305", Email = "fatma.kamel@gmail.com", Salary = 3300m, DepartmentId = 1 },
                new Employee { Fname = "Ali", Lname = "Ahmed", PhoneNumber = "01078956432", Email = "ali.ahmed@gmail.com", Salary = 2900m, DepartmentId = 3 },
                new Employee { Fname = "Reem", Lname = "Salem", PhoneNumber = "01089067543", Email = "reem.salem@gmail.com", Salary = 3500m, DepartmentId = 2 },
                new Employee { Fname = "Tamer", Lname = "Gad", PhoneNumber = "01090178654", Email = "tamer.gad@gmail.com", Salary = 2100m, DepartmentId = 4 },
                new Employee { Fname = "Dina", Lname = "Mahmoud", PhoneNumber = "01001234567", Email = "dina.mahmoud@gmail.com", Salary = 2900m, DepartmentId = 1 },
                new Employee { Fname = "Hassan", Lname = "Sayed", PhoneNumber = "01012345098", Email = "hassan.sayed@gmail.com", Salary = 2700m, DepartmentId = 2 },
                new Employee { Fname = "Manal", Lname = "Fouad", PhoneNumber = "01023456109", Email = "manal.fouad@gmail.com", Salary = 3100m, DepartmentId = 1 },
                new Employee { Fname = "Adel", Lname = "Younes", PhoneNumber = "01034567210", Email = "adel.younes@gmail.com", Salary = 2800m, DepartmentId = 1 },
                new Employee { Fname = "Mona", Lname = "Gaber", PhoneNumber = "01045678321", Email = "mona.gaber@gmail.com", Salary = 2600m, DepartmentId = 3 },
                new Employee { Fname = "Hisham", Lname = "Amin", PhoneNumber = "01056789432", Email = "hisham.amin@gmail.com", Salary = 3400m, DepartmentId = 4 },
                new Employee { Fname = "Nour", Lname = "Saleh", PhoneNumber = "01067890543", Email = "nour.saleh@gmail.com", Salary = 2300m, DepartmentId = 1 },
                new Employee { Fname = "Rania", Lname = "Osman", PhoneNumber = "01078912345", Email = "rania.osman@gmail.com", Salary = 2500m, DepartmentId = 2 },
                new Employee { Fname = "Ziad", Lname = "Nabil", PhoneNumber = "01089023456", Email = "ziad.nabil@gmail.com", Salary = 2900m, DepartmentId = 3 },
                new Employee { Fname = "Jana", Lname = "Hassan", PhoneNumber = "01090134567", Email = "jana.hassan@gmail.com", Salary = 2700m, DepartmentId = 4 },
                new Employee { Fname = "Mariam", Lname = "Fawzy", PhoneNumber = "01001245678", Email = "mariam.fawzy@gmail.com", Salary = 3200m, DepartmentId = 2 },
                new Employee { Fname = "Rami", Lname = "Farid", PhoneNumber = "01012356789", Email = "rami.farid@gmail.com", Salary = 3100m, DepartmentId = 3 },
                new Employee { Fname = "Layla", Lname = "Gamal", PhoneNumber = "01023467890", Email = "layla.gamal@gmail.com", Salary = 2800m, DepartmentId = 1 },
                new Employee { Fname = "Samir", Lname = "Khalil", PhoneNumber = "01034578901", Email = "samir.khalil@gmail.com", Salary = 2900m, DepartmentId = 2 },
                new Employee { Fname = "Hoda", Lname = "Karam", PhoneNumber = "01045689012", Email = "hoda.karam@gmail.com", Salary = 3000m, DepartmentId = 3 },
                new Employee { Fname = "Khaled", Lname = "Rashed", PhoneNumber = "01056790123", Email = "khaled.rashed@gmail.com", Salary = 3100m, DepartmentId = 4 },
                new Employee { Fname = "Nadia", Lname = "El Sayed", PhoneNumber = "01067801234", Email = "nadia.elsayed@gmail.com", Salary = 3300m, DepartmentId = 1 },
                new Employee { Fname = "Youssef", Lname = "Hany", PhoneNumber = "01078912346", Email = "youssef.hany@gmail.com", Salary = 2700m, DepartmentId = 2 },
                new Employee { Fname = "Mona", Lname = "Saeed", PhoneNumber = "01089023457", Email = "mona.saeed@gmail.com", Salary = 2900m, DepartmentId = 1 },
                new Employee { Fname = "Fadi", Lname = "Ibrahim", PhoneNumber = "01090134568", Email = "fadi.ibrahim@gmail.com", Salary = 2800m, DepartmentId = 2 },
                new Employee { Fname = "Maya", Lname = "Ghanem", PhoneNumber = "01001245679", Email = "maya.ghannem@gmail.com", Salary = 3000m, DepartmentId = 3 },
                new Employee { Fname = "Omar", Lname = "Shaker", PhoneNumber = "01012356780", Email = "omar.shaker@gmail.com", Salary = 2900m, DepartmentId = 4 },
                new Employee { Fname = "Lina", Lname = "Badr", PhoneNumber = "01023467891", Email = "lina.badr@gmail.com", Salary = 3100m, DepartmentId = 3 },
                new Employee { Fname = "Tariq", Lname = "El Khatib", PhoneNumber = "01034578902", Email = "tariq.elkhatib@gmail.com", Salary = 3200m, DepartmentId = 4 },
                new Employee { Fname = "Rania", Lname = "Ali", PhoneNumber = "01045689023", Email = "rania.ali@gmail.com", Salary = 2700m, DepartmentId = 1 },
                new Employee { Fname = "Kareem", Lname = "Salah", PhoneNumber = "01056790134", Email = "kareem.salah@gmail.com", Salary = 2800m, DepartmentId = 2 },
                new Employee { Fname = "Hala", Lname = "Mohamed", PhoneNumber = "01067801235", Email = "hala.mohamed@gmail.com" , Salary = 3000m,DepartmentId = 1},
                new Employee { Fname = "Nabil", Lname = "Kamal", PhoneNumber = "01011223344", Email = "nabil.kamal@gmail.com", Salary = 2600m, DepartmentId = 1 },
                new Employee { Fname = "Dalia", Lname = "Hassan", PhoneNumber = "01022334455", Email = "dalia.hassan@gmail.com", Salary = 2900m, DepartmentId = 2 },
                new Employee { Fname = "Fady", Lname = "Gamal", PhoneNumber = "01033445566", Email = "fady.gamal@gmail.com", Salary = 2800m, DepartmentId = 3 },
                new Employee { Fname = "Hanan", Lname = "Tariq", PhoneNumber = "01044556677", Email = "hanan.tariq@gmail.com", Salary = 3100m, DepartmentId = 4 },
                new Employee { Fname = "Youssef", Lname = "Khaled", PhoneNumber = "01055667788", Email = "youssef.khaled@gmail.com", Salary = 3200m, DepartmentId = 2 },
                new Employee { Fname = "Layla", Lname = "Zaki", PhoneNumber = "01066778899", Email = "layla.zaki@gmail.com", Salary = 3000m, DepartmentId = 3 },
                new Employee { Fname = "Jad", Lname = "Said", PhoneNumber = "01077889900", Email = "jad.said@gmail.com", Salary = 2700m, DepartmentId = 1 },
                new Employee { Fname = "Mariam", Lname = "Fahmy", PhoneNumber = "01088990011", Email = "mariam.fahmy@gmail.com", Salary = 3100m, DepartmentId = 2 },
                new Employee { Fname = "Rami", Lname = "Ghanem", PhoneNumber = "01099001122", Email = "rami.ghannem@gmail.com", Salary = 2800m, DepartmentId = 3 },
                new Employee { Fname = "Nada", Lname = "Gaber", PhoneNumber = "01010112233", Email = "nada.gaber@gmail.com", Salary = 2900m, DepartmentId = 4 },
                new Employee { Fname = "Ibrahim", Lname = "Fouad", PhoneNumber = "01021223344", Email = "ibrahim.fouad@gmail.com", Salary = 3000m, DepartmentId = 2 },
                new Employee { Fname = "Rania", Lname = "Shaker", PhoneNumber = "01032334455", Email = "rania.shaker@gmail.com", Salary = 2700m, DepartmentId = 1 },
                new Employee { Fname = "Khaled", Lname = "Mansour", PhoneNumber = "01043445566", Email = "khaled.mansour@gmail.com", Salary = 2800m, DepartmentId = 1 },
                new Employee { Fname = "Amira", Lname = "Nabil", PhoneNumber = "01054556677", Email = "amira.nabil@gmail.com", Salary = 2900m, DepartmentId = 2 },
                new Employee { Fname = "Nour", Lname = "Said", PhoneNumber = "01065667788", Email = "nour.said@gmail.com", Salary = 3100m, DepartmentId = 3 },
                new Employee { Fname = "Yasser", Lname = "Mourad", PhoneNumber = "01076778899", Email = "yasser.mourad@gmail.com", Salary = 3200m, DepartmentId = 4 },
                new Employee { Fname = "Hoda", Lname = "Ali", PhoneNumber = "01087889900", Email = "hoda.ali@gmail.com", Salary = 3000m, DepartmentId = 3 },
                new Employee { Fname = "Amina", Lname = "Hassan", PhoneNumber = "01098990011", Email = "amina.hassan@gmail.com", Salary = 2700m, DepartmentId = 4 },
                new Employee { Fname = "Salim", Lname = "Zaki", PhoneNumber = "01010122334", Email = "salim.zaki@gmail.com", Salary = 2900m, DepartmentId = 1 },
                new Employee { Fname = "Rasha", Lname = "Shaker", PhoneNumber = "01021233445", Email = "rasha.shaker@gmail.com", Salary = 2800m, DepartmentId = 2 },
                new Employee { Fname = "Hassan", Lname = "Tariq", PhoneNumber = "01032344556", Email = "hassan.tariq@gmail.com", Salary = 3000m, DepartmentId = 3 },
                new Employee { Fname = "Mona", Lname = "Gamal", PhoneNumber = "01043455667", Email = "mona.gamal@gmail.com", Salary = 3100m, DepartmentId = 4 },
                new Employee { Fname = "Omar", Lname = "Fahmy", PhoneNumber = "01054566778", Email = "omar.fahmy@gmail.com", Salary = 3200m, DepartmentId = 2 },
                new Employee { Fname = "Lina", Lname = "Khaled", PhoneNumber = "01065677889", Email = "lina.khaled@gmail.com", Salary = 3000m, DepartmentId = 1 },
                new Employee { Fname = "Ziad", Lname = "Nasser", PhoneNumber = "01076788990", Email = "ziad.nasser@gmail.com", Salary = 2700m, DepartmentId = 1 },
                new Employee { Fname = "Kareem", Lname = "Said", PhoneNumber = "01087899001", Email = "kareem.said@gmail.com", Salary = 2900m, DepartmentId = 2 },
                new Employee { Fname = "Hala", Lname = "Gaber", PhoneNumber = "01098900112", Email = "hala.gaber@gmail.com", Salary = 2800m, DepartmentId = 3 },
                new Employee { Fname = "Fahad", Lname = "Farid", PhoneNumber = "01010111223", Email = "fahad.farid@gmail.com", Salary = 3000m, DepartmentId = 4 },
                new Employee { Fname = "Nour", Lname = "Shaker", PhoneNumber = "01021222334", Email = "nour.shaker@gmail.com", Salary = 3100m, DepartmentId = 2 },
                new Employee { Fname = "Mariam", Lname = "Mansour", PhoneNumber = "01032333445", Email = "mariam.mansour@gmail.com", Salary = 3200m, DepartmentId = 1 },
                new Employee { Fname = "Jana", Lname = "Zaki", PhoneNumber = "01043444556", Email = "jana.zaki@gmail.com", Salary = 2900m, DepartmentId = 1 },
                new Employee { Fname = "Adel", Lname = "Ali", PhoneNumber = "01054555667", Email = "adel.ali@gmail.com", Salary = 2800m, DepartmentId = 2 },
                new Employee { Fname = "Nadia", Lname = "Gamal", PhoneNumber = "01065666778", Email = "nadia.gamal@gmail.com", Salary = 3100m, DepartmentId = 3 },
                new Employee { Fname = "Khaled", Lname = "Mourad", PhoneNumber = "01076777889", Email = "khaled.mourad@gmail.com", Salary = 3200m, DepartmentId = 4 },
                new Employee { Fname = "Amina", Lname = "Hassan", PhoneNumber = "01087888990", Email = "amina.hassan@gmail.com", Salary = 3000m, DepartmentId = 2 },
                new Employee { Fname = "Omar", Lname = "Zaki", PhoneNumber = "01098990001", Email = "omar.zaki@gmail.com", Salary = 2700m, DepartmentId = 3 },
                new Employee { Fname = "Rania", Lname = "Said", PhoneNumber = "01010111224", Email = "rania.said@gmail.com", Salary = 2900m, DepartmentId = 1 },
                new Employee { Fname = "Rami", Lname = "Shaker", PhoneNumber = "01021222345", Email = "rami.shaker@gmail.com", Salary = 2800m, DepartmentId = 2 },
                new Employee { Fname = "Mona", Lname = "Nasser", PhoneNumber = "01032333456", Email = "mona.nasser@gmail.com", Salary = 3000m, DepartmentId = 3 },
                new Employee { Fname = "Hala", Lname = "Farid", PhoneNumber = "01043444567", Email = "Hala.Farid@gmail.com", Salary = 4000m, DepartmentId = 3 },
                new Employee { Fname = "Samir", Lname = "Hassan", PhoneNumber = "01054555678", Email = "samir.hassan@gmail.com", Salary = 3200m, DepartmentId = 2 },
                new Employee { Fname = "Amira", Lname = "Ali", PhoneNumber = "01065666789", Email = "amira.ali@gmail.com", Salary = 3000m, DepartmentId = 1 },
                new Employee { Fname = "Tamer", Lname = "Gamal", PhoneNumber = "01076777890", Email = "tamer.gamal@gmail.com", Salary = 2700m, DepartmentId = 1 },
                new Employee { Fname = "Mariam", Lname = "Zaki", PhoneNumber = "01087888901", Email = "mariam.zaki@gmail.com", Salary = 2900m, DepartmentId = 2 },
                new Employee { Fname = "Amin", Lname = "Mourad", PhoneNumber = "01098990012", Email = "amin.mourad@gmail.com", Salary = 2800m, DepartmentId = 3 },
                new Employee { Fname = "Lina", Lname = "Farid", PhoneNumber = "01010111225", Email = "lina.farid@gmail.com", Salary = 3000m, DepartmentId = 4 },
                new Employee { Fname = "Mona", Lname = "Said", PhoneNumber = "01021222346", Email = "mona.said@gmail.com", Salary = 3100m, DepartmentId = 4 },
                new Employee { Fname = "Omar", Lname = "Gamal", PhoneNumber = "01032333457", Email = "omar.gamal@gmail.com", Salary = 3200m, DepartmentId = 3 },
                new Employee { Fname = "Fady", Lname = "Khaled", PhoneNumber = "01043444568", Email = "fady.khaled@gmail.com", Salary = 2700m, DepartmentId = 1 },
                new Employee { Fname = "Nadia", Lname = "Shaker", PhoneNumber = "01054555689", Email = "nadia.shaker@gmail.com", Salary = 2900m, DepartmentId = 2 },
                new Employee { Fname = "Tariq", Lname = "Fouad", PhoneNumber = "01065666790", Email = "tariq.fouad@gmail.com", Salary = 2800m, DepartmentId = 3 },
                new Employee { Fname = "Hanan", Lname = "Gaber", PhoneNumber = "01076777891", Email = "hanan.gaber@gmail.com", Salary = 3000m, DepartmentId = 4 },
                new Employee { Fname = "Laila", Lname = "Gamal", PhoneNumber = "01087888902", Email = "laila.gamal@gmail.com", Salary = 3100m, DepartmentId = 2 },
                new Employee { Fname = "Adel", Lname = "Hassan", PhoneNumber = "01098990023", Email = "adel.hassan@gmail.com", Salary = 3200m, DepartmentId = 1 }

            };

            //context.Employees.AddRange(emps);

            //var departs = new List<Department>
            //{
            //    new Department{Name = "Sales" },
            //    new Department{Name = "Purchases" },
            //    new Department{Name = "Accountancy" },
            //    new Department{Name = "Credenza" }
            //};

            //context.Departments.AddRange(departs);
            //context.SaveChanges();



            //var configuration = new ConfigurationBuilder().AddJsonFile("appsittings.json").Build();
            //var connection = configuration.GetSection("Connection String").Value;

            //[Services Collection DbContext]
            //var services = new ServiceCollection();
            //services.AddDbContext<AppDbContext>(option => option.UseSqlServer(connection));
            //IServiceProvider serviceProvider = services.BuildServiceProvider();

            //[External DbContext]
            //var optionbuilder = new DbContextOptionsBuilder();
            //optionbuilder.UseSqlServer(connection);
            //var option = optionbuilder.Options;

            //[Factory DbContext]
            //var services = new ServiceCollection();
            //services.AddDbContextFactory<AppDbContext>(option => option.UseSqlServer(connection));
            //IServiceProvider serviceProvider = services.BuildServiceProvider();
            //var contextfactory = serviceProvider.GetService<IDbContextFactory<AppDbContext>>();

            //[internal Dbcontext]
            //using var context = serviceProvider.GetService<AppDbContext>(); 
            //using var context = new AppDbContext(option);
            //using var context = contextfactory?.CreateDbContext();
            using var context = new AppDbContext();
            var employees = context.Employees;
            var departments = context.Departments;
            var clients = context.Clients;
            var projects = context.Projects;
            //var result = employees.Where(emp => emp.Fname.StartsWith("r")).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //employees.AsNoTracking().ToList().GetAllData().Print();

            //departments.SelectMany(dep => dep.Employees).Print();

            //var result = employees.Where(emp => emp.Salary < 3000);
            //foreach (var item in employees)
            //{
            //    item.Salary += 1000;
            //}
            //result.Print();

            //employees
            //    .Join(
            //    departments,
            //    emp => emp.DepartmentId,
            //    dep => dep.Departmentid,
            //    (emp, dep) =>  new
            //    {
            //        emp.Fname,
            //        emp.Lname,
            //        emp.Salary,
            //        emp.Email,
            //        emp.PhoneNumber,
            //        dep.Name
            //    }).Print();


            //Console.Write("Enter search name : ");
            //string? name = Console.ReadLine();
            //var result = employees.Where(emp => (emp.Fname + emp.Lname).Contains(name!.Replace(" ", ""))).ToList();
            //if (result.IsNullOrEmpty())
            //    Console.WriteLine("NO Result!!?");
            //result.Print();

            //foreach (var item in employees.Where(emp => emp.Employeeid >= 11).ToList())
            //{
            //    item.Email = item.Email?.Replace("example", "gmail");
            //}

            //context.SaveChanges();


            //var result = await employees.Where(emp => emp.Salary > 2000).ToListAsync();
            //var result2 = await departments.ToListAsync();
            //result.Print();
            //await Task.Delay(8000);
            //result2.Print();

            //context.Set<Employee>().OfType<Manager>().AsNoTracking().ToList().Print();
            //var result = context.Set<Employee>().OfType<Manager>().AsNoTracking();
            //Console.WriteLine(result.ToQueryString());

            //var result = departments.AsNoTracking().SelectMany(dep => dep.Employees, (dep, e) => new
            //{
            //    fname = e.Fname,
            //    lname = e.Lname,
            //    salary = e.Salary,
            //    phoneNumber = e.PhoneNumber,
            //    name = dep.Name
            //})
            //    .Select(e => new { e.fname, e.lname, e.salary, e.phoneNumber, e.name });

            //Console.WriteLine(result.ToQueryString());
            //result.ToList().Print();

            //var result = employees.AsNoTracking()
            //    .Include(emp => emp.Department)
            //    .GroupBy(dep => dep.Department.Name);
            //foreach (var item in result.ToList())
            //{
            //    Console.WriteLine(item.Key);
            //    item.Print();
            //}

            //var result = employees.AsNoTracking()
            //    .Include(emp => emp.Department).ToList()
            //    .GroupBy(dep => dep.Department.Name)
            //    .OrderByDescending(emp => emp.Count())
            //    .FirstOrDefault();

            //Console.WriteLine(result?.Key);
            //result?.Print();
            //Console.WriteLine(result?.Count());

            //[Using View]
            //context.DataofEmployees.AsNoTracking().ToList().Print();
            //[Using Stored Procedure]
            //context.GetEmployees.FromSqlRaw($"Exec [Work].[GetEmployees] {"Adel"}").AsNoTracking().ToList().Print();
            //[Using Function]
            //Console.WriteLine(context.GetTotalEmployees());

            //var clients = new List<Client>
            //{
            //    new Client
            //    {
            //        Clientfname = "Adel" ,
            //        Clientlname = "Abas" ,
            //        ContactNumber = "01143254939",
            //        Projects = new List<Project>
            //        {
            //            new Project
            //            {
            //                Projectname = "Factory of Pasta"
            //                , TimeSlot = new TimeSlot
            //                {
            //                    Startdate = DateTime.Now,
            //                    Enddate = DateTime.Now.AddDays(10)
            //                }
            //            }
            //        }
            //    },

            //    new Client
            //    {
            //        Clientfname = "Emad" ,
            //        Clientlname = "Hamdy" ,
            //        ContactNumber = "01148754939",
            //        Projects = new List<Project>
            //        {
            //            new Project
            //            {
            //                Projectname = "Factory of Wood"
            //                , TimeSlot = new TimeSlot
            //                {
            //                    Startdate = DateTime.Now,
            //                    Enddate = DateTime.Now.AddDays(12)
            //                }
            //            }
            //        }
            //    }

            //};

            //context.Clients.AddRange(clients);
            //context.SaveChanges();

            //clients.Print();
            //projects.Print();

            //departments.Print();

            //var result = departments.SingleOrDefault(dep => dep.Name == "Sales");

            //result?.Employees.Add(new Employee
            //{
            //    Fname = "Kamal",
            //    Lname = "Omar",
            //    PhoneNumber = "01090990023",
            //    Email = "kamal.omar@gmail.com",
            //    Salary = 4500m
            //});

            //context.SaveChanges();

            //var result = projects.SingleOrDefault(pro => pro.Projectid == 2);
            //result.EmployeeProjects.Add(new EmployeeProject
            //{
            //    Employee = employees.AsNoTracking().ToList().FirstOrDefault(emp => emp.DepartmentId == 4),
            //});
            //context.SaveChanges();

            //context.DataofEmployees.AsNoTracking().ToList().Print();

            var client = new List<Client>
             {
                 new Client
                 {
                     Clientfname = "Mohamed",
                     Clientlname = "Ali",
                     ContactNumber = "01154938217",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "Construction Site",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(1),
                                 Enddate = DateTime.Now.AddDays(15)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Sara",
                     Clientlname = "Khaled",
                     ContactNumber = "01165829374",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "Marketing Campaign",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(2),
                                 Enddate = DateTime.Now.AddDays(20)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Hassan",
                     Clientlname = "Gamal",
                     ContactNumber = "01176948325",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "Tech Startup",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(3),
                                 Enddate = DateTime.Now.AddDays(25)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Nour",
                     Clientlname = "Maged",
                     ContactNumber = "01187459236",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "Real Estate Development",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(4),
                                 Enddate = DateTime.Now.AddDays(30)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Amina",
                     Clientlname = "Fathy",
                     ContactNumber = "01198567345",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "E-commerce Platform",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(5),
                                 Enddate = DateTime.Now.AddDays(12)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Omar",
                     Clientlname = "Shams",
                     ContactNumber = "01109678452",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "App Development",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(6),
                                 Enddate = DateTime.Now.AddDays(22)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Laila",
                     Clientlname = "Hassan",
                     ContactNumber = "01120789563",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "Consulting Services",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(7),
                                 Enddate = DateTime.Now.AddDays(18)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Samir",
                     Clientlname = "Elgohary",
                     ContactNumber = "01131897654",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "Education Program",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(8),
                                 Enddate = DateTime.Now.AddDays(14)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Mona",
                     Clientlname = "Nassar",
                     ContactNumber = "01142908765",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "Healthcare System",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(9),
                                 Enddate = DateTime.Now.AddDays(21)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Youssef",
                     Clientlname = "Farouk",
                     ContactNumber = "01154019876",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "Financial Analysis",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(10),
                                 Enddate = DateTime.Now.AddDays(28)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Reem",
                     Clientlname = "Nabil",
                     ContactNumber = "01165120987",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "HR Management",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(11),
                                 Enddate = DateTime.Now.AddDays(13)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Khaled",
                     Clientlname = "Sayed",
                     ContactNumber = "01176231456",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "Supply Chain",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(12),
                                 Enddate = DateTime.Now.AddDays(17)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Nadia",
                     Clientlname = "Eid",
                     ContactNumber = "01187342567",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "Product Launch",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(13),
                                 Enddate = DateTime.Now.AddDays(19)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Jamal",
                     Clientlname = "Fouad",
                     ContactNumber = "01198453678",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "Market Research",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(14),
                                 Enddate = DateTime.Now.AddDays(23)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Heba",
                     Clientlname = "Tarek",
                     ContactNumber = "01109564879",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "Software Upgrade",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(15),
                                 Enddate = DateTime.Now.AddDays(29)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Ibrahim",
                     Clientlname = "Hossam",
                     ContactNumber = "01120675980",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "Infrastructure",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(16),
                                 Enddate = DateTime.Now.AddDays(31)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Salma",
                     Clientlname = "Sherif",
                     ContactNumber = "01131768091",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "Event Management",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(17),
                                 Enddate = DateTime.Now.AddDays(26)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Khalil",
                     Clientlname = "Rashid",
                     ContactNumber = "01142879102",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "Digital Marketing",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(18),
                                 Enddate = DateTime.Now.AddDays(27)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Farida",
                     Clientlname = "Salah",
                     ContactNumber = "01153980213",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "Customer Support",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(19),
                                 Enddate = DateTime.Now.AddDays(24)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Rami",
                     Clientlname = "Hamed",
                     ContactNumber = "01164091324",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "Quality Assurance",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(20),
                                 Enddate = DateTime.Now.AddDays(25)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Nada",
                     Clientlname = "Moustafa",
                     ContactNumber = "01175102435",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "Risk Management",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(21),
                                 Enddate = DateTime.Now.AddDays(30)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Mazen",
                     Clientlname = "Kamel",
                     ContactNumber = "01186213546",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "Business Analysis",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(22),
                                 Enddate = DateTime.Now.AddDays(32)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Jihan",
                     Clientlname = "Zakaria",
                     ContactNumber = "01197324657",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "Logistics",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(23),
                                 Enddate = DateTime.Now.AddDays(29)
                             }
                         }
                     }
                 },
                 new Client
                 {
                     Clientfname = "Khaled",
                     Clientlname = "Youssef",
                     ContactNumber = "01108435768",
                     Projects = new List<Project>
                     {
                         new Project
                         {
                             Projectname = "Website Development",
                             TimeSlot = new TimeSlot
                             {
                                 Startdate = DateTime.Now.AddDays(24),
                                 Enddate = DateTime.Now.AddDays(28)
                             }
                         }
                     }
                 }
             };
            //clients.AddRange(client);
            //context.SaveChanges();


            //var result = projects.SingleOrDefault(pro => pro.Projectid == 26);
            //var result2 = employees.Include(emp => emp.Department).Where(emp => emp.Department.Name == "Credenza");
            //foreach (var item in result2)
            //{
            //    result.EmployeeProjects.Add(new EmployeeProject { Employee = item });
            //}
            //context.SaveChanges();

            //var cliens = clients.First();
            //clients.Remove(cliens);
            //context.SaveChanges();


            //clients.AsNoTracking().ToList().Print();
            //projects.AsNoTracking().ToList().Print();
            //employees.AsNoTracking().ToList().Print();
            //departments.AsNoTracking().ToList().Print();

            //var result = context.DataofEmployees;
            //result.Print();
            //Console.WriteLine(result.Count());

            //var addclient = new Client { Clintid = 15 };
            //context.Attach(addclient);
            //addclient.Clientlname = "Ahmed";
            //context.SaveChanges();

            //var employee = new Employee { Employeeid = 1 };
            //context.Attach(employee);
            //employee.Lname = "Hamed";
            //context.SaveChanges();

            employees.AsNoTracking().ToList().Print();


        }
    }
}
