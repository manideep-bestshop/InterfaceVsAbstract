using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class PartTimeEmployee : BaseEmployee
    {
        public int HourlyPay { get; set; }
        public int TotalHoursWorked { get; set; }


        public override int GetMonthlySalary()
        {
            return this.HourlyPay * this.TotalHoursWorked;
        }

    }
}
