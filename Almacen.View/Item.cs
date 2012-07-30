using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Almacen.View
{
    public class Item
    {
        public string Name {get; set;}
        public int Value{get; set;}
 
        public Item(string name, int value)
        {
            Name = name;
            Value = value;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
