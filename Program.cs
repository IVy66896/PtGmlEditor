using LINQPad.Cmd;
using System;
using System.IO;

internal class Program
{
	[STAThread]
	[LoaderOptimization(LoaderOptimization.MultiDomainHost)]
	private static int Main(string[] args)
	{
		try
		{
			return Go(args);
		}
		catch (FileNotFoundException ex)
		{
			Console.WriteLine(ex.Message);
			return 1;
		}
	}

	private static int Go(string[] args)
	{
		return LINQPad.Cmd.LPCmd.Run(args);
	}
}
