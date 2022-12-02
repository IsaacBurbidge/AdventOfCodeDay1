using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventOfCodeDay1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			StreamReader Input = new StreamReader("input.txt");
			List<string> Output = new List<string>();
			bool Reading = true;
			while(Reading)
			{
				string Calorie = Input.ReadLine();
				if (Calorie == null)
				{
					Reading = false;
				}
				else
				{
					Output.Add(Calorie);
				}
			}
			int HighestCalorie = 0;
			int SecondHighest = 0;
			int ThirdHighest = 0;
			int CurrentCalorie = 0;
			for(int i = 0; i < Output.Count; i++)
			{
				if(Output[i] != "")
				{
					CurrentCalorie += Convert.ToInt32(Output[i]);
				}
				else
				{
					if (CurrentCalorie > HighestCalorie)
					{
						ThirdHighest = SecondHighest;
						SecondHighest = HighestCalorie;
						HighestCalorie = CurrentCalorie;
						Console.WriteLine("Current highest = "+HighestCalorie);
					}else if(CurrentCalorie > SecondHighest)
					{
						ThirdHighest = SecondHighest;
						SecondHighest = CurrentCalorie;
						Console.WriteLine("Current second highest = " + SecondHighest);
					}
					else if (CurrentCalorie > ThirdHighest)
					{
						ThirdHighest = CurrentCalorie;
						Console.WriteLine("Current third highest = " + ThirdHighest);
					}
					CurrentCalorie = 0; 
				}
			}
			Console.WriteLine(HighestCalorie);
			Console.WriteLine(SecondHighest);
			Console.WriteLine(ThirdHighest);
			Console.WriteLine(HighestCalorie+SecondHighest+ThirdHighest);
			Console.ReadLine();
		}
	}
}
