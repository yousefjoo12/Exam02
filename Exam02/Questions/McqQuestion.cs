using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Question
{
	internal class McqQuestion : Questions
	{
		public McqQuestion(string headofquestion, string BodyOfQuestion, int Mark, int NumberOFAnswers) : base(headofquestion, BodyOfQuestion, Mark, 2)
		{

		}
		public McqQuestion() : base()
		{

		}
	}
}
