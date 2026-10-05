//********************************************************************
//*Практическая работа №7                                            *
//*Сделал Егоров Н.Н, группа 2-ИСП                                   *
//*Задание: определить кол-во баллов школ, лучшую школу и участника  *
//********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа__7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Практическая работа №7";//задаёт значение в заголовок консоли

            int students, score1 = 0, score2 = 0, score3 = 0;
            try
            {
                Console.WriteLine("Здравствуйте!");
                Console.Write("Введите количество участников в 3 школах: ");
                students = Int32.Parse(Console.ReadLine());
                int MaxStudentScore = 0, BestStudentNumber = 0, BestSchool = 0;
                if (students <= 0)
                {
                    Console.WriteLine("Вы ввели недопустимое число студентов.");
                }
                else
                {
                    for (int i = 1; i <= 3; i++)//цикл с количеством школ
                    {
                        for (int j = 1; j <= students; j++)//вложенный цикл с количеством участников
                        {
                            int score = i * 10 + j * 3;//выражение для баллов школ

                            if (i == 1)//если школа под номером 1
                                score1 += score;//то зачисляем баллы 1 школе
                            else if (i == 2)
                                score2 += score;
                            else
                                score3 += score;

                            Console.WriteLine($"Школа {i}, участник {j}: {score}");//вывод каждого участника из 3 школ

                            if (score > MaxStudentScore)//если счёт больше максимального
                            {
                                MaxStudentScore = score;//максимальный счёт равен данному
                                BestStudentNumber = j;//записывается номер студента в зависимости значения j
                                BestSchool = i;//записывается номер школы в зависимости значения i
                            }
                        }
                    }
                    Console.WriteLine($"\nШкола 1: {score1}");
                    Console.WriteLine($"Школа 2: {score2}");
                    Console.WriteLine($"Школа 3: {score3}");
                    Console.WriteLine($"Победитель: Школа {BestSchool}");
                    Console.WriteLine($"Лучший участник: Школа {BestSchool}, участник {BestStudentNumber} ({MaxStudentScore} баллов).");
                }
            }
            catch (FormatException fex)//обработка исключения FormatException (входная строка имела неправильный формат)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Что-то пошло не так! Ошибка: {fex.Message}");//Вывод текста с помощью интерполяции: Что-то пошло не так! Ошибка: Входная строка имела неправильный формат. 
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (OverflowException ofex)//обработка исключения OverflowException (Значение было недопустимо малым или недопустимо большим для Int32)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Что-то пошло не так! Ошибка: {ofex.Message}");//Вывод текста с помощью интерполяции: Что-то пошло не так! Ошибка: Значение было недопустимо малым или недопустимо большим для Int32.
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)//обработка исключения Exception (все ошибки в целом)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Что-то пошло не так! Ошибка: {ex.Message}");//Вывод текста с помощью интерполяции: Что-то пошло не так! Ошибка: сообщение об ошибке из ex.Message.
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ReadKey();
        }
    }
}
