


namespace Inheritance
{
    public class Drink {
        public double volume { get; set; }
    }

    public class Juice : Drink {
        public string usingFruit { get; set; }
        public bool hasPulp { get; set; }
    }

    public class Soda : Drink {
        public string type { get; set; }
        public int countBubbles { get; set; }
    }

    public class Alcohol : Drink { 
        public int strength { get; set; }
        public string type { get; set; }
    }
    
}