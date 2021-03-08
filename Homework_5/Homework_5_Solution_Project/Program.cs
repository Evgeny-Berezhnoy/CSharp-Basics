using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Homework_5_Solution_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                // 0. Preparations
                // 0.1. Greet the User
                Console.WriteLine("Домашняя работа №4.");
                Console.WriteLine();
                Console.WriteLine("Задание 1 - Проверка логина");
                Console.WriteLine("Задание 1+ - Проверка логина (с использованием регулярных выражений)");
                Console.WriteLine("Задание 2 - Класс Message");
                Console.WriteLine("Задание 3 - Проверка перестановок строк");
                Console.WriteLine("Задание 4 - Худшие ученики");
                Console.WriteLine("Задание 5 - Верно ли утверждение?");
                
                string User_Task = Enter_Data_String("Введите номер задания. Введите q для выхода из программы: ");

                switch (User_Task)
                {

                    case "q":

                        // Quit the game
                        return;

                    case "1":

                        Task_1();

                        break;

                    case "1+":

                        Task_1_Plus();

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

        static void Task_1() {

            // 0. Preparations
            // 0.1. Clear the console from things, written in console
            Console.Clear();
            Console.WriteLine("Задание №1 - проверка правильности ввода логина");
            Console.WriteLine("Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой.");
            Console.WriteLine();

            // 0.2. Variables
            string Login = Enter_Data_String("Введите логин для проверки: ");

            Console.WriteLine();
            
            StringBuilder Errors_Log = new StringBuilder();
                
            Errors_Log.AppendLine("Введенный логин содержит ошибки:");
            Errors_Log.AppendLine();

            bool Login_IsValid = true;

            // 1. Check up
            // 1.0. Login exists at the firstplace
            if (String.IsNullOrWhiteSpace(Login)) {

                // Empty string won't be checked
                Console.WriteLine("Логин не введен.");

                return;

            };

            // 1.1. It is a string with length from 2 to 10
            if ((Login.Length < 2)
                    || (Login.Length > 10)) {

                Errors_Log.AppendLine("Длина логина должна составлять от 2 до 10 символов.");

                Login_IsValid = false;

            };

            // 1.2. First symbol can't be numberic
            if (Char.IsDigit(Login[0])) {

                Errors_Log.AppendLine("Логин не должен начинаться с цифры.");

                Login_IsValid = false;

            };

            // 1.3. Check what symbol
            foreach (char Login_Symbol in Login) {

                char Login_Symbol_LowerCase = Char.ToLower(Login_Symbol);

                if (Char.IsDigit(Login_Symbol)) {

                    // Don't do anything. Symbol complies to numbers

                } else if (Login_Symbol_LowerCase == 'a'
                            || Login_Symbol_LowerCase == 'b'
                            || Login_Symbol_LowerCase == 'c'
                            || Login_Symbol_LowerCase == 'd'
                            || Login_Symbol_LowerCase == 'e'
                            || Login_Symbol_LowerCase == 'f'
                            || Login_Symbol_LowerCase == 'g'
                            || Login_Symbol_LowerCase == 'h'
                            || Login_Symbol_LowerCase == 'i'
                            || Login_Symbol_LowerCase == 'j'
                            || Login_Symbol_LowerCase == 'k'
                            || Login_Symbol_LowerCase == 'l'
                            || Login_Symbol_LowerCase == 'm'
                            || Login_Symbol_LowerCase == 'n'
                            || Login_Symbol_LowerCase == 'o'
                            || Login_Symbol_LowerCase == 'p'
                            || Login_Symbol_LowerCase == 'q'
                            || Login_Symbol_LowerCase == 'r'
                            || Login_Symbol_LowerCase == 's'
                            || Login_Symbol_LowerCase == 't'
                            || Login_Symbol_LowerCase == 'u'
                            || Login_Symbol_LowerCase == 'v'
                            || Login_Symbol_LowerCase == 'w'
                            || Login_Symbol_LowerCase == 'x'
                            || Login_Symbol_LowerCase == 'y'
                            || Login_Symbol_LowerCase == 'z') { // Only Latin symbols. Russian is not included
                    
                    // Don't do anything. Symbol complies to Latin alphabet

                } else { 
                
                    Errors_Log.AppendLine($@"{Login_Symbol} не является числом или буквой латинского алфавита.");

                    Login_IsValid = false;

                };

            };

            if (!(Login_IsValid)) {

                Console.WriteLine(Errors_Log);

            } else {

                Console.WriteLine("Логин составлен верно.");
                    
            };

        }

        static void Task_1_Plus() {

            // 0. Preparations
            // 0.1. Clear the console from things, written in console
            Console.Clear();
            Console.WriteLine("Задание №1 - проверка правильности ввода логина");
            Console.WriteLine("Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой.");
            Console.WriteLine();

            // 0.2. Variables
            string Login = Enter_Data_String("Введите логин для проверки: ");

            Regex Login_Controller_Whole        = new Regex(@"(^[A-Za-z0-9]{2,10}$)");
            Regex Login_Controller_First_Symbol = new Regex(@"(^[A-Za-z])");

            // 1. Check up
            if (Login_Controller_Whole.IsMatch(Login)
                    && Login_Controller_First_Symbol.IsMatch(Login)) {

                Console.WriteLine("Введенный пароль удовлетворяет условиям.");

            } else {

                Console.WriteLine("Введенный логин содержит ошибки.");

            };

        }

        #endregion

        #region Task 2

        static void Task_2()
        {

            // 0. Preparations
            // 0.1. Clear the console from things, written in console
            Console.Clear();
            Console.WriteLine("Задание №2 - Класс Message");
            Console.WriteLine(@"Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
а) Вывести только те слова сообщения, которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
д) *Создать метод, который производит частотный анализ текста.В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.");
            Console.WriteLine();

            // 0.2. Variables
            string Text = Enter_Data_String("Введите строку для анализа: ");

            Console.WriteLine();
            
            // 1. Count words with length, lower than 5
            Console.WriteLine(Message.Words_of_lower_length(Text, 5));
            Console.WriteLine();
            
            // 2. String without words, ending with "к"
            Console.WriteLine($"Строка без слов, оканчивающихся на букву 'к': {Message.Cut_words_ending_with(Text, "к")}");
            Console.WriteLine();

            // 3. Find the first longenst word in the Text
            Console.WriteLine($"{Message.The_Longest_Word(Text)}");
            Console.WriteLine();

            // 4. Find all the longenst words in the Text
            Console.WriteLine(Message.The_Longest_Words(Text));
            Console.WriteLine();

            // 5. Count the number of unique words
            Console.WriteLine("Частотный анализ текста.");
            Console.WriteLine();

            Dictionary<string, int> My_Dictionary = Message.FrequencyAnalysis(Text);
            
            foreach(KeyValuePair<string, int> My_Dictionary_Twain in My_Dictionary) {

                Console.WriteLine($"Слово {My_Dictionary_Twain.Key} встречается {My_Dictionary_Twain.Value} раз(-а).");

            };

        }

        #endregion

        #region Task 3

        static void Task_3()
        {

            // 0. Preparations
            // 0.1. Clear the console from things, written in console
            Console.Clear();
            Console.WriteLine("Задание №3 - Проверка перестановок строк");
            Console.WriteLine(@"Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
Например: badc являются перестановкой abcd.");
            Console.WriteLine();

            // 0.2. Variables
            String StringData_1 = Enter_Data_String("Введите 1 строку для сравнения: ");
            String StringData_2 = Enter_Data_String("Введите 2 строку для сравнения: ");

            Console.WriteLine();
            
            char[] StringData_1_Letters = StringData_1.ToCharArray();
            char[] StringData_2_Letters = StringData_2.ToCharArray();

            char StringData_1_Letters_Symbol;
            char StringData_2_Letters_Symbol;

            // 1. Calculations
            if (!(StringData_1_Letters.Length == StringData_2_Letters.Length)) {

                // Different legth in these two strings
                Console.WriteLine("Строки НЕ являются перестановками друг друга. Строки имеют разную длину");

                return;

            } else if (StringData_1_Letters.Length == 0) {

                // Different legth in these two strings
                Console.WriteLine("Введены строки нулевой длины.");

                return;

            };

            Array.Sort(StringData_1_Letters);
            Array.Sort(StringData_2_Letters);

            for (int i = 0; i < StringData_1_Letters.Length; i++) {
                
                StringData_1_Letters_Symbol = StringData_1_Letters[i];
                StringData_2_Letters_Symbol = StringData_2_Letters[i];
                
                if (!(StringData_1_Letters_Symbol.Equals(StringData_2_Letters_Symbol))) {
                    
                    // Different legth in these two strings
                    Console.WriteLine("Строки НЕ являются перестановками друг друга.");

                    return;

                };

            };

            // All symbols are equal
            Console.WriteLine("Строки являются перестановками друг друга.");
            
        }

        #endregion

        #region Task 4

        static void Task_4() {

            // 0. Preparations
            // 0.1. Clear the console from things, written in console
            Console.Clear();
            Console.WriteLine("Задание №4 - Подсчет среднего балла");
            Console.WriteLine(@"Задача ЕГЭ.
На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
< Фамилия > < Имя > < оценки >,
где < Фамилия > — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. Пример входной строки:
Иванов Петр 4 5 3
Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена..");
            Console.WriteLine();

            // 0.2. Variables
            int File_Length, Reader_Line_Number;
            int Pupils_Worst_Amount = 0;

            Dictionary<double, List<string>> Pupils_Statistics = new Dictionary<double, List<string>>();

            List<double> Pupil_Statistics_Rating = new List<double>();
            List<string> Pupil_Statistics_Data;
            
            string[] Separators = { " " };
            string[] Reader_Line_Data;
            string File_Name = AppDomain.CurrentDomain.BaseDirectory + "ExamResults.txt";
            string Reader_Line;
            
            string Pupil_Initials;

            double Pupil_Grade_1;
            double Pupil_Grade_2;
            double Pupil_Grade_3;
            double Pupil_Grade_Average;

            StreamReader Reader = new StreamReader(File_Name);

            // 1. Read the file
            // 1.1. First line contains the number of data lines in the file
            Int32.TryParse(Reader.ReadLine(), out File_Length);

            if (File_Length == 0) {

                Console.WriteLine($"Не удалось прочитать файл {File_Name}: не удалось считать количество строк данных в файле.");

                return;

            };

            // 1.2. Read data about pupils
            for (int i = 0; i < File_Length; i++) {

                Reader_Line_Number = i + 1;
                Reader_Line = Reader.ReadLine();
                Reader_Line_Data = Reader_Line.Split(Separators, StringSplitOptions.RemoveEmptyEntries);

                if (Reader_Line_Data.Length != 5) {

                    Console.WriteLine($"Строка №{Reader_Line_Number}: неверный формат строки. Данные строки не будут прочитаны.");

                    continue;

                };

                Pupil_Initials = Reader_Line_Data[0] + " " + Reader_Line_Data[1];

                if (!(Double.TryParse(Reader_Line_Data[2], out Pupil_Grade_1))) {

                    Console.WriteLine($"Строка №{Reader_Line_Number}: не удалось прочитать 1 оценку ученика. Данные оценки обнулены.");

                };

                if (!(Double.TryParse(Reader_Line_Data[3], out Pupil_Grade_2))) {

                    Console.WriteLine($"Строка №{Reader_Line_Number}: не удалось прочитать 2 оценку ученика. Данные оценки обнулены.");

                };

                if (!(Double.TryParse(Reader_Line_Data[4], out Pupil_Grade_3))) {

                    Console.WriteLine($"Строка №{Reader_Line_Number}: не удалось прочитать 3 оценку ученика. Данные оценки обнулены.");

                };

                Pupil_Grade_Average = Math.Round((Pupil_Grade_1 + Pupil_Grade_2 + Pupil_Grade_3) / 3, 2);

                if (Pupils_Statistics.ContainsKey(Pupil_Grade_Average)) {

                    // There is such average grade in stistics
                    Pupil_Statistics_Data = Pupils_Statistics[Pupil_Grade_Average];

                } else {

                    // There isn't such average grade in statistics
                    Pupil_Statistics_Rating.Add(Pupil_Grade_Average);

                    Pupils_Statistics.Add(Pupil_Grade_Average, new List<string>());

                    Pupil_Statistics_Data = Pupils_Statistics[Pupil_Grade_Average];

                };

                Pupil_Statistics_Data.Add(Pupil_Initials);

            };

            // 2. By the average grades we'll get the worst 3 pupils (or more, if they have the same average grade)
            Pupil_Statistics_Rating.Sort();

            Console.WriteLine("Худшие ученики:");

            for (int i = 0; i < Pupil_Statistics_Rating.Count; i++) {

                Pupil_Grade_Average = Pupil_Statistics_Rating[i];

                Pupil_Statistics_Data = Pupils_Statistics[Pupil_Grade_Average];

                foreach (string Pupil in Pupil_Statistics_Data) {

                    Console.WriteLine($"{Pupil}, средний балл = {Pupil_Grade_Average}");

                    Pupils_Worst_Amount++;

                };

                if (Pupils_Worst_Amount >= 3) {

                    break;

                };

            };

        }

        #endregion

        #region Task 5

        static void Task_5()
        {

            // 0. Preparations
            // 0.1. Clear the console from things, written in console
            Console.Clear();
            Console.WriteLine("Задание №5 - Верно ли утверждение?");
            Console.WriteLine(@"Написать игру «Верю. Не верю». В файле хранятся вопрос и ответ, правда это или нет. Например: «Шариковую ручку изобрели в древнем Египте», «Да». Компьютер загружает эти данные, случайным образом выбирает 5 вопросов и задаёт их игроку. Игрок отвечает Да или Нет на каждый вопрос и набирает баллы за каждый правильный ответ. Список вопросов ищите во вложении (ГДЕ?) или воспользуйтесь интернетом.");
            Console.WriteLine();

            // 0.2. Variables
            int File_Line_Number;
            int File_Line_Index;
            int User_Answers_Correct = 0;

            Dictionary<string, string> Quiz_Questions           = new Dictionary<string, string>();
            Dictionary<string, string> Quiz_Questions_For_Users = new Dictionary<string, string>();

            string File_Name = AppDomain.CurrentDomain.BaseDirectory + "Quiz_questions.txt";
            
            string[] File_Lines = File.ReadAllLines(File_Name);

            string Question_Data;

            string User_Answer;

            Random Random_Generator = new Random();

            // 1. Read the file
            // 1.1. First line contains the number of data lines in the file
            if (File_Lines.Length == 0) {

                Console.WriteLine($"Не удалось прочитать файл {File_Name}: содержимое не обнаружено.");

                return;

            };

            // 1.2. Read questions data
            for (int i = 0; i < File_Lines.Length; i++) {

                File_Line_Number = i + 1;

                Question_Data = File_Lines[i];

                if (String.IsNullOrWhiteSpace(Question_Data)) {

                    Console.WriteLine($"Строка №{File_Line_Number}: нет данных.");

                    continue;

                };

                Quiz_Questions.Add(Question_Data.Substring(2), Question_Data.Substring(0, 1));
                
            };

            // 1.3. fill the questions for user
            for (int i = 0; i < 5; i++) {

                do {

                    File_Line_Index = Random_Generator.Next(0, File_Lines.Length);

                    Question_Data = File_Lines[File_Line_Index].Substring(2);

                } while (Quiz_Questions_For_Users.ContainsKey(Question_Data));

                Quiz_Questions_For_Users.Add(Question_Data, Quiz_Questions[Question_Data]);

            };

            // 2. Ask questions from users
            Console.WriteLine("Предлагаем вам угадать, верны ли утверждения. Поставьте +, если вы согласны с утверждением, - если нет.");
            Console.WriteLine();
            
            foreach (KeyValuePair<string, string> Quiz_Question_Data in Quiz_Questions_For_Users) {

                User_Answer = Enter_Data_String($"{Quiz_Question_Data.Key}: ");                    

                if (User_Answer.Equals(Quiz_Question_Data.Value)) {

                    Console.WriteLine("Ответ верный.");
                    Console.WriteLine();
                    
                    User_Answers_Correct++;

                } else {

                    Console.WriteLine("Ответ неверный.");
                    Console.WriteLine();

                };

            };

            Console.WriteLine($"Количество правильных ответов = {User_Answers_Correct}.");
            
        }

        #endregion

        #region Common methods

        /// <summary>
        ///  Method outputs message and prompts user to type value
        /// </summary>
        /// <param name="User_Question">Message, clarifying task for the User</param>
        /// <returns>User's answer to the question</returns>
        static decimal Enter_Data_Decimal(string User_Question, decimal DefaultValue, bool NotifyIncorrectValues = true)
        {

            // 0. Variables
            string User_Answer_String;

            Decimal User_Answer;

            // 1. Ask the question
            Console.Write(User_Question);

            // 2. User data input
            User_Answer_String = Console.ReadLine();

            if (User_Answer_String.Equals("0"))
            {

                return 0;

            }
            else if (!(Decimal.TryParse(User_Answer_String, out User_Answer)))
            {

                if (NotifyIncorrectValues)
                {

                    Console.WriteLine($"Введено значение, отличное от числа. Установлено значение по умолчанию = {DefaultValue}.");

                }
                else
                {

                    Console.WriteLine("Введено значение, отличное от числа.");

                };

                return DefaultValue;

            }
            else
            {

                return User_Answer;

            };

        }

        /// <summary>
        ///  Method outputs message and prompts user to type value
        /// </summary>
        /// <param name="User_Question">Message, clarifying task for the User</param>
        /// <returns>User's answer to the question</returns>
        static int Enter_Data_Integer(string User_Question, int DefaultValue, bool NotifyIncorrectValues = true)
        {

            // 0. Variables
            string User_Answer_String;

            int User_Answer;

            // 1. Ask the question
            Console.Write(User_Question);

            // 2. User data input
            User_Answer_String = Console.ReadLine();

            if (User_Answer_String.Equals("0"))
            {

                return 0;

            }
            else if (!(Int32.TryParse(User_Answer_String, out User_Answer)))
            {

                if (NotifyIncorrectValues)
                {

                    Console.WriteLine($"Введено значение, отличное от числа. Установлено значение по умолчанию = {DefaultValue}.");

                }
                else
                {

                    Console.WriteLine("Введено значение, отличное от числа.");

                };

                return DefaultValue;

            }
            else
            {

                return User_Answer;

            };

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

    #region Classes
        
    public static class Message {

        #region Variables

        private static string[] Separators = {",", ".", "!", "?", ":", ":", " ", ", "};

        #endregion

        #region Methods

        public static string Words_of_lower_length(string String_Example, int String_Words_Length) {

            // 0. Variables
            string Words_of_lower_length = "";

            // 1. Devide the string on words
            string[] String_Example_Words = String_Example.Split(Separators, StringSplitOptions.RemoveEmptyEntries);

            // 2. Words investigation
            foreach (string String_Example_Word in String_Example_Words) {

                if (String_Example_Word.Length <= String_Words_Length) {

                    if (Words_of_lower_length.Length == 0) {

                        Words_of_lower_length = "" + Words_of_lower_length + String_Example_Word;

                    } else {

                        Words_of_lower_length = "" + Words_of_lower_length + ", " + String_Example_Word;

                    }; 

                };

            };

            if (Words_of_lower_length.Length == 0) {

                return  $"Нет слов длиной меньше {String_Words_Length}.";

            } else {

                return $"Слова длиной менее {String_Words_Length} символов: {Words_of_lower_length}";

            };

        }

        public static string Cut_words_ending_with(string String_Example, string Cut_words_Conclusion) {

            // 0. Variables
            string String_Example_Word = "";

            Regex Condition_StringConclusion = new Regex(@"[" + Cut_words_Conclusion + @"]$");
            
            // 1. Devide the string on words
            string[] String_Example_Words = String_Example.Split(Separators, StringSplitOptions.RemoveEmptyEntries);

            List<string> String_Example_Words_Satisfactory = new List<string>();

            // 2. Words investigation
            for (int i = 0; i < String_Example_Words.Length; i++) {

                String_Example_Word = String_Example_Words[i];

                if (Condition_StringConclusion.IsMatch(String_Example_Word)) {

                    String_Example_Words_Satisfactory.Add(String_Example_Word);

                };

            };

            // 3. Delete all satisfactory words from string
            foreach(string Word_Delete in String_Example_Words_Satisfactory) {

                String_Example = String_Example.Replace(Word_Delete, "");

            };

            return String_Example;

        }

        public static string The_Longest_Word(string String_Example) {

            // 0. Variables
            string String_The_Longest_Word = "";

            // 1. Devide the string on words
            string[] String_Example_Words = String_Example.Split(Separators, StringSplitOptions.None);

            // 2. Words investigation
            foreach (string String_Example_Word in String_Example_Words) {

                if (String_Example_Word.Length > String_The_Longest_Word.Length) {

                    String_The_Longest_Word = String_Example_Word;

                };

            };

            return $"Самое длинное слово в искомой строке: {String_The_Longest_Word}.";

        }

        public static StringBuilder The_Longest_Words(string String_Example) {

            // 0. Variables
            int String_Example_Longest_Length = 0;

            string String_Example_Word;
            
            // 1. Devide the string on words
            string[] String_Example_Words = String_Example.Split(Separators, StringSplitOptions.None);

            StringBuilder The_Longest_Words_String = new StringBuilder();
            
            The_Longest_Words_String.AppendLine("Самые длинные слова в последовательности:");
            
            // 2. Words investigation
            for (int i = 0; i < String_Example_Words.Length; i++) {

                String_Example_Word = String_Example_Words[i];

                if (String_Example_Word.Length > String_Example_Longest_Length) {

                    The_Longest_Words_String = new StringBuilder();
                    The_Longest_Words_String.AppendLine("Самые длинные слова в последовательности:");
                    The_Longest_Words_String.AppendLine(String_Example_Word);

                    String_Example_Longest_Length = String_Example_Word.Length;
                    
                } else if (String_Example_Word.Length == String_Example_Longest_Length) {

                    The_Longest_Words_String.AppendLine(String_Example_Word);
                    
                };

            };

            return The_Longest_Words_String;

        }

        public static Dictionary<string, int> FrequencyAnalysis(string String_Example) {
            
            // 0. Variables
            string[] String_Example_Words = String_Example.Split(Separators, StringSplitOptions.None);

            // 1. Calculations
            return FrequencyAnalysis(String_Example_Words);

        }

        public static Dictionary<string, int> FrequencyAnalysis(string[] String_Example_Words) {

            // 0. Variables
            string String_Example_Word;

            // 1. Devide the string on words
            Dictionary<string, int> My_Dictionary = new Dictionary<string, int>();

            // 2. Words investigation
            for (int i = 0; i < String_Example_Words.Length; i++) {

                String_Example_Word = String_Example_Words[i];

                if (String.IsNullOrWhiteSpace(String_Example_Word)) {

                    continue;

                };

                if (My_Dictionary.ContainsKey(String_Example_Word)) {

                    My_Dictionary[String_Example_Word] = My_Dictionary[String_Example_Word] + 1;

                } else {

                    My_Dictionary.Add(String_Example_Word, 1);

                };

            };

            return My_Dictionary;

        }


        #endregion

    }

    #endregion

}






/*1.Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) *с использованием регулярных выражений.

2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
а) Вывести только те слова сообщения, которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
д) *Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.

3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
Например:
badc являются перестановкой abcd.

4. Задача ЕГЭ.
На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
< Фамилия > < Имя > < оценки >,
где < Фамилия > — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. Пример входной строки:
Иванов Петр 4 5 3
Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.

Достаточно решить 2 задачи. Старайтесь разбивать программы на подпрограммы. Переписывайте в начало программы условие и свою фамилию. Все программы сделать в одном решении. Для решения задач используйте неизменяемые строки (string).*/