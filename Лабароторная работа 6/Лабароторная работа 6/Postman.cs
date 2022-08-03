using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Postman : Employee
    {
        public override string WhatYouDo() => "Я сейчас разношу почту, не мешайте";

        public override int WorkTime() => (int)(((DateTime.Now - DateOfEmployment).Days) / 365.0);

        public override string Timetype() => "Лет";
    }
}
