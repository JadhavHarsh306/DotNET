namespace _01abstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.PDF \n2.DOCX \n3.TXT \n4.XML\nChoice");
            int choice=Convert.ToInt32(Console.ReadLine());
            ReportFactory rfactory = new ReportFactory();
            report r = rfactory.Get(choice);
            r.flow();
        }
    }

    public interface IReport
    {
        void flow();
    }

    public abstract class report
    {
        protected abstract void parse();
        protected abstract void validate();
        protected abstract void save();
        public virtual void flow()
        {
            parse();
            validate();
            save();
        }

    }
    public abstract class SpecialReport:report
    {
        protected abstract void revalidate();
        public override void flow()
        {
            parse();
            validate();
            revalidate();
            save();
        }
    }

    public class ReportFactory
    {
        public report Get(int choice)
        {
            report r = null;
            switch (choice)
            {
                case 1:
                    r = new PDF();
                    break;
                case 2:
                    r = new DOCX();
                    break;
                case 3:
                    r=new TXT();
                    break;
                case 4:
                    r = new XML();
                    break;
            }
            return r;
        }
    }
    public class PDF:report
    {
        protected override void parse()
        {
            Console.WriteLine("PDF Parsed");
        }
        protected override void validate()
        {
            Console.WriteLine("PDF Validated");
        }
        protected override void save()
        {
            Console.WriteLine("PDF Saved");
        }
    }
    public class DOCX:report
    {
        protected override void parse()
        {
            Console.WriteLine("DOCX Parsed");
        }
        protected override void validate()
        {
            Console.WriteLine("DOCX Validated");
        }
        protected override void save()
        {
            Console.WriteLine("DOCX Saved");
        }
    }
    public class TXT:report
    {
        protected override void parse()
        {
            Console.WriteLine("TXT Parsed");
        }
        protected override void validate()
        {
            Console.WriteLine("TXT Validated");
        }
        protected override void save()
        {
            Console.WriteLine("TXT Saved");
        }
    }
    public class XML:SpecialReport
    {
        protected override void parse()
        {
            Console.WriteLine("XML Parsed");
        }
        protected override void validate()
        {
            Console.WriteLine("XML Validated");
        }
        protected override void revalidate()
        {
            Console.WriteLine("XML revalidated");
        }
        protected override void save()
        {
            Console.WriteLine("XML Saved");
        }
        
    }
}
