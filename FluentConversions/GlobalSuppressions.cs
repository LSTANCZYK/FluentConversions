// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs" company="Brennan A. Fee">
//   Copyright (c) 2013 Brennan A. Fee. All Rights Reserved.  See License.txt in the project root for license information.
// </copyright>
// <summary>
//   This file is used by Code Analysis to maintain SuppressMessage
//   attributes that are applied to this project.
//   Project-level suppressions either have no target or are given
//   a specific target and scoped to a namespace, type, member, etc.
//   To add a suppression to this file, right-click the message in the
//   Code Analysis results, point to "Suppress Message", and click
//   "In Suppression File".
//   You do not need to add suppressions to this file manually.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Microsoft.Usage", "CA2243:AttributeStringLiteralsShouldParseCorrectly", 
        Justification = "Rule shouldn't fire for the AssemblyInformationalVersionAttribute.")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", 
    MessageId = "FluentConversions.StringConversions.NullableStringConversions.Decimal(System.Globalization.NumberStyles)", Scope = "member", 
    Target = "FluentConversions.StringConversions.NullableStringConversions.#Currency(System.Boolean)",
    Justification = "We specifically want the default culture info behavior provided by the framework.")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", 
    MessageId = "FluentConversions.StringConversions.StandardStringConversions.Decimal(System.Globalization.NumberStyles)", Scope = "member", 
    Target = "FluentConversions.StringConversions.StandardStringConversions.#Currency(System.Boolean)",
    Justification = "We specifically want the default culture info behavior provided by the framework.")]
