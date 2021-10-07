using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionarios.Entities
{
    class Employees
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }
        
        public Employees()
        {
        }

        public Employees(string name, int hours, double valueperhour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valueperhour;
        }

        public virtual double Payment()
        {
            return ValuePerHour * Hours;
        }

        public override string ToString()
        {
            return $"{Name} - $ {Payment():F2}";
        }
    }
}
