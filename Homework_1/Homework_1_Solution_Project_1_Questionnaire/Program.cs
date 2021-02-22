using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_Solution_Project
{
    class Questionnaire
    {
        static void Main(string[] args)
        {

            #region Task Questionnaire

            // 0. Variables
            string User_Name;
            string User_Surname;
            string User_Age;
            string User_Height;
            string User_Weight;
            string User_City;

            // 1. User greetings
            Console.WriteLine("Вас приветствует приложение Анкета. От вас требуется ввести ваши данные для последующей работы.");

            // 2. Asking questions
            User_Name       = Enter_Data("Введите ваше имя: ");
            User_Surname    = Enter_Data("Введите вашу фамилию: ");
            User_Age        = Enter_Data("Введите ваш возраст, лет: ");
            User_Height     = Enter_Data("Введите ваш рост, м: ");
            User_Weight     = Enter_Data("Введите ваш вес, кг: ");
            User_City       = Enter_Data("Введите ваш город: ");

            // 3. Data one-string output
            Console.WriteLine();

            Console.WriteLine("Ваши данные: Имя - " + User_Name + "; Фамилия - " + User_Surname + "; Возраст - " + User_Age + "; Рост - " + User_Height + "; Вес - " + User_Weight);
            Console.WriteLine("Ваши данные: Имя - {0}; Фамилия - {1}; Возраст - {2}; Рост - {3}; Вес - {4}", User_Name, User_Surname, User_Age, User_Height, User_Weight);
            Console.WriteLine($"Ваши данные: Имя - {User_Name}; Фамилия - {User_Surname}; Возраст - {User_Age}; Рост - {User_Height}; Вес - {User_Weight}");

            #endregion

            #region Task Body Mass Index

            // 0. Variables
            double User_MassIndex_Weight = Double.Parse(User_Weight);
            double User_MassIndex_Height = Double.Parse(User_Height);
            
            double User_MassIndex = Math.Round(User_MassIndex_Weight / (User_MassIndex_Height * User_MassIndex_Height), 2);

            // 1. Calculations output
            Console.WriteLine();

            Console.WriteLine($"Ваш индекс массы: {User_MassIndex}");

            #endregion

            // Pause in order not to close application
            Console_Pause_And_Clear();

            #region Task Coordinates distance

            // 0. User greetings
            Console.WriteLine("Вас приветствует вычислитель расстояния между координатами. От вас требуется ввести ваши данные для последующей работы.");

            // 1. Coordinates input
            double Coordinate_x_1       = Double.Parse(Enter_Data("Координата x первой точки: "));
            double Coordinate_y_1       = Double.Parse(Enter_Data("Координата y первой точки: "));

            double Coordinate_x_2       = Double.Parse(Enter_Data("Координата x второй точки: "));
            double Coordinate_y_2       = Double.Parse(Enter_Data("Координата y второй точки: "));

            double Coordinates_Distance = Coordinates_Distance_Count(Coordinate_x_1, Coordinate_y_1, Coordinate_x_2, Coordinate_y_2);

            // 2. Calculations output
            Console.WriteLine();

            Console.WriteLine($"Расстояние между указанными координатами: {Coordinates_Distance.ToString("F2")}");

            #endregion

            // Pause in order not to close application
            Console_Pause_And_Clear();

            #region Task Value exchange

            // 0. User greetings
            Console.WriteLine("Вас приветствует обмен значениями. От вас требуется ввести ваши данные для последующей работы.");

            // 1. Variables
            int Exchange_Simple_Value_X         = Int32.Parse(Enter_Data("Введите первое значение x: "));
            int Exchange_Simple_Value_Y         = Int32.Parse(Enter_Data("Введите второе значение y: "));
            int Exchange_Simple_Value_Z;

            int Exchange_Complicated_Value_X    = Exchange_Simple_Value_X;
            int Exchange_Complicated_Value_Y    = Exchange_Simple_Value_Y;

            // 2. Simple Exchange
            Exchange_Simple_Value_Z = Exchange_Simple_Value_X;
            Exchange_Simple_Value_X = Exchange_Simple_Value_Y;
            Exchange_Simple_Value_Y = Exchange_Simple_Value_Z;

            // 3. Complicated exchange
            Exchange_Complicated_Value_X = Exchange_Complicated_Value_X + Exchange_Complicated_Value_Y;
            Exchange_Complicated_Value_Y = Exchange_Complicated_Value_X - Exchange_Complicated_Value_Y;
            Exchange_Complicated_Value_X = Exchange_Complicated_Value_X - Exchange_Complicated_Value_Y;

            // 4. User output
            Console.WriteLine($"Произошел обмен простым способом: x = {Exchange_Simple_Value_X}; y = {Exchange_Simple_Value_Y}");
            Console.WriteLine($"Произошел обмен сложным способом: x = {Exchange_Complicated_Value_X}; y = {Exchange_Complicated_Value_Y}");

            #endregion

            // Pause in order not to close application
            Console_Pause_And_Clear();

            #region Task Questionnaire center allign

            // 0. Variables
            string User_Data_CenterAllign = $"Ваши данные: Имя - {User_Name}; Фамилия - {User_Surname}; Город проживания - {User_City}";

            // 3. Data one-string output
            Console.WriteLine();

            Console.SetCursorPosition((Console.WindowWidth - User_Data_CenterAllign.Length) / 2, Console.CursorTop);

            Console.WriteLine(User_Data_CenterAllign);

            #endregion

            // Pause in order not to close application
            Console_Pause_And_Clear();

        }

        /// <summary>
        ///  Method outputs message and prompts user to type value
        /// </summary>
        /// <param name="User_Question">Message, clarifying task for the User</param>
        /// <returns>User's answer to the question</returns>
        static string Enter_Data(string User_Question) {

            // 0. Variables
            string User_Answer;

            // 1. Ask the question
            Console.Write(User_Question);

            // 2. User data input
            User_Answer = Console.ReadLine();

            return User_Answer;

        }

        /// <summary>
        /// Method calculates distance between two points on the flat
        /// </summary>
        /// <param name="Coordinate_x_1">First point x coordinate</param>
        /// <param name="Coordinate_y_1">First point y coordinate</param>
        /// <param name="Coordinate_x_2">Second point x coordinate</param>
        /// <param name="Coordinate_y_2">Second point y coordinate</param>
        /// <returns>Distance between two points</returns>
        static double Coordinates_Distance_Count(double Coordinate_x_1, double Coordinate_y_1, double Coordinate_x_2, double Coordinate_y_2)
        {

            // 0. Variable
            double Coordinates_Distance;

            // 1. Calculations
            Coordinates_Distance = Math.Sqrt(Math.Pow(Coordinate_x_2 - Coordinate_x_1, 2) + Math.Pow(Coordinate_y_2 - Coordinate_y_1, 2));

            // Return
            return Coordinates_Distance;

        }

        /// <summary>
        /// Method pauses code execution and let user to estimate everything that has been done in the code so far
        /// </summary>
        static void Console_Pause_And_Clear() {

            Console.WriteLine();
            Console.WriteLine("Нажмите Enter, чтобы продолжить...");

            // Pause in order not to close application
            Console.ReadLine();

            // Clear window for another programm
            Console.Clear();

        }

    }

}
