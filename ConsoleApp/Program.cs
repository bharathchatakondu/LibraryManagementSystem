using BusinessLayer;
using BusinessLayer.Auth;
using DomainLayer.Models;
using BusinessLayer.Library;
using System;
using Repository;
using System.Collections.Generic;
using DomainLayer;
namespace ConsoleApp
{
    class Program
    {
        public int choice;
        static void Main(string[] args)
        {

            Console.WriteLine("welcome to library");
            IAuthentication obj = BALFactory.GetAuthenticationObject();
            Console.WriteLine(StringLiterals.Enteremail);
            string email = Console.ReadLine();
            Console.WriteLine(StringLiterals.Password);
             Console.WriteLine(StringLiterals.PerformedId);
            string password = Console.ReadLine();
             string Bookresult;

            bool result = obj.Authenticate(new AuthModel
            {

                Email = email,
                Password = password
            });

            if (result == true)
            {
                Program ob = new Program();
                do
                {

                    Console.WriteLine("----- main menu ----");
                    Console.WriteLine("1.Add Book \n 2. Issue Book \n 3.Return Book \n 4.History Book Details\n 5.ListBooks\n 6.RemoveBook\n 7.Display all books 8.logout");

                    Console.WriteLine("Enter your choice:");
                    ob.choice = int.Parse(Console.ReadLine());
                    switch (ob.choice)
                    {
                        case 1:
                            AddBook();
                            break;
                        case 2:
                            IssueBook();
                            break;
                        case 3:
                            ReturnBook();
                            break;
                        case 4:
                            HistoryBook();
                            break;

                        case 5:
                            RemoveBook();
                            break;
                        case 6:
                            displayallBooks();
                            break;
                        case 7:
                            Addstudent();
                            break;


                        default:
                            Console.WriteLine("wrong Choice");
                            break;
                    }
                    Console.ReadLine();

                } while (ob.choice != 7);
             }
        }
        public static void AddBook()
        {
            IBookModule IBookObj = BALFactory.GetBookModuleObject();
            Console.WriteLine(StringLiterals.BookId);
            int AddBookID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(StringLiterals.BookName);
            String BookName = Console.ReadLine();
            Console.WriteLine(StringLiterals.AuthorName);
            String AuthorName = Console.ReadLine();
            Console.WriteLine(StringLiterals.DepartmentName);
            String DepartmentName = Console.ReadLine();

            string Bookresult = IBookObj.AddBook(new BookModel
            {
                BookID = AddBookID,
                Name = BookName,
                AuthorName = AuthorName,
                Department = DepartmentName,
                IsActive = true
            });
            Console.WriteLine("{0}", Bookresult);

        }
        public static void IssueBook()
        {
            IBookModule IBookObj = BALFactory.GetBookModuleObject();
            Console.WriteLine(StringLiterals.BookId);
            int BookID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(StringLiterals.UserId);
            int UserID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(StringLiterals.Remarks);
            String remarks = Console.ReadLine();
            Console.WriteLine(StringLiterals.PerformedId);
            int Performedid = Convert.ToInt32(Console.ReadLine());
            string Issueresult = IBookObj.IssueBook(new BookHistoryModel
            {
                BookID = BookID,
                UserID = UserID,
                OperationPerofrmedAt = DateTime.Now,
                ReturnedAt = Convert.ToDateTime(null),
                Remarks = remarks,
                PerformedByID = Performedid,
                Operation = Console.ReadLine()


            });
            Console.WriteLine("{0}", Issueresult);
        }
        public static void ReturnBook()
        {
            IBookModule IBookObj = BALFactory.GetBookModuleObject();

            Console.WriteLine(StringLiterals.BookId);
            int BookId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(StringLiterals.UserId);
            int UserId = Convert.ToInt32(Console.ReadLine());
            IBookObj.ReturnBook(BookId, UserId);
            Console.WriteLine(StringLiterals.SucessReturn);
        }
        public static void HistoryBook()
        {
            IBookModule IBookObj = BALFactory.GetBookModuleObject();
            IEnumerable<BookHistoryModel> _bookHistoryList = IBookObj.Isuebooks();
            foreach (BookHistoryModel v in _bookHistoryList)
            {
                Console.WriteLine("BookID:{0}\nUserID:{1}\nOperationPerofrmedAt:{2}\nReturnedAt:{3}\nRemarks:{4}\nPerformedByI:{5} ", v.BookID, v.UserID, v.OperationPerofrmedAt, v.ReturnedAt, v.Remarks, v.PerformedByID);
            }

        }
       
        
        public static void RemoveBook()
        {
            IBookModule IBookObj = BALFactory.GetBookModuleObject();
            Console.WriteLine(StringLiterals.BookId);
            int BookID = Convert.ToInt32(Console.ReadLine());

            string Bookresult =IBookObj.RemoveBook(BookID);
         
            Console.WriteLine(Bookresult);
        }
        public static void displayallBooks()
        {
            IBookModule IBookObj = BALFactory.GetBookModuleObject();
            {
                Console.Write("Disply all available books both Active and Inactive \n 1. Yes \n 2. No \n Option : ");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    var allBooks = IBookObj.displayallBooks(true);
                    foreach (var item in allBooks)
                    {
                        Console.WriteLine(" Book Id : {0}, Name : {1},  Written by {2}, ({3}), IsActive : {4}", item.BookID, item.Name, item.AuthorName, item.Department, item.IsActive);

                    }
                }
                else if (choice == "2")
                {
                    var allBooks = IBookObj.displayallBooks(false);
                    foreach (var item in allBooks)
                    {
                        Console.WriteLine(" Book Id : {0}, Name : {1},  Written by {2}, ({3}), IsActive : {4}", item.BookID, item.Name, item.AuthorName, item.Department, item.IsActive);

                    }
                }
            }
        }
                public static void Addstudent()
              {
            IBookModule IBookObj = BALFactory.GetBookModuleObject();
            Console.WriteLine(StringLiterals.Details);

            Console.Write( StringLiterals.StudentId);
           int  StudentId = Convert.ToInt32(Console.ReadLine());
            Console.Write( StringLiterals.StudentName);
            string name = Console.ReadLine();
            Console.Write("Email : ");
            string emailId = Console.ReadLine();
            Console.WriteLine(BookModuleObject.AddStudent(new studentmodel() { StudentId = StudentId, Name = name, EmailId = emailId, NumberOfBooks = 0, IsActive = true }));

        }

    }
               
 }
        
        
    
            
     
    

