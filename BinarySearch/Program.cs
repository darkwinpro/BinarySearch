using System;

public class Program
{
    public static void Main()
    {
        string[] students = Input();
        Array.Sort(students);
        string surname = Console.ReadLine();
        BinarySearch(surname, students);
    }

    private static string[] Input()
    {
        var number = Convert.ToInt32(Console.ReadLine());
        string[] students = new string[number];
        
        for (var i = 0; i < students.Length; i++)
        {
            students[i] = Console.ReadLine();
        }
        
        return students;
    }

    private static void BinarySearch(string surname, string[] studs)
    {
        int left = 0;
        int right = studs.Length;
        int mid = 0;

        while (left != right)
        {
            mid = left + (right - left) / 2;
            
            if (studs[mid] == surname)
            {
                break;
            }

            if (String.Compare(studs[mid], surname) > 0)
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }

        if (studs[mid] == surname)
        {
            Console.Write(mid + 1);
        }
        else
        {
            Console.WriteLine("Выпускник с данной фамилией не найден в списке");
        }

        

    }
}