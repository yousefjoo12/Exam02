using Exam02.Question;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.exams
{
	internal abstract class Exam
	{

		public int TimeOfExam { get; set; }
		public int NumberOfQuestions { get; set; }
		public Questions[] questions { get; set; }
		public Exam(int timeofexam, int numberofquestions)
		{
			this.TimeOfExam = timeofexam;
			this.NumberOfQuestions = numberofquestions;
			this.questions = new Questions[numberofquestions];

		}
		public Exam() { }
		public void ShowExam()
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();

			for (int i = 0; i < NumberOfQuestions; i++)
			{
				if (questions[i] != null)
				{
					Console.WriteLine(questions[i].Header);
					Console.WriteLine(questions[i].Body);
					for (int j = 0; j < questions[i].ListOfAnswers.Length; j++)
					{
						if (questions[i].ListOfAnswers[j] != null)
						{
							Console.WriteLine($"{questions[i].ListOfAnswers[j].AnswerId}: {questions[i].ListOfAnswers[j].AnswerText}");
						}
					}
					Console.Write("Enter your answer: ");
					questions[i].UserAnswer = int.Parse(Console.ReadLine());
				}
			}

			stopwatch.Stop();
			TimeSpan timeTaken = stopwatch.Elapsed;
			Console.Clear();
			Console.WriteLine("Exam Completed!");
			ShowResults();
			Console.WriteLine($"Time taken: {timeTaken.Minutes} minutes and {timeTaken.Seconds} seconds");
		}

		private void ShowResults()
		{
			int totalMarks = 0;
			int obtainedMarks = 0;

			for (int i = 0; i < NumberOfQuestions; i++)
			{
				if (questions[i] != null)
				{
					Console.WriteLine(questions[i].Header);
					Console.WriteLine(questions[i].Body);
					foreach (var answer in questions[i].ListOfAnswers)
					{
						if (answer != null)
							Console.WriteLine($"{answer.AnswerId}: {answer.AnswerText}");
					}
					Console.WriteLine($"Your answer: {questions[i].UserAnswer}");
					Console.WriteLine($"Correct answer: {questions[i].RightAnswer}");

					totalMarks += questions[i].Mark;
					if (questions[i].IsCorrect())
					{
						obtainedMarks += questions[i].Mark;
					}
				}
			}
			Console.WriteLine($"Total Marks: {totalMarks}");
			Console.WriteLine($"Obtained Marks: {obtainedMarks}");
			Console.WriteLine($"t3bnakm m3ana");
		}



	}
}
