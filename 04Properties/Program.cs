namespace _04Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Console.WriteLine("Enter Empoyee Id");
            int id= Convert .ToInt32(Console.ReadLine());
            e.eid = id;
            Console.WriteLine(e.eid);
            Console.WriteLine("Enter Empoyee Id");
            string name = Console.ReadLine();
            e.ename = name;
            Console.WriteLine(e.ename);
            e.log = new Logger();
            e.log.log();

        }
    }
    public class Employee
    {
        private int Eid;
        private string Ename;
        private Logger Log;

       public int eid
        {
            set
            {
                Eid = value;
            }
            get
            {
                return Eid;
            }
        }
        public string ename
        {
            set
            {
                Ename = value;
            }
            get
            {
                return Ename;
            }
        }
        public Logger log
        {
            set
            {
                Log = value;
            }
            get
            {
                return Log;
            }
        }
    }

    public class Logger
    {
        public void log()
        {
            Console.WriteLine("In Logger Method");
        }
    }
}
