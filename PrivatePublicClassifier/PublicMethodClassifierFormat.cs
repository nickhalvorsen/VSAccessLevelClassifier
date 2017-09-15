//------------------------------------------------------------------------------
// <copyright file="PublicMethodClassifierFormat.cs" company="Company">
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
    /// Defines an editor format for the PublicMethodClassifier type that has a purple background
    /// and is underlined.
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [FileExtension(".cs")]
    [ClassificationType(ClassificationTypeNames = "PublicMethodClassifier")]
    [Name("PublicMethodClassifier")]
    [UserVisible(true)] // This should be visible to the end user
    [Order(After = Priority.High)] // high priority
    internal sealed class PublicMethodClassifierFormat : ClassificationFormatDefinition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicMethodClassifierFormat"/> class.
        /// </summary>
        public PublicMethodClassifierFormat()
        {
            this.DisplayName = "C# 'public' keyword"; // Human readable version of the name
        }
    }
}
