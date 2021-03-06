using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_Solution_Project
{
    class Program
    {
        static void Main(string[] args) {

            while (true) {

                // 0. Preparations
                // 0.1. Greet the User
                Console.WriteLine("Домашняя работа №4.");
                Console.WriteLine();
                Console.WriteLine("Задание №1 - Работа с одномерным массивом");
                Console.WriteLine("Задание №2 - Аутентификация");
                Console.WriteLine("Задание №3 - Работа с двухмерным массивом");

                string User_Task = Enter_Data_String("Введите номер задания (от 1 до 3). Введите q для выхода из программы: ");

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
            Console.WriteLine("Задание №1");
            Console.WriteLine("Продемонстрировать работу класса одномерного массива.");
            
            // 0.2. Variables
            OneDimensionArray My_Array = new OneDimensionArray(20, 382, 4);

            int Twain_Quantity = 0;
            
            // 1. Calculations
            // 1.0. Start conditions
            Console.WriteLine();
            Console.WriteLine("Чтение данных массива из файла OneDimensionArray_Example.txt.");
            Console.WriteLine();

            My_Array.File_Load(AppDomain.CurrentDomain.BaseDirectory + "OneDimensionArray_Example.txt");
            
            My_Array.Print();

            // 1.1. Searching for twains
            for (int i = 1; i < My_Array.ArrayData_Length; i++) {

                int My_Array_PreviousElement                    = My_Array.ArrayData[i - 1];
                int My_Array_ThisElement                        = My_Array.ArrayData[i];

                bool My_Array_PreviousElement_isDevidableOn_3   = ((My_Array_PreviousElement - ((My_Array_PreviousElement / 3) * 3)) == 0);
                bool My_Array_ThisElement_isDevidableOn_3       = ((My_Array_ThisElement - ((My_Array_ThisElement / 3) * 3)) == 0);
                
                if (My_Array_PreviousElement_isDevidableOn_3 || My_Array_ThisElement_isDevidableOn_3) {

                    Twain_Quantity++;

                };

            };

            Console.WriteLine();
            Console.WriteLine($"Количество пар в массиве = {Twain_Quantity}.");
            Console.WriteLine();

            // 1.2. Inversion
            Console.WriteLine();
            Console.WriteLine("Инвертирование элементов массива.");
            Console.WriteLine();
            
            My_Array.Inverse();

            My_Array.Print();

            // 1.3. Multiplication
            Console.WriteLine();
            Console.WriteLine("Умножение элементов массива на 4.");
            Console.WriteLine();
            
            My_Array.Multi(4);

            My_Array.Print();

        }

        #endregion

        #region Task 2

        static void Task_2()
        {

            // 0. Preparations
            // 0.1. Clear the console from things, written in console
            Console.Clear();
            Console.WriteLine("Задание №2 - Аутентификация");
            Console.WriteLine("Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.");
            Console.WriteLine();
            
            // 0.2. Variables
            string User_Login;
            string User_Password;

            int Attempts_Quantity = 0;
            int Attempts_Maximum = 3;

            AuthentificationData[] Logins_Data = AuthentificationData.File_Load(AppDomain.CurrentDomain.BaseDirectory + "Logins_Passwords.txt");

            // 1. User enters password
            do {

                User_Login      = Enter_Data_String("Введите ваш login: ");
                User_Password   = Enter_Data_String("Введите ваш пароль: ");

                if (Task_2_Authentificate(User_Login, User_Password, Logins_Data)) {

                    break;

                } else {

                    Console.WriteLine();
                    Console.WriteLine("Неверные учетные данные.");
                    Console.WriteLine();

                    Attempts_Quantity++;

                };

            } while (Attempts_Quantity < Attempts_Maximum);

            // 2. Result determination
            if (Attempts_Quantity < Attempts_Maximum) {

                Console.WriteLine();
                Console.WriteLine("Аутентификация пройдена.");

            } else {

                Console.WriteLine();
                Console.WriteLine("Аутентификация не пройдена. По вопросам восстановления ваших учетных данных звоните по номеру 555.");

            };

        }

        static bool Task_2_Authentificate(string User_Login, string User_Password, AuthentificationData[] Logins_Data)
        {

            // 0. Preparations
            // 1. Seeking for the fittable twain of login and password in the list
            foreach(AuthentificationData Login_Password in Logins_Data) {

                if (Login_Password.Matches(User_Login, User_Password)) {

                    return true;

                };

            };

            return false;

        }

        #endregion

        #region Task 3

        static void Task_3() {

            // 0. Preparations
            // 0.1. Clear the console from things, written in console
            Console.Clear();
            Console.WriteLine("Задание №3");
            Console.WriteLine("Реализовать класс для работы с двумерным массивом.");

            // 0.2. Variables
            TwoDimensionsArray My_Array;

            string File_Name = AppDomain.CurrentDomain.BaseDirectory + "TwoDimensionsArray.txt";

            // 1. Calculations
            // 1.0. Start conditions
            Console.WriteLine();
            Console.WriteLine("Инициализация двумерного массива.");
            Console.WriteLine();

            My_Array = new TwoDimensionsArray(8, 10, -100, 100, true);

            My_Array.Print();
            
            // 1.1. Sum above threshold
            Console.WriteLine();
            Console.WriteLine($"Сумма элементов массива выше 90 = {My_Array.Sum_AboveThreshold(90)}");
            Console.WriteLine();

            // 1.2. Unload array in text file reinit it and upload it again
            Console.WriteLine();
            Console.WriteLine($"Выгрузка массива в файл.");
            Console.WriteLine();

            My_Array.File_Unload(File_Name);

            Console.WriteLine();
            Console.WriteLine($"Массив переинициализирован.");
            Console.WriteLine();
            
            My_Array = new TwoDimensionsArray(8, 10, -100, 100, true);

            My_Array.Print();

            Console.WriteLine();
            Console.WriteLine($"Массив загружен обратно из выгруженного файла.");
            Console.WriteLine();

            My_Array.File_Load(File_Name);

            My_Array.Print();
            
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

    public class OneDimensionArray {

        #region Fields

        private int[] arrayData;
        private int arrayData_Length;

        private static int value_Minimum = -10000;
        private static int value_Maximum = 10000;

        private int sum;
        private int maximumElement;
        private int maximumElement_Quantity;
        
        public int[] ArrayData {

            get {

                return arrayData;

            }

        }
        
        public int ArrayData_Length {

            get {

                return arrayData_Length;

            }

        }

        public static int Value_Minimum {

            get {

                return value_Minimum;

            }

        }

        public static int Value_Maximum
        {

            get {

                return value_Maximum;

            }

        }

        public int Sum {

            get {

                return sum;

            }

        }

        public int MaximumElement
        {

            get
            {

                return maximumElement;

            }

        }

        public int MaximumElement_Quantity
        {

            get
            {

                return maximumElement_Quantity;

            }

        }

        #endregion

        #region Constructors

        public OneDimensionArray(int Length) {

            this.arrayData_Length   = Length;
            this.arrayData          = new int[Length];

            this.Determine_AdditionalFields();

        }

        public OneDimensionArray(int Length, int Number_Start, int Number_Step) {

            this.arrayData_Length   = Length;
            this.arrayData          = new int[Length];
    
            for (int i = 0; i < Length; i++) {

                if (Number_Start + i * Number_Step < OneDimensionArray.Value_Minimum) {

                    this.arrayData[i] = OneDimensionArray.Value_Minimum;

                } else if (Number_Start + i * Number_Step > OneDimensionArray.Value_Maximum) {

                    this.arrayData[i] = OneDimensionArray.Value_Maximum;

                } else {

                    this.arrayData[i] = Number_Start + i * Number_Step;

                };

            };

            this.Determine_AdditionalFields();

        }

        public OneDimensionArray(int Length, bool Fill_With_Random_Numbers)
        {

            this.arrayData_Length = Length;
            this.arrayData = new int[Length];

            if (Fill_With_Random_Numbers) {

                Random Randomizer = new Random();

                for (int i = 0; i < Length; i++)
                {

                    this.arrayData[i] = Randomizer.Next(OneDimensionArray.Value_Minimum, OneDimensionArray.Value_Maximum + 1);

                };

            };

            this.Determine_AdditionalFields();

        }

        public OneDimensionArray(OneDimensionArray Array_Copy) {

            Copy(Array_Copy);

        }

        public OneDimensionArray(string File_Name) {

            File_Load(File_Name);

        }

        #endregion

        #region Methods

        public void Determine_AdditionalFields() {

            this.sum                        = 0;
            this.maximumElement             = OneDimensionArray.Value_Minimum;
            this.maximumElement_Quantity    = 0;

            foreach (int ArrayData_Element in this.arrayData) {

                this.sum = this.sum + ArrayData_Element;

                if (this.maximumElement < ArrayData_Element) {

                    this.maximumElement = ArrayData_Element;
                    this.maximumElement_Quantity = 1;

                } else if (this.maximumElement == ArrayData_Element) {

                    this.maximumElement_Quantity = this.maximumElement_Quantity + 1;

                };

            };

        }

        public void Inverse() {

            for (int i = 0; i < this.arrayData_Length; i++) {

                this.arrayData[i] = 0 - this.arrayData[i];

            };

            Determine_AdditionalFields();

        }

        public void Multi(int Multiplicator) {

            for (int i = 0; i < this.arrayData_Length; i++)
            {

                if (this.arrayData[i] * Multiplicator < OneDimensionArray.Value_Minimum) {

                    this.arrayData[i] = OneDimensionArray.Value_Minimum;

                } else if (this.arrayData[i] * Multiplicator > OneDimensionArray.Value_Maximum) {

                    this.arrayData[i] = OneDimensionArray.Value_Maximum;

                } else {

                    this.arrayData[i] = this.arrayData[i] * Multiplicator;

                };

            };

            Determine_AdditionalFields();

        }

        public void File_Load(string File_Name) {

            OneDimensionArray Array_Cache = new OneDimensionArray(this);
            
            try {

                // 0. Preparations
                if (!(File.Exists(File_Name)))
                {

                    throw new Exception ($"Не удалось прочитать файл по указанному пути {File_Name}: Файл не существует.");

                };

                // 0.1. Variables
                string[] ArrayData_String = File.ReadAllLines(File_Name);

                int ArrayData_String_Number;

                // 1. Parameters determination
                this.arrayData_Length = ArrayData_String.Length;

                this.arrayData = new int[this.ArrayData_Length];

                for (int i = 0; i < this.ArrayData_Length; i++)
                {

                    if (!(Int32.TryParse(ArrayData_String[i], out ArrayData_String_Number))) {

                        throw new Exception($"Не удалось преобразовать {i} строку ({ArrayData_String[i]}) в элемент целочисленного массива.");

                    };

                    this.ArrayData[i] = ArrayData_String_Number;

                };

                Determine_AdditionalFields();

            }
            catch (Exception Error) {

                Console.WriteLine("Не удалось записать данные из файла в массив. Произошла ошибка: {0}: {1}", Error.GetType().Name, Error.Message);

                Copy(Array_Cache);

            };

        }

        public void File_Unload(string File_Name) {

            StreamWriter Stream = new StreamWriter(File_Name);

            for (int i = 0; i < this.ArrayData_Length; i++) {

                Stream.WriteLine(this.ArrayData[i].ToString());

            };

            Stream.Close();

        }

        public void Print() {

            Console.WriteLine();
            
            Console.Write("Элементы массива: ");

            foreach (int ArrayData_Element in this.ArrayData) {

                Console.Write("{0}; ", ArrayData_Element);

            };

            Console.WriteLine($"Сумма элементов массива = {this.Sum}; Максимальный элемент = {this.MaximumElement}; Количество максимальных элементов = {this.MaximumElement_Quantity}");

        }

        public void Copy(OneDimensionArray Array_Copy) {

            this.arrayData_Length           = Array_Copy.ArrayData_Length;
            this.arrayData                  = Array_Copy.ArrayData;
            this.sum                        = Array_Copy.Sum;
            this.maximumElement             = Array_Copy.MaximumElement;
            this.maximumElement_Quantity    = Array_Copy.MaximumElement_Quantity;

        }

        #endregion

    }

    public class TwoDimensionsArray {

        #region Fields

        private int arrayData_Length;
        private int arrayData_Height;
        private int[,] arrayData;
        
        private int sum;

        private int maximumElement;
        private int minimumElement;

        private Coordinate maximumElement_Coordinate = new Coordinate();
        private Coordinate minimumElement_Coordinate = new Coordinate();
       
        public int ArrayData_Length {

            get {

                return arrayData_Length;

            }

        }

        public int ArrayData_Height {

            get {

                return arrayData_Height;

            }

        }
        
        public int[,] ArrayData {

            get {

                return arrayData;

            }

        }

        public int Sum {

            get {

                return sum;

            }

        }

        public int MaximumElement {

            get {

                return maximumElement;

            }

        }

        public int MinimumElement {

            get {

                return minimumElement;

            }

        }

        public Coordinate MaximumElement_Coordinate {

            get {

                return maximumElement_Coordinate;

            }

        }

        public Coordinate MinimumElement_Coordinate {

            get {

                return minimumElement_Coordinate;

            }

        }

        #endregion

        #region Constructors

        public TwoDimensionsArray(int Length, int Height) {

            this.arrayData_Length = Length;
            this.arrayData_Height = Height;
            
            this.arrayData = new int[Length, Height];

            this.Determine_AdditionalFields();

        }

        public TwoDimensionsArray(int Length, int Height, int Number_Start, int Number_Step) {

            this.arrayData_Length = Length;
            this.arrayData_Height = Height;

            this.arrayData = new int[Length, Height];

            for (int i = 0; i < Length; i++) {

                for (int j = 0; j < Height; j++) {

                    this.arrayData[i, j] = Number_Start + Number_Step;

                    Number_Start = Number_Start + Number_Step;

                };

            };

            this.Determine_AdditionalFields();

        }

        public TwoDimensionsArray(int Length, int Height, int Value_Minimum, int Value_Maximum, bool Fill_With_Random_Numbers) {
            
            Random Randomizer = new Random();
            
            this.arrayData_Length = Length;
            this.arrayData_Height = Height;

            this.arrayData = new int[Length, Height];

            for (int i = 0; i < Length; i++) {

                for (int j = 0; j < Height; j++) {

                    this.arrayData[i, j] = Randomizer.Next(Value_Minimum, Value_Maximum + 1);
                    
                };

            };

            this.Determine_AdditionalFields();

        }

        public TwoDimensionsArray(TwoDimensionsArray Array_Copy)
        {

            Copy(Array_Copy);

        }

        public TwoDimensionsArray(string File_Name) {

            File_Load(File_Name);

        }

        #endregion

        #region Methods

        public void Determine_AdditionalFields() {

            // 0. Variables
            int ArrayData_Element;

            // 1. Override variables
            this.sum = 0;
            
            this.maximumElement = Int32.MinValue;
            this.minimumElement = Int32.MaxValue;

            this.MaximumElement_Coordinate.Point();
            this.MinimumElement_Coordinate.Point();

            // 2. Walk through array and determine additional fields
            for (int i = 0; i < this.ArrayData_Length; i++) {

                for (int j = 0; j < this.ArrayData_Height; j++) {

                    ArrayData_Element = this.arrayData[i, j];

                    this.sum = this.sum + ArrayData_Element;

                    if (ArrayData_Element > this.MaximumElement) {

                        this.maximumElement = ArrayData_Element;

                        this.MaximumElement_Coordinate.Point(i, j);

                    };

                    if (ArrayData_Element < this.MinimumElement) {

                        this.minimumElement = ArrayData_Element;

                        this.MinimumElement_Coordinate.Point(i, j);

                    };

                };

            };

        }

        public int Sum_AboveThreshold(int Value_Threshold) {
            
            int Sum_AboveThreshold = 0;

            for (int i = 0; i < this.ArrayData_Length; i++) {

                for (int j = 0; j < this.ArrayData_Height; j++) {
                    
                    if (this.arrayData[i, j] > Value_Threshold) {

                        Sum_AboveThreshold = Sum_AboveThreshold + this.arrayData[i, j];

                    };

                };

            };

            return Sum_AboveThreshold;

        }
        
        public void File_Load(string File_Name) {

            TwoDimensionsArray Array_Cache = new TwoDimensionsArray(this);

            try {

                // 0. Preparations
                if (!(File.Exists(File_Name))) {

                    throw new Exception($"Не удалось прочитать файл по указанному пути {File_Name}: Файл не существует.");

                };

                // 0.1. Variables
                string[] ArrayData_String = File.ReadAllLines(File_Name);

                int[] Array_Elements = new int[ArrayData_String.Length];

                Coordinate Array_Coordinate_Maximum = new Coordinate();

                int File_String_Position_OpenBracket;
                int File_String_Position_DotComma;
                int File_String_Position_CloseBracket;
                int File_String_Position_Bicle;

                int File_String_Coordinate_X;
                int File_String_Coordinate_Y;
                int File_String_Element;

                int Array_Elements_Index = -1;

                // 1. Come through array to designate numbers from it and remember Length and the Height of uppermentioned
                for (int i = 0; i < ArrayData_String.Length; i++) {

                    int File_String_Number = i + 1;

                    string File_String = ArrayData_String[i];
                    
                    File_String_Position_OpenBracket    = File_Load_StringPosition(File_String, File_String_Number, "(");
                    File_String_Position_DotComma       = File_Load_StringPosition(File_String, File_String_Number, ";");
                    File_String_Position_CloseBracket   = File_Load_StringPosition(File_String, File_String_Number, ")");
                    File_String_Position_Bicle          = File_Load_StringPosition(File_String, File_String_Number, "=");

                    File_String_Coordinate_X    = File_Load_GetValue(File_String, File_String_Number, File_String_Position_OpenBracket + 1, File_String_Position_DotComma);
                    File_String_Coordinate_Y    = File_Load_GetValue(File_String, File_String_Number, File_String_Position_DotComma + 1, File_String_Position_CloseBracket);
                    File_String_Element         = File_Load_GetValue(File_String, File_String_Number, File_String_Position_Bicle + 1);
                    
                    if (Array_Coordinate_Maximum.X < File_String_Coordinate_X) {

                        Array_Coordinate_Maximum.Point(File_String_Coordinate_X, Array_Coordinate_Maximum.Y);

                    };

                    if (Array_Coordinate_Maximum.Y < File_String_Coordinate_Y) {

                        Array_Coordinate_Maximum.Point(Array_Coordinate_Maximum.X, File_String_Coordinate_Y);

                    };

                    Array_Elements[i] = File_String_Element;

                };

                // 2. Setting fields of this array
                this.arrayData_Length   = Array_Coordinate_Maximum.X + 1;
                this.arrayData_Height   = Array_Coordinate_Maximum.Y + 1;
                this.arrayData          = new int[arrayData_Length, arrayData_Height];

                for (int i = 0; i < this.ArrayData_Length; i++) {

                    for (int j = 0; j < this.ArrayData_Height; j++) {

                        Array_Elements_Index = Array_Elements_Index + 1;

                        this.arrayData[i, j] = Array_Elements[Array_Elements_Index];

                    };

                };

                Determine_AdditionalFields();

            }
            catch (Exception Error) {

                Console.WriteLine("Не удалось записать данные из файла в массив. Произошла ошибка: {0}: {1}", Error.GetType().Name, Error.Message);

                Copy(Array_Cache);

            };

        }

        private int File_Load_StringPosition(string String_Source, int String_Number, string String_Search) {

            int String_Search_Position = String_Source.IndexOf(String_Search);

            if (String_Search_Position == -1) {

                throw new Exception($"Не удалось найти подстроку {String_Search} в строке №{String_Number} для определения элементов массива.");

            };

            return String_Search_Position;
        }

        private int File_Load_GetValue(string String_Source, int String_Number, int Index_Start, int Index_Finish = -1)
        {
            // 0. Variables
            string Value_String;

            int Value;

            // 1. Finding string, containing value
            if (Index_Finish == -1) {

                Value_String = String_Source.Substring(Index_Start);

            } else {

                Value_String = String_Source.Substring(Index_Start, Index_Finish - Index_Start);

            };

            // 2. Getting int value
            if (!(Int32.TryParse(Value_String, out Value))) {

                throw new Exception($"Не удалось преобразовать в строке №{String_Number} строку ({Value_String}) в целочисленное значение.");

            };

            return Value;

        }

        public void File_Unload(string File_Name) {

            StreamWriter Stream = new StreamWriter(File_Name);

            for (int i = 0; i < this.ArrayData_Length; i++) {

                for (int j = 0; j < this.ArrayData_Height; j++) {

                    Stream.WriteLine("({0};{1})={2}", i, j, this.arrayData[i, j]);

                };

            };

            Stream.Close();

        }

        public void Print()
        {

            Console.WriteLine();
            Console.WriteLine("Элементы массива: ");

            for (int i = 0; i < this.ArrayData_Length; i++) {

                for (int j = 0; j < this.ArrayData_Height; j++) {

                    Console.Write("{0} ", this.arrayData[i, j]);

                };

                Console.WriteLine();

            };

            Console.WriteLine();
            Console.WriteLine($"Сумма элементов массива = {this.Sum}");
            Console.WriteLine($"Максимальный элемент = {this.MaximumElement}: Координата = {this.MaximumElement_Coordinate}");
            Console.WriteLine($"Минимальный элемент = {this.MinimumElement}: Координата = {this.MinimumElement_Coordinate}");
            
        }

        public void Copy(TwoDimensionsArray Array_Copy)
        {

            this.arrayData_Length   = Array_Copy.ArrayData_Length;
            this.arrayData_Height   = Array_Copy.arrayData_Height;
            this.arrayData          = Array_Copy.ArrayData;
            
            this.sum                = Array_Copy.Sum;
            
            this.maximumElement     = Array_Copy.MaximumElement;
            this.minimumElement     = Array_Copy.MinimumElement;

            this.MaximumElement_Coordinate.Point(Array_Copy.MaximumElement_Coordinate);
            this.MinimumElement_Coordinate.Point(Array_Copy.MinimumElement_Coordinate);
    }

        #endregion

    }

    public class Coordinate {

        #region Variables

        private int x;
        private int y;

        public int X {

            get {

                return x;

            }

        }

        public int Y {

            get {

                return y;

            }

        }

        #endregion

        #region Constructors

        public Coordinate() {

            Point(0, 0);

        }

        public Coordinate(int Coordinate_X, int Coordinate_Y)
        {

            Point(Coordinate_X, Coordinate_Y);

        }

        #endregion

        #region Methods

        public void Point(int Coordinate_X, int Coordinate_Y) {

            this.x = Coordinate_X;
            this.y = Coordinate_Y;

        }

        public void Point(Coordinate Coordinate_Copy) {

            this.x = Coordinate_Copy.X;
            this.y = Coordinate_Copy.Y;

        }

        public void Point() {

            this.x = Int32.MinValue;
            this.y = Int32.MinValue;

        }

        public override string ToString() {

            return $"({this.X}:{this.Y})";
        
        }

        #endregion

    }

    public class AuthentificationData {

        #region Variables

        private string login;
        private string password;

        public string Login {

            get {

                return login;

            }

        }

        public string Password {

            get {

                return password;

            }

        }

        #endregion

        #region Constructors

        public AuthentificationData(string User_Login, string User_Password) {

            this.login      = User_Login;
            this.password   = User_Password;

        }

        #endregion

        #region Methods

        public bool Matches(string User_Login, string User_Password) {

            return ((this.Login == User_Login)
                        && (this.Password == User_Password));

        }
        
        public static AuthentificationData[] File_Load(string File_Name) {

            AuthentificationData[] Logins_Data;
            
            try {

                // 0. Preparations
                if (!(File.Exists(File_Name))) {

                    throw new Exception($"Не удалось прочитать файл по указанному пути {File_Name}: Файл не существует.");

                };

                // 0.1. Variables
                string[] AuthentificationData_String = File.ReadAllLines(File_Name);

                Logins_Data = new AuthentificationData[AuthentificationData_String.Length];

                int File_String_Position_Login;
                int File_String_Position_DotComma;
                int File_String_Position_Password;

                string File_String_Login;
                string File_String_Password;

                // 1. Come through array to designate numbers from it and remember Length and the Height of uppermentioned
                for (int i = 0; i < AuthentificationData_String.Length; i++) {

                    string AuthentificationData_String_Element = AuthentificationData_String[i];

                    int File_String_Number = i + 1;

                    File_String_Position_Login      = File_Load_StringPosition(AuthentificationData_String_Element, File_String_Number, "Login:");
                    File_String_Position_DotComma   = File_Load_StringPosition(AuthentificationData_String_Element, File_String_Number, ";");
                    File_String_Position_Password   = File_Load_StringPosition(AuthentificationData_String_Element, File_String_Number, "Password:");

                    File_String_Login               = File_Load_GetValue(AuthentificationData_String_Element, File_String_Number, File_String_Position_Login, File_String_Position_DotComma - 1);
                    File_String_Password            = File_Load_GetValue(AuthentificationData_String_Element, File_String_Number, File_String_Position_Password);

                    Logins_Data[i]                  = new AuthentificationData(File_String_Login, File_String_Password);

                };
                
            }
            catch (Exception Error) {

                Console.WriteLine("Не удалось прочитать данные аутентификации из файла. Произошла ошибка: {0}: {1}", Error.GetType().Name, Error.Message);

                Logins_Data = new AuthentificationData[0];

            };

            return Logins_Data;

        }

        private static int File_Load_StringPosition(string String_Source, int String_Number, string String_Search, int String_StartIndex = 0, bool ReturnEndPosition = true) {

            int String_Search_Position;

            if (String_StartIndex == 0) {

                String_Search_Position = String_Source.IndexOf(String_Search);

            } else {

                String_Search_Position = String_Source.IndexOf(String_Search, String_StartIndex);

            };

            if (String_Search_Position == -1) {

                throw new Exception($"Не удалось найти подстроку {String_Search} в строке №{String_Number} для определения данных учетной записи.");

            };

            if (ReturnEndPosition) {

                return String_Search_Position + String_Search.Length;

            } else {

                return String_Search_Position;

            };

        }

        private static string File_Load_GetValue(string String_Source, int String_Number, int Index_Start, int Index_Finish = -1)
        {
            // 0. Variables
            string Value_String;

            // 1. Finding string, containing value
            if (Index_Finish == -1) {

                Value_String = String_Source.Substring(Index_Start);

            } else {

                Value_String = String_Source.Substring(Index_Start, Index_Finish - Index_Start);

            };

            // 2. Check up
            if (String.IsNullOrEmpty(Value_String)) {

                throw new Exception($"Не удалось получить данные в строке №{String_Number}: Получена пустая строка.");

            };

            return Value_String;

        }

        #endregion

    }

    #endregion
}
