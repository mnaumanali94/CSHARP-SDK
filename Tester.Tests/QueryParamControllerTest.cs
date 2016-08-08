/*
 * Tester.Tests
 *
 * This file was automatically generated for Stamplay by APIMATIC v2.0 ( https://apimatic.io ) on 08/08/2016
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using NUnit.Framework;
using Tester.PCL;
using Tester.PCL.Controllers;
 
using Tester.PCL.Models;
 
using Tester.PCL.Exceptions;
using Tester.PCL.Http.Client;
using Tester.Tests.Helpers;

namespace Tester.Tests
{
    [TestFixture]
    public class QueryParamControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static QueryParamController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().QueryParam;
            applyConfiguration();
        }

        /// <summary>
        /// TODO: Add description for test TestSimpleQuery
        /// </summary>
        [Test]
        public async Task TestSimpleQuery() 
        {
            // Parameters for the API call
            bool boolean = true;
            int number = 4;
            string mstring = "TestString";
            // key-value map for optional query parameters
            Dictionary<string, object> queryParams = new Dictionary<string, object>();

            // Perform API call
            ServerResponse result = null;

            try
            {
                result = await controller.SimpleQueryAsync(boolean, number, mstring, queryParams);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    true, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TODO: Add description for test TestNoParams
        /// </summary>
        [Test]
        public async Task TestNoParams() 
        {

            // Perform API call
            ServerResponse result = null;

            try
            {
                result = await controller.NoParamsAsync();
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    true, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TODO: Add description for test TestStringParam
        /// </summary>
        [Test]
        public async Task TestStringParam() 
        {
            // Parameters for the API call
            string mstring = "l;asd;asdwe[2304&&;'.d??\\a\\\\\\;sd//";

            // Perform API call
            ServerResponse result = null;

            try
            {
                result = await controller.StringParamAsync(mstring);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    true, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TODO: Add description for test TestUrlParam
        /// </summary>
        [Test]
        public async Task TestUrlParam() 
        {
            // Parameters for the API call
            string url = "https://www.shahidisawesome.com/and/also/a/narcissist?thisis=aparameter&another=one";

            // Perform API call
            ServerResponse result = null;

            try
            {
                result = await controller.UrlParamAsync(url);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    true, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TODO: Add description for test TestMultipleParams
        /// </summary>
        [Test]
        public async Task TestMultipleParams() 
        {
            // Parameters for the API call
            int number = 123412312;
            double precision = 1112.34;
            string mstring = "\"\"test./;\";12&&3asl\"\";\"qw1&34\"///..//.";
            string url = "http://www.abc.com/test?a=b&c=\"http://lolol.com?param=no&another=lol\"";

            // Perform API call
            ServerResponse result = null;

            try
            {
                result = await controller.MultipleParamsAsync(number, precision, mstring, url);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    true, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TODO: Add description for test TestNumberArray
        /// </summary>
        [Test]
        public async Task TestNumberArray() 
        {
            // Parameters for the API call
            List<int> integers = APIHelper.JsonDeserialize<List<int>>("[1,2,3,4,5]");

            // Perform API call
            ServerResponse result = null;

            try
            {
                result = await controller.NumberArrayAsync(integers);
            }
            catch(APIException) {};

            // Test response code
            Assert.IsTrue((httpCallBackHandler.Response.StatusCode >= 200)
                    && (httpCallBackHandler.Response.StatusCode <= 208),
                    "Status should be between 200 and 208");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    true, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TODO: Add description for test TestStringArray
        /// </summary>
        [Test]
        public async Task TestStringArray() 
        {
            // Parameters for the API call
            List<string> strings = APIHelper.JsonDeserialize<List<string>>("[\"abc\", \"def\"]");

            // Perform API call
            ServerResponse result = null;

            try
            {
                result = await controller.StringArrayAsync(strings);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    true, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TODO: Add description for test TestStringEnumArray
        /// </summary>
        [Test]
        public async Task TestStringEnumArray() 
        {
            // Parameters for the API call
            List<Days> days = APIHelper.JsonDeserialize<List<Days>>("[\"Tuesday\", \"Saturday\", \"Wednesday\", \"Monday\", \"Sunday\"]");

            // Perform API call
            ServerResponse result = null;

            try
            {
                result = await controller.StringEnumArrayAsync(days);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    true, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TODO: Add description for test TestIntegerEnumArray
        /// </summary>
        [Test]
        public async Task TestIntegerEnumArray() 
        {
            // Parameters for the API call
            List<SuiteCode> suites = APIHelper.JsonDeserialize<List<SuiteCode>>("[1, 3, 4, 2, 3]");

            // Perform API call
            ServerResponse result = null;

            try
            {
                result = await controller.IntegerEnumArrayAsync(suites);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    true, true, false),
                    "Response body should have matching keys");
        }

    }
}
