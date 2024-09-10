namespace Slot1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Nhập họ và tên:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Nhập năm sinh");
            //string year = Console.ReadLine();
            //int age = DateTime.Now.Year - int.Parse(year);
            ////Console.WriteLine( "Họ và tên: " + name + ", Năm sinh:" + year);
            //Console.WriteLine($"Họ và tên: {name}, Tuoi: {age} ");

            //Student s1 = new Student();
            //s1.FullName = "Test";
            //s1.Dob = DateOnly.Parse("01/01/2001");
            //s1.Gender = "Male";
            //Console.WriteLine($"Full Name: {s1.FullName}, Date of Birth: {s1.Dob}, Gender: {s1.Gender}");

            //s1.input();
            //s1.display();

            //Course course = new Course();
            //course.Input();
            //course.Display();

            OnlineCourse onlineCourse = new OnlineCourse();
            onlineCourse.Input();
            onlineCourse.Display();

        }
    }
    
}
