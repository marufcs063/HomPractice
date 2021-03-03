using System;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PersonContext pc = new PersonContext())
            {
                pc.Perosns.AddRange
                    (
                     new Person { Name = "Isaac Newton" },
                     new Person { Name = "C.F Gauss" },
                     new Person { Name = "Albert Einstein"}
                     );
                     


                    
                pc.SaveChanges();
            }
        }
    }
}
