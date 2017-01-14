using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Person
    {
        // Слагам пропъртита за имената - Мартин
        public string _FirstName { get; protected set; }
        public string _LastName { get; protected set; }

        public Person(string firstname, string lastname)
        {
            this._FirstName = firstname;
            this._LastName = lastname;
        }
    }
}
