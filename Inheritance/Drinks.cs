


namespace Inheritance
{
    public class Drink {
        public double Volume;
        public virtual string getInfo() { return "Я напиток"; }
    }

    public class Juice : Drink {
        public string UsingFruit;
        public bool hasPulp;

        public override string getInfo()
        {
            var str = "Я сок";
            str += String.Format("\nОбъем: {0}", this.Volume);
            return str;
        }
    }

    public class Soda : Drink {
        public string Type;
        public int CountBubbles;

        public override string getInfo()
        {
            var str = "Я газировка";
            str += String.Format("\nОбъем: {0}", this.Volume);
            return str;
        }
    }

    public class Alcohol : Drink { 
        public int Strength;
        public string Type;

        public override string getInfo()
        {
            var str = "Я алкоголь";
            str += String.Format("\nОбъем: {0}", this.Volume);
            return str;
        }
    }
    
}