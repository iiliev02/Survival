namespace Survival
{
    using System;
    using System.Text;

    public class Animal
    {
        private readonly string name;
        private readonly int maxLive;
        private readonly string[] foods;
        private readonly string favoriteFood;

        protected Animal(string name, int live, string[] foods, string favoriteFood)
        {
            this.name = name;
            this.maxLive = live;
            this.CurrentLive = live;
            this.foods = foods;
            this.favoriteFood = favoriteFood;
        }

        private int CurrentLive { get; set; }

        public bool isDead()
        {
            return this.CurrentLive == 0;
        }

        public void Eats(string food)
        {
            var eatThisFood = false;
            for (int i = 0; i < this.foods.Length; i++)
            {
                if(this.foods[i].Equals(food))
                {
                    eatThisFood = true;
                    if (this.CurrentLive != this.maxLive)
                    {
                        if (this.favoriteFood.Equals(food) && this.CurrentLive + 2 <= this.maxLive)
                        {
                            Console.WriteLine(this.EatFavoriteFood());
                        }
                        else this.CurrentLive += 1;
                    }
                }
            }
            if (!eatThisFood) this.CurrentLive -= 1;
        }

        private string EatFavoriteFood()
        {
            this.CurrentLive += 2;
            switch (this)
            {
                case Animals.Turtle turtle:
                    return turtle.GetSound();

                case Animals.Rabbit rabbit:
                    return rabbit.GetSound();

                case Animals.Ostrich ostrich:
                    return ostrich.GetSound();

                case Animals.Hamster hamster:
                    return hamster.GetSound();

                case Animals.Dog dog:
                    return dog.GetSound();
            }

            return null;
        }

        public string detailsDeadAnimal()
        {
            StringBuilder details = new StringBuilder();
            details.Append(Constants.AnimalIsDead);
            details.Append($"{this.name} is dead \nFavorite food: {this.favoriteFood} \nThe foods which eat: {String.Join(", ", this.foods)}\n");

            return details.ToString();
        }

        public virtual string GetSound()
        {
            return Constants.BaseSound;
        }
    }
}
