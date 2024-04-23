namespace ZooManagementSystem
{
    
    internal class Animal
    {
        
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex {  get; set; }
        public string Location { get; set; }

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
    // -----------------------------------------------------------------------------------------
    internal interface IFeedable
    {
        public string Feed();
    }
    // -----------------------------------------------------------------------------------------
    internal interface IPlayable
    {
        public string Play();
    }
    // -----------------------------------------------------------------------------------------
    internal interface IVocal
    {
        public string Vocalize();
    }
    // -----------------------------------------------------------------------------------------
    internal class Giraffe : Animal, IFeedable
    {
        public Giraffe(string name, int age, string sex, string location)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.Location = location;
        }

        public override string Eat()
        {
            string msg = $"{Name} the Giraffe is eating leaves.";
            return msg;
        }
        public override string Sleep()
        {
            string msg = $"{Name} the Giraffe is sleeping.";
            return msg;
        }

        public string Feed()
        {
            string msg = $"{Name} the Giraffe was fed some grass pellets.";
            return msg;
        }
    }
    // -----------------------------------------------------------------------------------------
    internal class SquirrelMonkey : Animal, IFeedable, IPlayable, IVocal
    {
        public SquirrelMonkey(string name, int age, string sex, string location)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.Location = location;
        }
        public override string Eat()
        {
            string msg = $"{Name} the SquirrelMonkey is eating fruit.";
            return msg;
        }

        public string Feed()
        {
            string msg = $"{Name} the Squirrel Monkey was fed some bananas";
            return msg;
        }

        public string Play()
        {
            string msg = $"{Name} the Squirrel Monkey is playing with a toy hoop.";
            return msg;
        }

        public string Vocalize()
        {
            string msg = $"{Name} the Squirrel Monkey starts to cackle.";
            return msg;
        }
    }
    // -----------------------------------------------------------------------------------------
    internal class Wolf : Animal, IFeedable, IPlayable, IVocal
    {
        public Wolf(string name, int age, string sex, string location)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.Location = location;
        }
        public override string Eat()
        {
            string msg = $"{Name} the Wolf is eating meat.";
            return msg;
        }

        public string Feed()
        {
            string msg = $"{Name} the Wolf was fed some ckicken treats.";
            return msg;
        }

        public string Play()
        {
            string msg = $"{Name} the Wolf is playing with a toy ball.";
            return msg;
        }

        public string Vocalize()
        {
            string msg = $"{Name} the Wolf starts to howl.";
            return msg;
        }
    }


}
