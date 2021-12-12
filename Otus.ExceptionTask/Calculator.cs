using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.ExceptionTask
{
	class Calculator
	{
		class Operands
		{
			public int Arg1 { get; set; }

			public int Arg2 { get; set; }

			public char Operand { get; set; }
		}
		public void Calculate()
		{
			string s;
			while ((s = Console.ReadLine()) != "exit")
			{
				var operands = Parse(s);

				int res = 0;
				var a = operands.Arg1;
				var b = operands.Arg2;
				switch (operands.Operand)
				{
					case '+':
						res = Sum(a, b);
						break;
					case '-':
						res = Sub(a, b);
						break;
					case '*':
						res = Mul(a, b);
						break;
					case '/':
						res = Div(a, b);
						break;
				}

				Console.WriteLine(res);
			}
		}


		int Sum(int a, int b)
		{
			return a + b;
		}

		int Sub(int a, int b)
		{
			return a - b;
		}

		int Div(int a, int b)
		{
			return a / b;
		}

		int Mul(int a, int b)
		{
			return a * b;
		}



		Operands Parse(string s)
		{
			var operands = s.Split(' ');
			var a1 = int.Parse(operands[0]);
			var a2 = int.Parse(operands[2]);
			var op = operands[1][0];
			return new Operands
			{
				Arg1 = a1,
				Arg2 = a2,
				Operand = op
			};
		}
	}
}
