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
    public partial interface IErrorCodesController
    {
        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        dynamic Get400();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        Task<dynamic> Get400Async();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        dynamic Get500();

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        Task<dynamic> Get500Async();

    }
} 