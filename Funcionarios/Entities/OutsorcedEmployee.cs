using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionarios.Entities
{
    class OutsorcedEmployee : Employees
    {
        public double AdditionalCharge { get; set; }
        
        public OutsorcedEmployee()
        {
        }

        public OutsorcedEmployee(string name, int hours, double valueperhour, double additionalcharge) : base(name, hours, valueperhour)
        {
            AdditionalCharge = additionalcharge;
        }

        public sealed override double Payment()
        {
            return ValuePerHour * Hours + 1.1 * AdditionalCharge;
        }

        public override string ToString()
        {
            return $"{Name} - $ {Payment():F2}";
        }
    }
}
