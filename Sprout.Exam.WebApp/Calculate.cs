using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sprout.Exam.WebApp
{
    public class Calculate
    {
        //value for Id for Regular/Contractual Employee
        public int Id { get; set; }

        //value for AbsentDays for Regular Employee
        [Required(ErrorMessage = "AbsentDays is required")]
        public decimal AbsentDays { get; set; }

        //value for WorkedDays for Contractual Employee
        [Required(ErrorMessage = "WorkedDays is required")]
        public decimal WorkedDays { get; set; }

        //Constant value for basicSalary for Regular Employee
        private const decimal basicSalary = 20000m;

        //Constant value for taxDeduction for Regular Employee
        private const decimal taxDeduction = 0.12m;

        //Constant value for perDayRate for Contractual Employee
        private const decimal perDayRate = 500m;

        public decimal GetRegularNetIncome()
        {
            //Based on the Developer Applicant Exam.pdf
            //The computation for regulary salary
            //  Regular Employee
            //• Has 20,000 basic monthly salary
            //• 1 day absent
            //• 12 % tax
            //• = 20,000 - (20, 000 / 22) - (20, 000 * 0.12)
            //• = 16,690.91

            return Math.Round(basicSalary - ((basicSalary / 22) * AbsentDays) - (basicSalary * taxDeduction), 2);
        }

        public decimal GetContractualNetIncome()
        {
            //Contractual employee
            //• Has 500 per day rate
            //• Reported to work for 15.5 days
            //• = 500 * 15.5
            //• = 7,750.00

            return Math.Round(perDayRate * WorkedDays, 2);
        }
    }
}
