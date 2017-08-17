using DomainLayer.Models;
using System.Collections.Generic;

namespace BusinessLayer.Library
{
    public interface IBookModule
    {
        string IssueBook(BookHistoryModel obj);

        void ReturnBook(int Bookid, int Userid);

        string AddBook(BookModel bookObj);

        string RemoveBook(int bookID);
        string Addstudent(studentmodel studentDetails);
      

        IEnumerable<BookModel> displayallBooks(bool isIncludeDisabled);
        IEnumerable<BookHistoryModel> Isuebooks();



    }

}
