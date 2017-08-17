using DomainLayer.Models;
using System.Collections.Generic;
using System;

namespace Repository
{
    internal static class StaticDatabase
    {
        internal static List<BookModel> _booksList = new List<BookModel>()
        {
            new BookModel() {  BookID=1, Name="Book1", AuthorName="Author1", Department="EEE", IsActive=true},
            new BookModel() {  BookID=2, Name="Book2", AuthorName="Author2", Department="Mec", IsActive=true },
            new BookModel() {  BookID=3, Name="Book3", AuthorName="Author3", Department="CSE", IsActive=false},
            new BookModel() {  BookID=4, Name="Book4", AuthorName="Author4", Department="ECM", IsActive=true },
            new BookModel() {  BookID=5, Name="Book5", AuthorName="Author1", Department="MEC" , IsActive=false  }
        };

        internal static List<UserModel> _usersList = new List<UserModel>()
        {
            new UserModel() {  UserID=1, Name="User1", Email="Author1", IsActive=true, Password="Pwd1", IsAdmin=true },
            new UserModel() {  UserID=2, Name="User2", Email="Author2", IsActive=true, Password="Pwd2"   },
            new UserModel() {  UserID=3, Name="User3", Email="Author3", IsActive=false, Password="Pwd3" },
            new UserModel() {  UserID=4, Name="User4", Email="Author4", IsActive=true, Password="Pwd4" },
            new UserModel() {  UserID=5, Name="User5", Email="Author5", IsActive=false, Password="Pwd5"  }
        };

        //internal static List<BookHistoryModel> _bookHistoryList = new List<BookHistoryModel>()
        //{
        //  new BookHistoryModel() { BookID=1,UserID=1,OperationPerofrmedAt= new DateTime(2016,05,01,06,23,31),ReturnedAt=new DateTime(2016,05,31,09,43,13),Remarks=" ",PerformedByID=1,Operation=" "},
        //  new BookHistoryModel() { BookID=2,UserID=2,OperationPerofrmedAt=new DateTime(2017,07,01,06,23,31),ReturnedAt=Convert.ToDateTime(null),Remarks=" ",PerformedByID=1,Operation=" "}

        //};
        internal static List<studentmodel> _studentList = new List<studentmodel>()
        {
            new studentmodel() { StudentId=1516, Name="Rakesh Varma Alluri", EmailId="rakesh.alluri@ggktech.com", NumberOfBooks=0, IsActive=true },
            new studentmodel() { StudentId=1512, Name="Prudhvi Kumar Jellu", EmailId="prudhvi.jellu@ggktech.com", NumberOfBooks=0, IsActive=true },
            new studentmodel() { StudentId=1518, Name="Sai Kiran Yeddula", EmailId="saikiran.yeddula@ggktech.com", NumberOfBooks=0, IsActive=true },
            new studentmodel() { StudentId=1517, Name="Pathan Niyaz Ahammed", EmailId="prudhvi.jellu@ggktech.com", NumberOfBooks=0, IsActive=true },
            new studentmodel() { StudentId=1506, Name="Bharat Chatakondu", EmailId="prudhvi.jellu@ggktech.com", NumberOfBooks=0, IsActive=true },
        };


        internal static List<BookHistoryModel> _bookHistoryList = new List<BookHistoryModel>()
        {

        };
      
    }
}
