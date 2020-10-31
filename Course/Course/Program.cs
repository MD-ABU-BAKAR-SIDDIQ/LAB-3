using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class course
    {
        private String cname;
        private String ccode;
        private int ccredit;
        public void insert(String CName, String CCode,int CCredit)
        {

            cname = CName;
            ccode = CCode;
            ccredit = CCredit;
        }


        public void ShowCourseInfo()
        {
            Console.WriteLine(cname + " " + ccode + " " + ccredit + " ");
        }
    }

    class tesCourse
    {

        static void Main(string[] args)
        {
            course c1 = new course();
            course c2 = new course();
            c1.insert("oop2", "36813",3);
            c2.insert("oop1", "36713",3);
            c1.ShowCourseInfo();
            c2.ShowCourseInfo();
        }
    }
}
