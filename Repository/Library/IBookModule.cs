using DomainLayer.Models;
using System.Collections.Generic;

namespace Repository.Library
{
    public interface IBookModule
    {
        string IssueBook(BookHistoryModel obj);

         void ReturnBook(int bookid,int userid);

        string AddBook(BookModel bookObj);

          string  RemoveBook(int bookID);


        string AddStudent(studentmodel studentDetails);

        IEnumerable<BookModel> displayallBooks(bool isIncludeDisabled);
        IEnumerable<BookHistoryModel> Isuebooks();
    }
}
