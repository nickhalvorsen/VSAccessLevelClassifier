//------------------------------------------------------------------------------
// <copyright file="PrivateMethodClassifierFormat.cs" company="Company">
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
    /// Defines an editor format for the PrivateMethodClassifier type that has a purple background
    /// and is underlined.
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "PrivateMethodClassifier")]
    [Name("PrivateMethodClassifier")]
    [UserVisible(true)] // This should be visible to the end user
    [Order(After = Priority.High)] // high priority
    internal sealed class PrivateMethodClassifierFormat : ClassificationFormatDefinition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateMethodClassifierFormat"/> class.
        /// </summary>
        public PrivateMethodClassifierFormat()
        {
            this.DisplayName = "C# 'private' keyword"; // Human readable version of the name
        }
    }
}
