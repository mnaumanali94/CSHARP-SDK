/*
 * Tester.PCL
 *
 * This file was automatically generated for Stamplay by APIMATIC v2.0 ( https://apimatic.io ) on 08/09/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tester.PCL;
using Tester.PCL.Http.Request;
using Tester.PCL.Http.Response;
using Tester.PCL.Http.Client;
using Tester.PCL.Models;

namespace Tester.PCL.Controllers
{
    public partial interface IResponseTypesController
    {
        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the long response from the API call</return>
        long GetLong();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the long response from the API call</return>
        Task<long> GetLongAsync();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the Employee response from the API call</return>
        Employee GetModel();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the Employee response from the API call</return>
        Task<Employee> GetModelAsync();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the List<Days> response from the API call</return>
        List<Days> GetStringEnumArray();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the List<Days> response from the API call</return>
        Task<List<Days>> GetStringEnumArrayAsync();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the Days response from the API call</return>
        Days GetStringEnum();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the Days response from the API call</return>
        Task<Days> GetStringEnumAsync();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the List<Employee> response from the API call</return>
        List<Employee> GetModelArray();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the List<Employee> response from the API call</return>
        Task<List<Employee>> GetModelArrayAsync();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the SuiteCode response from the API call</return>
        SuiteCode GetIntEnum();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the SuiteCode response from the API call</return>
        Task<SuiteCode> GetIntEnumAsync();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the List<SuiteCode> response from the API call</return>
        List<SuiteCode> GetIntEnumArray();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the List<SuiteCode> response from the API call</return>
        Task<List<SuiteCode>> GetIntEnumArrayAsync();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the double response from the API call</return>
        double GetPrecision();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the double response from the API call</return>
        Task<double> GetPrecisionAsync();

        /// <summary>
        /// gets a binary object
        /// </summary>
        /// <return>Returns the Stream response from the API call</return>
        Stream GetBinary();

        /// <summary>
        /// gets a binary object
        /// </summary>
        /// <return>Returns the Stream response from the API call</return>
        Task<Stream> GetBinaryAsync();

        /// <summary>
        /// Gets a integer response
        /// </summary>
        /// <return>Returns the int response from the API call</return>
        int GetInteger();

        /// <summary>
        /// Gets a integer response
        /// </summary>
        /// <return>Returns the int response from the API call</return>
        Task<int> GetIntegerAsync();

        /// <summary>
        /// Get an array of integers.
        /// </summary>
        /// <return>Returns the List<int> response from the API call</return>
        List<int> GetIntegerArray();

        /// <summary>
        /// Get an array of integers.
        /// </summary>
        /// <return>Returns the List<int> response from the API call</return>
        Task<List<int>> GetIntegerArrayAsync();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        dynamic GetDynamic();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        Task<dynamic> GetDynamicAsync();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        dynamic GetDynamicArray();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        Task<dynamic> GetDynamicArrayAsync();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the DateTime response from the API call</return>
        DateTime GetDatetime();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the DateTime response from the API call</return>
        Task<DateTime> GetDatetimeAsync();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the List<DateTime> response from the API call</return>
        List<DateTime> GetDatetimeArray();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the List<DateTime> response from the API call</return>
        Task<List<DateTime>> GetDatetimeArrayAsync();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the bool response from the API call</return>
        bool GetBoolean();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the bool response from the API call</return>
        Task<bool> GetBooleanAsync();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the List<bool> response from the API call</return>
        List<bool> GetBooleanArray();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the List<bool> response from the API call</return>
        Task<List<bool>> GetBooleanArrayAsync();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the void response from the API call</return>
        void GetHeaders();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the void response from the API call</return>
        Task GetHeadersAsync();

    }
} 