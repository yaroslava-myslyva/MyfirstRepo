using System;

namespace Loops
{
	class Program
	{
		static void Main(string[] args)
		{


			/*
			// Ёлочка №1
			// *
			// **
			// ***
			 
			int y = 0;
			int a = 8;
			
			while (y < a)
			{
				int x = 0;
						  
				while (x <=y)
				{
					Console.Write("*");
					x = x + 1;
				}
				y = y + 1;
				Console.WriteLine("");
			}
			*/


			// Ёлочка #2

			// ***
			// **
			// *

			/*
			 int y = 5;
			 int a = 0;

			 while (y >= a)
			 {
				 int x = 0;

				 while (x <= y)
				 {
					 Console.Write("*");
					 x = x + 1;
				 }
				 y = y - 1;
				 Console.WriteLine("");
			 }
			 */

			// Ёлочка 3

			//      *
			//    **
			//  ***
			/*
			int y = 1;
			int a = 15;

			while (y <= a)
			{
				int x = 1;

				 while (x <= y)
				 {
					 int p = a;

					 while (p > y & x<2)
					 {
						 Console.Write(" ");
						 p=p-1;
					}
					x = x + 1;
					Console.Write("*");
				}
				y = y + 1;
				Console.WriteLine("");
			}
			*/

			// Ёлочка 4

			// ***
			//   **
			//    *
			/*
			int y = 1;
			int a = 5;

			while (y <= a)
			{
				int x = a;

				while (x >= y)
				{
					int p = 1;

					while (p < y & x < 2)
					{
						Console.Write(" ");
						p = p + 1;
					}
					x = x - 1;
					Console.Write("*");
				}
				y = y + 1;
				Console.WriteLine("");
			}
			*/

			// Ёлочка 5

			//      *
			//     ***
			//   *****
			/*
			int y = 1;
			int a =5;

			while (y<=a)
            {
				int p = a;
				while (p >y)
				{
					Console.Write(" ");
					p = p - 1;
				}
				int x = 1;
				while (y > 1 & x < y)
				{
					Console.Write("**");
					x = x + 1;
				}
				Console.Write("*");
				Console.WriteLine("");
				y = y + 1;
			}
			*/


			// Пифагор

			Console.WriteLine();
			Console.WriteLine("Введите начальное значение высоты:");
			int y1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите конечное значение высоты:");
			int y2 = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите начальное значение ширины:");
			int x1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите конечное значение ширины:");
			int x2 = int.Parse(Console.ReadLine());

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();

			// первая строка
			int spacecorner = y2;
			while (spacecorner >=1)
			{
				Console.Write(" ");
				spacecorner = spacecorner / 10;
			}
			Console.Write("|");

			int x = x1;
			while (x <= x2)
			{
				// пробелы начало
				int valueresultmax = x2*y2;
				int spaceresultmax = 0;
				while (valueresultmax >= 1)
				{
					valueresultmax = valueresultmax / 10;
					spaceresultmax = spaceresultmax + 1;
				}
				int valuex = x;
				int spacex = 0;
				while (valuex >= 1)
				{
					valuex = valuex / 10;
					spacex = spacex + 1;
				}
				int spacexresult = spaceresultmax - spacex;
				while (spacexresult > 0)
				{
					Console.Write(" ");
					spacexresult = spacexresult - 1;
				}
				// пробелы конец
				Console.Write("  "+ x);
				x = x + 1;
			}
			Console.WriteLine();

			// разделительна строка
			int string1 = y2;
			while (string1 >= 1)
			{
				Console.Write("-");
				string1 = string1 / 10;
			}
			Console.Write("+");
			int string2 = x1;
			while (string2 <= x2)
			{
				int stringresultmax = x2 * y2;
				while (stringresultmax >= 1)
				{
					Console.Write("-");
					stringresultmax = stringresultmax / 10;
				}
				Console.Write("--");
				string2 = string2 + 1;
			}
			Console.WriteLine();

			// основная часть

			int y = y1;
			while (y <= y2)
			{
				// y 
				// пробелы начало
				int valuey2 = y2;
				int spacey2 = 0;
				while(valuey2>=1)
                {
					valuey2 = valuey2 / 10;
					spacey2 = spacey2 + 1;
                }
				int valuey = y;
				int spacey = 0;
				while (valuey >= 1)
				{
					valuey = valuey / 10;
					spacey = spacey + 1;
				}
				int spaceyresult = spacey2 - spacey;
				while (spaceyresult>0)
                {
					Console.Write(" ");
					spaceyresult = spaceyresult - 1;
                }
				// пробелы конец
				Console.Write(y);
				Console.Write("|");
				
				// результаты начало
				int xresult = x1;
				while(xresult <= x2)
                {
					// пробелы начало
					int valueresultmax = x2 * y2;
					int spaceresultmax = 0;
					while (valueresultmax >= 1)
					{
						valueresultmax = valueresultmax / 10;
						spaceresultmax = spaceresultmax + 1;
					}

					int valueresult = xresult * y;
					int spaceresult = 0;
					while (valueresult >= 1)
					{
						valueresult = valueresult / 10;
						spaceresult = spaceresult + 1;
					}
					int spaceresultresult = spaceresultmax - spaceresult;
					while (spaceresultresult > 0)
					{
						Console.Write(" ");
						spaceresultresult = spaceresultresult - 1;
					}
					// пробелы конец
					Console.Write("  " + xresult*y);

					xresult = xresult + 1;
                }
				Console.WriteLine();
				y = y + 1;



			}





			
		}





		/*while (y2<=a)
		{
			int x = 1;
			while (x<=a)
			{
				if (x * y < 10)
				{
					Console.Write("   ");
				}
				else if (x*y <100)
				{
					Console.Write("  ");
				}
				else
				{
					Console.Write(" ");
				}
				Console.Write(x * y);
					x = x+ 1;
			}
			Console.WriteLine("");
			y = y + 1;
		}
		*/





	}

}
	
