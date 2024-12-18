using _06TableDemoLib;
namespace _06EmployeeLib
{
	[Table(TableName ="Employee")]
    public class Employee
    {
		
		private int _Id;
		private string _Name;

        [Column(ColumnName = "Id", ColumnType = "int")]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        [Column(ColumnName = "Name", ColumnType = "varchar(50)")]
        public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

       

	}
}
