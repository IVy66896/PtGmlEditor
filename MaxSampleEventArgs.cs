using System;
using System.Diagnostics;

public class MaxSampleEventArgs : EventArgs
{
	public float MaxSample
	{
		get;
		private set;
	}

	public float MinSample
	{
		get;
		private set;
	}
