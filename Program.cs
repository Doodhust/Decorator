namespace Decorator
{
    public interface IBeverage
    {
        public string getDescription();

        public double getCost();
    }

    public class Espresso : IBeverage
    {
        public double getCost()
        {
            return 4.99;
        }

        public string getDescription()
        {
            return "Espresso +";
        }
    }

    public class Raf : IBeverage
    {
        public double getCost()
        {
            return 9.50;
        }

        public string getDescription()
        {
            return "Raf +";
        }
    }
    public class Decaf : IBeverage
    {
        public double getCost()
        {
            return 9.99;
        }

        public string getDescription()
        {
            return "Decaf +";
        }
    }

    public class HouseBlend : IBeverage
    {
        public double getCost()
        {
            return 7;
        }

        public string getDescription()
        {
            return "HouseBlend +";
        }
    }

    public class Latte : IBeverage
    {
        public double getCost()
        {
            return 8.50;
        }

        public string getDescription()
        {
            return "Latte +";
        }
    }

    public interface CondimentDecorator : IBeverage { }

    public class MilkDecorator : CondimentDecorator
    {
        IBeverage wrappedObject;

        public MilkDecorator(IBeverage wrappedObject)
        {
            this.wrappedObject = wrappedObject;
        }

        public string getDescription()
        {
            return wrappedObject.getDescription() + " milk";
        }

        public double getCost()
        {
            return wrappedObject.getCost() + 1.50;
        }
    }

    public class SoyDecorator : CondimentDecorator
    {
        IBeverage wrappedObject;

        public SoyDecorator(IBeverage wrappedObject)
        {
            this.wrappedObject = wrappedObject;
        }

        public string getDescription()
        {
            return wrappedObject.getDescription() + " soy";
        }

        public double getCost()
        {
            return wrappedObject.getCost() + 0.99;
        }
    }

    public class MochaDecorator : CondimentDecorator
    {
        IBeverage wrappedObject;

        public MochaDecorator(IBeverage wrappedObject)
        {
            this.wrappedObject = wrappedObject;
        }

        public string getDescription()
        {
            return wrappedObject.getDescription() + " mocha";
        }

        public double getCost()
        {
            return wrappedObject.getCost() + 2.50;
        }
    }

    public class WhipDecorator : CondimentDecorator
    {
        IBeverage wrappedObject;

        public WhipDecorator(IBeverage wrappedObject)
        {
            this.wrappedObject = wrappedObject;
        }

        public string getDescription()
        {
            return wrappedObject.getDescription() + " whip";
        }

        public double getCost()
        {
            return wrappedObject.getCost() + 1.99;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IBeverage beverage = new MilkDecorator(new SoyDecorator(new WhipDecorator(new Raf())));
            Console.WriteLine("Order: " + beverage.getDescription());
            Console.WriteLine("Cost: " + beverage.getCost());

        }
    }
}