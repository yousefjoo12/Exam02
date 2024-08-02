using Exam02.exams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Subject
{
	internal class Subject
	{
		public int SubjectId { get; set; }
		public string SubjectName { get; set; }
		public Exam Exam { get; set; }

		public Subject(int subjectId, string subjectName)
		{
			SubjectId = subjectId;
			SubjectName = subjectName;
		}
		public void creatQuestion()
		{
			int typeofexam;
			int timeofexam;
			int numberofQuestions;

			do
			{
				Console.WriteLine("Enter the Type of your exam : 1 = final , 2=partical");
				int.TryParse(Console.ReadLine(), out typeofexam);
			} while (typeofexam != 1 && typeofexam != 2);

			do
			{
				Console.WriteLine("Enter the Time of exam : ");
				int.TryParse(Console.ReadLine(), out timeofexam);
			} while (timeofexam < 0);
			do
			{
				Console.WriteLine("Enter the number of questions : ");
				int.TryParse(Console.ReadLine(), out numberofQuestions);
			} while (numberofQuestions < 0);
			if (typeofexam == 1)
			{
				FinalExam finalExam = new FinalExam(timeofexam, numberofQuestions);
				finalExam.Addquestions();
				Console.Clear();
				finalExam.ShowExam();

			}
			else
			{
				ParticalExam particalExam = new ParticalExam(timeofexam, numberofQuestions);
				particalExam.Addquestions();
				Console.Clear();
				particalExam.ShowExam();

			}
		}
	}
}
