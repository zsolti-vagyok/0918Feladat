namespace ConsoleSzinezo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            int x = Console.WindowWidth / 2;  
            int y = Console.WindowHeight / 2;

            Console.WriteLine("Színek:");
            
            Console.WriteLine("Num 0 : WHITE");
            Console.WriteLine("Num 1 : RED");
            Console.WriteLine("Num 2 : GREEN");
            Console.WriteLine("Num 3 : BLUE");
            Console.WriteLine("Num 4 : Magenta");
            Console.WriteLine("Num 5 : YELLOW");
            char karakter = '█';
            while (true)
            {
                
                Console.SetCursorPosition(x, y);  
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);  

                
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    x--;
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    x++;
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow )  
                {
                    y--;
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)                  
                {
                    y++;
                }
                else if (keyInfo.Key == ConsoleKey.NumPad0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (keyInfo.Key == ConsoleKey.NumPad1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (keyInfo.Key == ConsoleKey.NumPad2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (keyInfo.Key == ConsoleKey.NumPad3)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (keyInfo.Key == ConsoleKey.NumPad4)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (keyInfo.Key == ConsoleKey.NumPad5)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if(keyInfo.Key == ConsoleKey.F1)
                {
                    karakter = '█';
                }

                else if(keyInfo.Key == ConsoleKey.F2)
                {
                    karakter = '▓';
                }
                else if (keyInfo.Key == ConsoleKey.F3)
                {
                    karakter = '▒';
                }
                else if (keyInfo.Key == ConsoleKey.F4)
                {
                    karakter = '░';
                }
                else if (keyInfo.Key == ConsoleKey.Spacebar)  
                {
                    
                    Console.Write(karakter);  
                }
                
                else if (keyInfo.Key==ConsoleKey.Escape)
                {
                    Console.Clear();
                }
            
            }   
        }

    }
}