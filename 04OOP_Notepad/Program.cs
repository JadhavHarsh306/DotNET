using System.Threading.Channels;

namespace _04OOP_Notepad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LangFactory lf = new LangFactory();
            ILangChecker lc = lf.spellcheck("hindi");
            Notepad n = new Notepad(lc);
            lc.langcheck();
            
        }
    }
    public class Notepad
    {
        ILangChecker lc;
        LangFactory lf = new LangFactory();
        public Notepad(ILangChecker lc1)
        {
            if (lc1 == null)
            {
               lc= lf.spellcheck("en");
            }
            else
            {
                lc = lc1;
            }
        }
        public void checklang()
        {
            lc.langcheck();
        }
    }
    public interface ILangChecker
    {
        void langcheck();
    }

    public class LangFactory
    {
        public ILangChecker spellcheck(string lang)
        {
            ILangChecker lc = null;
            switch (lang)
            {
                case "en":
                    lc = new englishlang();
                    break;
                case "hindi":
                    lc = new hindilang();
                    break;
                case "marathi":
                    lc= new marathilang();
                    break;
            }
            return lc;
        }
    }
    public class hindilang: ILangChecker
    {
        public void langcheck()
        {
            Console.WriteLine("Hindi language checked");
        }
    }
    public class englishlang: ILangChecker
    {
        public void langcheck()
        {
            Console.WriteLine("English language checked");
        }
    }
    public class marathilang: ILangChecker
    {
        public void langcheck()
        {
            Console.WriteLine("Marathi language checked");
        }
    }
}
