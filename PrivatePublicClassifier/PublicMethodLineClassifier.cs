//------------------------------------------------------------------------------
// <copyright file="PublicMethodLineClassifier.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;

namespace PrivatePublicClassifier
{
    /// <summary>
    /// Classifier that classifies all text as an instance of the "PublicMethodLineClassifier" classification type.
    /// </summary>
    internal class PublicMethodLineClassifier : IClassifier
    {
        /// <summary>
        /// Classification type.
        /// </summary>
        private readonly IClassificationType classificationType;

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicMethodLineClassifier"/> class.
        /// </summary>
        /// <param name="registry">Classification registry.</param>
        internal PublicMethodLineClassifier(IClassificationTypeRegistryService registry)
        {
            this.classificationType = registry.GetClassificationType("PublicMethodLineClassifier");
        }

        #region IClassifier

#pragma warning disable 67

        /// <summary>
        /// An event that occurs when the classification of a span of text has changed.
        /// </summary>
        /// <remarks>
        /// This event gets raised if a non-text change would affect the classification in some way,
        /// for example typing /* would cause the classification to change in C# without directly
        /// affecting the span.
        /// </remarks>
        public event EventHandler<ClassificationChangedEventArgs> ClassificationChanged;

#pragma warning restore 67

        /// <summary>
        /// Gets all the <see cref="ClassificationSpan"/> objects that intersect with the given range of text.
        /// </summary>
        /// <remarks>
        /// This method scans the given SnapshotSpan for potential matches for this classification.
        /// In this instance, it classifies everything and returns each span as a new ClassificationSpan.
        /// </remarks>
        /// <param name="span">The span currently being classified.</param>
        /// <returns>A list of ClassificationSpans that represent spans identified to be of this classification.</returns>
        public IList<ClassificationSpan> GetClassificationSpans(SnapshotSpan span)
        {
            var result = new List<ClassificationSpan>();

            var lineText = span.GetText().TrimStart().ToLower();
            var indentSize = span.GetText().Length - span.GetText().TrimStart().Length;

            if (lineText.StartsWith("public ")
                && lineText.Contains("(")
                && lineText.Contains(")"))
            {
                result.Add(new ClassificationSpan(new SnapshotSpan(span.Snapshot, new Span(span.Start.Add(indentSize), span.Length)), this.classificationType));
            }

            return result;
        }

        #endregion
    }
}
