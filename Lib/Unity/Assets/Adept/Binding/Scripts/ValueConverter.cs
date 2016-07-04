﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
using System;
using UnityEngine;
using Windows.UI.Xaml.Data;

namespace Adept.Unity
{
    public abstract class ValueConverter : MonoBehaviour, IValueConverter
    {
        /// <summary>
        /// Modifies the source data before passing it to the target for display in the UI.
        /// </summary>
        /// <param name="value">
        /// The source data being passed to the target.
        /// </param>
        /// <param name="targetType">
        /// The <see cref="Type"/> of data expected by the target property.
        /// </param>
        /// <param name="parameter">
        /// An optional parameter to be used in the converter logic.
        /// </param>
        /// <param name="language">
        /// The language of the conversion.
        /// </param>
        /// <returns>
        /// The value to be passed to the target property.
        /// </returns>
        public abstract object Convert(object value, Type targetType, object parameter, string language);

        /// <summary>
        /// Converts a value.
        /// </summary>
        /// <param name="value">
        /// The value that is produced by the binding target.
        /// </param>
        /// <param name="targetType">
        /// The type to convert to.
        /// </param>
        /// <param name="parameter">
        /// The converter parameter to use.
        /// </param>
        /// <param name="language">
        /// The language of the conversion.
        /// </param>
        /// <returns>
        /// A converted value.
        /// </returns>
        public abstract object ConvertBack(object value, Type targetType, object parameter, string language);
    }
}