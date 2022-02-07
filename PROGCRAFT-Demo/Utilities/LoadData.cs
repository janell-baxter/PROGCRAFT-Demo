using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace PROGCRAFT_Demo.Utilities
{
    class LoadData
    {
        //public static string LoadTextFromFile(string path)
        //{
        //    return File.ReadAllText(path);
        //}

        public static string LoadTextFromFile(string path) => File.ReadAllText(path);
        public static string[] LoadTextLinesFromFile(string path)
        {
            return File.ReadAllLines(path);
        }
        public static void AddItemsIntoInventory(Person d)
        {
            string[] lines = LoadTextLinesFromFile("../../data/ShopItems.txt");

            foreach (string str in lines)
            {
                string[] subs = str.Split('~');
                d.Inventory.Add(new Item()
                {
                    Name = subs[0],
                    Quantity = float.Parse(subs[1]),
                    Price = float.Parse(subs[2]),
                    Description = subs[3]
                });
            }
        }
        public static List<Item> CreateItemsFromTextFile(string path)
        {
            //temp list of items
            List<Item> items = new List<Item>();

            foreach (string s in File.ReadAllLines(path))
            {
                string[] subs = s.Split('~');
                Item i = new Item();
                i.Name = subs[1];
                i.Amount = float.Parse(subs[0]);
                items.Add(i);
            }

            return items;
        }

    }

}
