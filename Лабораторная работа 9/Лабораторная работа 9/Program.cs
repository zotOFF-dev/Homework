using System;
using static System.Console;
using System.Collections.Generic;

namespace Lab_9
{
    internal class Program
    {
        static void Main()
        {
            Checkpoint checkpoint = new Checkpoint();
            WriteLine("Вас приветствует информационная система КПП СибГУ");
            WriteLine("Список желающих пройти через КПП:");
            foreach(var visitor in checkpoint.VisitorsWantToISIT)
            {
                WriteLine(visitor.Name);
            }
            WriteLine("--------------------------------------------------------------------------------");
            WriteLine("Проверка людей, прищедших в СибГУ");
            checkpoint.Check();
            WriteLine("--------------------------------------------------------------------------------");
            WriteLine("Список прошедших в университет:");
            foreach (var visitor in checkpoint.VisitorsCanToISIT)
            {
                WriteLine(visitor.Name);
            }
            WriteLine("--------------------------------------------------------------------------------");
            WriteLine($"Остаток СИЗ:\n Маски: {checkpoint.howmask}; Доз антисептика: {checkpoint.howdis}");
            if(checkpoint.howmask == 0 || checkpoint.howdis == 0)
            {
                if (checkpoint.howmask == 0 && checkpoint.howdis == 0)
                {
                    WriteLine("ПРОПУСК ЛЮДЕЙ, НЕ ИМЕЮЩИХ СВОИ СИЗ, ВРЕМЕННО ОГРАНИЧЕН ДО ПОСТАВКИ НА КПП НОВЫХ СИЗ");
                    WriteLine("--------------------------------------------------------------------------------");
                }
                else if(checkpoint.howmask == 0)
                {
                    WriteLine("ПРОПУСК ЛЮДЕЙ, НЕ ИМЕЮЩИХ СВОЮ МАСКУ, ВРЕМЕННО ОГРАНИЧЕН ДО ПОСТАВКИ НА КПП НОВЫХ МАСОК");
                    WriteLine("--------------------------------------------------------------------------------");
                }
                else if(checkpoint.howdis == 0)
                {
                    WriteLine("ПРОПУСК ЛЮДЕЙ, НЕ ИМЕЮЩИХ СВОЕГО АНТИСЕПТИКА, ВРЕМЕННО ОГРАНИЧЕН ДО ПОСТАВКИ НА КПП НОВЫХ АНТИСЕПТИКОВ");
                    WriteLine("--------------------------------------------------------------------------------");
                }
                else
                {
                    WriteLine("ВСЕ ЛЮДИ И ЖИВОТНЫЕ БЫЛИ ПРОПУЩЕНЫ");
                    WriteLine("--------------------------------------------------------------------------------");
                }
            }
            WriteLine("Список тех, кому был отказан проход в СибГУ:");
            foreach (var visitor in checkpoint.VisitorsWantToISIT)
            {
                Write(visitor.Name);
                if(visitor is Human)
                {
                    if (visitor is Student student)
                    {
                        if(student.IsHaveQR == false)
                        {
                            WriteLine(" - Причина: Нет информации о вакцинации");
                        }
                        else
                        {
                            WriteLine(" - Причина: У студента нет своих СИЗ, а на КПП СИЗ закончились");
                        }
                    }
                    else if (visitor is Teacher teacher)
                    {
                        if (teacher.IsHaveQR == false)
                        {
                            WriteLine(" - Причина: Нет информации о вакцинации");
                        }
                        else
                        {
                            WriteLine(" - Причина: У преподавателя нет своих СИЗ, а на КПП СИЗ закончились");
                        }
                    }
                    else if (visitor is Enrollee enrollee)
                    {
                        if (enrollee.IsHaveQR == false)
                        {
                            WriteLine(" - Причина: Нет информации о вакцинации");
                        }
                        else
                        {
                            WriteLine(" - Причина: У абитуриента нет своих СИЗ, а на КПП СИЗ закончились");
                        }
                    }
                }
                else if(visitor is Animal)
                {
                    WriteLine(" - Причина: У животного нет данных о вакцинации");
                }
            }
            WriteLine("--------------------------------------------------------------------------------\n\n");
            WriteLine("Спасибо за использование данной информационной системы!!!");
        }           
    }
}
