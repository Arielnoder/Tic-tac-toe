using System;

namespace Program
{
    class Program
    {
        
        public static void board(int pick) {
            int[,] boardAr = { {1,2,3 },{4,5,6 },{7,8,9 } };
            Console.WriteLine($"    {boardAr[0, 0]} |  {boardAr[0, 1]}  |  {boardAr[0, 2]} ");
            Console.WriteLine("------------------");
            Console.WriteLine($"    {boardAr[1, 0]} |  {boardAr[1, 1]}  |  {boardAr[1, 2]} ");
            Console.WriteLine(" ------------------");
            

        }


       
        static void Main(string[] args)
        {   
            int pick;

            var play = new Random();
            int player = play.Next(1,3);
           
            Console.WriteLine("Welcome to tic tac toe");
            Console.WriteLine("Pick an area according to the number"); 
               pick = int.Parse(Console.ReadLine());
            board(pick);
            while (player % 2 == 0 ) {
               Console.WriteLine("You are X\n");
              
               
               
            

             
            }   
               Console.WriteLine("You are O");

      
            
           
               
       




           

        }
    }
}
