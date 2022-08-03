using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_6
{
    class Employee
    {
        public string name { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public string Say() => name;

        public virtual int WorkTime() => 0;

        public virtual string WhatYouDo() => "";

        public virtual string Timetype() => "";

    }
}
