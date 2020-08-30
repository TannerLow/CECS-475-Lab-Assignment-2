using System;
using System.Collections.Generic;
using System.Text;

namespace LabAssignment2_part2
{
    class PPO : IHealthPlan
    {
        private readonly double _annualCharge, _deductionAmount;
        private const PlanType _plan = PlanType.PPO;

        public PPO()
        {
            _annualCharge = 8000.00;
            _deductionAmount = 1350.00;
        }

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
