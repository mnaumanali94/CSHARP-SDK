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
    public partial class BodyParamsController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static BodyParamsController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static BodyParamsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new BodyParamsController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// sends a string body param
        /// </summary>
        /// <param name="sarray">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public ServerResponse SendStringArray(List<string> sarray)
        {
            Task<ServerResponse> t = SendStringArrayAsync(sarray);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// sends a string body param
        /// </summary>
        /// <param name="sarray">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public async Task<ServerResponse> SendStringArrayAsync(List<string> sarray)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/body/string");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "array", "true" }
            });


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
            var _body = APIHelper.JsonSerialize(sarray);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
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

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="integers">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public ServerResponse SendIntegerArray(List<int> integers)
        {
            Task<ServerResponse> t = SendIntegerArrayAsync(integers);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="integers">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public async Task<ServerResponse> SendIntegerArrayAsync(List<int> integers)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/body/number");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "array", "true" }
            });


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
            var _body = APIHelper.JsonSerialize(integers);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
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

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="model">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public ServerResponse SendModel(Employee model)
        {
            Task<ServerResponse> t = SendModelAsync(model);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="model">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public async Task<ServerResponse> SendModelAsync(Employee model)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/body/model");


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
            var _body = APIHelper.JsonSerialize(model);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
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

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="models">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public ServerResponse SendModelArray(List<Employee> models)
        {
            Task<ServerResponse> t = SendModelArrayAsync(models);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="models">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public async Task<ServerResponse> SendModelArrayAsync(List<Employee> models)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/body/model");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "array", "true" }
            });


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
            var _body = APIHelper.JsonSerialize(models);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
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

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public ServerResponse SendDynamic(object mdynamic)
        {
            Task<ServerResponse> t = SendDynamicAsync(mdynamic);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public async Task<ServerResponse> SendDynamicAsync(object mdynamic)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/body/dynamic");


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
            var _body = APIHelper.JsonSerialize(mdynamic);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
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

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="mvalue">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public ServerResponse SendString(string mvalue)
        {
            Task<ServerResponse> t = SendStringAsync(mvalue);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="mvalue">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public async Task<ServerResponse> SendStringAsync(string mvalue)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/body/string");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "Stamplay SDK" },
                { "accept", "application/json" }
            };

            //append body params
             var _body = mvalue;

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
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

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="days">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public ServerResponse SendStringEnumArray(List<Days> days)
        {
            Task<ServerResponse> t = SendStringEnumArrayAsync(days);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="days">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public async Task<ServerResponse> SendStringEnumArrayAsync(List<Days> days)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/body/stringenum");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "array", "true" }
            });


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
            var _body = APIHelper.JsonSerialize(days);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
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

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="suites">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public ServerResponse SendIntegerEnumArray(List<SuiteCode> suites)
        {
            Task<ServerResponse> t = SendIntegerEnumArrayAsync(suites);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="suites">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public async Task<ServerResponse> SendIntegerEnumArrayAsync(List<SuiteCode> suites)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/body/integerenum");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "array", "true" }
            });


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
            var _body = APIHelper.JsonSerialize(suites);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
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