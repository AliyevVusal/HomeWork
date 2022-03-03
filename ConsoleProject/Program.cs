using System;
using ConsoleProject.Models;
using System.Collections;


namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
           ILibraryManagerServic libraryManagerServic = new ILibraryManagerServic();

            do
            {
                string choicestr = Console.ReadLine();
                int choice;
                int.TryParse(choicestr, out choice);
                while (!int.TryParse(choicestr, out choice))
                {
                    choicestr = Console.ReadLine();
                }


                Console.WriteLine("1 - Kitab Elave Edin");
                Console.WriteLine("2 - Kitab Haqqinda Melumatlar");
                Console.WriteLine("3 - Kitab Axtarishi");
                Console.WriteLine("4 - Filter sistemi");

                switch (choice)
                {
                    case 1:
                        Add(libraryManagerServic);
                        break;

                    case 2:
                        ShowInfo(libraryManagerServic);
                        break;

                    case 3:
                        Search(libraryManagerServic);
                        break;

                    case 4:
                        FiFilter(libraryManagerServic);
                        break;
                }




            } while (true);



        }

        public static void Add(ILibraryManagerServic libraryManagerServic)
        {
            Console.WriteLine("Elave Olunacaq Kitabin  Adi");
            string nameStr = Console.ReadLine();
            while (string.IsNullOrEmpty(nameStr))
            {
                nameStr = Console.ReadLine();
            }
            Console.WriteLine("Elave Olunacaq Kitabin Muellif Adi");
            string authorStr = Console.ReadLine();
            while (string.IsNullOrEmpty(authorStr))
            {
                authorStr = Console.ReadLine();
            }
            Console.WriteLine("Elave Olunacaq Kitabin Vereq Sayi");
            string pageCountStr = Console.ReadLine();
            int pageCount;
            int.TryParse(pageCountStr,out pageCount);
            while (!int.TryParse(pageCountStr, out pageCount))
            {
                pageCountStr=Console.ReadLine();
            }
            Console.WriteLine("Elave Olunacaq Kitabin Janri");
            string generStr = Console.ReadLine();
            while (string.IsNullOrEmpty(generStr))
            {
                generStr = Console.ReadLine();
            }

            libraryManagerServic.Add(nameStr, authorStr, pageCount, generStr);
        }

        public static void ShowInfo(ILibraryManagerServic libraryManagerServic)
        {
            Console.WriteLine("Axtardiginiz Kitabin Adi");
            string nameStr = Console.ReadLine();
            while (string.IsNullOrEmpty(nameStr))
            {
                nameStr = Console.ReadLine();
            }

            libraryManagerServic.ShowInfo(nameStr);
        }

        public static void Search(ILibraryManagerServic libraryManagerServic)
        {
            Console.WriteLine("Axtarish Edin");
            string search = Console.ReadLine();
            while (string.IsNullOrEmpty(search))
            {
                search = Console.ReadLine();
            }
            
            libraryManagerServic.Search(search);

        }

        public static void FiFilter(ILibraryManagerServic libraryManagerServic)
        {
            Console.WriteLine("Janr Adin Ve Ya Muellif Adin Qeyd  Edinn");
            string search = Console.ReadLine();
            while (string.IsNullOrEmpty(search))
            {
                search = Console.ReadLine();
            }

            libraryManagerServic.Filter(search);
;
        }






    }
}
