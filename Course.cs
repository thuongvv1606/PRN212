using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot1
{
    internal class Course
    {
        public Course()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public Course(int id, string name, string code)
        {
            Id = id;
            Name = name;
            Code = code;
        }

        public virtual void Input()
        {
            Console.WriteLine("Input Id: ");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Input Code: ");
            Code = Console.ReadLine();
        }

        public virtual void Display() {
            Console.WriteLine("Display Course Information: ");
            Console.Write($"Id: {Id}, Name: {Name}, Code: {Code}");
        }

    }
}
