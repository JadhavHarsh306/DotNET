namespace _01InterfaceDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IX f1 = new Cmath();
            IY f2 = new Cmath();
            f1.add(20,30);
            f1.multiply(20,30);
            f2.add(20,30);
            f2.subtract(20,30);
        }
    }

    public interface IX
    {
        void add(int x,int y);
        void multiply(int x, int y);
    }

    public interface IY
    {
        void add(int x, int y);
        void subtract(int x, int y);
    }

    public class Cmath:IX,IY
    {
        void IX.add(int x, int y)
        {
            Console.WriteLine("Addition is: " + (x + y));
        }

        void IY.add(int x, int y)
        {
            Console.WriteLine("Addition is: " + (x + y+100));
        }


        public void multiply(int x,int y)
        {
            Console.WriteLine("Multipication is: "+(x*y));
        }
        public void subtract(int x, int y)
        {
            Console.WriteLine("subtraction is: " + (x - y));
        }
    }
}
