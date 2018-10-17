using NinjaDomain.Classes;
using NinjaDomain.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        public static object Ninja { get; private set; }

        static void Main(string[] args)
        {
            Database.SetInitializer(new NullDatabaseInitializer<NinjaContext>()); 
            InsertNinja();
            Console.Read();
        }

        private static void InsertNinja()
        {
            Ninja n = new Ninja
            {
                Name = "New Ninja",
                ClanId = 1,
                DateOfBirth = DateTime.Now,
                ServedInOniwaban = true
            };

            using(var db = new NinjaContext())
            {
                db.Database.Log = Console.WriteLine;
                db.Ninjas.Add(n);
                db.SaveChanges();
            }

        }
    }

   
}
