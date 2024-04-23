namespace ZooManagementSystem
{
    /*This is the base class for all animals */
    internal class Animal
    {
        // Properties inherited by all derived classes
        public string Name { get; set; } 
        public int Age { get; set; }
        public string Sex {  get; set; }
        public string Location { get; set; }

        // Methods inherited by all derived classes
        public virtual string Eat()
        {
            string msg = $"{Name} is eating.";
            return msg;
        }

        public virtual string Sleep()
        {
            string msg = $"{Name} is sleeping.";
            return msg;
        }

    }
    // Interfaces for derived classes
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

    /* 
     * Giraffe is derived from Animal. It's constructor initializes
     * the inherited Animal properties. Giraffe only utilizes the 
     * IFeedable interface.
     */
    internal class Giraffe : Animal, IFeedable
    {
        public Giraffe(string name, int age, string sex, string location)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.Location = location;
        }

        /* 
         * Example of method override. We change the inherited method to
         * return a new string that includes the object's name prop.
         */
        public override string Eat()
        {
            string msg = $"{Name} the Giraffe is eating leaves.";
            return msg;
        }
        /* 
         * Example of method overload. We add the option for the method to accept
         * a parameter string, in which case the returned string incorporates the 
         * parameter. If the method is invoked without an argument, it will default
         * to the original inherited version.
         */
        public string Sleep(string sleepLocation)
        {
            string msg = $"{Name} the Giraffe is sleeping in {sleepLocation}.";
            return msg;
        }

        /*
         * Interface method being implemented.
         */
        public string Feed(string treat)
        {
            string msg = $"{Name} the Giraffe was fed some {treat}.";
            return msg;
        }
    }
    
    /*
     * Similar to Giraffe, but this derived class implements
     * additional interfaces (Iplayable & IVocal)
     */
    internal class SquirrelMonkey : Animal, IFeedable, IPlayable, IVocal
    {
        public SquirrelMonkey(string name, int age, string sex, string location)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.Location = location;
        }
        // Example of method override
        public override string Eat()
        {
            string msg = $"{Name} the SquirrelMonkey is eating fruit.";
            return msg;
        }

        // Example of method overload
        public string Sleep(string sleepLocation)
        {
            string msg = $"{Name} the Squirrel Monkey is sleeping in {sleepLocation}.";
            return msg;
        }

        // IFeedable interface method implementation
        public string Feed(string treat)
        {
            string msg = $"{Name} the Squirrel Monkey was fed some {treat}.";
            return msg;
        }

        // IPlayable interface method implementation
        public string Play()
        {
            string msg = $"{Name} the Squirrel Monkey is playing with a toy hoop.";
            return msg;
        }

        // IVocal interface method implementation
        public string Vocalize()
        {
            string msg = $"{Name} the Squirrel Monkey starts to cackle.";
            return msg;
        }
    }
    
    // Similar to the above derived class.
    internal class Wolf : Animal, IFeedable, IPlayable, IVocal
    {
        public Wolf(string name, int age, string sex, string location)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.Location = location;
        }
        // Example of method override
        public override string Eat()
        {
            string msg = $"{Name} the Wolf is eating meat.";
            return msg;
        }

        // Example of method overload
        public string Sleep(string sleepingLocation)
        {
            string msg = $"{Name} the Wolf is sleeping in {sleepingLocation}.";
            return msg;
        }

        // IFeedable interface method implementation
        public string Feed(string treat)
        {
            string msg = $"{Name} the Wolf was fed some {treat}.";
            return msg;
        }

        // IPlayable interface method implementation
        public string Play()
        {
            string msg = $"{Name} the Wolf is playing with a toy ball.";
            return msg;
        }

        // IVocal interface method implementation
        public string Vocalize()
        {
            string msg = $"{Name} the Wolf starts to howl.";
            return msg;
        }
    }

}
