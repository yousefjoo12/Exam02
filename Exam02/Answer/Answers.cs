using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Answer
{
	internal class Answers
	{
		public int AnswerId { get; set; }
		public string AnswerText { get; set; }
		public Answers(int _id, string _answer)
		{
			AnswerId = _id;
			AnswerText = _answer;
		}
		public Answers()
		{ 
		}
	}
}
