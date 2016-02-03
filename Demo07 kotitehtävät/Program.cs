using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tehtävä3
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Show> tv = new List<Show>();


            tv.Add(new Show { Sarja = "Arrow", Aika = "42 min", Kanava = "Sub", Jakso = "Count Vertigo" });
            tv.Add(new Show { Sarja = "Frendit", Aika = "22 min", Kanava = "viaplay", Jakso = "S10E9" });
            tv.Add(new Show { Sarja = "Uusi Paiva", Aika = "30 min", Kanava = "TV2", Jakso = "Jakso 324" });
            tv.Add(new Show { Sarja = "The Simpsons", Aika = "20min", Kanava = "Sub", Jakso = "Treehouse of horror XXX" });



            System.IO.StreamWriter outputFile = null;
            try
            {
                outputFile = new System.IO.StreamWriter(@"C:\test.txt");
                outputFile.WriteLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {

                if (outputFile != null)
                {
                    outputFile.Close();
                }

            }
        }
    }
}

