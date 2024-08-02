using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Question
{
	internal class TrueOrFalseQuestion : Questions
	{
		public TrueOrFalseQuestion(string headofquestion, string BodyOfQuestion, int Mark) : base(headofquestion, BodyOfQuestion, Mark, 2)
		{

		}
		public TrueOrFalseQuestion() : base()
		{

		}

	}
}
