using System;

public interface IAudioPlayer : IDisposable
{
	TimeSpan CurrentPosition
	{
		get;
		set;
	}

	TimeSpan StartPosition
	{
		get;
		set;
	}

	TimeSpan EndPosition
	{
		get;
		set;
	}

	void LoadFile(string path);

	void Play();

	void Stop();
}
