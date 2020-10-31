using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class student
    {
        private String name;
        private String id;
        private String department;
        private float cgpa;
        public void insert(String Name, String i, String d, float c)
        {
            
            name = Name;
            id = i;
            department = d;
            cgpa = c;
        }


        public void display()
        {
            Console.WriteLine(name + " " + id + " " + department + " " + cgpa + " ");
        }
    }

    class testStudent { 
    
        static void Main(string[] args)
        {
            student s1 = new student();
            student s2 = new student();
            s1.insert("Siddiq", "36813", "cse", 3.68f);
           s2.insert("Siddiq", "36813", "cse", 3.68f);
            s1.display();
            s2.display();
        }
    }
}

