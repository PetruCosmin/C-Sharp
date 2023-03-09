namespace ConsoleApp1
{
	public class Student
	{
		public Student()
		{
		}

		private int studID;
		private string studNume;
		private string studDate;

		public int Id
		{get{return studID;}
			set	{studID = value;}
		}

		public string Name
		{
			get{return studNume;}
			set	{studNume = value;}

		}
		public string DateUniv
		{
			get { return studDate; }
			set { studDate = value; }
		}
	}
}