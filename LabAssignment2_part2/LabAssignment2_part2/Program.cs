using System;

namespace LabAssignment2_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            IHealthPlan plan = null;
            while (true)
            {
                Console.WriteLine("==Factory Demo==\nWhich plan would you like info on?\n" +
                "> HMO\n> PPO\n> ObamaCare\nType \"exit\" to quit program.\n");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "HMO":
                        plan = HealthPlanFactory.GetHealthPlan(PlanType.HMO);
                        break;

                    case "PPO":
                        plan = HealthPlanFactory.GetHealthPlan(PlanType.PPO);
                        break;

                    case "ObamaCare":
                        plan = HealthPlanFactory.GetHealthPlan(PlanType.ObamaCare);
                        break;

                    case "exit": 
                        return;

                    default:
                        Console.WriteLine("Invalid Input, try again\n");
                        break;
                }

                if(plan != null)
                {
                    Console.WriteLine("Current Plan:");
                    DisplayPlan(plan);
                }
            }
            
        }

        static void DisplayPlan(IHealthPlan plan)
        {
            Console.WriteLine("Annual    : " + plan.AnnualCharge);
            Console.WriteLine("Dedeuciton: " + plan.DeductionAmount);
            Console.WriteLine("Plan      : " + plan.Plan + "\n");
        }
    }
}
