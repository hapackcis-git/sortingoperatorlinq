using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq3
{
    internal class MultipleSorting
    {
        public static void Main(String[] args)
        {
            List<student> students=new List<student>()
            {
                new student(){Id=1,Name="sdfds",Age=22},
                new student(){Id=2,Name="swerewr",Age=30},
                new student(){Id=3,Name="nknkkk",Age=29}
            }; 
            var qs=(from s in students
                    orderby s.Name,s.Age    
                    select s)
                    .ToList();  
            foreach(var s in qs)
            {
                Console.WriteLine("Name:{0},Age{1}",s.Name,s.Age);
            }
           
        }
    }
}
