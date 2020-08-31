using System;

namespace LabAssignment2_part2
{
    class Program
    {
        //Program's driver code
        static void Main(string[] args)
        {
            // Create HealthPlan interface.
            IHealthPlan plan = null;

            //Asks user for a health plan and displays info about the plan
            while (true)
            {
                Console.WriteLine("==Factory Demo==\nWhich plan would you like info on?\n" +
                "> HMO\n> PPO\n> ObamaCare\nType \"exit\" to quit program.\n");
                string input = Console.ReadLine();

                // Use factory pattern to create different health plan objects with similar attributes.
                // Plan creation is based on user input.
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

                    //exit break out of the Main method and ends the program
                    case "exit": 
                        return;

                    default:
                        Console.WriteLine("Invalid Input, try again\n");
                        break;
                }
                //If a valid plan exists then display info about it
                if(plan != null)
                {
                    Console.WriteLine("Current Plan:");
                    Console.WriteLine("Annual    : " + plan.AnnualCharge);
                    Console.WriteLine("Dedeuciton: " + plan.DeductionAmount);
                    Console.WriteLine("Plan      : " + plan.Plan + "\n");
                }
            }
            
        }
    }
}
