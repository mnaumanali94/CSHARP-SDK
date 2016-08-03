/*
 * Tester.PCL
 *
 * This file was automatically generated for Stamplay by APIMATIC v2.0 ( https://apimatic.io ) on 08/03/2016
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
    public partial interface IBodyParamsController
    {
        /// <summary>
        /// sends a string body param
        /// </summary>
        /// <param name="sarray">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        ServerResponse SendStringArray(List<string> sarray);

        /// <summary>
        /// sends a string body param
        /// </summary>
        /// <param name="sarray">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        Task<ServerResponse> SendStringArrayAsync(List<string> sarray);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="integers">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        ServerResponse SendIntegerArray(List<int> integers);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="integers">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        Task<ServerResponse> SendIntegerArrayAsync(List<int> integers);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="model">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        ServerResponse SendModel(Employee model);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="model">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        Task<ServerResponse> SendModelAsync(Employee model);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="models">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        ServerResponse SendModelArray(List<Employee> models);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="models">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        Task<ServerResponse> SendModelArrayAsync(List<Employee> models);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        ServerResponse SendDynamic(object mdynamic);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        Task<ServerResponse> SendDynamicAsync(object mdynamic);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="mvalue">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        ServerResponse SendString(string mvalue);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="mvalue">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        Task<ServerResponse> SendStringAsync(string mvalue);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="days">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        ServerResponse SendStringEnumArray(List<Days> days);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="days">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        Task<ServerResponse> SendStringEnumArrayAsync(List<Days> days);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="suites">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        ServerResponse SendIntegerEnumArray(List<SuiteCode> suites);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="suites">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        Task<ServerResponse> SendIntegerEnumArrayAsync(List<SuiteCode> suites);

    }
} 