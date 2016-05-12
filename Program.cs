using System;

using AppKit;
using Foundation;

namespace MacDaemonScaffold {
	class MainClass {
		public static void Main (string [] args)
		{
			NSApplication.Init ();
			var alert = new NSAlert {
				MessageText = "Hello world!"
			};
			alert.RunModal ();
		}
	}
}
