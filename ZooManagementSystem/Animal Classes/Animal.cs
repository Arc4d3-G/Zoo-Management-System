namespace ZooManagementSystem
{
    //Interfaces for derived classes
    internal interface IFeedable
    {
        public string Feed(string treat);
    }

    internal interface IPlayable
    {
        public string Play();
    }

    internal interface IVocal
    {
        public string Vocalize();
    }

    // Enums containing Diet info and foods
    public enum HerbivoreFoods
    {
        Grass,
        Hay,
        Leaves,
        Vegetables,
        Fruits
    }

    public enum CarivoreFoods
    {
        Beef,
        Chicken,
        Bones,
    }

    public enum DietType
    {
        Herbivore,
        Carnivore,
        Omnivore
    }

    public enum MealsPerDay
    {
        Once,
        Twice,
        Thrice
    }

    // Struct for Diet info data
    public struct DietInfo
    {
        public MealsPerDay mealsPerDay;
        public DietType dietType;

        public DietInfo(MealsPerDay times, DietType type)
        {
            this.dietType = type;
            this.mealsPerDay = times;
        }
    }

    /*This is the base class for all animals */
    public abstract class Animal
    {
        // AutoProperty syntax which creates private fields with public get/set
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Location { get; set; }

        // Abstract methods inherited by all derived classes
        public abstract string Eat();
        public abstract string Sleep();

    }


    /* 
     * Giraffe is derived from Animal. It's constructor initializes
     * the inherited Animal properties. Giraffe only utilizes the 
     * IFeedable interface.
     */
    public class Giraffe : Animal, IFeedable
    {
        public DietInfo dietInfo;
        public Giraffe(string name, int age, string sex, string location)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.Location = location;
            this.dietInfo = new DietInfo(MealsPerDay.Twice, DietType.Herbivore);
        }
        
        public override string Eat()
        {
            return $"{Name} the Giraffe is eating leaves.";
        }
        
        public override string Sleep()
        {
            return $"{Name} the Giraffe is sleeping.";
        }

        /*
         * Interface method being implemented.
         */
        public string Feed(string food)
        {
            return $"{Name} the Giraffe was fed some {food}.";
        }
    }

    ///*
    // * Similar to Giraffe, but this derived class implements
    // * additional interfaces (Iplayable & IVocal)
    // */
    internal class SquirrelMonkey : Animal, IFeedable, IPlayable, IVocal
    {
        public DietInfo dietInfo;
        public SquirrelMonkey(string name, int age, string sex, string location)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.Location = location;
            this.dietInfo = new DietInfo(MealsPerDay.Thrice, DietType.Omnivore);
        }
        public override string Eat()
        {
            return $"{Name} the SquirrelMonkey is eating fruit.";
        }

        public override string Sleep()
        {
            return $"{Name} the Squirrel Monkey is sleeping.";
        }

        // IFeedable interface method implementation
        public string Feed(string treat)
        {
            return $"{Name} the Squirrel Monkey was fed some {treat}.";
        }

        // IPlayable interface method implementation
        public string Play()
        {
            return $"{Name} the Squirrel Monkey is playing with a toy hoop.";
        }

        // IVocal interface method implementation
        public string Vocalize()
        {
            return $"{Name} the Squirrel Monkey starts to cackle.";
        }
    }

    //// Similar to the above derived class.
    internal class Wolf : Animal, IFeedable, IPlayable, IVocal
    {
        public DietInfo dietInfo;
        public Wolf(string name, int age, string sex, string location)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.Location = location;
            this.dietInfo = new DietInfo(MealsPerDay.Once, DietType.Carnivore);
        }

        public override string Eat()
        {
            return $"{Name} the Wolf is eating meat.";
        }

        public override string Sleep()
        {
            return $"{Name} the Wolf is sleeping.";
        }

        // IFeedable interface method implementation
        public string Feed(string treat)
        {
            return $"{Name} the Wolf was fed some {treat}.";
        }

        // IPlayable interface method implementation
        public string Play()
        {
            return $"{Name} the Wolf is playing with a toy ball.";
        }

        // IVocal interface method implementation
        public string Vocalize()
        {
            return $"{Name} the Wolf starts to howl.";
        }
    }

}
