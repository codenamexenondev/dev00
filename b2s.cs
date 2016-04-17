using System;
using System.Text;

class b2s
{
	static void Main(string[] args)
	{
		// 0x82-0xA0 = あ
		byte[] byteArraySJIS = { 0x82, 0xA0 };
		string str = Encoding.Default.GetString(byteArraySJIS);

		Console.WriteLine( "--- byte to string SJIS ---" );
		Console.WriteLine( "Input: " + BitConverter.ToString(byteArraySJIS) );
		Console.WriteLine( "S-JIS: " + str);


		// 0xE3-0x81-0x82 = あ
		byte[] byteArrayUTF8 = { 0xE3, 0x81, 0x82 };
		str = Encoding.UTF8.GetString(byteArrayUTF8);

		Console.WriteLine( "--- byte to string UTF8 ---" );
		Console.WriteLine( "Input: " + BitConverter.ToString(byteArrayUTF8) );
		Console.WriteLine( "UTF-8: " + str);
	}
}

