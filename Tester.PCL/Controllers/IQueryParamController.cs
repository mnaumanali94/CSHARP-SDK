/*
 * Tester.PCL
 *
 * This file was automatically generated for Stamplay by APIMATIC v2.0 ( https://apimatic.io ) on 08/08/2016
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
    public partial interface IQueryParamController
    {
        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="boolean">Required parameter: Example: </param>
        /// <param name="number">Required parameter: Example: </param>
        /// <param name="mstring">Required parameter: Example: </param>
        /// <param name="queryParameters">Additional optional query parameters are supported by this endpoint</param>
        /// <return>Returns the ServerResponse response from the API call</return>
        ServerResponse SimpleQuery(
                bool boolean,
                int number,
                string mstring,
                Dictionary<string, object> queryParameters = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="boolean">Required parameter: Example: </param>
        /// <param name="number">Required parameter: Example: </param>
        /// <param name="mstring">Required parameter: Example: </param>
        /// <param name="queryParameters">Additional optional query parameters are supported by this endpoint</param>
        /// <return>Returns the ServerResponse response from the API call</return>
        Task<ServerResponse> SimpleQueryAsync(
                bool boolean,
                int number,
                string mstring,
                Dictionary<string, object> queryParameters = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the ServerResponse response from the API call</return>
        ServerResponse NoParams();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the ServerResponse response from the API call</return>
        Task<ServerResponse> NoParamsAsync();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="mstring">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        ServerResponse StringParam(string mstring);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="mstring">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        Task<ServerResponse> StringParamAsync(string mstring);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="url">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        ServerResponse UrlParam(string url);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="url">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        Task<ServerResponse> UrlParamAsync(string url);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="number">Required parameter: Example: </param>
        /// <param name="precision">Required parameter: Example: </param>
        /// <param name="mstring">Required parameter: Example: </param>
        /// <param name="url">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        ServerResponse MultipleParams(
                int number,
                double precision,
                string mstring,
                string url);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="number">Required parameter: Example: </param>
        /// <param name="precision">Required parameter: Example: </param>
        /// <param name="mstring">Required parameter: Example: </param>
        /// <param name="url">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        Task<ServerResponse> MultipleParamsAsync(
                int number,
                double precision,
                string mstring,
                string url);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="integers">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        ServerResponse NumberArray(List<int> integers);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="integers">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        Task<ServerResponse> NumberArrayAsync(List<int> integers);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="strings">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        ServerResponse StringArray(List<string> strings);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="strings">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        Task<ServerResponse> StringArrayAsync(List<string> strings);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="days">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        ServerResponse StringEnumArray(List<Days> days);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="days">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        Task<ServerResponse> StringEnumArrayAsync(List<Days> days);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="suites">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        ServerResponse IntegerEnumArray(List<SuiteCode> suites);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="suites">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        Task<ServerResponse> IntegerEnumArrayAsync(List<SuiteCode> suites);

    }
} 