using System;
using System.IO;

namespace OggDecoder
{
	/// <summary>
	/// Ogg Vorbis decoder test application.
	/// </summary>
	internal class Decoder
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		//[STAThread]
		private static void Main(string[] args)
		{
			TextWriter s_err = Console.Error;
			FileStream input = null, output = null;
			if (args.Length == 2)
			{
				try
				{
					input = new FileStream(path: args[0], mode: FileMode.Open, access: FileAccess.Read);
					output = new FileStream(path: args[1], mode: FileMode.OpenOrCreate);
				}
				catch (Exception e)
				{
					s_err.WriteLine(value: e);
				}
			}
			else
			{
				return;
			}
			OggDecodeStream decode = new OggDecodeStream(input: input, skipWavHeader: true);
			byte[] buffer = new byte[4096];
			int read;
			while ((read = decode.Read(buffer: buffer, offset: 0, count: buffer.Length)) > 0)
			{
				output.Write(array: buffer, offset: 0, count: read);
			}
			// Close some files
			input.Close();
			output.Close();
		}
	}
}

