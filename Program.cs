using System;

namespace G_A_M_E
{
    internal class Program
    {

        //Playfield
        static char[,] playfield =
        {
            {'1','2','3'},//Row 0
            {'4','5','6'},//Row 1
            {'7','8','9'},//Row 2
        };


        static int turn = 0;


        static void Main(string[] args)
        {
            int player = 2; //player 1 starts
            int input = 0;
            bool inputcorrect = true;

            

            //RUNS CODE AS LONG AS PROGRAM RUNS
            do
            {
                
                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }
                
                Setfield();
                #region
                //Check Winning Conditions
                char[] playerChars = { 'X', 'I' };

                foreach(char playerChar in playerChars)
                {
                    if (((playfield[0,0] == playerChar) && (playfield[0,1] == playerChar) && (playfield[0,2] == playerChar))
                        || ((playfield[1, 0] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[1, 2] == playerChar))
                        || ((playfield[2, 0] == playerChar) && (playfield[2, 1] == playerChar) && (playfield[2, 2] == playerChar))
                        || ((playfield[0, 0] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 0] == playerChar))
                        || ((playfield[0, 1] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[1, 2] == playerChar))
                        || ((playfield[0, 2] == playerChar) && (playfield[2, 1] == playerChar) && (playfield[2, 2] == playerChar))
                        || ((playfield[0, 0] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 2] == playerChar))
                        || ((playfield[0, 2] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 0] == playerChar))

                        )
                    {
                        if(playerChar=='X')
                        {
                            Console.WriteLine("\nPlayer 2 has Won!");
                        }
                        else
                        {
                            Console.WriteLine("\nPlayer 1 has Won!");
                        }
                        //To do Reset the field


                        Console.WriteLine("Please Press any key to Reset the Game!");
                        Console.ReadKey();
                        resetField();
                        break;

                    }
                    else if (turn == 10)
                    {
                        Console.WriteLine("\n Draw as text!");
                        Console.WriteLine("Please Press any key to Reset the Game!");
                        Console.ReadKey();
                        resetField();
                        break;
                    }
                }
                
                #endregion



                #region
                //Test if field is already taken
                do
                {
                    Console.Write("Player {0} : Choose your field! ",player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please Enter a Number !!!!!!!");
                    }
                    if ((input == 1) && (playfield[0, 0] == '1'))
                    {
                        inputcorrect = true;
                    }
                    else if ((input == 2) && (playfield[0, 1] == '2'))
                        inputcorrect = true;
                    else if ((input == 3) && (playfield[0, 2] == '3'))
                        inputcorrect = true;
                    else if ((input == 4) && (playfield[1, 0] == '4'))
                        inputcorrect = true;
                    else if ((input == 5) && (playfield[1, 1] == '5'))
                        inputcorrect = true;
                    else if ((input == 6) && (playfield[1, 2] == '6'))
                        inputcorrect = true;
                    else if ((input == 7) && (playfield[2, 0] == '7'))
                        inputcorrect = true;
                    else if ((input == 8) && (playfield[2, 1] == '8'))
                        inputcorrect = true;
                    else if ((input == 9) && (playfield[2, 2] == '9'))
                        inputcorrect = true;
                    else
                    {
                        Console.WriteLine("\n Incorrect Input!! Please use another Field");
                        inputcorrect = false;
                    }




                } while (!inputcorrect);
                #endregion


            } while (true);



        }

        public static void resetField()
        {
            char[,] playfieldInitial =
            {
            {'1','2','3'},//Row 0
            {'4','5','6'},//Row 1
            {'7','8','9'},//Row 2
            };
            playfield = playfieldInitial;
            Setfield();
            turn = 0;
        }



        public static void Setfield()
        {
            Console.Clear();
            Console.WriteLine("     |     |     ");
            //replace below
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playfield[0, 0], playfield[0,1], playfield[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            //replace below
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playfield[1, 0], playfield[1, 1], playfield[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            //replace below
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playfield[2, 0], playfield[2, 1], playfield[2, 2]);
            Console.WriteLine("     |     |     ");
            turn++;
        }


        public static void EnterXorO(int player , int input)
        {

            char playerSign = ' ';

            if (player == 1)
                playerSign = 'X';
            else if (player == 2)
                playerSign = 'I';

            switch (input)
            {
                case 1:
                    playfield[0, 0] = playerSign;
                    break;
                case 2:
                    playfield[0, 1] = playerSign;
                    break;
                case 3:
                    playfield[0, 2] = playerSign;
                    break;
                case 4:
                    playfield[1, 0] = playerSign;
                    break;
                case 5:
                    playfield[1, 1] = playerSign;
                    break;
                case 6:
                    playfield[1, 2] = playerSign;
                    break;
                case 7:
                    playfield[2, 0] = playerSign;
                    break;
                case 8:
                    playfield[2, 1] = playerSign;
                    break;
                case 9:
                    playfield[2, 2] = playerSign;
                    break;
            }
        }
    }
}
