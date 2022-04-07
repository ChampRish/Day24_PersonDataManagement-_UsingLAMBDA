using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24_Person_data_management
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to person data management program.");
            PersonData data = new PersonData();
            data.NewList();

            Console.WriteLine("\n 1] Retrieve top 2 records from the list for age is less than 60 : ");
            data.ListTop2RecordsAgeLessThan60();

            Console.WriteLine("\n 2] Retrieve all record from the list for age between 13 to 18 : ");
            data.RecordsBetweenGivenAge();

            data.CalculateAverageAge();

            Console.WriteLine(" 4] Searching for value in list :");
            Console.Write("\n Enter a value to search : ");
            string value = Console.ReadLine();
            data.SearchValue(value);
        }
    }
}
