using System;

namespace Student
{
    public class Student
    {
        private string strName;
        private int iMark;
        public Student()
        {
            strName = "";
            iMark = 0;
        }
        public Student (String strName, int iMARK)
        {
            this.strName = strName;
            this.iMark = iMark;
        }
        public Student(string strName)
        {
            this.strName = strName;
            iMark = 0;
        }
        public Student(int iMARK)
        {
            this.iMark = iMark;
            strName = "";            
        }
        public override string ToString()
        {
            return "Name is " + strName + " and mark is " + iMark;
        }
    }

}
