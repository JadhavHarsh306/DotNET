namespace _01InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.SQL \n 2.MySQL \n 3.Oracle \n Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            DatabaseFactory dbfactory = new DatabaseFactory();
            IDatabase db = dbfactory.getDB(choice);
            Console.WriteLine("1.insert \n 2.update \n 3.delete \n Exit");
            int opchoice = Convert.ToInt32(Console.ReadLine());
            switch (opchoice)
            {
                case 1:
                    db.insert();
                    break;
                case 2:
                    db.update();
                    break;
                case 3:
                    db.delete();
                    break;
                case 4:
                    Console.WriteLine("Thanks For Visiting");
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;

            }
        }
    }

    public interface IDatabase
    {
        void insert();
        void update();
        void delete();

    }


    public class DatabaseFactory 
    {
        public IDatabase getDB(int choice)
        {
            IDatabase db = null;
            switch(choice){
                case 1:
                    db = new SQl();
                    break;
                case 2:
                    db=new MySQL();
                    break;
                case 3:
                    db=new Oracle();
                    break;
                case 4:
                    Console.WriteLine("Thanks For Visiting....");
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }
            return db;
        }
    }

    public class SQl:IDatabase
    {
        public void insert()
        {
            Console.WriteLine("Insertion Done SQL");
        }
        public void update()
        {
            Console.WriteLine("Updation Done SQL");
        }
        public void delete()
        {
            Console.WriteLine("Delete Done SQL");
        }
    }
    public class MySQL:IDatabase
    {
        public void insert()
        {
            Console.WriteLine("Insertion Done MySQL");
        }
        public void update()
        {
            Console.WriteLine("Updation Done MySQL");
        }
        public void delete()
        {
            Console.WriteLine("Delete Done MySQL");
        }
    }
    public class Oracle:IDatabase
    {
        public void insert()
        {
            Console.WriteLine("Insertion Done Oracle");
        }
        public void update()
        {
            Console.WriteLine("Updation Done Oracle");
        }
        public void delete()
        {
            Console.WriteLine("Delete Done Oracle");
        }
    }
}
