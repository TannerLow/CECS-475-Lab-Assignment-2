using System;
using System.Collections.Generic;
using System.Text;

namespace LabAssignment2_part2
{
    interface HealthPlan
    {
        double annualCharge
        {
            get;
            set;
        }

        double deductionAmount
        {
            get;
            set;
        }

        PlanType plan
        {
            get;
        }
    }
}
