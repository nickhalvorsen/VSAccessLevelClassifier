//------------------------------------------------------------------------------
// <copyright file="ProtectedMethodClassifierFormat.cs" company="Company">
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
    /// Defines an editor format for the ProtectedMethodClassifier type that has a purple background
    /// and is underlined.
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "ProtectedMethodClassifier")]
    [Name("ProtectedMethodClassifier")]
    [UserVisible(true)] // This should be visible to the end user
    [Order(After = Priority.High)] // high priority
    internal sealed class ProtectedMethodClassifierFormat : ClassificationFormatDefinition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedMethodClassifierFormat"/> class.
        /// </summary>
        public ProtectedMethodClassifierFormat()
        {
            this.DisplayName = "Access modifier Protected"; // Human readable version of the name
        }
    }
}
