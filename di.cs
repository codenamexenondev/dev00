using System;
using System.IO;

class Program {
	static void Main(string[] args) {
		// 現在のディレクトリ情報を取得
		System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(".");

		// 現在のディレクトリ下のサイズを取得
		// サイズ情報はdir /Sの結果と同等
		long dirsize = GetDirectorySize(di);
		Console.WriteLine("{0}", dirsize);
	}

	public static long GetDirectorySize(DirectoryInfo dirInfo) {

		long size = 0;
		long curSize = 0;

		foreach (FileInfo fi in dirInfo.GetFiles()) {
			//Console.WriteLine("{0}: {1}", fi.Length, fi.Name);
			size += fi.Length;
		}

		foreach (DirectoryInfo di in dirInfo.GetDirectories()) {
			curSize = GetDirectorySize(di);
			Console.WriteLine("{0}: {1}", curSize, di.FullName);
			size += curSize;
		}
		return size;
	}
}

