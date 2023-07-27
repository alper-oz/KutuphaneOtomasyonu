using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Model
{
    public class Book
    {
        public int BOOK_ID { get; set; }
        public string Book_Name { get; set; }
        public string Book_Writer { get; set; }
        public string Language { get; set; }
        public string Publisher { get; set; }
        public string Type { get; set; }
        public int Piece { get; set; }
        public int Page_Number { get; set; }
        public int Publish_Year { get; set; }

        public Book()
        {

        }
        public Book(int book_id, string book_name, string book_writer, string language, string publisher, string type, int page_number, int publish_year)
        {
            BOOK_ID = book_id;
            Book_Name = book_name;
            Book_Writer = book_writer;
            Language = language;
            Publisher = publisher;
            Type = type;
            Page_Number = page_number;
            Publish_Year = publish_year;
        }
        public int getBOOK_ID(int book_id)
        {
            return BOOK_ID;
        }
        public string getBook_Name(string book_name)
        {
            return Book_Name;
        }
        public string getBook_Writer(string book_writer)
        { 
            return Book_Writer; 
        }
        public string getLanguage(string language)
        {
            return Language;
        }
        public string getPublisher(string publisher)
        {
            return Publisher;
        }
        public string getType(string type)
        {
            return Type;
        }
        public int getPage_Number(int page_number)
        {
            return Page_Number;
        }
        public int getPublish_Year(int publish_year)
        {
            return Publish_Year;
        }
    }
}
