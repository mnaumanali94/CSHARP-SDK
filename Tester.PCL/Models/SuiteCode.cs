/*
 * Tester.PCL
 *
 * This file was automatically generated for Stamplay by APIMATIC v2.0 ( https://apimatic.io ) on 08/08/2016
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Tester.PCL;

namespace Tester.PCL.Models
{
    public enum SuiteCode
    {
        HEARTS = 1, //TODO: Write general description for this method
        SPADES = 2, //TODO: Write general description for this method
        CLUBS = 3, //TODO: Write general description for this method
        DIAMONDS = 4, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type SuiteCode
    /// </summary>
    public static class SuiteCodeHelper
    {
        /// <summary>
        /// Convert a list of SuiteCode values to a list of integers
        /// </summary>
        /// <param name="enumValues">The list of SuiteCode values to convert</param>
        /// <returns>The list of representative integer values</returns>
        public static List<int> ToValue(List<SuiteCode> enumValues)
        {
            if (null == enumValues)
                return null;
            
            return enumValues.Select(eVal => (int)eVal).ToList();
        }
    }
} 