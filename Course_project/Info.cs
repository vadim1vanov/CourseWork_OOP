using System;

namespace Course_project
{
    /// <summary>
    /// Класс хранящий id книги
    /// </summary>
    abstract class Info
    {
        public int BookID { get; set; }
    }
    
    /// <summary>
    /// Класс с информацией о книге
    /// </summary>
    class InfoBooks : Info, IComparable
    {
        /// <summary>
        /// свойство названия книги
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// свойство автора книги
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// свойство жанра книги
        /// </summary>
        public string Genre { get; set; }
        /// <summary>
        /// свойство количества страниц книги
        /// </summary>
        public int CountPages { get; set; }
        /// <summary>
        /// свойство года издания книги
        /// </summary>
        public int ProductionYear { get; set; }
        /// <summary>
        /// проверка id книги
        /// </summary>
        /// <param name="obj">объект, который проверяется</param>
        /// <returns>id</returns>
        public int CompareTo(object obj)
        {
            if (obj is InfoBooks book) return BookID.CompareTo(book.BookID);
            else throw new ArgumentException();
        }
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="title">название</param>
        /// <param name="author">автор</param>
        /// <param name="genre">жанр</param>
        /// <param name="countPages">количество страниц</param>
        /// <param name="productionYear">год издания</param>
        /// <param name="bookID">id книги</param>
        public InfoBooks(string title, string author, string genre, int countPages, int productionYear,  int bookID)
        {
            Title = title;
            Author = author;
            Genre = genre;
            CountPages = countPages;
            ProductionYear = productionYear;
            BookID = bookID;
        }
    }
    /// <summary>
    /// Класс с информацией о клиенте
    /// </summary>
    class InfoClients : Info
    {
        /// <summary>
        /// свойство фамилии
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// свойство имени
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// свойство даты выдачи книги
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// свойство крайнего срока сдачи
        /// </summary>
        public string Deadline { get; set; }
        /// <summary>
        /// свойство телефона
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// свойство статуса сдачи
        /// </summary>
        public string IsReturned {  get; set; }
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="firstName">фамилия</param>
        /// <param name="lastName">имя</param>
        /// <param name="date">дата выдачи</param>
        /// <param name="deadline">дата сдачи</param>
        /// <param name="phone">телефон</param>
        /// <param name="bookID">id книги</param>
        /// <param name="isReturned">статус сдачи</param>
        public InfoClients(string firstName, string lastName, string date, string deadline, string phone, int bookID, string isReturned)
        {
            FirstName = firstName;
            LastName = lastName;
            Date = date;
            Deadline = deadline;
            Phone = phone;
            BookID = bookID;
            IsReturned = isReturned;
        }
    }
}
