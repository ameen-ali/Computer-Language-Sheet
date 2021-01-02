using System;

namespace Application37
{
    class StudentTest
    {
        static void Main(string[] args)
        {
            /* One Solution ... */
            Student std1 = new Student(/* all Parameters Write here ... */);

            /* Second Solution ... */
            Student std2 = new Student();
            std2.NumberOfObjects = 6;
            std2.FullName = null;
            std2.Course = null;
            std2.Subject = null;
            std2.University = null;
            std2.EMail = null;
            std2.PhoneNumber = null;

            std2.PrintData();
        }
    }
}
