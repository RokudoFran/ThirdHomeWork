using System;

namespace ThirdHomeWork
{
    class Tasks
    {
        //Пользователь вводит 2 числа (A и B). Возвести число A в степень B.
        public static string Еxercise1(int b, double a)
        {
            double c = 1;
            int b1 = Math.Abs(b);
            string message = "";

            if (a == 0)
            {
                message = "Введите число А не равное нулю";
            }
            else
            {
                if (b == 0)
                {
                    message = $" Число А = {a} в степени B = {b}, равно {c}";
                }
                else
                {
                    for (int i = 1; i <= b1; i++)
                    {
                        c *= a;
                    }

                    if (b > 0)
                    {
                        message = $" Число А = {a} в степени B = {b}, равно {c}";
                    }
                    else
                    {
                        c = 1 / c;
                        message = $" Число А = {a} в степени B = {b}, равно {c}";
                    }
                }
            }

            return message;

        }

        //Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.
        public static int[] Еxercise2(int a)
        {
            int lengthM = 0;
            int[] result = new int[lengthM];
            int n = 0;

            if ( a == 0 )
            {
                throw new DivideByZeroException(" Число a равно нулю ");
            }
            else
            {
                if ( Math.Abs(a) < 1000 )
                {
                    lengthM = a / 1000;

                    for (int i = 1; i <= 1000; i++)
                    {
                        if (i % a == 0)
                        {
                            result[n] = i;
                            n++;
                        }
                    }
                }
                else
                {
                    throw new DivideByZeroException($" Число A = {a} больше 1000 ");
                }
                
            }

            return result;
        }

        //Пользователь вводит 1 число(A). Найдите количество положительных целых чисел, квадрат которых меньше A.
        public static string Еxercise3(int a)
        {
            string message = "";

            if (a <= 0)
            {
                message = $" Число A меньше, либо равно нулю ";
            }
            else
            {
                int b = 1;

                while (b * b < a)
                {
                    b++;
                }

                message = $" Количество положительных целых чисел, квадрат которых меньше A = {a}, равно {b-1} ";
            }

            return message;

        }

        //Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
        public static string Еxercise4(int a)
        {
            int b;
            int delitel = 0;
            string message = "";

            if (a == 0)
            {
                message = $" Число A равно нулю ";
            }
            else
            {
                for (int i = 2; i * 2 < a; i++)
                {
                    if (a % i == 0)
                    {
                        b = a / i;
                        if (b > delitel)
                        {
                            delitel = b;
                            message = $" Наибольшим делителем числа А = {a}, кроме самого числа А, является число равное {b}";
                        }
                    }
                }
            }

            return message;
        }

        //Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).
        public static string Еxercise5(int a, int b)
        {
            int niz = 0;
            int verh = 0;
            int c = 0;
            string message = "";

            if (a == 0 && b == 0)
            {
                message = $"Числа A и B равны нулю";
            }
            else
            {
                if (a < b)
                {
                    niz = a;
                    verh = b;
                }
                else
                {
                    niz = b;
                    verh = a;
                }

                for (int i = niz; i <= verh; i++)
                {
                    if (i % 7 == 0)
                    {
                        c += i;
                    }
                }

                message = $" Сумма всех чисел из диапазона от A = {a} до B = {b} , которые делятся без остатка на 7, равна {c} ";
            }

            return message;
        }

        //Пользователь вводит 1 число (N). Выведите N-ое число ряда фибоначчи. В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1.
        public static string Еxercise6(int n)
        {
            int a = 1;
            int b = 1; 
            int c = 1;

            string message = "";

            if (n == 0)
            {
                message = $" {n} число ряда Фибоначи равно 0 ";
            }
            else if (n > 0)
            {
                for (int i = 1; i < n - 1; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    message = $" {n} число ряда Фибоначи равно {c} ";
                }
            }
            else
            {
                b = -1;
                
                for (int i = -1; i < n + 1; i--)
                {
                    c = a - b;
                    a = b;
                    b = c;

                    message = $" {n} число ряда Фибоначи равно {c} ";
                    
                }
            }


            return message;
        }

        //Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.
        public static string Еxercise7 (float a, float b)
        {
            float nod = Math.Abs(a + b);
            float nodo = -nod;
            string message = "";

            if (a == 0 || b == 0)
            {
                message = $"Число A или/и B равно нулю";
            }
            else
            {
                while ((a != 0) && (b != 0))
                {
                    if (Math.Abs(a) > Math.Abs(b))
                    {
                        a = a % b;
                    }
                    else
                    {
                        b = b % a;
                    }
                }

                nod = Math.Abs(a + b);
                nodo = -nod;

                message = $" Наибольший общий делитель чисел А = {a} и B = {b} равен ({nod};{nodo}) ";
            }

            return message;
        }

        //Пользователь вводит целое положительное число, которое является кубом целого числа N. Найдите число N методом половинного деления.
        public static string Еxercise8 (int a)
        {
            int prav = a;
            int lev = 0;
            int centr = a / 2;
            string message = "";

            if ( ( a == 0 ) || ( a < 0 ))
            {
                message = "Число A меньше либо равно нулю";
            }
            else
            {
                while (centr * centr * centr != a)
                {
                    if (lev < prav)
                    {
                        centr = (prav + lev) / 2;
                        if (centr * centr * centr > a)
                        {
                            prav = centr;
                        }
                        else
                        {
                            lev = centr;
                        }

                        message = $" Число А = {a} является кубом числа {centr}";
                    }
                    else
                    {
                        centr = lev;
                        centr = (prav + lev) / 2;
                        message = $" Число А = {a} является кубом числа {centr}";
                    }
                }
            }

            return message;
        }

        //Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
        public static string Еxercise9(int a)
        {
            int nechet = 0;
            int chet = 0;
            string message = "";

            if (a == 0)
            {
                message = "Число A равно нулю";
            }
            else
            {
                while (Math.Abs(a) > 0)
                {
                    if (a % 2 != 0)
                    {
                        nechet++;
                        a = a / 10;

                        message = $" Кол-во нечетных чисел числа A = {a} равно {nechet}";
                    }
                    else
                    {
                        chet++;
                        a = a / 10;
                    }
                }
            }

            return message;
        }

        //Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321.
        public static int Еxercise10(int a)
        {
            int a1 = Math.Abs(a);
            int b = 0;
            int zer = 0;
            string message = "";

            if (a == 0)
            {
                message = "Число A равно нулю";
            }
            else
            {
                while (a1 > 0)
                {
                    b = a1 % 10;
                    zer = zer * 10 + b;
                    a1 = a1 / 10;

                }

                if (a > 0)
                {
                    zer = Math.Abs(zer);

                    message = $" Зеркальным отображением числа A={a} является число {zer}";
                }
                else
                {
                    zer = -zer;

                    message = $" Зеркальным отображением числа A={a} является число {zer}";
                }
            }

            return zer;
        }

        //Пользователь вводит целое положительное  число (N). Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных. 
        public static string Еxercise11(int a)
        {
            int n = 0;
            int nechet = 0;
            int chet = 0;

            string message = "";

            if (a < 0 || a == 0)
            {
                message = "Число A меньше, либо равно нулю";
            }
            else
            {
                for (int i = 1; i <= a; i++)
                {

                    int tmp = i;

                    while (tmp > 0)
                    {
                        n = tmp % 10;
                        if (n % 2 == 0)
                        {
                            chet = +n;
                        }
                        else
                        {
                            nechet = +n;
                        }
                        tmp = tmp / 10;
                        n = 0;
                    }

                    if (chet > nechet)
                    {
                        message = " " + i; 
                        
                        nechet = 0;
                        chet = 0;
                    }
                    else
                    {
                        nechet = 0;
                        chet = 0;
                    }
                }
            }
            return message;
        }

        //Пользователь вводит 2 числа.Сообщите, есть ли в написании двух чисел одинаковые цифры.Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
        public static string Еxercise12(int a, int b)
        {
            int a1 = Math.Abs(a);
            int b1 = Math.Abs(b);

            int srav = 0;
            int i = 0;
            int j = 0;
            string result = "";

            if (a == 0 || b == 0)
            {
                if ( a == 0 )
                {
                    while ( b1 > 0)
                    {
                        j = b1 % 10;
                        b1 = b1 / 10;

                        if (a == j)
                        {
                            srav += 1;
                        }
                    }
                }
                else
                {
                    while (a1 > 0)
                    {
                        j = a1 % 10;
                        a1 = a1 / 10;

                        if (b1 == j)
                        {
                            srav += 1;
                        }
                    }
                }

            }
            else
            {
                while (a1 > 0)
                {
                    i = a1 % 10;
                    a1 = a1 / 10;

                    while (b1 > 0)
                    {
                        j = b1 % 10;
                        b1 = b1 / 10;

                        if (i == j)
                        {
                            srav += 1;
                        }
                    }

                    b1 = b;
                }

                if (srav != 0)
                {
                    result = "YES";
                }
                else
                {
                    result = "NO";
                }
            }

            return result;
        }

    }
}
