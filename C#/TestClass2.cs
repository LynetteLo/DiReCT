using System;

using first_space;

using first_space.second_space;

namespace first_space
{
	class abc
	{
		public void func()
		{
			Console.WriteLine("Inside first_space");
		}
	
	}
	namespace second_space
	{
		class efg
			{
			public void func()
			{
			Console.WriteLine("Inside second_space");
			}
	
			}
	
	}


}

class TestClass2
{
	static void Main(string[] args)
	{
		abc fc = new abc();
	
		efg sc = new efg();

		fc.func();

		sc.func();

		Console.ReadKey();

	}

}