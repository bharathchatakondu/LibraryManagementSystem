using DomainLayer;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Library
{
    internal class BookModule : IBookModule
    {
        public string AddBook(BookModel bookObj)
        {
            try
            {
                StaticDatabase._booksList.Add(bookObj);

                return StringLiterals.SuccesMsg;
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<BookModel> displayallBooks(bool isIncludeDisabled)
        {
            try
            {
                if (isIncludeDisabled)
                {
                    return StaticDatabase._booksList;
                }

                return StaticDatabase._booksList.Where(m => m.IsActive == true);
            }
            catch
            {
                throw;
            }
        }
        public IEnumerable<BookHistoryModel> Isuebooks( )
        {
            try
            {
                    return StaticDatabase._bookHistoryList;
 
            }
            
            catch
            {
                throw;
            }
        }

        public string IssueBook(BookHistoryModel obj)
        {
            try
            {
                if (StaticDatabase._bookHistoryList.Any(m => m.BookID == obj.BookID && m.UserID==obj.UserID && m.ReturnedAt==new DateTime(0001,01,01,00,00,00)))
                {
                    return StringLiterals.BookIsAssignedToUser;
                }

                StaticDatabase._bookHistoryList.Add(obj);
                return StringLiterals.SuccesMsg;
            }
            catch
            {
                throw;
            }
        }

        public string  RemoveBook(int bookID)
        {
          BookModel bookObj = StaticDatabase._booksList.Where(m => m.BookID == bookID).FirstOrDefault();
           bookObj.IsActive = false;
            return StringLiterals.RemoveBookSuccess;

          // add entry into history table
        }

        public void ReturnBook(int bookid,int userid)
        {
            // access the list, get that record , fill the returned at
             
          BookHistoryModel bookObj = StaticDatabase._bookHistoryList.Where(m => m.BookID == bookid && m.UserID==userid && m.ReturnedAt==new DateTime(0001,01,01,00,00,00)).FirstOrDefault();
          bookObj.ReturnedAt=DateTime.Now; 
          
         }
        public string Addstudent(studentmodel studentDetails)
        {
            try
            {
                StaticDatabase._studentList.Add(studentDetails);
                return StringLiterals.SuccesMsg;

            }
            catch
            {
                throw;
            }
        }


    }



}



