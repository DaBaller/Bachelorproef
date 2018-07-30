using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testdatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Testclass test = new Testclass() { A = 2187 };

            TestClass2 test2 = new TestClass2() { Test = test }; 

            TestContext context = new TestContext(); 
            context.Tests2.Add(test2);
            context.SaveChanges();

            var query = from t in context.Tests2
                        orderby t.Id
                        select t;


            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            
            

        }

        public class TestContext : DbContext
        {
            public DbSet<Testclass> Tests { get; set; }
            public DbSet<TestClass2> Tests2 { get; set; }

            public TestContext() : base("BachelorProef1718")
            {

            }

        }

        public class Testclass
        {
            public int Id { get; set; }
            public int A { get; set; }

            public Testclass()
            {

            }


        }

        public class TestClass2
        {
            public int Id { get; set; }

            public virtual Testclass Test { get; set; }

            public TestClass2()
            {

            }

        }
    }
}
