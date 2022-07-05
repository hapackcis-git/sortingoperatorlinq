
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq3
{
    //Linq Sorting Operators:OrderBy & OrderByDescending
    /*
     * A sorting operator arranges the elements of the collection in 
     *  ascending or descending order.LINQ includes following sorting operators.
     *  There are five sorting operators in c#
     *  1.OrderBy
     *  2.OrderByDescending
     *  3.ThenBy
     *  4.ThenByDescending
     *  5.Reverse
     *  
     *  OrderBy:- Sorts the elements in the collection based on specified fields in ascending or descending order.
     *  OrderByDescending:- Sorts the collection based on specified fields in descending order.Obly valid in method syntax.
     *  ThenBy:- Only valid in method syntax.Used for second level sorting in descending order
     *  ThenByDescending:-Only valid in method syntax.Used for second level sorting in descending order.
     *  Reverse:- Only valid in method syntax.Sorts the collection in reverse order.
     *  
     *  
     *  
     *  
     *  
     */
    internal class Program

    {
        static void Main(string[] args)
        {
            List<student> students = new List<student>()
            {

                new student(){Id = 1, Name ="amit",Age =20},
                new student(){Id = 2,Name ="jj",Age=20},
                new student(){Id = 3,Name="dds",Age=32},
            };

            var qs = (from s in students
                      orderby s.Id
                      select s);
            foreach(var item in qs)
            {
                Console.WriteLine(item.Name);
            }
            var qs1=(from s in students
                     orderby s.Name descending
                     select s); 
        foreach(var s in qs1)
            {
                Console.WriteLine(s.Name);
            }

        }
    }
    public class student
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Age { get; set; }
    }
}
