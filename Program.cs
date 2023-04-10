using System;

namespace task_4
{
	class Program
	{
		static void Main(string[] args)
		{
			string name;
			int age;
			string zodiac;
			string workPlace;
			Console.WriteLine("введите имя");
			name = Console.ReadLine();
			Console.WriteLine("ваш возраст");
			age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("ваш знак зодиака");
			zodiac = Console.ReadLine();
			Console.WriteLine("ваше место работы");
			workPlace = Console.ReadLine();
			Console.WriteLine($"Здравствуйте {name}, вам {age}, по знаку зодиака вы - {zodiac}, ваше место работы - {workPlace}");
		}
	}
}
