using System;

namespace BoxApplication2
{
	class Box
	{
		private double length;	
			
		private double breadth;

		private double height;

		public void setLength( double len)
		{
			length = len;
		}
		
		public void setBreadth( double bre )
		{
			breadth = bre;
		}

		public void setHeight( double hei )
		{
			height = hei;
		}	
		public double getVolume()
		{
			return length * breadth * height;
		}
	}
		class Boxtester
		{
			static void Main(string[] args)
			{
				Box Box1 = new Box();

				Box Box2 = new Box();

				double volume;

				//Declare Box2 of type Box
			
				// box 1 specification

				Box1.setLength(6.0);

				Box1.setLength(7.0);

				Box1.setLength(5.0);

				//box 2 specification
 				
				Box2.setLength(12.0);

				Box2.setBreadth(13.0);

				Box2.setHeight(10.0);

				// volume of box 1
				
				volume = Box1.getVolume();

				Console.WriteLine("Volume of Box1 : {0}", volume);

				// volume of box 2

				volume = Box2.getVolume();

				Console.WriteLine("Volume of Box2 : {0}", volume);

				Console.ReadKey();

			}
	
		}

}