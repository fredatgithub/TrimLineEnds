using Microsoft.VisualStudio.Shell;
using System;
using System.Runtime.InteropServices;

namespace TrimLineEnds
{
  [PackageRegistration(UseManagedResourcesOnly = true)]
  [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
  [ProvideMenuResource("Menus.ctmenu", 1)]
  [Guid(GuidList.guidTrimLineEndsPkgString)]
  public abstract class TrimLineEndsPackageBase : Package
  {
  }
}
