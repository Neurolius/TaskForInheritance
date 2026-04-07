


namespace Inheritance
{
    public class Drink {
        public double Volume = 0;
        public virtual string getInfo() {
            var str = String.Format("\nОбъем: {0}", this.Volume);
            return str; 
        }
    }

    public class Juice : Drink {
        public string UsingFruit = "Яблоко";
        public bool hasPulp = true;

        public override string getInfo()
        {
            var str = "Я сок";
            str += base.getInfo();
            str += String.Format("\nИспользуемый фрукт: {0}", this.UsingFruit);
            str += String.Format("\nНаличие мякоти: {0}", this.hasPulp);
            return str;
        }

        public static Juice Generate()
        {
            var rnd = new Random();
            var Fruits = new string[] { "Яблоко", "Апельсин", "Груша", "Виноград" };

            return new Juice { 
                Volume = rnd.Next(1, 10),
                UsingFruit = Fruits[rnd.Next(0,Fruits.Length)],
                hasPulp = rnd.Next(0, 2) == 1
            };
        }
    }

    public class Soda : Drink {
        public string Type = "Добрый кола";
        public int CountBubbles = 500;

        public override string getInfo()
        {
            var str = "Я газировка";
            str += base.getInfo();
            str += String.Format("\nВид газировки: {0}", this.Type);
            str += String.Format("\nКоличество пузырьков: {0}", this.CountBubbles);
            return str;
        }

        public static Soda Generate()
        {
            var rnd = new Random();
            var Types = new string[] { "Добрый кола", "Фанта", "Спрайт", "Пепси" };
            return new Soda
            {
                Volume = rnd.Next(1, 10),
                Type = Types[rnd.Next(0, Types.Length)],
                CountBubbles = rnd.Next(100, 1000)
            };
        }
    }

    public class Alcohol : Drink { 
        public int Strength = 50;
        public string Type = "Вино";

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
            var rnd = new Random();
            var Types = new string[] { "Вино", "Пиво", "Водка", "Коньяк" };
            return new Alcohol
            {
                Volume = rnd.Next(1, 10),
                Strength = rnd.Next(1, 100),
                Type = Types[rnd.Next(0, Types.Length)]
            };
        }
    }
    
}