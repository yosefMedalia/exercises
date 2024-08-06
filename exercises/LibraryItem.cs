using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class LibraryItem
    {

        protected internal string Title {  get; set; }


        public string GateTitle()
        {
            return Title;
        }

    }
    public class Book : LibraryItem 
    { 
        public Book(string title)
        {
            GateTitle();
        }
    
    
    }
    
}
