using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartyApplication
{
    class DinnerParty
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOptions { get; set; }
        public const int CostOfFoodPerPerson = 25;

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

        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += ((CalculateCostOfBeveragesPerPersom() + CostOfFoodPerPerson) * NumberOfPeople);

                if (HealthyOptions)
                    totalCost *= .95M;

                if (NumberOfPeople > 12)
                    totalCost += 100;

                return totalCost;
            }
        }
    }
}
