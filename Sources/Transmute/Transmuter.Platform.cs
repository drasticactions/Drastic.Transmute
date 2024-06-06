using System;
namespace Transmute
{
	public partial class Transmuter
	{
		#if !ANDROID && !IOS && !MACCATALYST && !TVOS
		public void RegisterPlatform() { }
		#endif
	}
}
