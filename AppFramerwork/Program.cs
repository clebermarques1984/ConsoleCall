using System;
using System.Linq;

namespace AppFramerwork
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			if (!args.Any())
				throw new ArgumentException("Args deve ser preenchido", nameof(args));

			Console.WriteLine("Aux app inicio");

			foreach (var item in args)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("Aux app fim");
		}
	}
}
