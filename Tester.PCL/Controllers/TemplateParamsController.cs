/*
 * Tester.PCL
 *
 * This file was automatically generated for Stamplay by APIMATIC v2.0 ( https://apimatic.io ) on 08/03/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tester.PCL;
using Tester.PCL.Http.Request;
using Tester.PCL.Http.Response;
using Tester.PCL.Http.Client;
using Tester.PCL.Exceptions;
using Tester.PCL.Models;

namespace Tester.PCL.Controllers
{
    public partial class TemplateParamsController: BaseController, ITemplateParamsController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static TemplateParamsController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static TemplateParamsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new TemplateParamsController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="strings">Required parameter: Example: </param>
        /// <return>Returns the EchoResponse response from the API call</return>
        public EchoResponse SendStringArray(List<string> strings)
        {
            Task<EchoResponse> t = SendStringArrayAsync(strings);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="strings">Required parameter: Example: </param>
        /// <return>Returns the EchoResponse response from the API call</return>
        public async Task<EchoResponse> SendStringArrayAsync(List<string> strings)
        {
            //validating required parameters
            if (null == strings)
                throw new ArgumentNullException("strings", "The parameter \"strings\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/{strings}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "strings", strings }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "Stamplay SDK" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //return null on 404
            if (_response.StatusCode == 404)
                 return null;

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<EchoResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="integers">Required parameter: Example: </param>
        /// <return>Returns the EchoResponse response from the API call</return>
        public EchoResponse SendIntegerArray(List<int> integers)
        {
            Task<EchoResponse> t = SendIntegerArrayAsync(integers);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="integers">Required parameter: Example: </param>
        /// <return>Returns the EchoResponse response from the API call</return>
        public async Task<EchoResponse> SendIntegerArrayAsync(List<int> integers)
        {
            //validating required parameters
            if (null == integers)
                throw new ArgumentNullException("integers", "The parameter \"integers\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/{integers}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "integers", integers }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "Stamplay SDK" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //return null on 404
            if (_response.StatusCode == 404)
                 return null;

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<EchoResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 