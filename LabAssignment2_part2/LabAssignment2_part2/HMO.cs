using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace LabAssignment2_part2
{
    class HMO : HealthPlan
    {
        double _annualCharge, _deductionAmount;
        const PlanType _plan = PlanType.HMO;

        public HMO()
        {
            _annualCharge = 10000.00;
            _deductionAmount = 1200.00;
        }

        public double annualCharge
        { 
            get => _annualCharge; 
            set => _annualCharge = value; 
        }
        public double deductionAmount 
        { 
            get => _deductionAmount; 
            set => _deductionAmount = value; 
        }
        
        public PlanType plan
        {
            get => _plan;
        }

    }
}
