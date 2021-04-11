using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Playground
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("App inicio");

			var path = Directory.GetCurrentDirectory();

			var exePath = @$"{path}\aux-app\AppFramerwork.exe";

			var items = new List<string> { "item1", "item2", "item3" };

			ProcessStartInfo info = new ProcessStartInfo(exePath, string.Join(" ", items));

			Process p = Process.Start(info);

			p.WaitForExit();

			Console.WriteLine($"Aux app exitcode = {p.ExitCode}");

			Console.WriteLine("App fim");

			Console.ReadLine();
		}
	}
}
