using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> intStack = new MyStack<int>();
            Console.WriteLine("Danh sach int: ");
            if (intStack.IsEmpty())
                Console.WriteLine("Danh sach rong");
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            Console.WriteLine("After Push: " + intStack.Peak());
            Console.WriteLine("Peak: " + intStack.Peak());
            Console.WriteLine("Pop: " + intStack.Pop());
            Console.WriteLine("after Pop: " + intStack.Peak());

            Console.WriteLine("Danh sach string");
            MyStack<string> stringStack = new MyStack<string>();
            if (stringStack.IsEmpty())
                Console.WriteLine("Danh sach cua ban rong");
            stringStack.Push("mot");
            stringStack.Push("hai");
            stringStack.Push("ba");
            Console.WriteLine("After Push: " + stringStack.Peak());
            Console.WriteLine("Peak: " + stringStack.Peak());
            Console.WriteLine("Pop: " + stringStack.Pop());
            Console.WriteLine("after Pop: " + stringStack.Pop());


            var students = new Dictionary<int, Student>()
            {
                { 1, new Student(1, "Trung", 10) },
                { 2, new Student(2, "thu", 7) },
                { 3, new Student(3, "Tu", 8) },
                { 4, new Student(4, "An", 5) },
                { 5, new Student(5, "Hieu", 6) }
            };

            var topGradeStudent = students.Values.OrderByDescending(s => s.Grade).FirstOrDefault();
            if (topGradeStudent != null)
                Console.WriteLine("Sinh vien co diem cao nhat: " + topGradeStudent.Grade + "-" + topGradeStudent.Name);

            var value = 7;

            var highGradeStudent = students.Values.Where(s => s.Grade > value);
            Console.WriteLine("Danh sach sinh vien co diem cao hon " + 7 + ": ");
            foreach (var student in highGradeStudent)
            {
                Console.WriteLine("ten: " + student.Name + ", diem: " + student.Grade);
            }

            var medium = 5;

            var aboveMediumGradeStudent = students.Values.Count(s => s.Grade > 5);
            Console.WriteLine("So luong sinh vien co diem dat trung binh tro len: " + aboveMediumGradeStudent);

            Console.ReadKey();
        }
    }
}
