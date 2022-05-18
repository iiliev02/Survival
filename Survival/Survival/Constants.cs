namespace Survival
{
    using System;
    public static class Constants
    {
        public static Random rnd = new Random();

        public static string OstrichName = "Ostrich";
        public static string DogName = "Dog";
        public static string RabbitName = "Rabbit";
        public static string HamsterName = "Hamster";
        public static string TurtleName = "Turtle";

        public static int OstrichLive = 70;
        public static int DogLive = 13;
        public static int RabbitLive = 9;
        public static int HamsterLive = 3;
        public static int TurtleLive = 100;

        public static string OstrichFavoriteFood = "seeds";
        public static string DogFavoriteFood = "beef";
        public static string RabbitFavoriteFood = "hay";
        public static string HamsterFavoriteFood = "apple";
        public static string TurtleFavoriteFood = "lettuce";

        public static string[] OstrichFood = new[] { "leaves", "seeds", "locusts" };
        public static string[] DogFood = new[] { "bugs", "beef", "pork" };
        public static string[] RabbitFood = new[] { "hay", "carrot", "corn" };
        public static string[] HamsterFood = new[] { "wheat", "watermelon", "apple" };
        public static string[] TurtleFood = new[] { "dandelion", "carrot", "lettuce" };

        public static string[] AllFoods = new[] {"hay", "carrot", "corn", 
                                                 "bread", "cherry","tomatoes",
                                                 "dandelion", "lettuce", "bugs", 
                                                 "beef", "pork", "seeds", 
                                                 "locusts", "wheat", "watermelon", 
                                                 "apple", "leaves"};

        public static string BaseSound = "I am Animal";
        public static string OstrichSound = "The Ostrich ate his favorite food. Inserted 2 life points to him.\n";
        public static string DogSound = "The Dog ate his favorite food. Inserted 2 life points to him.\n";
        public static string RabbitSound = "The Rabbit ate his favorite food. Inserted 2 life points to him.\n";
        public static string HamsterSound = "The Hamster ate his favorite food. Inserted 2 life points to him.\n";
        public static string TurtleSound = "The Turtle ate his favorite food. Inserted 2 life points to him.\n";

        public static string AnimalIsDead = "Unfortunately one of the animals died.\n";
        public static string AnimalsAreDead = "All Animals are dead";
    }
}
