/*
 * Tester.PCL
 *
 * This file was automatically generated for Stamplay by APIMATIC v2.0 ( https://apimatic.io ) on 08/08/2016
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
    public partial class EchoController: BaseController, IEchoController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static EchoController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static EchoController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new EchoController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Echo's back the request
        /// </summary>
        /// <param name="input">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic JsonEcho(object input)
        {
            Task<dynamic> t = JsonEchoAsync(input);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Echo's back the request
        /// </summary>
        /// <param name="input">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> JsonEchoAsync(object input)
        {
            //validating required parameters
            if (null == input)
                throw new ArgumentNullException("input", "The parameter \"input\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "Stamplay SDK" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(input);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

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
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Sends the request including any form params as JSON
        /// </summary>
        /// <param name="input">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic FormEcho(object input)
        {
            Task<dynamic> t = FormEchoAsync(input);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Sends the request including any form params as JSON
        /// </summary>
        /// <param name="input">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> FormEchoAsync(object input)
        {
            //validating required parameters
            if (null == input)
                throw new ArgumentNullException("input", "The parameter \"input\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "Stamplay SDK" },
                { "accept", "application/json" }
            };

            //append form/field parameters
            var _fields = new Dictionary<string,object>();
            _fields.Add(APIHelper.PrepareFormFieldsFromObject("input", input));

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

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
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="queryParameters">Additional optional query parameters are supported by this endpoint</param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public ServerResponse QueryEcho(Dictionary<string, object> queryParameters = null)
        {
            Task<ServerResponse> t = QueryEchoAsync(queryParameters);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="queryParameters">Additional optional query parameters are supported by this endpoint</param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public async Task<ServerResponse> QueryEchoAsync(Dictionary<string, object> queryParameters = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/");

            //append optional parameters to the query
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, queryParameters);


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
                return APIHelper.JsonDeserialize<ServerResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 