namespace Survival.Animals
{
    class Rabbit : Animal
    {
        public Rabbit() : base(Constants.RabbitName, Constants.RabbitLive, Constants.RabbitFood, Constants.RabbitFavoriteFood)
        {

        }

        public override string GetSound()
        {
            return Constants.RabbitSound;
        }
    }
}
