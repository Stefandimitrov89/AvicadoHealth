using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Menu
    {
        private readonly List<MenuItem> menuItems = new List<Main.MenuItem>();

        public Menu(List<MenuItem> menuItems)
        {
            this.menuItems = menuItems;
        }
        public List<MenuItem> MenuItems
        {
            get
            {
                return menuItems;
            }
        }

        public int PrintAndGetInput()
        {
            this.Print();
            int result = -1;
            do
            {
                result = (int)Console.ReadKey(true).KeyChar - '0'; // MAKE exception safe
                // TODO validate if int in menu
            } while (result < 0);

            return result;
        }

        public void Print()
        {
            foreach (var item in this.menuItems)
            {
                Console.WriteLine($"{item.Number}. {item.MenuText}");
            }
        }
    }
}
