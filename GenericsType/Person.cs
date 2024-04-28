using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsType
{
    internal class Person
    {
        private static int _idCounter = 1;

        public int Id { get; }
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }

        public Person(string name, string surname, int age)
        {
            Id = _idCounter++;
            Name = name;
            Surname = surname;
            Age = age;
        }
    }

  

}

