using Exam02.Answer;
using Exam02.exams;
using Exam02.Question;
using Exam02.Subject;

namespace exam
{


	internal class Program
	{

		static void Main(string[] args)
		{

			Subject subject = new Subject(10, "C#");
			subject.creatQuestion();

		}
	}
}