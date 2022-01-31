using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROGCRAFT_Demo
{
    public class Person
    {

        //field
        private string name;

        //property
        public string Name;

        //C# properties have some method qualities
        public List<Item> Inventory
        {
            get => default;
           
        }
    }
}