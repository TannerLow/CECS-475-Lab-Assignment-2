using System;
using System.Collections.Generic;
using System.Text;

namespace LabAssignment2_part2
{
    // Constructor defines ObamaCare plan object members.
    class ObamaCare : IHealthPlan
    {
        private readonly double _annualCharge, _deductionAmount;
        private const PlanType _plan = PlanType.ObamaCare;

        // Define private members.
        public ObamaCare()
        {
            _annualCharge = 15000.00;
            _deductionAmount = 2000.00;
        }

        // Getters.
        public double AnnualCharge
        {
            get => _annualCharge;
        }
        public double DeductionAmount
        {
            get => _deductionAmount;
        }

        public PlanType Plan
        {
            get => _plan;
        }
    }
}
