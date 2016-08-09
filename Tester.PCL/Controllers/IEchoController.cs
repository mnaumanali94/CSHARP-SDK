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
    public partial interface IEchoController
    {
        /// <summary>
        /// Echo's back the request
        /// </summary>
        /// <param name="input">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        dynamic JsonEcho(object input);

        /// <summary>
        /// Echo's back the request
        /// </summary>
        /// <param name="input">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        Task<dynamic> JsonEchoAsync(object input);

        /// <summary>
        /// Sends the request including any form params as JSON
        /// </summary>
        /// <param name="input">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        dynamic FormEcho(object input);

        /// <summary>
        /// Sends the request including any form params as JSON
        /// </summary>
        /// <param name="input">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        Task<dynamic> FormEchoAsync(object input);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="queryParameters">Additional optional query parameters are supported by this endpoint</param>
        /// <return>Returns the ServerResponse response from the API call</return>
        ServerResponse QueryEcho(Dictionary<string, object> queryParameters = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="queryParameters">Additional optional query parameters are supported by this endpoint</param>
        /// <return>Returns the ServerResponse response from the API call</return>
        Task<ServerResponse> QueryEchoAsync(Dictionary<string, object> queryParameters = null);

    }
} 