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
    //Separa en dos clases distintas la clase Book y la clase Shelvebook 
    
      public class ShelveBook{
          public string LibrarySector { get ; set; }
          public string LibraryShelve { get ; set; }
          
          public ShelveBook(String sector, String shelve){
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
              
       }
          
      }
}
