//------------------------------------------------------------------------------
// <copyright file="InternalMethodClassifierFormat.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace PrivatePublicClassifier
{
    /// <summary>
    /// Defines an editor format for the InternalMethodClassifier type that has a purple background
    /// and is underlined.
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [FileExtension(".cs")]
    [ClassificationType(ClassificationTypeNames = "InternalMethodClassifier")]
    [Name("InternalMethodClassifier")]
    [UserVisible(true)] // This should be visible to the end user
    [Order(After = Priority.High)] // high priority
    internal sealed class InternalMethodClassifierFormat : ClassificationFormatDefinition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalMethodClassifierFormat"/> class.
        /// </summary>
        public InternalMethodClassifierFormat()
        {
            this.DisplayName = "C# 'internal' keyword"; // Human readable version of the name
        }
    }
}
