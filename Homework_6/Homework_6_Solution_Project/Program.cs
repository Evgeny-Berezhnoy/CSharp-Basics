using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6_Solution_Project {

    class Program {

        #region Delegates

        public delegate double Function_Value(double a, double x);

        public delegate bool Students_FitsTheDiscription(Student student);

        public delegate int Students_Sort_Rule(Student student_1, Student student_2);

        #endregion

        static void Main(string[] args) {
            
            while (true) {

                // 0. Preparations
                // 0.1. Greet the User
                Console.WriteLine("Домашняя работа №6.");
                Console.WriteLine();
                Console.WriteLine("Задание 1 - Вывод функций (упрощенный)");
                Console.WriteLine("Задание 2 - Вывод функций (параметризируемый)");
                Console.WriteLine("Задание 3 - Список студентов");
                
                string User_Task = Enter_Data_String("Введите номер задания. Введите q для выхода из программы: ");

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
        
        public static void Task_1() {

            // 1. Programm itself
            // 1.1. Greet the User
            Console.Clear();
            
            Console.WriteLine("Задание 1 - Вывод функций (упрощенный)");
            Console.WriteLine();

            Console.WriteLine("Таблица функции a * Sin(x), где a = 2, x = от -10 до 10, шаг = 1:");

            Table(Function_Sinusoid, 2, -10, 10);

            Console.WriteLine("Таблица функции a * x ^ 2, где a = 2, x = от -10 до 10, шаг = 1:");

            Table(Function_Parabola, 2, -10, 10);
            
        }
        
        public static void Table(Function_Value user_function, double a, double x, double b) {
            
            Console.WriteLine("----- X ----- Y -----");
            
            while (x <= b) {

                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, user_function(a, x));
            
                x++;
            
            }
            
            Console.WriteLine("---------------------");

        }
        
        #endregion

        #region Task 2

        public static void Task_2() {

            // 0. Preparations
            // 0.1. Variables
            Dictionary<string, Function_Value> functions_list = new Dictionary<string, Function_Value>();

            functions_list.Add("1", Function_InclinedLine);
            functions_list.Add("2", Function_Parabola);
            functions_list.Add("3", Function_Sinusoid);
                
            string user_Function_String;

            Function_Value user_Function;

            double user_a;
            double user_x_LeftBoundary;
            double user_x_RightBoundary;
            double user_x_Step;
            
            double[] file_values;

            double file_Minimum;

            // 1. Programm itself
            // 1.1. Greet the User
            Console.Clear();
            
            Console.WriteLine("Задание 2 - Вывод функций (параметризируемый)");
            Console.WriteLine();
            Console.WriteLine("Функция 1 - Наклонная линия (a * x)");
            Console.WriteLine("Функция 2 - Парабола (a * x * x)");
            Console.WriteLine("Функция 3 - Синусоида (a * sin(x))");
            Console.WriteLine();
            
            // 1.2. variables input
            user_a               = Enter_Data_Double("Введите значение a: ", 0);
            user_x_LeftBoundary  = Enter_Data_Double("Введите левую границу x: ", 0);
            user_x_RightBoundary = Enter_Data_Double("Введите правую границу x: ", 0);
            user_x_Step          = Enter_Data_Double("Введите шаг функции: ", 0);
            user_Function_String = Enter_Data_String("Введите номер функции (см. выше): ");
            
            switch (user_Function_String) {

                case "1":

                    user_Function = functions_list["1"];

                    break;

                case "2":

                    user_Function = functions_list["2"];

                    break;

                case "3":

                    user_Function = functions_list["3"];
                    
                    break;

                default:

                    Console.WriteLine();
                    Console.WriteLine("Введено некорректное значение номера функции.");

                    return;

            };
            
            // 2. Function data file record
            Function_SaveFiles("User_Function.bin", user_a, user_x_LeftBoundary, user_x_RightBoundary, user_x_Step, user_Function);

            // 3. Load file values
            file_values = Function_Load("User_Function.bin", out file_Minimum);

            // 4. Print file values
            Console.WriteLine();

            Console.WriteLine($"Минимальное значение функции в промежутке от {user_x_LeftBoundary} до {user_x_RightBoundary} y = {file_Minimum}");
            Console.WriteLine();

            Console.Write("Значения функции: ");
            
            foreach(double file_value in file_values) {

                Console.Write($"{file_value}; ");

            };

        }

        public static double Function_Parabola(double a, double x) {

            return a * Math.Pow(x, 2);

        }

        public static double Function_Sinusoid(double a, double x) {

            return a * Math.Sin(x);

        }
        
        public static double Function_InclinedLine(double a, double x) {

            return a * x;

        }

        public static void Function_SaveFiles(string fileName, double a, double x_LeftBoundary, double x_RightBoundary, double function_Step, Function_Value Function_Calculation) {
            
            // 1. Open up FileStream
            FileStream file_stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);

            // 2. Graph points calculation
            // 2.0. Open up bynary writer
            using (BinaryWriter bynary_writer = new BinaryWriter(file_stream)) {

                // 2.1. Immeadiate determination
                for (double x = x_LeftBoundary; x <= x_RightBoundary; x = x + function_Step) {

                    bynary_writer.Write(Function_Calculation(a, x));

                };

                bynary_writer.Close();

            };

            // 3. Close file stream
            file_stream.Close();

        }

        public static double[] Function_Load(string fileName, out double file_Minimum) {

            // 0. Preparations
            // 0.1. Variables
            double[] file_values;
            double file_CurrentValue = Double.MinValue;
            
            file_Minimum = Double.MaxValue;

            // 1. Open up FileStream
            FileStream file_stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            // 1.1. Determine the returning array
            file_values = new double[file_stream.Length / sizeof(double)];

            // 2. Graph points calculation
            // 2.0. Open up bynary reader and read values from file
            using (BinaryReader bynary_reader = new BinaryReader(file_stream)) {

                for (int i = 0; i < file_stream.Length / sizeof(double); i++) {

                    // 2.1. Read value
                    file_CurrentValue = bynary_reader.ReadDouble();

                    file_values[i] = file_CurrentValue;

                    if (file_CurrentValue < file_Minimum) {

                        file_Minimum = file_CurrentValue;

                    };

                };

                bynary_reader.Close();
            
            };

            // 3. Close file stream
            file_stream.Close();

            return file_values;

        }

        #endregion

        #region Task 3

        public static void Task_3() {

            // 0. Preparations
            // 0.1. Greet the User
            Console.Clear();
            
            Console.WriteLine("Задание 3 - Список студентов");
            Console.WriteLine();

            // 0.2. Variables
            Dictionary<int, int> students_5_6_courses_statistics            = new Dictionary<int, int>();
            Dictionary<int, int> students_18_20_years_courses_statistics    = new Dictionary<int, int>();
            
            List<Student> students_list = new List<Student>();

            Student student;

            StreamReader stream_Reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "students.csv");
            
            // 1. File data record into the array
            while (!(stream_Reader.EndOfStream)) {

                try {
                    
                    // 1.1. Read line from the file
                    string[] student_data = stream_Reader.ReadLine().Split(';');

                    // 1.2. Create student
                    student = new Student(student_data[0],
                                          student_data[1],
                                          student_data[2],
                                          student_data[3],
                                          student_data[4],
                                          Int32.Parse(student_data[5]),
                                          Int32.Parse(student_data[6]),
                                          Int32.Parse(student_data[7]),
                                          student_data[8]);

                    // 1.3. Add Student to the list
                    students_list.Add(student);

                    // 1.4. Simultaneously adding new student to dictionaries, if it fits the condition
                    Check_Student_Parameters_Compatibility(student, Student_Is_5_6_Course, student.course, students_5_6_courses_statistics);
                    Check_Student_Parameters_Compatibility(student, Student_Between_18_20_Years_Course, student.course, students_18_20_years_courses_statistics);

                }
                catch (Exception e) {

                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка! ESC - прекратить выполнение программы");

                    // Out of programm
                    if (Console.ReadKey().Key == ConsoleKey.Escape) {

                        return;

                    };

                };

            };

            // 2. Close stream_reader
            stream_Reader.Close();

            // 3. Data output
            // 3.0. Print all students
            Console.WriteLine();
            Console.WriteLine("Изначальный список студентов:");
            Console.WriteLine();
            
            foreach (Student students_list_element in students_list) {

                Console.WriteLine($"{students_list_element.lastName} {students_list_element.firstName} {students_list_element.course} курс {students_list_element.age} лет");

            };
            
            // 3.1. Print students quantity of 5 and 6 courses
            Console.WriteLine();

            foreach (KeyValuePair<int, int> students_Quantity in students_5_6_courses_statistics) {

                Console.WriteLine($"Количество студентов на {students_Quantity.Key} курсе = {students_Quantity.Value}");

            };

            // 3.2. Print students quantity between 18 and 20 years old and their courses
            Console.WriteLine();

            foreach (KeyValuePair<int, int> students_Quantity in students_18_20_years_courses_statistics) {

                Console.WriteLine($"Количество студентов на {students_Quantity.Key} курсе (от 18 до 20 лет) = {students_Quantity.Value}");

            };

            // 3.3. Sorting out students by their age
            Console.WriteLine();
            Console.WriteLine("Отсортированный по возрасту список студентов:");
            Console.WriteLine();
            
            students_list.Sort(Students_Sort_Age);

            foreach (Student students_list_element in students_list) {

                Console.WriteLine($"{students_list_element.lastName} {students_list_element.firstName} {students_list_element.age} лет");

            };

            // 3.4. Sorting out students by their course and age
            Console.WriteLine();
            Console.WriteLine("Отсортированный по курсу и возрасту список студентов:");
            Console.WriteLine();
            
            students_list.Sort(Students_Sort_Course_Age);

            foreach (Student students_list_element in students_list) {

                Console.WriteLine($"{students_list_element.lastName} {students_list_element.firstName} {students_list_element.course} курс {students_list_element.age} лет");

            };

        }

        public static void Check_Student_Parameters_Compatibility(Student student_example, Students_FitsTheDiscription Student_condition, int student_Key, Dictionary<int, int> students_fittable) {

            if (Student_condition(student_example)) {

                if (!(students_fittable.ContainsKey(student_Key))) {

                    students_fittable.Add(student_Key, 0);

                };

                students_fittable[student_Key]++;

            };

        }

        public static bool Student_Is_5_6_Course(Student student_example) {

            if (student_example.course == 5
                    || student_example.course == 6) {

                return true;

            } else {

                return false;

            };
            
        }

        public static bool Student_Between_18_20_Years_Course(Student student_example) {

            if (student_example.age >= 18
                    && student_example.age <= 20) {

                return true;

            } else {

                return false;

            };

        }

        public static int Students_Sort_Course_Age(Student student_1, Student student_2) {

            if (student_1.course > student_2.course) {

                return 1;

            } else if (student_1.course < student_2.course) {

                return -1;

            } else if (student_1.age > student_2.age) {

                return 1;

            } else if (student_1.age < student_2.age) {

                return -1;

            } else {

                return 0;

            };

        }

        public static int Students_Sort_Age(Student student_1, Student student_2) {

            if (student_1.age > student_2.age) {

                return 1;

            } else if (student_1.age < student_2.age) {

                return -1;

            } else {

                return 0;

            };

        }
        
        #endregion

        #region Common methods

        /// <summary>
        ///  Method outputs message and prompts user to type value
        /// </summary>
        /// <param name="User_Question">Message, clarifying task for the User</param>
        /// <returns>User's answer to the question</returns>
        static double Enter_Data_Double(string User_Question, double DefaultValue, bool NotifyIncorrectValues = true) {

            // 0. Variables
            string User_Answer_String;

            double User_Answer;

            // 1. Ask the question
            Console.Write(User_Question);

            // 2. User data input
            User_Answer_String = Console.ReadLine();

            if (User_Answer_String.Equals("0")) {

                return 0;

            } else if (!(Double.TryParse(User_Answer_String, out User_Answer))) {

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

    class Student {

        #region Variables

        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public string department;
        public int age;
        public int course;
        public int group;
        public string city;

        #endregion

        #region Constructor

        public Student(string firstName,
                       string lastName,
                       string university,
                       string faculty,
                       string department,
                       int age,
                       int course,
                       int group,
                       string city) {

            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.age = age;
            this.course = course;
            this.group = group;
            this.city = city;

        }
        
        #endregion

    }

}

/*1. Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double,double). Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
б) Используйте массив (или список) делегатов, в котором хранятся различные функции.
в) *Переделайте функцию Load, чтобы она возвращала массив считанных значений. Пусть она
возвращает минимум через параметр.

3. Переделать программу «Пример использования коллекций» для решения следующих задач:
а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (частотный массив);
в) отсортировать список по возрасту студента;
г) *отсортировать список по курсу и возрасту студента;
д) разработать единый метод подсчета количества студентов по различным параметрам
выбора с помощью делегата и методов предикатов.
*Достаточно решить 2 задачи. Старайтесь разбивать программы на подпрограммы. Переписывайте в начало программы условие и свою фамилию. Все программы сделайте в одном решении.*/