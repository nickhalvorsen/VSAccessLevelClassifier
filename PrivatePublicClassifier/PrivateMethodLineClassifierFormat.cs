//------------------------------------------------------------------------------
// <copyright file="PrivateMethodLineClassifierFormat.cs" company="Company">
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
    /// Defines an editor format for the PrivateMethodLineClassifier type that has a purple background
    /// and is underlined.
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "PrivateMethodLineClassifier")]
    [Name("PrivateMethodLineClassifier")]
    [UserVisible(true)] // This should be visible to the end user
    [Order(Before = Priority.Default)] // Set the priority to be after the default classifiers
    internal sealed class PrivateMethodLineClassifierFormat : ClassificationFormatDefinition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateMethodLineClassifierFormat"/> class.
        /// </summary>
        public PrivateMethodLineClassifierFormat()
        {
            this.DisplayName = "Access modifier Private method line"; // Human readable version of the name
        }
    }
}
