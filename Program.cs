using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        public static void menuSelector()
        {
            Console.WriteLine();
            Console.WriteLine(" 1_ Input users infos");
            Console.WriteLine(" 2_ Input books infos");
            Console.WriteLine(" 3_ Show users infos");
            Console.WriteLine(" 4_ Show books infos");
            Console.WriteLine(" 5_ Search in books by subject");
            Console.WriteLine(" 6_ Edit user infos");
            Console.WriteLine(" 7_ Exit");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Receive books number
            Console.Write("enter books number: ");
            int booksNumber = int.Parse(Console.ReadLine());

            // Receive users number
            Console.Write("enter users number: ");
            int usersNumber = int.Parse(Console.ReadLine());

            // Definition array for each lists
            // books list
            string[] booksTitleList = new string[booksNumber];
            string[] booksSubjectList = new string[booksNumber];
            // users list
            string[] usersLastNameList = new string[usersNumber];
            string[] usersFirstNameList = new string[usersNumber];


            // Select menu
            menuSelector();
            Console.Write("select an option: ");
            int selectedValue = int.Parse(Console.ReadLine());

            while (selectedValue != 7)
            {
                switch (selectedValue)
                {
                    // handle input users infos
                    case 1:
                        Console.Clear();
                        for (int i = 0; i < usersNumber; i++)
                        {
                            Console.Write("enter user {0} first name: ", i + 1);
                            usersFirstNameList[i] = Console.ReadLine();

                            Console.Write("enter user {0} last name: ", i + 1);
                            usersLastNameList[i] = Console.ReadLine();

                            Console.WriteLine();
                        }
                        Console.Clear();
                        break;

                    // handle input books infos
                    case 2:
                        Console.Clear();
                        for (int i = 0; i < booksNumber; i++)
                        {
                            Console.Write("enter book {0} subject: ", i + 1);
                            booksSubjectList[i] = Console.ReadLine();

                            Console.Write("enter book {0} title: ", i + 1);
                            booksTitleList[i] = Console.ReadLine();

                            Console.WriteLine();
                        }
                        Console.Clear();
                        break;

                    // handle show users list
                    case 3:
                        Console.Clear();
                        for (int i = 0; i < usersNumber; i++)
                            Console.WriteLine("{0} {1}", usersFirstNameList[i], usersLastNameList[i]);
                        break;

                    // handle show books list
                    case 4:
                        Console.Clear();
                        for (int i = 0; i < booksNumber; i++) 
                            Console.WriteLine("{0} {1}", booksTitleList[i], booksSubjectList[i]);
                        break;
                    // handle search in books by subject
                    case 5:
                        Console.Clear();
                        Console.Write("enter book subject: ");
                        string searchedBookSubject = Console.ReadLine();
                        Console.Clear();
                        for (int i = 0; i < booksNumber; i++)
                            if (booksSubjectList[i] == searchedBookSubject) 
                                Console.WriteLine(booksTitleList[i]);
                        break;
                    // handle edit user
                    case 6:
                        Console.Clear();
                        Console.Write("enter user membership code: ");
                        int membershipCode = int.Parse(Console.ReadLine());

                        Console.WriteLine();

                        Console.Write("enter new first name: ");
                        usersFirstNameList[membershipCode] = Console.ReadLine();

                        Console.Write("enter new last name: ");
                        usersLastNameList[membershipCode] = Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("error!");
                        break;
                }
                menuSelector();
                Console.Write("select an option: ");
                selectedValue = int.Parse(Console.ReadLine());
            }
        }
    }
}
