using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inf2c;

namespace inf2cConsole
{
    class CircularyTest
    {
        public CircularyTest()
        {
            // create linked list
            CircularyLinkedList<string> names = new CircularyLinkedList<string>();
 
            names.InsertFirst("Piet");
            // create values for the list
            names.Insert("Henk", "Piet");
            names.Insert("Kees", "Henk");
  
            names.Insert("Geert", "Piet");
            names.PrintList();
  
            //search for elements
            Console.WriteLine("[CircularyLinkedList] Zoek naar element 0 : " + names.Search(0).Element);
            Console.WriteLine("[CircularyLinkedList] Zoek naar element 1 : " + names.Search(1).Element);
            Console.WriteLine("[CircularyLinkedList] Zoek naar element 7 : " + names.Search(7).Element);
         
  
      
 

            Console.ReadLine();
               
        }       
     }

    }

