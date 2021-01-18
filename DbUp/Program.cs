using Microsoft.EntityFrameworkCore;
using Persistence;

namespace DbUp
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DatabaseContext();
            context.Database.EnsureCreated();
            context.Database.Migrate();
        }
    }
}
