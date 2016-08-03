/*
 * Tester.PCL
 *
 * This file was automatically generated for Stamplay by APIMATIC v2.0 ( https://apimatic.io ) on 08/03/2016
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Tester.PCL;

namespace Tester.PCL.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum Days
    {
        SUNDAY, //TODO: Write general description for this method
        MONDAY, //TODO: Write general description for this method
        TUESDAY, //TODO: Write general description for this method
        WEDNESDAY, //TODO: Write general description for this method
        THURSDAY, //TODO: Write general description for this method
        FRIDAY, //TODO: Write general description for this method
        SATURDAY, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type Days
    /// </summary>
    public static class DaysHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        /// <summary>
        /// Converts a Days value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Days value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Days enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Days.SUNDAY:
                case Days.MONDAY:
                case Days.TUESDAY:
                case Days.WEDNESDAY:
                case Days.THURSDAY:
                case Days.FRIDAY:
                case Days.SATURDAY:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Days values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Days values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Days> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into Days value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Days value</returns>
        public static Days ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type Days", value));

            return (Days) index;
        }
    }
} 