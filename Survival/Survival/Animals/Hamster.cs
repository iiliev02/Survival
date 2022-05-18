namespace Survival.Animals
{
    class Hamster : Animal
    {
        public Hamster() : base(Constants.HamsterName, Constants.HamsterLive, Constants.HamsterFood, Constants.HamsterFavoriteFood)
        {

        }

        public override string GetSound()
        {
            return Constants.HamsterSound;
        }
    }
}
