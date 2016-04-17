using System;
using System.Text;

class s2b {
	public static void Main(string[] args) {
		// Check arguments
		if ( args.Length != 1 ) {
			Console.WriteLine( "Syntax: s2b character" );
			Console.WriteLine( "Examples" );
			Console.WriteLine( "s2b あ" );
			Console.WriteLine( "S_JIS: 82-A0" );
			Console.WriteLine( "UTF-8: E3-81-82" );
			
			return;
		}

		string str = args[0];

		Encoding sjis = Encoding.GetEncoding("Shift_JIS");
		byte[] byteArraysSjis = sjis.GetBytes(str);

		Console.WriteLine("S_JIS: " + BitConverter.ToString(byteArraysSjis));

		Encoding utf8 = Encoding.GetEncoding("UTF-8");
		byte[] byteArraysUtf8 = utf8.GetBytes(str);

		Console.WriteLine("UTF-8: " + BitConverter.ToString(byteArraysUtf8));
	}
}

