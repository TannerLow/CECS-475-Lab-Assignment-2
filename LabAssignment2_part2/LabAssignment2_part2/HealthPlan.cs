using System;
using System.Collections.Generic;
using System.Text;

namespace LabAssignment2_part2
{
    interface IHealthPlan
    {
        double AnnualCharge
        {
            get;
        }

        double DeductionAmount
        {
            get;
        }

        PlanType Plan
        {
            get;
        }
    }
}
