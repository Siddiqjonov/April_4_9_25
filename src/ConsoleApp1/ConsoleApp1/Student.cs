using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

public class Student
{
	private int studentId;

	public int StudentId
	{
		get { return studentId; }
		set { studentId = value; }
	}

	private string fullName;

	public string FullName
	{
		get { return fullName; }
		set { fullName = value; }
	}

	public int Age { get; set; }

    public string Password { get; set; }
}
