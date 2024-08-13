using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeee
{
    public class Employer
    {
        private double salary;
        private string empNumber, jobTitle, name, surname;

        public static Employer operator +(Employer emp1, Employer emp2)
        {
            Employer emp3 = new Employer();
            emp3.jobTitle = emp1.jobTitle;
            emp3.name = emp1.name;
            emp3.surname = emp1.surname;
            emp3.empNumber = emp1.empNumber;
            emp3.salary = emp1.salary + emp2.salary;

            return emp3; 
        }
        public static Employer operator +(Employer emp1, int i)
        {
            Employer emp3 = new Employer();
            emp3.jobTitle = emp1.jobTitle;
            emp3.name = emp1.name;
            emp3.surname = emp1.surname;
            emp3.empNumber = emp1.empNumber;
            emp3.salary = emp1.salary + i;

            return emp3;
        }
        public static Employer operator -(Employer emp1, Employer emp2)
        {
            Employer emp3 = new Employer();
            emp3.jobTitle = emp1.jobTitle;
            emp3.name = emp1.name;
            emp3.surname = emp1.surname;
            emp3.empNumber = emp1.empNumber;
            emp3.salary = emp1.salary - emp2.salary;

            return emp3;
        }
        public static Employer operator -(Employer emp1, int i) //Decreases the salary by how much
        {
            Employer emp3 = new Employer();
            emp3.jobTitle = emp1.jobTitle;
            emp3.name = emp1.name;
            emp3.surname = emp1.surname;
            emp3.empNumber = emp1.empNumber;
            emp3.salary = emp1.salary - i;

            return emp3;
        }

        public Employer(double salary, string empNumber, string jobTitle, string name, string surname)
        {
            this.salary = salary;
            this.empNumber = empNumber;
            this.jobTitle = jobTitle;
            this.name = name;
            this.surname = surname;
        }
        public Employer()
        {
            this.salary = 0;
            this.empNumber = "";
            this.jobTitle = "";
            this.name = "";
            this.surname = "";
        }
        public double Salary
        {
            get
            {
                return Salary;
            }
            set
            {
                this.salary = value; 
            }
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return this.empNumber;
                }
                else if (index == 1)
                {
                    return this.jobTitle;
                }
                else if (index == 2)
                {
                    return this.name;
                }
                else if (index == 3)
                {
                    return this.surname;
                }
                else if (index == 4)
                {
                    return this.salary;
                }
                return null;
            }
            set
            {
                if (index == 0)
                {
                    this.empNumber = (string)value; //forcimng the program to know that the datatype is that of a string because it recives an object and doesnt know what it is
                }
                else if (index == 1)
                {
                    this.jobTitle = (string)value;
                }
                else if (index == 2)
                {
                    this.name = (string)value;
                }
                else if (index == 3)
                {
                    this.surname = (string)value;
                }
                else if (index == 4)
                {
                    this.salary = (double)value;
                }
            }
        }

            public object this[string attrName]
            { 
                get
                {
                    if(attrName.ToLower().Equals("empNumber"))
                    {
                        return this.empNumber;
                    }
                    else if (attrName.ToLower().Equals("jobTitle"))
                    {
                        return this.jobTitle;
                    }
                    else if (attrName.ToLower().Equals("name"))
                    {
                        return this.name;
                    }
                    else if (attrName.ToLower().Equals("surname"))
                    {
                        return this.surname;
                    }
                    else if (attrName.ToLower().Equals("salary"))
                    {
                        return this.salary;
                    }
                    return null;    
                }
                set
                {
                    if (attrName.ToLower().Equals("empNumber"))
                    {
                        this.empNumber = (string)value; ;
                    }
                    else if (attrName.ToLower().Equals("jobTitle"))
                    {
                        this.jobTitle = (string)value; ;
                    }
                    else if (attrName.ToLower().Equals("name"))
                    {
                        this.name = (string)value;
                }
                    else if (attrName.ToLower().Equals("surname"))
                    {
                        this.surname = (string)value;
                }
                    else if (attrName.ToLower().Equals("salary"))
                    {
                        this.salary = (double)value;
                    }
                }
            }




    }
}
