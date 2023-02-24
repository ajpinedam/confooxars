using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace confoolasters.Skia.Tizen
{
	public sealed class Program
	{
		static void Main(string[] args)
		{
			var host = new TizenHost(() => new confoolasters.App());
			host.Run();
		}
	}
}
