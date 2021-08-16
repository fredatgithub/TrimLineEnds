using Microsoft.VisualStudio.Editor;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.TextManager.Interop;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace CMcG.TrimLineEnds
{
  [Export(typeof(IVsTextViewCreationListener))]
  [ContentType("text")]
  [TextViewRole(PredefinedTextViewRoles.Editable)]
  class VsTextViewCreationListener : IVsTextViewCreationListener
  {
    [Import]
    IVsEditorAdaptersFactoryService AdaptersFactory = null;

    public void VsTextViewCreated(IVsTextView textViewAdapter)
    {
      var wpfTextView = AdaptersFactory.GetWpfTextView(textViewAdapter);
      if (wpfTextView != null)
        CommandFilter.Register(textViewAdapter, new TrimLineEndsCommandFilter(wpfTextView));
    }
  }
}