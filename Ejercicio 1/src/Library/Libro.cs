using System;

namespace SRP
{

    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
            
        }


    }
    
      public class ShelveBook{
          public string LibrarySector { get ; set; }
          public string LibraryShelve { get ; set; }
          
          public (String sector, String shelve){
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
              
       }
          
      }
}
