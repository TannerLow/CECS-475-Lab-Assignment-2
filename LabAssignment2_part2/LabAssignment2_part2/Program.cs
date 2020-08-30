using System;

namespace LabAssignment2_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Demo");

            HealthPlan myPlan = HealthPlanFactory.getHealthPlan(PlanType.HMO);

            DisplayPlan(myPlan);
            myPlan.annualCharge    += 1000D;
            myPlan.deductionAmount -= 100D;
            DisplayPlan(myPlan);
        }

        static void DisplayPlan(HealthPlan plan)
        {
            Console.WriteLine("Annual    : " + plan.annualCharge);
            Console.WriteLine("Dedeuciton: " + plan.deductionAmount);
            Console.WriteLine("Plan      : " + plan.plan + "\n");
        }
    }
}
