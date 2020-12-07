using EmployeeServer.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeServer.Context
{
    public class EmployeeContext : DbContext
    {

        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
            /*
             * Both EmployeeContext and DbContext have a constructor. The next statement is according to this situation:
             * In this case, both the base class and derived class has their own constructors, so the process is complicated 
             * because the constructors of both classes must be executed. 
             * To overcome this situation C# provide a keyword known as a base keyword. With the help of base keyword, 
             * the derived class (EmployeeContext) can call the constructor which is defined in its base class (DbContext).
             * source: https://www.geeksforgeeks.org/c-sharp-inheritance-in-constructors/
             * 
             * */


        }

        public DbSet<Employee> Employee { get; set; }
    }
}
