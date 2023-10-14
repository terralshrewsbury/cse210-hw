using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int>numbers= new List<int>();
        int enteredNumber;
        int sum = 0;
        float average = 0.00f;
        int largestNumber = 0;
        int smallestPositiveNumber = 1000;
        



        do
        {
            Console.Write("Enter number: ");
            if (int.TryParse(Console.ReadLine(), out enteredNumber))
            {
                numbers.Add(enteredNumber);
            } 
        } while (enteredNumber != 0);
        
        

        foreach( int number in numbers)
        {
            sum += number; 

            if (largestNumber < number)
            {
                largestNumber = number;
            }

            if (number > 0 && smallestPositiveNumber > number && number!= 0)
            {
                smallestPositiveNumber = number;
            }
        }
        Console. WriteLine($"The sum is: {sum}.");
        
        int lengthOfList = numbers.Count - 1;
        
        average = (float)sum / lengthOfList;
        
        // Console.WriteLine(lengthOfList);

        Console.WriteLine($"The average is: {average}.");

        Console.WriteLine($"The largest number is: {largestNumber}");

        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");

        numbers.Sort();
        
        Console.WriteLine("the sorted list is: ");
        foreach (int number in numbers)
        {
            if (number != 0)
            {
            Console.WriteLine(number + " ");
            }
        }








    }

}