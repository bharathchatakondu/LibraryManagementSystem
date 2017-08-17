using DomainLayer.Models;
using System.Collections.Generic;
using Repo = Repository.Library;
using System;
namespace BusinessLayer.Library
{
    internal class BookModule : IBookModule
    {
        Repo.IBookModule _bookObj;

        public BookModule()
        {
            _bookObj = Repository.RepoFactory.GetBookModuleObject();
        }

        public string AddBook(BookModel bookObj)
        {
            return _bookObj.AddBook(bookObj);
        }

        public IEnumerable<BookModel> displayallBooks(bool isIncludeDisabled = false)
        {
            return _bookObj.displayallBooks(isIncludeDisabled);
        }

        public string IssueBook(BookHistoryModel obj)
        {
            return _bookObj.IssueBook(obj);
        }

        public IEnumerable<BookHistoryModel> Isuebooks()
        {
            throw new NotImplementedException();
        }

        public string RemoveBook(int bookID)
        {
           return _bookObj.RemoveBook(bookID);
        }

        public void ReturnBook(int bookId, int userId)
        {

            _bookObj.ReturnBook(bookId, userId);
        }
        public string AddStudent(studentmodel studentDetails)
        {
            return _bookObj.AddStudent(studentDetails);
        }





    }
}

