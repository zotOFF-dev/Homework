using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    internal class Checkpoint
    {
        public List<IVisitor> VisitorsWantToISIT = new List<IVisitor>()
        {
            new Cat{Name = "Кот Шлёпа"},
            new Teacher{Name = "Физрук Клара Михайловна", IsHaveQR = true, IsHaveMask = false, IsHaveDisinfect = false},
            new Dog{Name = "Пёс Барбос"},
            new Enrollee{Name = "Школьник Александр",IsHaveQR = true, IsHaveMask = false, IsHaveDisinfect = false },
            new Student{Name = "Первокурсница Надежда", IsHaveQR = true, IsHaveMask = false, IsHaveDisinfect = true},
            new Rat{Name = "Крыса Лариса"},
            new Student{ Name = "Второкурсник Максим", IsHaveQR = false, IsHaveMask = true, IsHaveDisinfect = true },
            new Student{ Name = "Аспирант Евгений", IsHaveQR = true, IsHaveMask = true, IsHaveDisinfect = true },
            new Dog{ Name = "Пёс Шарик"},
            new Enrollee{Name = "Выпускница Анастасия", IsHaveMask = false, IsHaveQR = false, IsHaveDisinfect = true},
            new Cat{Name = "Кот Матроскин"},
            new Teacher{Name = "Историк Афанасий Петрович", IsHaveQR = true, IsHaveMask = true, IsHaveDisinfect = false },
            new Dog{Name = "Пёс Сэм"},
            new Enrollee{Name = "Одинадцатиклассница Ирина", IsHaveQR = true, IsHaveMask = false, IsHaveDisinfect = true },
            new Student{Name = "Третьекурсник Илья", IsHaveQR = true, IsHaveMask = false, IsHaveDisinfect = true },
            new Rat{Name = "Крыса Оксана"},
            new Student{Name = "Магистрант Кирилл", IsHaveQR = true, IsHaveMask = true, IsHaveDisinfect = false},
            new Student{Name = "Лаборантка Елена", IsHaveQR = true, IsHaveMask = false, IsHaveDisinfect = true},
            new Dog{Name = "Пёс Дерек"},
            new Enrollee{Name = "Десятиклассник Геннадий", IsHaveQR = true, IsHaveMask = true, IsHaveDisinfect = false },
            new Teacher{Name = "Математик Кирилл Анатольевич", IsHaveQR = true, IsHaveMask = false, IsHaveDisinfect = false},
        };
        public List<IVisitor> VisitorsCanToISIT = new List<IVisitor>();
        public int howdis = 10;
        public int howmask = 10;
        public void Check()
        {
            for(int i = 0; i < VisitorsWantToISIT.Count(); i++)
            {
                var visitor = VisitorsWantToISIT[i];
                if (visitor is Human human)
                {
                    if (howdis > 0 || howmask > 0)
                    {
                        if (howdis > 0 && howmask > 0)
                        {
                                if (human.IsHaveQR == true)
                                {
                                    if (human.IsHaveMask == true && human.IsHaveDisinfect == true)
                                    {
                                        VisitorsCanToISIT.Add(visitor);
                                        VisitorsWantToISIT.Remove(visitor);
                                        i--;
                                    }
                                    else if (human.IsHaveMask == true || human.IsHaveDisinfect == true)
                                    {
                                        if (human.IsHaveMask == true)
                                        {
                                            howdis--;
                                            VisitorsCanToISIT.Add(visitor);
                                            VisitorsWantToISIT.Remove(visitor);
                                            i--;
                                        }
                                        else
                                        {
                                            howmask--;
                                            VisitorsCanToISIT.Add(visitor);
                                            VisitorsWantToISIT.Remove(visitor);
                                            i--;
                                        }
                                    }
                                    else
                                    {
                                        howmask--;
                                        howdis--;
                                        VisitorsCanToISIT.Add(visitor);
                                        VisitorsWantToISIT.Remove(visitor);
                                        i--;
                                    }
                                }
                        }
                        else if (howdis > 0)
                        {
                                if (human.IsHaveQR == true)
                                {
                                    if (human.IsHaveMask == true && human.IsHaveDisinfect == true)
                                    {
                                        VisitorsCanToISIT.Add(visitor);
                                        VisitorsWantToISIT.Remove(visitor);
                                        i--;
                                    }
                                    else if (human.IsHaveMask == true)
                                    {
                                        howdis--;
                                        VisitorsCanToISIT.Add(visitor);
                                        VisitorsWantToISIT.Remove(visitor);
                                        i--;
                                    }
                                }
                        }
                        else if (howmask > 0)
                        {
                                if (human.IsHaveQR == true)
                                {
                                    if (human.IsHaveMask == true && human.IsHaveDisinfect == true)
                                    {
                                        VisitorsCanToISIT.Add(visitor);
                                        VisitorsWantToISIT.Remove(visitor);
                                        i--;
                                    }
                                    else if (human.IsHaveMask == true)
                                    {
                                        howdis--;
                                        VisitorsCanToISIT.Add(visitor);
                                        VisitorsWantToISIT.Remove(visitor);
                                        i--;
                                    }
                                }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
