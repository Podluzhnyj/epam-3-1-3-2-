using System;

namespace princess
{
    class Program
    {
        public static int startPointX = 0;
        public static int startPointY = 0;
        public static int finishPointX = 10;
        public static int finishPointY = -10;
        public static int HP = 3;
        static ConsoleKeyInfo key;

        // Не лезь - убьет.
        #region Генерация и присваивание координат бомбы
        static Random bombX_one = new Random();
        static Random bombX_two = new Random();
        static Random bombX_three = new Random();
        static Random bombX_four = new Random();
        static Random bombX_five = new Random();
        static Random bombX_six = new Random();
        static Random bombX_seven = new Random();
        static Random bombX_eight = new Random();
        static Random bombX_nine = new Random();
        static Random bombX_ten = new Random();

        static Random bombY_one = new Random();
        static Random bombY_two = new Random();
        static Random bombY_three = new Random();
        static Random bombY_four = new Random();
        static Random bombY_five = new Random();
        static Random bombY_six = new Random();
        static Random bombY_seven = new Random();
        static Random bombY_eight = new Random();
        static Random bombY_nine = new Random();
        static Random bombY_ten = new Random();

        static int x_1 = bombX_one.Next(1, 9);
        static int x_2 = bombX_two.Next(1, 9);
        static int x_3 = bombX_three.Next(1, 9);
        static int x_4 = bombX_four.Next(1, 9);
        static int x_5 = bombX_five.Next(1, 9);
        static int x_6 = bombX_six.Next(1, 9);
        static int x_7 = bombX_seven.Next(1, 9);
        static int x_8 = bombX_eight.Next(1, 9);
        static int x_9 = bombX_nine.Next(1, 9);
        static int x_10 = bombX_ten.Next(1, 9);

        static int y_1 = bombY_one.Next(1, 9);
        static int y_2 = bombY_two.Next(1, 9);
        static int y_3 = bombY_three.Next(1, 9);
        static int y_4 = bombY_four.Next(1, 9);
        static int y_5 = bombY_five.Next(1, 9);
        static int y_6 = bombY_six.Next(1, 9);
        static int y_7 = bombY_seven.Next(1, 9);
        static int y_8 = bombY_eight.Next(1, 9);
        static int y_9 = bombY_nine.Next(1, 9);
        static int y_10 = bombY_ten.Next(1, 9);
        #endregion  

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру 'Принцесса'.");
            //GetBomb(); // Генерируем бомбы и выводим их на экран.
            Console.WriteLine("Нажмите любую клавишу для начала игры.\nУправление - стрелочки вверх, вниз, вправо, влево.");
            
            do
            {
                if (HP > 0)
                {

                    startPointX = 0;
                    startPointY = 0;
                    Gameplay(); // Передаем управление пользователю.
                    
                }
           

            }

            while (HP > 0);
            Console.WriteLine("Ты проиграл!");

        }
        public static void GetError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Граница карты.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void GetBomb()
        {
            Console.WriteLine("Бомбы сгенированы.");

            #region Вывод координат бомб
            Console.WriteLine(x_1 + " " + y_1);


            Console.WriteLine(x_2 + " " + y_2);


            Console.WriteLine(x_3 + " " + y_3);


            Console.WriteLine(x_4 + " " + y_4);

            Console.WriteLine(x_5 + " " + y_5);


            Console.WriteLine(x_6 + " " + y_6);


            Console.WriteLine(x_7 + " " + y_7);

            Console.WriteLine(x_8 + " " + y_8);

            Console.WriteLine(x_9 + " " + y_9);

            Console.WriteLine(x_10 + " " + y_10);
            #endregion
        }

        public static void Gameplay()
        {


            do
            {
                
                key = Console.ReadKey(true);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                
                switch (key.Key)
                {

                    case ConsoleKey.UpArrow:
                        {

                            if (startPointY < 0)
                            {

                                if (startPointY == -y_1 && startPointX == x_1 || startPointY == -y_2 && startPointX == x_2 || startPointY == -y_3 && startPointX == x_3 || startPointY == -y_4 && startPointX == x_4 || startPointY == -y_5 && startPointX == x_5 || startPointY == -y_6 && startPointX == x_6 || startPointY == -y_7 && startPointX == x_7 || startPointY == -y_8 && startPointX == x_8 || startPointY == -y_9 && startPointX == x_9 || startPointY == -y_10 && startPointX == x_10)
                                {
                                    Console.WriteLine("ты взорвался");
                                    HP--;
                                    Console.WriteLine($"Осталось {HP} жизни.");
                                    return;
                                }
                                else
                                {
                                    startPointY++;
                                    Console.WriteLine("X = " + startPointX + " - Y= " + startPointY);
                                   
                                }



                            }
                            else if (startPointY == -10 && startPointX == 10)
                            {
                                WinGame();
                                return;
                            }
                            else GetError();
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {

                            if (startPointY > -10)
                            {

                                if (startPointY == -y_1 && startPointX == x_1 || startPointY == -y_2 && startPointX == x_2 || startPointY == -y_3 && startPointX == x_3 || startPointY == -y_4 && startPointX == x_4 || startPointY == -y_5 && startPointX == x_5 || startPointY == -y_6 && startPointX == x_6 || startPointY == -y_7 && startPointX == x_7 || startPointY == -y_8 && startPointX == x_8 || startPointY == -y_9 && startPointX == x_9 || startPointY == -y_10 && startPointX == x_1)
                                {
                                    Console.WriteLine("ты взорвался");
                                    HP--;
                                    Console.WriteLine($"Осталось {HP} жизни.");
                                    return;
                                }
                                else
                                {
                                    startPointY--;
                                    Console.WriteLine("X = " + startPointX + " - Y= " + startPointY);
                                   
                                }

                            }
                            else if (startPointY == -10 && startPointX == 10)
                            {
                                WinGame();
                                return;
                            }
                            else GetError();
                            break;
                        }
                    case ConsoleKey.LeftArrow:
                        {
                            if (startPointX > 0)
                            {

                                if (startPointY == -y_1 && startPointX == x_1 || startPointY == -y_2 && startPointX == x_2 || startPointY == -y_3 && startPointX == x_3 || startPointY == -y_4 && startPointX == x_4 || startPointY == -y_5 && startPointX == x_5 || startPointY == -y_6 && startPointX == x_6 || startPointY == -y_7 && startPointX == x_7 || startPointY == -y_8 && startPointX == x_8 || startPointY == -y_9 && startPointX == x_9 || startPointY == -y_10 && startPointX == x_1)
                                {
                                    Console.WriteLine("ты взорвался");
                                    HP--;
                                    Console.WriteLine($"Осталось {HP} жизни.");
                                    return;
                                }
                                else
                                {
                                    startPointX--;
                                    Console.WriteLine("X = " + startPointX + " - Y= " + startPointY);
                                    
                                }

                            }
                            else if (startPointX == 10 && startPointY == -10)
                            {
                                WinGame();
                                return;
                            }
                            else GetError();
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (startPointX < 10)
                            {

                                if (startPointY == -y_1 && startPointX == x_1 || startPointY == -y_2 && startPointX == x_2 || startPointY == -y_3 && startPointX == x_3 || startPointY == -y_4 && startPointX == x_4 || startPointY == -y_5 && startPointX == x_5 || startPointY == -y_6 && startPointX == x_6 || startPointY == -y_7 && startPointX == x_7 || startPointY == -y_8 && startPointX == x_8 || startPointY == -y_9 && startPointX == x_9 || startPointY == -y_10 && startPointX == x_1)
                                {
                                    Console.WriteLine("ты взорвался");
                                    HP--;
                                    Console.WriteLine($"Осталось {HP} жизни.");
                                    return;
                                }
                                else
                                {
                                    startPointX++;
                                    Console.WriteLine("X = " + startPointX + " - Y= " + startPointY);
                                    
                                }

                            }
                            else if (startPointX == 10 && startPointY == -10)
                            {
                                WinGame();
                                return;
                            }
                            else GetError();
                            break;
                        }
                }

            }
            while (key.Key != ConsoleKey.Enter);

        }

        public static void WinGame()
        {
            Console.WriteLine($"Ура! Принцесса спасена! Спасибо тебе, рыцарь.\nЖизней осталось {HP}.");
            Environment.Exit(0);

        }
       
    }
}
