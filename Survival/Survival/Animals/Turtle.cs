namespace Survival.Animals
{
    using System;
    class Turtle : Animal
    {
        public Turtle() : base(Constants.TurtleName, Constants.TurtleLive, Constants.TurtleFood, Constants.TurtleFavoriteFood)
        {

        }

        public override string GetSound()
        {
            return Constants.TurtleSound;
        }
    }
}
