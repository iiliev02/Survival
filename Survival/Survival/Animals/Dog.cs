namespace Survival.Animals
{
    class Dog : Animal
    {
        public Dog() : base(Constants.DogName, Constants.DogLive, Constants.DogFood, Constants.DogFavoriteFood)
        {

        }

        public override string GetSound()
        {
            return Constants.DogSound;
        }
    }
}
