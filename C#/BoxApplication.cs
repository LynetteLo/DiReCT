using System;

namespace BoxApplication

{

	class Box
	{
		public double length; // Length of a box

		public double breadth; // Breadth of a box

		public double height;  // Height of a box

	}

	class Boxtester
	{
	static void Main(string[] args)
	{
		Box Box1 = new Box();

		Box Box2 = new Box();

		double volumn = 0.0;

		Box1.height = 5.0;

		Box1.length = 6.0;

		Box1.breadth = 7.0;

		Box2.height = 10.0;

		Box2.length = 12.0;
	
		Box2.breadth = 13.0;
		
		volumn = Box1.height * Box1.length * Box1.breadth;

		Console.WriteLine("Volumn of Box1 : {0}", volumn);

		volumn = Box2.height * Box2.length * 	Box2.breadth;

		Console.WriteLine("Volumn of Box2 : {0}", volumn);

		Console.ReadKey();


	}

	}



}