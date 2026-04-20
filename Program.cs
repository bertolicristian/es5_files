using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Formatters;

namespace es5_files
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<string> lettura = new List<string>();
            List<string> critical = new List<string>();

            using (StreamReader sr = new StreamReader("log_sistema.txt"))
            {
                string riga = sr.ReadLine();

                while (riga != null)
                {
                    lettura.Add(riga);
                    riga = sr.ReadLine();
                }

                for (int i = 0; i < lettura.Count; i++)
                {
                    if (lettura[i].Contains("CRITICAL"))
                    {
                        critical.Add(lettura[i]);
                    }
                }

                for (int i = 0;i < critical.Count; i++)
                {
                    Console.WriteLine(critical[i]);
                }
            }
        }
    }
}
