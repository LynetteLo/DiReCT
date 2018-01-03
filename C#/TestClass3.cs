#define DEBUG

#define VC_V10

using System;

public class TestClass3
{
	public static void Main()
	{
	
		#if (DEBUG && !VC_V10)
			Console.WriteLine("DEBUG is defiend");
		#elif (!DEBUG && VC_V10)
			Console.WriteLine("DEBUG and VC_V10 are defined");
		#elif (DEBUG && VC_V10)
			Console.WriteLine("DEBUG and VC_V10 are defined");
		#else
			Console.WriteLine("DEBUG and VC_V10 are not defined");
		#endif
		Console.ReadKey();


	}


}