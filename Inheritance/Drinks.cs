


namespace Inheritance
{
    public class Drink {
        public double Volume { get; set; }
    }

    public class Juice : Drink {
        public string UsingFruit { get; set; }
        public bool hasPulp { get; set; }
    }

    public class Soda : Drink {
        public string Type { get; set; }
        public int countBubbles { get; set; }
    }

    public class Alcohol : Drink { 
        public int strength { get; set; }
        public string Type { get; set; }
    }
    
}