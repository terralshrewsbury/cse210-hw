using System;

class Program
{
    static void Main(string[] args)
    {
        string sign = "";
        Console.WriteLine("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();
        
        if (int.TryParse(gradeInput, out int grade))
        {
            int onesplace = grade % 10;
            
            if (onesplace < 3 )
            {
                sign = "-";
            }
            
            else if (onesplace > 7 )
            {
                sign = "+";
            } 
            
            if (grade >= 70)
            {
                Console.WriteLine("You passed the class!");
                    
                if (grade >= 90)
                {
                    if (sign == "" && sign == "-")
                    {
                    Console.WriteLine($"You have an {sign}A");
                    }
        
                    else
                    {
                    Console.WriteLine("You have an A");
                    }                                    
                }          
                
                else if (grade >= 80)
                {
                    Console.WriteLine($"You have a {sign}B");
                }
                
                else if (grade >= 70)
                {
                    Console.WriteLine($"You have a {sign}C");
                }
            }    
                
            else
            {
                Console.WriteLine("You must take the class again to learn what you need to pass.");
                
                if (grade >= 60)
                {
                    Console.WriteLine($"You have a {sign}D");
                }
                else
                {
                Console.WriteLine("You have an F");
                }
            }                    
        }
    }
}
    