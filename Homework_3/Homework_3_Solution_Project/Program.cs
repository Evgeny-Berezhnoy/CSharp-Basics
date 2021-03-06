using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_Solution_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                // 0. Preparations
                // 0.1. Greet the User
                Console.WriteLine("Домашняя работа №3.");
                Console.WriteLine();
                Console.WriteLine("Задание №1 - Выявление минимального числа из трех введенных");
                Console.WriteLine("Задание №2 - Выявление количества цифр введенного числа");
                Console.WriteLine("Задание №3 - Расчет суммы положительных нечетных чисел");
                
                string User_Task = Enter_Data_String("Введите номер задания (от 1 до 3). Введите q для выхода из программы: ");

                switch (User_Task)
                {

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
            Console.WriteLine("Задание №1 - создание и демонстрация работы классов комплексных чисел.");
            Console.WriteLine("Написать класс Complex, добавив методы сложения, вычитания и произведения чисел. Проверить работу класса.");
            Console.WriteLine("Задание №1 - создание и демонстрация работы классов комплексных чисел.");
            Console.WriteLine();

            // 0.2. Variables
            decimal Complex_1_Real      = Enter_Data_Decimal("Введите действительную часть 1 числа: ", 0);
            decimal Complex_1_Imagine   = Enter_Data_Decimal("Введите мнимую часть 1 числа: ", 0);
            decimal Complex_2_Real      = Enter_Data_Decimal("Введите действительную часть 2 числа: ", 0);
            decimal Complex_2_Imagine   = Enter_Data_Decimal("Введите мнимую часть 2 числа: ", 0);
            
            Complex Complex_1 = new Complex(Complex_1_Real, Complex_1_Imagine);
            Complex Complex_2 = new Complex(Complex_2_Real, Complex_2_Imagine);

            // 1. Calculations
            Console.WriteLine();
            Console.WriteLine("Число 1: {0}", Complex_1.toString());
            Console.WriteLine("Число 2: {0}", Complex_2.toString());
            Console.WriteLine();
            Console.WriteLine("Результат сложения чисел 1 и 2: {0}", Complex.Add(Complex_1, Complex_2).toString());
            Console.WriteLine("Результат вычитания из числа 1 числа 2: {0}", Complex.Subtract(Complex_1, Complex_2).toString());
            Console.WriteLine("Результат умножения чисел 1 и 2: {0}", Complex.Multiple(Complex_1, Complex_2).toString());
            
        }

        #endregion

        #region Task 2

        static void Task_2()
        {

            // 0. Preparations
            // 0.1. Clear the console from things, written in console
            Console.Clear();
            Console.WriteLine("Задание №2 - Расчет суммы положительных нечетных чисел");
            Console.WriteLine("а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;");
            Console.WriteLine("б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. При возникновении ошибки вывести сообщение. Напишите соответствующую функцию.");
            Console.WriteLine();

            // 0.2. Variables
            int Numbers_PositiveOddTotal = 0;

            int Number;

            // 1. Entering numbers
            while (true)
            {

                Number = Enter_Data_Integer("Введите число (0 - выход): ", -1, false);

                if ((Number > 0)
                      && ((Number % 2) > 0))
                {

                    // If we have positive odd number
                    Numbers_PositiveOddTotal = Numbers_PositiveOddTotal + Number;

                }
                else if (Number == 0)
                {

                    break;

                }

            };

            // 2. User's numbers total output
            Console.WriteLine();
            Console.WriteLine($"Сумма введенных вами позитивных нечетных чисел = {Numbers_PositiveOddTotal}");

        }

        #endregion

        #region Task 3

        static void Task_3()
        {

            // 0. Preparations
            // 0.1. Clear the console from things, written in console
            Console.Clear();
            Console.WriteLine("Задание №3 - Выявление количества цифр введенного числа");
            Console.WriteLine("*Описать класс дробей -рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса. Достаточно решить 2 задачи. Все программы сделать в одном решении.");
            Console.WriteLine("**Добавить проверку, чтобы знаменатель не равнялся 0.Выбрасывать исключение. ArgumentException(Знаменатель не может быть равен 0)");
            Console.WriteLine("Добавить упрощение дробей.");
            Console.WriteLine();

            // 0.2. Variables
            int Fraction_1_Divident     = Enter_Data_Integer("Введите числитель 1 числа: ", 1);
            int Fraction_1_Denominator  = Enter_Data_Integer("Введите знаменатель 1 числа: ", 1);
            int Fraction_2_Divident     = Enter_Data_Integer("Введите числитель 2 числа: ", 1);
            int Fraction_2_Denominator  = Enter_Data_Integer("Введите знаменатель 2 числа: ", 1);

            Fraction Fraction_1;
            Fraction Fraction_2;

            try {

                Fraction_1 = new Fraction(Fraction_1_Divident, Fraction_1_Denominator);
                Fraction_2 = new Fraction(Fraction_2_Divident, Fraction_2_Denominator);
                
                // 1. Calculations
                Console.WriteLine();
                Console.WriteLine("Дробь 1: {0}", Fraction_1.toString());
                Console.WriteLine("Дробь 2: {0}", Fraction_2.toString());
                Console.WriteLine();
                Console.WriteLine("Результат сложения дробей 1 и 2: {0}", Fraction.Add(Fraction_1, Fraction_2).toString());
                Console.WriteLine("Результат вычитания из дроби 1 дроби 2: {0}", Fraction.Subtract(Fraction_1, Fraction_2).toString());
                Console.WriteLine("Результат умножения дробей 1 и 2: {0}", Fraction.Multiple(Fraction_1, Fraction_2).toString());
                Console.WriteLine("Результат деления дроби 1 на дробь 2: {0}", Fraction.Devide(Fraction_1, Fraction_2).toString());

            }
            catch (ArgumentException e)
            {

                Console.WriteLine("Не удалось выполнить операции с дробями. Произошла ошибка: {0}: {1}", e.GetType().Name, e.Message);

                return;

            };

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
        static int Enter_Data_Integer(string User_Question, int DefaultValue, bool NotifyIncorrectValues = true) {

            // 0. Variables
            string User_Answer_String;
            
            int User_Answer;
            
            // 1. Ask the question
            Console.Write(User_Question);

            // 2. User data input
            User_Answer_String = Console.ReadLine();

            if (User_Answer_String.Equals("0")) {

                return 0;

            } else if (!(Int32.TryParse(User_Answer_String, out User_Answer))) {

                if (NotifyIncorrectValues) {

                    Console.WriteLine($"Введено значение, отличное от числа. Установлено значение по умолчанию = {DefaultValue}.");

                } else {

                    Console.WriteLine("Введено значение, отличное от числа.");

                };
                
                return DefaultValue;

            } else {

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

    class Complex {

        // 1. Fields
        private decimal Real;
        private decimal Imagine;

        // 1.1. Fields designation - no neccessarity

        // 2. Constructor
        public Complex (decimal Real, decimal Imagine) {

            this.Real       = Real;
            this.Imagine    = Imagine;

        }

        public Complex(Complex Complex_Copy)
        {

            this.Real       = Complex_Copy.Real;
            this.Imagine    = Complex_Copy.Imagine;

        }

        // 3. Methods
        public static Complex Add(Complex Complex_1, Complex Complex_2) {

            // 0. Variables
            Complex Complex_Result = new Complex(Complex_1);

            // 1. Calculation
            Complex_Result.Real      = Complex_Result.Real + Complex_2.Real;
            Complex_Result.Imagine   = Complex_Result.Imagine + Complex_2.Imagine;

            return Complex_Result;

        }

        public static Complex Subtract(Complex Complex_1, Complex Complex_2)
        {

            // 0. Variables
            Complex Complex_Result = new Complex(Complex_1);

            // 1. Calculation
            Complex_Result.Real     = Complex_Result.Real - Complex_2.Real;
            Complex_Result.Imagine  = Complex_Result.Imagine - Complex_2.Imagine;

            return Complex_Result;

        }

        public static Complex Multiple(Complex Complex_1, Complex Complex_2)
        {
            // 0. Variables
            Complex Complex_Result = new Complex(Complex_1);

            // 1. Calculation
            Complex_Result.Real       = (Complex_1.Real * Complex_2.Real) - (Complex_1.Imagine * Complex_2.Imagine);
            Complex_Result.Imagine    = (Complex_1.Imagine * Complex_2.Real) + (Complex_1.Real * Complex_2.Imagine);

            return Complex_Result;

        }

        public string toString() {

            if (this.Imagine > 0) { 
                
                return string.Format("{0} + {1}i", this.Real, this.Imagine);

            } else if (this.Imagine < 0) {

                return string.Format("{0} - {1}i", this.Real, 0 - this.Imagine);

            } else {

                return string.Format("{0}", this.Real);

            };

        }

    }

    class Fraction
    {

        // 1. Fields
        private int dividend;
        private int denominator;

        // 1.1. Fields designation - no neccessarity
        public int Dividend{

            set {

                dividend = value;
                
            }

            get {

                return dividend;

            }
        
        }

        public int Denominator
        {

            set {

                if (value < 0) {

                    this.Dividend = 0 - this.Dividend;

                    denominator = 0 - value;

                }
                else if (value == 0) {

                    throw new ArgumentException(String.Format("Знаменатель должен быть больше 0."));

                } else {
                   
                    denominator = value;

                };

            }

            get {

                return denominator;

            }

        }

        // 2. Constructor
        public Fraction(int dividend, int denominator) {

            this.Dividend       = dividend;
            this.Denominator    = denominator;

        }

        public Fraction(Fraction Fraction_Copy)
        {

            this.Dividend = Fraction_Copy.Dividend;
            this.Denominator = Fraction_Copy.Denominator;

        }

        // 3. Methods
        public static Fraction Add(Fraction Fraction_1, Fraction Fraction_2) {

            // 0. Preparations
            // 0.1. Setting coomon denominator for both fractions
            Fraction.SetCommonDenominator(Fraction_1, Fraction_2);

            // 0.2. Creating return reference
            Fraction Fraction_Result = new Fraction(Fraction_1);

            // 2. Immediate calculation 
            Fraction_Result.Dividend = Fraction_1.Dividend + Fraction_2.Dividend;

            // 3. Simplification
            Fraction_1.Simplify();
            Fraction_2.Simplify();
            Fraction_Result.Simplify();

            return Fraction_Result;

        }

        public static Fraction Subtract(Fraction Fraction_1, Fraction Fraction_2) {

            // 0. Preparations
            // 0.1. Setting coomon denominator for both fractions
            Fraction.SetCommonDenominator(Fraction_1, Fraction_2);

            // 0.2. Creating return reference
            Fraction Fraction_Result = new Fraction(Fraction_1);

            // 2. Immediate calculation 
            Fraction_Result.Dividend = Fraction_1.Dividend - Fraction_2.Dividend;

            // 3. Simplification
            Fraction_1.Simplify();
            Fraction_2.Simplify();
            Fraction_Result.Simplify();

            return Fraction_Result;

        }

        public static Fraction Multiple(Fraction Fraction_1, Fraction Fraction_2) {
            // 0. Preparations
            Fraction Fraction_Result = new Fraction(Fraction_1);

            // 1. Immediate calculation 
            Fraction_Result.Dividend       = Fraction_Result.Dividend * Fraction_2.Dividend;
            Fraction_Result.Denominator    = Fraction_Result.Denominator * Fraction_2.Denominator;

            // 2. Simplification
           Fraction_Result.Simplify();

            return Fraction_Result;

        }

        public static Fraction Devide(Fraction Fraction_1, Fraction Fraction_2) {

            // 0. Preparations
            Fraction Fraction_Result = new Fraction(Fraction_1);

            // 1. Immediate calculation 
            Fraction_Result.Dividend       = Fraction_Result.Dividend * Fraction_2.Denominator;
            Fraction_Result.Denominator    = Fraction_Result.Denominator * Fraction_2.Dividend;

            // 2. Simplification
            Fraction_Result.Simplify();

            return Fraction_Result;

        }

        public string toString()
        {

            return string.Format("{0}/{1}", this.Dividend, this.Denominator);

        }

        public static void SetCommonDenominator(Fraction Fraction_1, Fraction Fraction_2) {

            // 0.1. Examination
            if (Fraction_1.Denominator == Fraction_2.Denominator)
            {

                // No need to set common Denominator
                return;

            };

            // 0.2. Variables
            int CommonDenominator = Fraction_1.Denominator * Fraction_2.Denominator;

            // 1. Set dividends for both fractions
            Fraction_1.Dividend = Fraction_1.Dividend * Fraction_2.Denominator;
            Fraction_2.Dividend = Fraction_2.Dividend * Fraction_1.Denominator;

            // 2. Set common denominator for both fractions
            Fraction_1.Denominator = CommonDenominator;
            Fraction_2.Denominator = CommonDenominator;

        }

        public void Simplify() {

            // 0. Preparations
            // 0.1. Variables
            List<int> List_MultiplicationMembers_Divident       = this.Simplify_Break_down_Number(this.Dividend);
            List<int> List_MultiplicationMembers_Denomenator    = this.Simplify_Break_down_Number(this.Denominator);

            int List_MultiplicationMembers_Divident_Member;
            
            // 1. Breaking down the numbers
            for (int List_MultiplicationMembers_Divident_Index = 1 - List_MultiplicationMembers_Divident.Count;
                        List_MultiplicationMembers_Divident_Index <= 0;
                        List_MultiplicationMembers_Divident_Index++) {

                List_MultiplicationMembers_Divident_Member = List_MultiplicationMembers_Divident.ElementAt(0 - List_MultiplicationMembers_Divident_Index);

                if ((List_MultiplicationMembers_Divident_Member == 0)
                        || (List_MultiplicationMembers_Divident_Member) == 1) {

                    continue;

                } else if (List_MultiplicationMembers_Denomenator.Contains(List_MultiplicationMembers_Divident_Member)) {

                    List_MultiplicationMembers_Divident.Remove(List_MultiplicationMembers_Divident_Member);
                    List_MultiplicationMembers_Denomenator.Remove(List_MultiplicationMembers_Divident_Member);

                };

            };

            // 2. Redefine the parts of the fraction
            // 2.1. Divident
            this.Dividend = 1;
            
            foreach(int Fraction_Example_Divident_Member in List_MultiplicationMembers_Divident) {

                this.Dividend = this.Dividend * Fraction_Example_Divident_Member;

            };

            // 2.2. Denominator
            this.Denominator = 1;

            foreach (int Fraction_Example_Denominator_Member in List_MultiplicationMembers_Denomenator)
            {

                this.Denominator = this.Denominator * Fraction_Example_Denominator_Member;

            };

        }

        private List<int> Simplify_Break_down_Number(int Number) {

            List<int> List_MultiplicationMembers = new List<int>();

            int Number_Multiplication_Member = 2;

            if (Number < 0) {

                List_MultiplicationMembers.Add(-1);

                Number = 0 - Number;

            } else {

                List_MultiplicationMembers.Add(1);

            };

            while (true) {

                if ((Number == 0)) {

                    List_MultiplicationMembers.Add(0);

                    break;

                } else if (Number == 1) {

                    break;

                } else if (((Number / Number_Multiplication_Member) * Number_Multiplication_Member) == Number) {

                    List_MultiplicationMembers.Add(Number_Multiplication_Member);

                    Number = Number / Number_Multiplication_Member;

                } else {

                    Number_Multiplication_Member = Number_Multiplication_Member + 1;

                };

            };

            return List_MultiplicationMembers;

        }


    }

    #endregion

}