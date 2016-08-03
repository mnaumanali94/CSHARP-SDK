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
    public partial interface IHeaderController
    {
        /// <summary>
        /// Sends a single header params
        /// </summary>
        /// <param name="customHeader">Required parameter: Example: </param>
        /// <param name="mvalue">Required parameter: Represents the value of the custom header</param>
        /// <return>Returns the ServerResponse response from the API call</return>
        ServerResponse SendHeaders(string customHeader, string mvalue);

        /// <summary>
        /// Sends a single header params
        /// </summary>
        /// <param name="customHeader">Required parameter: Example: </param>
        /// <param name="mvalue">Required parameter: Represents the value of the custom header</param>
        /// <return>Returns the ServerResponse response from the API call</return>
        Task<ServerResponse> SendHeadersAsync(string customHeader, string mvalue);

    }
} 