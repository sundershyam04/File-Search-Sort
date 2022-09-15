using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sort_Search_from_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {


           
    
            //Console.WriteLine("------Print Splitted Contents from file------");
            //foreach (var item in Contents)
            //{
            //    Console.WriteLine(item + '\n');
            //}

            Console.WriteLine("-------DSA PROJECT-----------");

            string p = "C:\\Users\\SHYAM SUNDER\\Desktop\\SL_projects\\Practice projects\\Project 2 - DSA\\data.txt";



            string[] cont=null;

            Console.WriteLine("---- <READ >-------");
            FileStream fs = new FileStream(p, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            var con = sr.ReadLine().Split('|');

            cont = con;

            foreach (var item in con)
            {
                Console.WriteLine(item);
            }

            fs.Close();
            sr.Close();

            Console.WriteLine("Menu\n1.Searching\n2.Sorting");
            Console.WriteLine("Enter choice :") ;
            int choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    Search(p, cont);
                    break;
                case 2:
                    Sorts(p, cont);
                    break;
               
                default:
                    break;
            }

        }

           

        private static void Search(string p, string[] cont)
        {
            Console.WriteLine("Enter student name to search :");
            string studname=Console.ReadLine();
            bool status = false;
            foreach (var item in cont)
            {
                if(item.Split(',')[0] == studname)
                {
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine("Student FOUND");

                    Console.WriteLine($"NAME    :{item.Split(',')[0]}");
                    Console.WriteLine($"CLASS   :{item.Split(',')[1]}");
                    Console.ForegroundColor = ConsoleColor.White;
                    status = true;
                }

            }
            if(status==false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Student NOT FOUND");
                Console.ForegroundColor = ConsoleColor.White;

            }

        }

        private static void Sorts(string p, string[] cont) 
        
        {
            Console.WriteLine("< SORTED STUDENT DETAILS >");

            List<string> studlist = new List<string>(cont);

            studlist.Sort( (a,b) => a.Split(',')[0].CompareTo(b.Split(',')[0]));  //comp based on name


            foreach (var item in studlist)
            {
                Console.WriteLine(item);
            }
        
        
        
        }
        }



    }

