namespace Survival.Animals
{
    class Ostrich : Animal
    {
        public Ostrich() : base(Constants.OstrichName, Constants.OstrichLive, Constants.OstrichFood, Constants.OstrichFavoriteFood)
        {

        }

        public override string GetSound()
        {
            return Constants.OstrichSound;
        }
    }
}
