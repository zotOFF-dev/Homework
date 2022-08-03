using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Operator : Employee
    {
        public override string WhatYouDo() => "В процессе поиска посылки";

        public override int WorkTime() => (int)(((DateTime.Now - DateOfEmployment).Days) / 365.0) * 12;

        public override string Timetype() => "Месяцев";
    }
}