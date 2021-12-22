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
   
    if (board[row, 0] == 'X' ||board[row, 1] == 'X' || board[row, 2] == 'X' )
    {
   return true;
    } else if (board[row, 0] == 'X' ||board[row, 1] == 'X' || board[row, 2] == 'X') {

    }
    

return false;

}

public static bool checkColumn( char[,] board,int column) {
   
    if (board[1, column] == 'X' ||board[1, column] == 'X' || board[1, column] == 'X' )
    {
   return true;
    }
    

return false;

}

public static bool winLineDown(int row, char[,] board,int column) {
   
    if (board[row, column] == 'X' ||board[row, column] == 'X' || board[row, column] == 'X' )
    {
   return true;
    }
    

return false;

}

public static bool winColumnRight(int row, char[,] board,int column) {
   
    if (board[row, column] == 'X' ||board[row, column] == 'X' || board[row, column] == 'X' )
    {
   return true;
    }
    

return false;

}
public static bool winColumnMiddle(int row, char[,] board,int column) {
   
    if (board[row, column] == 'X' ||board[row, column] == 'X' || board[row, column] == 'X' )
    {
   return true;
    }
    

return false;

}

public static bool winMainDiagonal(int row, char[,] board,int column) {
   
    if (board[row, column] == 'X' ||board[row, column] == 'X' || board[row, column] == 'X' )
    {
   return true;
    }
    

return false;

}
public static bool winSecondDiagonal(int row, char[,] board,int column) {
   
    if (board[row, column] == 'X' ||board[row, column] == 'X' || board[row, column] == 'X' )
    {
   return true;
    }
    

return false;

}

public  static void winCondition(char[,] board, int row ,int column) {
    if ( board[0,0] == 'X') {
            winLineUp(board , row , column);
    }
}





        static void Main(string[] args)
        {
char[,] board = { {'1','2','3' },{'4','5','6' },{'7','8','9' } };
int player = 1;
int choice;
int row;  
int column;

            Console.WriteLine("Welcome to tic tac toe \n");
            
            PrintBoard(board);

            Console.WriteLine("\n");

            if (player == 1 ) {
            Console.WriteLine("You are X");

            System.Console.WriteLine("Enter a number an area");

            choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                        case 1:
                        board[0, 0] = 'X';
                        Console.Clear();
                        PrintBoard(board);
                        row = 0; 
                        column = 0;
                        winCondition(board,row,column);
                        break;

                    case 2:
                        board[0, 1] = 'X';
                        Console.Clear();
                        PrintBoard(board);
                        row = 0;
                        column = 1;
                        winCondition(board,row,column);
                        break;

                    case 3:
                        board[0, 2] = 'X';
                        Console.Clear();
                        PrintBoard(board);
                        row = 0;
                        column = 2;
                        winCondition(board,row,column);
                        break;

                    case 4:
                        board[1, 0] = 'X';
                        Console.Clear();
                        PrintBoard(board);
                        row = 1;
                        column = 0;
                        winCondition(board,row,column);
                        break;
                    
                    case 5:
                        board[1, 1] = 'X';
                        Console.Clear();
                        PrintBoard(board);
                        row = 1;
                        column = 1;
                        winCondition(board,row,column);
                        break;

                      case 6:
                        board[1, 2] = 'X';
                        Console.Clear();
                        PrintBoard(board);
                        row = 1;
                        column = 2;
                        winCondition(board,row,column);
                        break;

                     case 7:
                        board[2,0] = 'X';
                        Console.Clear();
                        PrintBoard(board);
                        row = 2;
                        column = 0;
                        winCondition(board,row,column);
                        break;

                     case 8:
                        board[2,1] = 'X';
                        Console.Clear();
                        PrintBoard(board);
                        row = 2;
                        column = 1;
                        winCondition(board,row,column);
                        break;

                      case 9:
                        board[2,2] = 'X';
                        Console.Clear();
                        PrintBoard(board);
                        column = 2;
                        row = 2;
                        winCondition(board,row,column);
                        break;

            }




            } else {
               Console.WriteLine("You are O");

            }


            
            

              
        }
    }
}
