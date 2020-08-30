using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace LabAssignment2_part2
{
    class HMO : IHealthPlan
    {
        private readonly double _annualCharge, _deductionAmount;
        private const PlanType _plan = PlanType.HMO;

        public HMO()
        {
            _annualCharge = 10000.00;
            _deductionAmount = 1200.00;
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
