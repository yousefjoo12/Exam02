using Exam02.Answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Question
{
	abstract class Questions
	{
		public string Header { get; set; }
		public string Body { get; set; }
		public int Mark { get; set; }
		public Answers[] ListOfAnswers { get; set; }
		public int RightAnswer { get; set; }
		public int UserAnswer { get; set; }

		public Questions(string _Header, string _Body, int _Mark, int _NumberOFAnswers)
		{
			this.Header = _Header;
			this.Body = _Body;
			this.Mark = _Mark;
			this.ListOfAnswers = new Answers[_NumberOFAnswers];
		}
		public Questions()
		{
		}
		public bool IsCorrect()
		{
			return UserAnswer == RightAnswer;
		}
	}
}
