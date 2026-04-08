namespace Inheritance
{
    public class Drink {
        public double Volume = 0;
        public virtual string getInfo() {
            var str = String.Format("\nОбъем: {0}", this.Volume);
            return str; 
        }
        public static Random rnd = new Random();
    }

    public enum Fruit
    {
        Apple,
        Orange,
        Pear,
        Grape
    }

    public class Juice : Drink {
        public Fruit usingFruit = Fruit.Apple;
        public bool hasPulp = true;

        public override string getInfo()
        {
            var str = "Я сок";
            str += base.getInfo();
            str += String.Format("\nИспользуемый фрукт: {0}", this.usingFruit);
            str += String.Format("\nНаличие мякоти: {0}", this.hasPulp);
            return str;
        }

        public static Juice Generate()
        {
            return new Juice { 
                Volume = rnd.Next(1, 10),
                usingFruit = (Fruit)rnd.Next(4),
                hasPulp = rnd.Next(0, 2) == 1
            };
        }
    }

    public enum SodaType
    {
        Cola,
        Fanta,
        Sprite,
        Pepsi
    }

    public class Soda : Drink {
        public SodaType Type = SodaType.Cola;
        public int countBubbles = 500;

        public override string getInfo()
        {
            var str = "Я газировка";
            str += base.getInfo();
            str += String.Format("\nВид газировки: {0}", this.Type);
            str += String.Format("\nКоличество пузырьков: {0}", this.countBubbles);
            return str;
        }

        public static Soda Generate()
        {
            return new Soda
            {
                Volume = rnd.Next(1, 10),
                Type = (SodaType)rnd.Next(4),
                countBubbles = rnd.Next(100, 1000)
            };
        }
    }

    public enum AlcoholType
    {
        Wine,
        Beer,
        Vodka,
        Cognac
    }

    public class Alcohol : Drink { 
        public int Strength = 50;
        public AlcoholType Type = AlcoholType.Wine;

        public override string getInfo()
        {
            var str = "Я алкоголь";
            str += base.getInfo();
            str += String.Format("\nКрепость алкоголя: {0}", this.Strength);
            str += String.Format("\nТип алкоголя: {0}", this.Type);
            return str;
        }

        public static Alcohol Generate()
        {
            return new Alcohol
            {
                Volume = rnd.Next(1, 10),
                Strength = rnd.Next(1, 100),
                Type = (AlcoholType)rnd.Next(4),
            };
        }
    }
    
}