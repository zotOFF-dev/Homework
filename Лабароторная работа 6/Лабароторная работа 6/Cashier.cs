using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Cashier : Employee
    {
        public override string WhatYouDo() => "Подсчитываю выручку, не мешайте.Математика дело тонкое";

        public override int WorkTime() => (int)(((DateTime.Now - DateOfEmployment).Days) / 365.0) * 365;

        public override string Timetype() => "Дней";
    }
}