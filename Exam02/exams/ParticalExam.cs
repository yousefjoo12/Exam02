using Exam02.Answer;
using Exam02.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.exams
{
	internal class ParticalExam : Exam
	{

		public ParticalExam(int timeoeexam, int numberofquestions) : base(timeoeexam, numberofquestions)
		{
			questions = new Questions[numberofquestions];

		}
		public ParticalExam() : base() { }

		public Questions[] Addquestions()
		{
			for (int i = 0; i < NumberOfQuestions; i++)
			{


				questions[i] = new McqQuestion();
				questions[i].Header = "MCQ Question";
				Console.WriteLine("Enter the body of question:");
				questions[i].Body = Console.ReadLine();
				Console.WriteLine("Enter the marks of the question:");
				questions[i].Mark = int.Parse(Console.ReadLine());
				Console.WriteLine("Enter the number of choices:");
				int choicesCount = int.Parse(Console.ReadLine());
				questions[i].ListOfAnswers = new Answers[choicesCount];
				for (int j = 0; j < choicesCount; j++)
				{
					Console.WriteLine($"Enter choice {j + 1}:");
					questions[i].ListOfAnswers[j] = new Answers(j + 1, Console.ReadLine());
				}
				Console.WriteLine("Enter the right answer id:");
				questions[i].RightAnswer = int.Parse(Console.ReadLine());

			}
			return questions;

		}
	}
}
