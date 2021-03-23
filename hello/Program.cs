using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("what is your name \n");

            string inputes = Console.ReadLine() ; 
            Random random = new Random();
            int correctNumber = random.Next(1 , 3); 
            int guess = 0 ; 
            int win = 0 ;
            int totalWin = 0 ;
            int lose = 0 ;
            int totalLose = 0 ;
            int total = 0 ;

            Console.Write("throw the dice") ; 

            while(guess != correctNumber){
                string input = Console.ReadLine() ;
                if(!int.TryParse(input, out guess)){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("please input a number");
                    Console.ResetColor(); 
                    continue;
                } 
                guess = Int32.Parse(input) ; 

                if(guess != correctNumber){
                    Console.ForegroundColor = ConsoleColor.Red ; 
                    Console.WriteLine("oops , please try") ; 
                    Console.ResetColor() ; 
                    lose += 1 ;
                    totalLose += lose ;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green ; 
            Console.Write("correct") ; 
            Console.ResetColor() ; 
            win += 1 ;
            totalWin += win ;
            

            result:
            Console.WriteLine("your total result is: {0} out of {1}",totalWin, total);
        }
    }
}
