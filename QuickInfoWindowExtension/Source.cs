using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Language.Intellisense;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Operations;
using Microsoft.VisualStudio.Text.Tagging;
using Microsoft.VisualStudio.Utilities;

namespace QuickInfoWindowExtension
{
    internal class Source : IQuickInfoSource
    {
        public void AugmentQuickInfoSession(IQuickInfoSession session, IList<object> quickInfoContent, out ITrackingSpan applicableToSpan)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    internal class SourceProvider : IQuickInfoSourceProvider
    {
        public IQuickInfoSource TryCreateQuickInfoSource(ITextBuffer textBuffer)
        {
            throw new NotImplementedException();
        }
    }

    internal class Controller : IIntellisenseController
    {
        public void ConnectSubjectBuffer(ITextBuffer subjectBuffer)
        {
            throw new NotImplementedException();
        }

        public void Detach(ITextView textView)
        {
            throw new NotImplementedException();
        }

        public void DisconnectSubjectBuffer(ITextBuffer subjectBuffer)
        {
            throw new NotImplementedException();
        }
    }

    internal class ControllerProvider : IIntellisenseControllerProvider
    {
        public IIntellisenseController TryCreateIntellisenseController(ITextView textView, IList<ITextBuffer> subjectBuffers)
        {
            throw new NotImplementedException();
        }
    }
}
