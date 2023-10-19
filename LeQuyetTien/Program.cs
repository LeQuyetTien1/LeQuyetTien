using LeQuyetTien;
using System;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so hoc sinh: ");
        int n=int.Parse(Console.ReadLine());
        Student[] st = new Student[n];
        TestStudent st2 = new TestStudent();
        Console.WriteLine("Please select an option:");
        Console.WriteLine("==========================");
        Console.WriteLine("1. Input information (input details for a student)");
        Console.WriteLine("2. Sorting student ascending by average mark");
        Console.WriteLine("3. Display all the student list");
        Console.WriteLine("4. Search studen by name");
        Console.WriteLine("5. Delete student by student ID");
        Console.WriteLine("6. Exit program");
        Console.WriteLine("==========================");
        int choice;
        do
        {
            Console.Write("Option: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    st2.Create(ref n, ref st);
                    break;
                case 2:
                    st2.Sort(ref n, ref st);
                    break;
                case 3:
                    st2.Display(ref n, ref st);
                    break;
                case 4:
                    st2.Search(ref n, ref st);
                    break;
                case 5:
                    st2.Delete(ref n, ref st);
                    break;
                default:
                    Console.WriteLine("Exit Program");
                    break;
            }
        } while (choice != 6);
    }
}