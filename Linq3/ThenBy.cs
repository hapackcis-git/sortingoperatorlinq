using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq3
{
    internal class ThenBy
    {
        public static void Main(String[] args)
        {
            List<student> students = new List<student>()
            {

                new student(){Id = 1, Name ="amit",Age =20},
                new student(){Id = 2,Name ="jj",Age=20},
                new student(){Id = 3,Name="dds",Age=32},
            };
            var ms=students.OrderBy(x => x.Name).ThenBy(x=>x.Age).ToList();
            foreach(var item in ms)
            {
                Console.Write("Name:{0},Age{1}",item.Name,item.Age);

            }
        }

    }
}
