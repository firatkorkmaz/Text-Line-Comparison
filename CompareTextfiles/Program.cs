/* Checking Which Lines in One Text File are Not Found in any Line of Another Text File */

using System;
using System.IO;

namespace CompareTextfiles
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Your Input Files:");
            
        FirstFile:
            Console.Write("\nCheck Lines of File: ");
            string checklist = Console.ReadLine();
            if (!File.Exists(checklist))
            {
                Console.WriteLine($"{checklist} does Not Exist!");
                goto FirstFile;
            }

        SecondFile:
            Console.Write("\nCheck Lines in File: ");
            string mainlist = Console.ReadLine();
            if (!File.Exists(mainlist))
            {
                Console.WriteLine($"{mainlist} does Not Exist!");
                goto SecondFile;
            }
            
            string newfilename = checklist.Split('.')[0] + "_." + checklist.Split('.')[1];
            int count = 0;

            Console.WriteLine($"\nLines from \"{checklist}\" Not Found in \"{mainlist}\":");
            Console.WriteLine("==========\n");
            using (var sw = new StreamWriter(newfilename))
            {
                bool check;
                foreach (string contained in File.ReadLines(checklist))
                {
                    check = false;
                    foreach (string contains in File.ReadLines(mainlist))
                    {
                        if (contains.Contains(contained))
                        {
                            check = true;
                            break;
                        }
                    }

                    if (check == false)
                    {
                        count++;
                        Console.WriteLine(contained);
                        sw.WriteLine(contained);
                    }

                }

            }


            Console.WriteLine("\n\n----------");
            Console.WriteLine($"Written to: \"{newfilename}\"");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
            return;
        }
    }
}
