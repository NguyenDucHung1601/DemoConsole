using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class Student
    {
        private int id;
        private string name;

        public Student() { }

        public Student(int _id, string _name)
        {
            this.id = _id;
            this.name = _name;
        }
    }
}
