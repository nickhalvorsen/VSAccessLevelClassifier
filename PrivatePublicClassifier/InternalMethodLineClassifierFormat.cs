//------------------------------------------------------------------------------
// <copyright file="InternalMethodLineClassifierFormat.cs" company="Company">
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
    /// Defines an editor format for the InternalMethodLineClassifier type that has a purple background
    /// and is underlined.
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "InternalMethodLineClassifier")]
    [Name("InternalMethodLineClassifier")]
    [UserVisible(true)] // This should be visible to the end user
    [Order(Before = Priority.Default)] // Set the priority to be after the default classifiers
    internal sealed class InternalMethodLineClassifierFormat : ClassificationFormatDefinition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalMethodLineClassifierFormat"/> class.
        /// </summary>
        public InternalMethodLineClassifierFormat()
        {
            this.DisplayName = "InternalMethodLineClassifier"; // Human readable version of the name
            this.BackgroundColor = Colors.BlueViolet;
            this.TextDecorations = System.Windows.TextDecorations.Underline;
        }
    }
}
