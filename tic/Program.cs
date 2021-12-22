using System;

namespace tic
{
    class Program
    {

public static void PrintBoard(char[,] boardAr){
// draws the board
            
            Console.WriteLine($"    {boardAr[0, 0]} |  {boardAr[0, 1]}  |  {boardAr[0, 2]} ");
            Console.WriteLine(" ------------------");
            Console.WriteLine($"    {boardAr[1, 0]} |  {boardAr[1, 1]}  |  {boardAr[1, 2]} ");
            Console.WriteLine(" ------------------");
            Console.WriteLine($"    {boardAr[2, 0]} |  {boardAr[2, 1]}  |  {boardAr[2, 2]}  ");
}

public static bool checkRow(int row, char[,] board) {
   
    if (board[row, 0] == 'X' && board[row, 1] == 'X' && board[row, 2] == 'X' )
    {
     Console.WriteLine("\n X won");   
   return true;
    } 
    

return false;

}

public static bool checkColumn( char[,] board,int column) {
   
    if (board[0, column] == 'X' && board[1, column] == 'X' && board[2, column] == 'X' )
    {
    Console.WriteLine("\n X won");   
   return true;
    } 
    

return false;

}




public static bool checkDiagonal( char[,] board) {
   
    if (board[0,0] == 'X' && board[1, 1] == 'X' && board[2,2] == 'X' )
    {
    Console.WriteLine("\n X won");   
   return true;
    } else if (board[0,2] == 'X' && board[1, 1] == 'X' && board[2, 0] == 'X' )
    {
         Console.WriteLine("\n X won");  
   return true;
    }
    

return false;

}


public  static bool winCondition(char[,] board, int row ,int column) {
    // checks for rows amd columns
    if ( board[0,column] == 'X' || board[1,column] == 'X' || board[2,column] == 'X' ) {
              if(checkRow(row,board)) {
       return true;
   } 
     if(checkColumn(board,column)) {
       return true;
   }      
    }
    // checks for Diagonal lines 

    if (board [1,1] == 'X') {
        if  (checkDiagonal(board)) {
       return true;
   }
    }

    
 
  
   
    return false;

 
}





        static void Main(string[] args)
        {
char[,] board = { {'1','2','3' },{'4','5','6' },{'7','8','9' } };
int player = 1;
int check = 0;
int choice;
int row;  
int column;

            Console.WriteLine("Welcome to tic tac toe \n");
            
            PrintBoard(board);

            Console.WriteLine("\n");

           
             Console.WriteLine("You are X");

            Console.WriteLine("Enter  an area number");

            
           
          
               
           while (check == 0) {
             
            switch ( choice = int.Parse(Console.ReadLine()))
            {
                        case 1:
                        board[0, 0] = 'X';
                        Console.Clear();
                     
                        PrintBoard(board);
                        row = 0; 
                        column = 0;
                        if(winCondition(board,row,column)) {
                            check++;
                        }
                     
                        break;

                    case 2:
                        board[0, 1] = 'X';
                        Console.Clear();
                     
                        PrintBoard(board);
                        row = 0;
                        column = 1;
                           if(winCondition(board,row,column)) {
                            check++;
                        }
                       
                        break;

                    case 3:
                        board[0, 2] = 'X';
                        Console.Clear();
                        PrintBoard(board);
                        row = 0;
                        column = 2;
                           if(winCondition(board,row,column)) {
                            check++;
                        }
                       
                        break;

                    case 4:
                        board[1, 0] = 'X';
                        Console.Clear();
                        PrintBoard(board);
                        row = 1;
                        column = 0;
                        if(winCondition(board,row,column)) {
                            check++;
                        }
                  
                        break;
                    
                    case 5:
                        board[1, 1] = 'X';
                        Console.Clear();
                        PrintBoard(board);
                        row = 1;
                        column = 1;
                       if(winCondition(board,row,column)) {
                            check++;
                        }
                        break;

                      case 6:
                        board[1, 2] = 'X';
                        Console.Clear();
                        PrintBoard(board);
                        row = 1;
                        column = 2;
                        if(winCondition(board,row,column)) {
                            check++;
                        }
                        break;

                     case 7:
                        board[2,0] = 'X';
                        Console.Clear();
                        PrintBoard(board);
                        row = 2;
                        column = 0;
                    if(winCondition(board,row,column)) {
                            check++;
                        }
                        break;

                     case 8:
                        board[2,1] = 'X';
                        Console.Clear();
                        PrintBoard(board);
                        row = 2;
                        column = 1;
                        if(winCondition(board,row,column)) {
                            check++;
                        }
                        break;

                      case 9:
                        board[2,2] = 'X';
                        Console.Clear();
                        PrintBoard(board);
                        column = 2;
                        row = 2;
                        if(winCondition(board,row,column)) {
                            check++;
                        }
                        break;

            }
           }
           




            


            
            

              
        }
    }
}
