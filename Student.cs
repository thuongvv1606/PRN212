using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot1
{
    internal class Student
    {
        public string FullName { get; set; }
        public DateOnly Dob { get; set; }
        public string Gender { get; set; }

        public Student()
        {
        }
        
        public Student(string fullName, DateOnly dob, string gender)
        {
            FullName = fullName;
            Dob = dob;
            Gender = gender;
        }

        public void input()
        {
            Console.WriteLine("Input Fullname: ");
            FullName = Console.ReadLine();
            Console.WriteLine("Input Brithdate:");
            Dob = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Input age: ");
            Gender = Console.ReadLine();

        }
        public void display() {
            Console.WriteLine($"FullName: {FullName}, Dob: {Dob}, Gender: {Gender}");
        }



    }
}
