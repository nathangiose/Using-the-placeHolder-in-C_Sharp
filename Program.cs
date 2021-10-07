using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_the_placeHolder_in_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //IEnumerable

            string myName = "Nathan";
            string mySurname = "Giose";
            int lowestResult = 60;
            int highestReslt = 100;
            string level = "NQF Level 5";
            string programTitle = "National Certificate: IT: Systems Support (PC Engineering)";
            string programCode = "2019_IT_FT_YR1_NC_SS5";
            int stdntNumber = 201817372;
            string college = "Damelin Cape Town Campus";
            string language = "Visual Basic, VB.Net, JavaScript, HTML5 & CSS3, Python";
            string learning = "C#, Java, 3js";
            var cntainer = " ";


            Console.Write("I am {0} {1}\n\n ", myName, mySurname );

            Console.ReadKey();

            Console.WriteLine("I completed a Higher Certificate at {0}. For reference, refer to the information provided \n{1} {4} \n{2} \nand my student number is {3} \n\n", college, programTitle, programCode, stdntNumber, level);

            Console.ReadKey();

            Console.WriteLine("With my lowest percentage being {0}% and the highest being 96.25% in the first semester, and my highest being {1} in the second sememster \n", lowestResult, highestReslt);

            Console.ReadKey();

            Console.WriteLine("| subject{0,7} | {0,7} | {0,7} | {0,7} | {0,7} | {0,7} | {0,7} |", cntainer);

            Console.ReadKey();

            Console.WriteLine("My Language Stack is " + language + " and I am currently learning " + learning);

            Console.ReadKey();

        }
    }
}
