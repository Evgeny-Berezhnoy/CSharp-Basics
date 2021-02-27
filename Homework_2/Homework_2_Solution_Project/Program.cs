using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Written by Evgeny Berezhnoy

namespace Homework_2_Solution_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true) {

                // 0. Preparations
                // 0.1. Greet the User
                Console.WriteLine("Домашняя работа №2.");
                Console.WriteLine();
                Console.WriteLine("Задание №1 - Выявление минимального числа из трех введенных");
                Console.WriteLine("Задание №2 - Выявление количества цифр введенного числа");
                Console.WriteLine("Задание №3 - Расчет суммы положительных нечетных чисел");
                Console.WriteLine("Задание №4 - Аутентификация");
                Console.WriteLine("Задание №5 - Индекс массы тела");
                Console.WriteLine("Задание №6 - Хорошие числа");
                Console.WriteLine("Задание №7 - Рекурсивный вывод чисел");
                
                string User_Task = Enter_Data_String("Введите номер задания (от 1 до 7). Введите q для выхода из программы: ");

                switch (User_Task) {

                    case "q":

                        // Quit the game
                        return;

                    case "1":

                        Task_1();

                        break;

                    case "2":

                        Task_2();

                        break;

                    case "3":

                        Task_3();

                        break;

                    case "4":

                        Task_4();

                        break;

                    case "5":

                        Task_5();

                        break;

                    case "6":

                        Task_6();

                        break;

                    case "7":

                        Task_7();

                        break;

                    default:

                        Console.WriteLine();
                        Console.WriteLine("Введено некорректное значение.");

                        break;

                };

                // Stop and show the user the result of his manipulations
                Console_Pause_And_Clear();

            };

        }

        #region Task 1

        static void Task_1()
        {

            // 0. Preparations
            // 0.1. Clear the console from things, written in console
            Console.Clear();
            Console.WriteLine("Задание №1 - Выявление минимального числа из трех введенных");
            Console.WriteLine("Написать метод, возвращающий минимальное из трех чисел.");


            // 0.2. Variables
            decimal Number_1 = Enter_Data_Decimal("Введите первое число: ");
            decimal Number_2 = Enter_Data_Decimal("Введите второе число: ");
            decimal Number_3 = Enter_Data_Decimal("Введите третье число: ");

            decimal Number_Minimum = Decimal.MaxValue;

            // 1. Calculations
            Number_Minimum = (Number_Minimum < Number_1 ? Number_Minimum : Number_1);
            Number_Minimum = (Number_Minimum < Number_2 ? Number_Minimum : Number_2);
            Number_Minimum = (Number_Minimum < Number_3 ? Number_Minimum : Number_3);

            // 2. Minimum number output
            Console.WriteLine();
            Console.WriteLine($"Минимальное введенное число: {Number_Minimum}");

        }

        #endregion

        #region Task 2

        static void Task_2() {

            // 0. Preparations
            // 0.1. Clear the console from things, written in console
            Console.Clear();
            Console.WriteLine("Задание №2 - Выявление количества цифр введенного числа");
            Console.WriteLine("Написать метод подсчета количества цифр числа.");

            // 0.2. Variables
            int User_Answer_NumbersQuantity = 0;

            string User_Answer = Enter_Data_String("Введите целое число:");

            string User_Answer_Character_String;

            // 1. Numbers quantity determination. For the case if user entered negative, decimal or jibberish number
            foreach (char User_Answer_Character in User_Answer) {

                User_Answer_Character_String = User_Answer_Character.ToString();

                if ((User_Answer_Character_String.Equals("1"))
                        || (User_Answer_Character_String.Equals("2"))
                        || (User_Answer_Character_String.Equals("3"))
                        || (User_Answer_Character_String.Equals("4"))
                        || (User_Answer_Character_String.Equals("5"))
                        || (User_Answer_Character_String.Equals("6"))
                        || (User_Answer_Character_String.Equals("7"))
                        || (User_Answer_Character_String.Equals("8"))
                        || (User_Answer_Character_String.Equals("9"))
                        || (User_Answer_Character_String.Equals("0"))) {

                    User_Answer_NumbersQuantity++;

                };

            };

            // 2. Output
            Console.WriteLine($"Число {User_Answer} содержит {User_Answer_NumbersQuantity} цифр");

        }

        #endregion

        #region Task 3

        static void Task_3()
        {

            // 0. Preparations
            // 0.1. Clear the console from things, written in console
            Console.Clear();
            Console.WriteLine("Задание №3 - Расчет суммы положительных нечетных чисел");
            Console.WriteLine("С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");

            // 0.2. Variables
            int Numbers_PositiveOddTotal = 0;

            int Number;

            // 1. Entering numbers
            while (true) {

                Number = Enter_Data_Integer("Введите число (0 - выход): ");

                if ((Number > 0)
                      && ((Number % 2) > 0)) {

                    // If we have positive odd number
                    Numbers_PositiveOddTotal = Numbers_PositiveOddTotal + Number;

                } else if (Number == 0) {

                    break;

                }

            };

            // 2. User's numbers total output
            Console.WriteLine($"Сумма введенных вами позитивных нечетных чисел = {Numbers_PositiveOddTotal}");

        }

        #endregion

        #region Task 4

        static void Task_4()
        {

            // 0. Preparations
            // 0.1. Clear the console from things, written in console
            Console.Clear();
            Console.WriteLine("Задание №4 - Аутентификация");
            Console.WriteLine("Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.");

            // 0.2. Variables
            string User_Login;
            string User_Password;

            int Attempts_Quantity = 0;
            int Attempts_Maximum = 3;

            // 1. User enters password
            do {

                User_Login = Enter_Data_String("Введите ваш login: ");
                User_Password = Enter_Data_String("Введите ваш пароль: ");

                if (Task_4_Authentificate(User_Login, User_Password)) {

                    break;

                } else {

                    Console.WriteLine();
                    Console.WriteLine("Неверные учетные данные.");
                    Console.WriteLine();
                    
                    Attempts_Quantity++;

                };

            } while (Attempts_Quantity < Attempts_Maximum);

            // 2. Result determination
            if (Attempts_Quantity < Attempts_Maximum)
            {

                Console.WriteLine();
                Console.WriteLine("Аутентификация пройдена.");

            } else {

                Console.WriteLine();
                Console.WriteLine("Аутентификация не пройдена. По вопросам восстановления ваших учетных данных звоните по номеру 555.");

            };

        }

        static bool Task_4_Authentificate(string User_Login, string User_Password) {

            // 0. Preparations
            // 0.1. Variables
            string Programm_Login = "root";
            string Programm_Password = "GeekBrains";

            // 1. Comparison
            return ((String.Equals(Programm_Login, User_Login)) && (String.Equals(Programm_Password, User_Password)));

        }

        #endregion

        #region Task 5

        static void Task_5()
        {

            // 0. Preparations
            // 0.1. Clear the console from things, written in console
            Console.Clear();
            Console.WriteLine("Задание №5 - Индекс массы тела");
            Console.WriteLine("а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;");
            Console.WriteLine("б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.");
            
            // 0.2. Variables
            string User_Height;
            string User_Weight;

            double User_MassIndex_Weight;
            double User_MassIndex_Height;

            double User_MassIndex;
            double User_MassIndex_Minimum = 18.5;
            double User_MassIndex_Maximum = 25;

            // 1. Asking questions
            User_Height     = Enter_Data_String("Введите ваш рост, м: ");
            User_Weight     = Enter_Data_String("Введите ваш вес, кг: ");
            
            // 2. Calculations
            User_MassIndex_Weight = Double.Parse(User_Weight);
            User_MassIndex_Height = Double.Parse(User_Height);

            User_MassIndex = Math.Round(User_MassIndex_Weight / (User_MassIndex_Height * User_MassIndex_Height), 2);

            // 3. Calculations output
            Console.WriteLine();
            Console.WriteLine($"Ваш индекс массы: {User_MassIndex}");

            if (User_MassIndex < User_MassIndex_Minimum) {

                Console.WriteLine($"Для оптимального веса вам необходимо набрать {(Task_5_WeightDifference(User_MassIndex_Minimum, User_MassIndex, User_MassIndex_Height))} кг.");
                
            } else if (User_MassIndex > User_MassIndex_Maximum) {

                Console.WriteLine($"Для оптимального веса вам необходимо сбросить {(Task_5_WeightDifference(User_MassIndex, User_MassIndex_Maximum, User_MassIndex_Height))} кг.");

            } else {

                Console.WriteLine("Ваш вес оптимален.");

            };

        }

        static double Task_5_WeightDifference(double User_MassIndex_Upper, double User_MassIndex_Lower, double User_MassIndex_Height)
        {

            return Math.Round((User_MassIndex_Upper - User_MassIndex_Lower) * Math.Pow(User_MassIndex_Height, 2), 2);

        }

        #endregion

        #region Task 6

        static void Task_6()
        {
            // 0. Preparations
            // 0.1. Clear the console from things, written in console
            Console.Clear();
            Console.WriteLine("Задание №6 - Хорошие числа");
            Console.WriteLine("*Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число, которое делится на сумму своих цифр. Реализовать подсчет времени выполнения программы, используя структуру DateTime.");
            Console.WriteLine("Идет подсчет чисел в промежутке от 1 до 1 000 000 000. Пожалуйста, подождите...");

            // 0.2. Variables
            DateTime Date_Start;
            DateTime Date_Finish;

            TimeSpan Dates_Difference;

            int GoodNumbers_Quantity = 0;

            double Number;
            double Number_MembersTotal;
            
            double Number_DevisionResult;

            string Number_String;

            // 1. Calculation
            // 1.1. Start
            Date_Start = DateTime.Now;

            // 1.2. Immediate calculation
            for (Number = 1; Number <= 1000000000; Number++) {

                Number_MembersTotal = 0;

                Number_String = Number.ToString();

                // Calculate total of members
                foreach (char Number_String_Member in Number_String) {

                    Number_MembersTotal = Number_MembersTotal + Int32.Parse(Char.ToString(Number_String_Member));

                }

                Number_DevisionResult = Number / Number_MembersTotal;
                
                if (Math.Round(Number_DevisionResult) == Number_DevisionResult) {

                    GoodNumbers_Quantity++;

                };

            };

            // 1.3. Finish 
            Date_Finish = DateTime.Now;

            Dates_Difference = Date_Finish - Date_Start;

            // 1.4. Result output
            Console.WriteLine($"Количество хороших чисел от 1 до 1 000 000 000 = {GoodNumbers_Quantity}");
            Console.WriteLine($"Расчет результатов занял {Dates_Difference.TotalSeconds} секунд.");

        }

        #endregion

        #region Task 7

        static void Task_7() 
        {

            // 0. Preparations
            // 0.1. Clear the console from things, written in console
            Console.Clear();
            Console.WriteLine("Задание №7 - Рекурсивный вывод чисел");
            Console.WriteLine("a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b);");
            Console.WriteLine("б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.");

            // 0.2. Variables
            int Number_1 = Enter_Data_Integer("Введите первое число: ");
            int Number_2 = Enter_Data_Integer("Введите второе число: ");

            int Numbers_Total = 0;

            // 1. Calculations
            Console.WriteLine();
            Console.WriteLine($"Вывод чисел от {Number_1} до {Number_2}: ");
            Console.WriteLine();

            Task_7_RecursiveOutput(Number_1, Number_2, ref Numbers_Total);

            Console.WriteLine();
            Console.WriteLine($"Сумма чисел от {Number_1} до {Number_2} = {Numbers_Total}");
            
        }

        static void Task_7_RecursiveOutput(int Number_1, int Number_2, ref int Numbers_Total) {

            if (Number_1 <= Number_2) {

                Console.WriteLine($"{Number_1}");

                Numbers_Total = Numbers_Total + Number_1;

                Task_7_RecursiveOutput(Number_1 + 1, Number_2, ref Numbers_Total);

            }

        }

        #endregion

        #region Common methods

        /// <summary>
        ///  Method outputs message and prompts user to type value
        /// </summary>
        /// <param name="User_Question">Message, clarifying task for the User</param>
        /// <returns>User's answer to the question</returns>
        static decimal Enter_Data_Decimal(string User_Question)
        {

            // 0. Variables
            Decimal User_Answer;

            // 1. Ask the question
            Console.Write(User_Question);

            // 2. User data input
            User_Answer = Decimal.Parse(Console.ReadLine());

            return User_Answer;

        }

        /// <summary>
        ///  Method outputs message and prompts user to type value
        /// </summary>
        /// <param name="User_Question">Message, clarifying task for the User</param>
        /// <returns>User's answer to the question</returns>
        static int Enter_Data_Integer(string User_Question)
        {

            // 0. Variables
            int User_Answer;

            // 1. Ask the question
            Console.Write(User_Question);

            // 2. User data input
            User_Answer = Int32.Parse(Console.ReadLine());

            return User_Answer;

        }

        /// <summary>
        ///  Method outputs message and prompts user to type value
        /// </summary>
        /// <param name="User_Question">Message, clarifying task for the User</param>
        /// <returns>User's answer to the question</returns>
        static String Enter_Data_String(string User_Question)
        {

            // 0. Variables
            String User_Answer;

            // 1. Ask the question
            Console.Write(User_Question);

            // 2. User data input
            User_Answer = Console.ReadLine();

            return User_Answer;

        }

        /// <summary>
        /// Method pauses code execution and let user to estimate everything that has been done in the code so far
        /// </summary>
        static void Console_Pause_And_Clear()
        {

            Console.WriteLine();
            Console.WriteLine("Нажмите Enter, чтобы продолжить...");

            // Pause in order not to close application
            Console.ReadLine();

            // Clear window for another programm
            Console.Clear();

        }

        #endregion

    }
}