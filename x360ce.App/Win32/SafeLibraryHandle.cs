﻿using System.Security;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace x360ce.App.Win32
{
	[SecurityCritical(SecurityCriticalScope.Everything), HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class SafeLibraryHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		internal SafeLibraryHandle()
			: base(true)
		{
		}

		protected override bool ReleaseHandle()
		{
			return NativeMethods.FreeLibrary(base.handle);
		}
	}

 

}
