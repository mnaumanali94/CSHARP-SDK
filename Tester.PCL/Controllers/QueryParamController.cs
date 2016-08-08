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
    public partial class QueryParamController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static QueryParamController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static QueryParamController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new QueryParamController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="boolean">Required parameter: Example: </param>
        /// <param name="number">Required parameter: Example: </param>
        /// <param name="mstring">Required parameter: Example: </param>
        /// <param name="queryParameters">Additional optional query parameters are supported by this endpoint</param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public ServerResponse SimpleQuery(
                bool boolean,
                int number,
                string mstring,
                Dictionary<string, object> queryParameters = null)
        {
            Task<ServerResponse> t = SimpleQueryAsync(boolean, number, mstring, queryParameters);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="boolean">Required parameter: Example: </param>
        /// <param name="number">Required parameter: Example: </param>
        /// <param name="mstring">Required parameter: Example: </param>
        /// <param name="queryParameters">Additional optional query parameters are supported by this endpoint</param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public async Task<ServerResponse> SimpleQueryAsync(
                bool boolean,
                int number,
                string mstring,
                Dictionary<string, object> queryParameters = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/query");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "boolean", boolean },
                { "number", number },
                { "string", mstring }
            });

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
        /// <return>Returns the ServerResponse response from the API call</return>
        public ServerResponse NoParams()
        {
            Task<ServerResponse> t = NoParamsAsync();
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the ServerResponse response from the API call</return>
        public async Task<ServerResponse> NoParamsAsync()
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/query/noparams");


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
        /// <param name="mstring">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public ServerResponse StringParam(string mstring)
        {
            Task<ServerResponse> t = StringParamAsync(mstring);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="mstring">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public async Task<ServerResponse> StringParamAsync(string mstring)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/query/stringparam");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "string", mstring }
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
        /// <param name="url">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public ServerResponse UrlParam(string url)
        {
            Task<ServerResponse> t = UrlParamAsync(url);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="url">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public async Task<ServerResponse> UrlParamAsync(string url)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/query/urlparam");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "url", url }
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
        /// <param name="number">Required parameter: Example: </param>
        /// <param name="precision">Required parameter: Example: </param>
        /// <param name="mstring">Required parameter: Example: </param>
        /// <param name="url">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public ServerResponse MultipleParams(
                int number,
                double precision,
                string mstring,
                string url)
        {
            Task<ServerResponse> t = MultipleParamsAsync(number, precision, mstring, url);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="number">Required parameter: Example: </param>
        /// <param name="precision">Required parameter: Example: </param>
        /// <param name="mstring">Required parameter: Example: </param>
        /// <param name="url">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public async Task<ServerResponse> MultipleParamsAsync(
                int number,
                double precision,
                string mstring,
                string url)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/query/multipleparams");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "number", number },
                { "precision", precision },
                { "string", mstring },
                { "url", url }
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
        public ServerResponse NumberArray(List<int> integers)
        {
            Task<ServerResponse> t = NumberArrayAsync(integers);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="integers">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public async Task<ServerResponse> NumberArrayAsync(List<int> integers)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/query/numberarray");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
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
        /// <param name="strings">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public ServerResponse StringArray(List<string> strings)
        {
            Task<ServerResponse> t = StringArrayAsync(strings);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="strings">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public async Task<ServerResponse> StringArrayAsync(List<string> strings)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/query/stringarray");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
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
        public ServerResponse StringEnumArray(List<Days> days)
        {
            Task<ServerResponse> t = StringEnumArrayAsync(days);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="days">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public async Task<ServerResponse> StringEnumArrayAsync(List<Days> days)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/query/stringenumarray");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "days", DaysHelper.ToValue(days) }
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
        public ServerResponse IntegerEnumArray(List<SuiteCode> suites)
        {
            Task<ServerResponse> t = IntegerEnumArrayAsync(suites);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="suites">Required parameter: Example: </param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public async Task<ServerResponse> IntegerEnumArrayAsync(List<SuiteCode> suites)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/query/integerenumarray");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "suites", SuiteCodeHelper.ToValue(suites) }
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