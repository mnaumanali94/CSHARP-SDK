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
    public class EchoControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static IEchoController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().Echo;
            applyConfiguration();
        }

        /// <summary>
        /// TODO: Add description for test TestJsonEcho
        /// </summary>
        [Test]
        public async Task TestJsonEcho() 
        {
            // Parameters for the API call
            object input = APIHelper.JsonDeserialize<dynamic>("{\"uid\": \"1123213\", \"name\": \"Shahid\"}");

            // Perform API call
            dynamic result = null;

            try
            {
                result = await controller.JsonEchoAsync(input);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"body\": {\"uid\": \"1123213\", \"name\": \"Shahid\"}}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    true, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TODO: Add description for test TestFormEcho
        /// </summary>
        [Test]
        public async Task TestFormEcho() 
        {
            // Parameters for the API call
            object input = APIHelper.JsonDeserialize<dynamic>("{\"uid\": \"1123213\", \"name\": \"Shahid\"}");

            // Perform API call
            dynamic result = null;

            try
            {
                result = await controller.FormEchoAsync(input);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"body\":{\"input\":{\"uid\":\"1123213\",\"name\":\"Shahid\"}}}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    true, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TODO: Add description for test TestQueryEcho
        /// </summary>
        [Test]
        public async Task TestQueryEcho() 
        {
            // key-value map for optional query parameters
            Dictionary<string, object> queryParams = new Dictionary<string, object>();
            queryParams.Add("hello", "world");

            // Perform API call
            ServerResponse result = null;

            try
            {
                result = await controller.QueryEchoAsync(queryParams);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"query\":{\"hello\":\"world\"}}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    true, true, false),
                    "Response body should have matching keys");
        }

    }
}
