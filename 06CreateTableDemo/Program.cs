using System.Reflection;
using _06TableDemoLib;

namespace _06CreateTableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"D:\DotNET\Codes\Practice\06EmployeeLib\bin\Debug\net8.0\06EmployeeLib.dll";
            Assembly asm = Assembly.LoadFrom(filepath);
            Type[] types = asm.GetTypes();
            string Query = "create table ";
            for(int i = 0; i < types.Length; i++)
            {
                Type type = types[i];
                Attribute[] allAttributes=type.GetCustomAttributes().ToArray();

                for(int j = 0; j < allAttributes.Length; j++)
                {
                    Attribute attr = allAttributes[j];

                    if(attr is Table)
                    {
                        Table table = attr as Table;
                        Query=Query+table.TableName+" (";
                    }
                }
                PropertyInfo[] allProperty=type.GetProperties();
                for(int k = 0; k < allProperty.Length; k++)
                {
                    PropertyInfo property = allProperty[k];
                    Attribute[] attributeProperty = property.GetCustomAttributes().ToArray();

                    for(int l = 0; l < attributeProperty.Length; l++)
                    {
                        Attribute attr = attributeProperty[l];

                        if(attr is Column)
                        {
                            Column column = attr as Column;
                            Query=Query+column.ColumnName +" "+column.ColumnType+" ,";
                        }
                    }
                }
            }
            Query = Query.TrimEnd(',') + ")";
            Console.WriteLine(Query);
        }
    }
}
