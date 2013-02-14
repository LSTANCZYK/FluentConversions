﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BoolConversionsStandard.cs" company="Brennan A. Fee">
//   Copyright (c) 2013 Brennan A. Fee. All Rights Reserved.  See License.txt in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Linq;

namespace FluentConversions.StringConversions.OtherConverters
{
    public class BoolConversionsStandard
    {
        private readonly string _input;

        internal BoolConversionsStandard(string input)
        {
            _input = input;
        }

        public bool Parse()
        {
            return GenericStringParser.Parse(_input, bool.Parse);
        }
    }
}
