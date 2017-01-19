using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyApplication
{
    class DinnerParty : Party
    {
        public bool HealthyOptions { get; set; }

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOptions)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOptions = healthyOptions;
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;

            if (FancyDecorations)
                costOfDecorations = (NumberOfPeople * 15) + 50;
            else
                costOfDecorations = (NumberOfPeople * 7.50M) + 30;

            return costOfDecorations;
        }

        private decimal CalculateCostOfBeveragesPerPersom()
        {
            decimal costOfBeveragesPerPerson;

            if (HealthyOptions)
                costOfBeveragesPerPerson = 5.00M;
            else
                costOfBeveragesPerPerson = 20.00M;

            return costOfBeveragesPerPerson;
        }

        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += ((CalculateCostOfBeveragesPerPersom() + CostOfFoodPerPerson) * NumberOfPeople);

                if (HealthyOptions)
                    totalCost *= .95M;

                return totalCost;
            }
        }
    }
}
