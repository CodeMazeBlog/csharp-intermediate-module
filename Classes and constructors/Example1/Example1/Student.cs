using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class Student
    {
        private string _name;
        private string _lastName;

        public Student()
        {
            _name = string.Empty;
            _lastName = string.Empty;
        }

        public Student(string name, string lastName)
        {
            _name = name;
            _lastName = lastName;
        }

        public string GetFullName()
        {
            return _name + ' ' + _lastName;
        }
    }
}
