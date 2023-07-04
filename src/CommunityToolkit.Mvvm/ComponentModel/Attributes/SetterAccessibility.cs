// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace CommunityToolkit.Mvvm.ComponentModel;

/// <summary>
/// Setter accessibility.
/// </summary>
public enum SetterAccessibility
{
    /// <summary>
    /// Public setter.
    /// </summary>
    Public,
    /// <summary>
    /// Protected setter.
    /// </summary>
    Protected,
    /// <summary>
    /// Internal setter.
    /// </summary>
    Internal,
    /// <summary>
    /// Private setter.
    /// </summary>
    Private
}