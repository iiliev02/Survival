namespace Survival
{
    using System;
    using System.Collections.Generic;
    using Animals;
    public class Engine
    {
        private List<Animal> animals;

        public Engine(List<Animal> animals)
        {
            this.animals = animals;
        }

        private void AddAllAnimals()
        {
            this.animals.Add(new Rabbit());
            this.animals.Add(new Dog());
            this.animals.Add(new Turtle());
            this.animals.Add(new Ostrich());
            this.animals.Add(new Hamster());
        }

        public void Process()
        {
            int index;

            this.AddAllAnimals();

            while (true)
            {
                for (var i = 0; i < animals.Count; i++)
                {
                    index = Constants.rnd.Next(Constants.AllFoods.Length);
                    this.animals[i].Eats(Constants.AllFoods[index]);

                    if (this.animals[i].isDead())
                    {
                        Console.WriteLine(this.animals[i].detailsDeadAnimal());
                        this.animals.RemoveAt(i);
                    }
                }

                if (this.animals.Count == 0) break;
            }

            Console.WriteLine(Constants.AnimalsAreDead);
        }
    }
}
