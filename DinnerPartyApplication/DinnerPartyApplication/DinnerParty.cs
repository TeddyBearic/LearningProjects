using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartyApplication
{
    class DinnerParty
    {
        public int NumberOfPeople;
        private decimal CostOfBeveragesPerPerson;
        private decimal CostOfDecorations;
        public const int CostOfFoodPerPerson = 25;

        public void CalculateCostOfDecorations(bool FancyDecorations)
        {
            if (FancyDecorations) { CostOfDecorations = (NumberOfPeople * 15) + 50; }
            else { CostOfDecorations = (NumberOfPeople * 7.50M) + 30; }
        }

        public void SetHealthyOption(bool HealthyOption)
        {
            if (HealthyOption) { CostOfBeveragesPerPerson = 5; }
            else { CostOfBeveragesPerPerson = 20; }
        }

        public decimal CalculateCost(bool HealthyOption)
        {
            decimal TotalCost;

            if (HealthyOption == true) { TotalCost = ((CostOfFoodPerPerson + CostOfBeveragesPerPerson) * NumberOfPeople + CostOfDecorations) * 0.95M; }
            else { TotalCost = (CostOfFoodPerPerson + CostOfBeveragesPerPerson) * NumberOfPeople + CostOfDecorations; }

            return TotalCost;
        }
    }
}
