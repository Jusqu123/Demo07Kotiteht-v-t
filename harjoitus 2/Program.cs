using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {


            string line = null;

            bool nro3;

            bool nro4;



            StreamWriter outputFile2 = new StreamWriter(@"d:\Int.txt");

            StreamWriter outputFile1 = new StreamWriter(@"d:\Float.txt");
        
            Console.Write("Anna Numero");
            line = Console.ReadLine();



            do
            {
                int nro;
                nro3 = int.TryParse(line, out nro);


                if (nro3 == true)
                {
                    outputFile1.WriteLine(nro);
                }


            } while (nro3 == false);




            do
            {


                float nro2;
                nro4 = float.TryParse(line, out nro2);


                if (nro4 == true)

                {
                    outputFile2.Write(nro2);
                }

            }
            while (nro4 == false);


        }
    }
}