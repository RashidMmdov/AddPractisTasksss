using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika_HomeWork_Student
{
    class Student
    {
        public string FullName;
        public string GroupNo;
        public int Age;

        public Student(string fullname, string group, int age)
        {
            FullName = fullname;
            GroupNo = group;
            Age = age;
        }

        public static bool CheckGroupNo(string GroupNo)
        {
            bool Check = false;
            //Set ederken yoxlayacam ACII cod ile Ki Qrupun ilki Boyuk herif olsun.
            //Qalanlari ise reqem araliginda olsun...
            if (GroupNo.Length > 4 || GroupNo.Length < 4)
            {
                Check = false;
            }
            else
            {
                int changeType = (int)GroupNo[0];

                if (changeType >= 65 && changeType <= 90)
                {
                    for (int i = 1; i < GroupNo.Length; i++)
                    {
                        changeType = (int)GroupNo[i];
                        if (changeType >= 48 && changeType <= 57)
                        {
                            Check = true;
                        }
                        else
                        {
                            Check = false;
                            break;
                        }
                    }
                }
                else
                {
                    Check = false;
                }
            }
            return Check;
        }
        public static bool CheckFullName(string FullName)
        {
            bool Check = false;

            string[] strArr = FullName.Split();
            if (strArr.Length != 2)
            {
                Check = false;
            }
            else
            {
                Check = true;
            }
            return Check;
        }
    }
}
