using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot1
{
    internal class OnlineCourse : Course
    {
        public OnlineCourse() { 
        }

        public string UrlMeet { get; set; }

        public OnlineCourse(int id, string name, string code, string urlMeet) : base(id, name, code)
        {
            UrlMeet = urlMeet;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("UrlMeet: ");
            UrlMeet = Console.ReadLine();
        }

        public override void Display()
        {
            base.Display();
            Console.Write($", UrlMeet: {UrlMeet}");
        }
    }
}
