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
    public class FormParamsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static FormParamsController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().FormParams;
            applyConfiguration();
        }

        /// <summary>
        /// TODO: Add description for test TestSendLong
        /// </summary>
        [Test]
        public async Task TestSendLong() 
        {
            // Parameters for the API call
            long mvalue = 5147483647;

            // Perform API call
            ServerResponse result = null;

            try
            {
                result = await controller.SendLongAsync(mvalue);
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
        /// TODO: Add description for test TestSendIntegerArray
        /// </summary>
        [Test]
        public async Task TestSendIntegerArray() 
        {
            // Parameters for the API call
            List<int> integers = APIHelper.JsonDeserialize<List<int>>("[1,2,3,4,5]");

            // Perform API call
            ServerResponse result = null;

            try
            {
                result = await controller.SendIntegerArrayAsync(integers);
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
        /// TODO: Add description for test TestSendStringArray
        /// </summary>
        [Test]
        public async Task TestSendStringArray() 
        {
            // Parameters for the API call
            List<string> strings = APIHelper.JsonDeserialize<List<string>>("[\"abc\", \"def\"]");

            // Perform API call
            ServerResponse result = null;

            try
            {
                result = await controller.SendStringArrayAsync(strings);
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
        /// TODO: Add description for test TestSendModel
        /// </summary>
        [Test]
        public async Task TestSendModel() 
        {
            // Parameters for the API call
            Employee model = APIHelper.JsonDeserialize<Employee>("{\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"name\":\"Zeeshan Ejaz\",\"age\":5147483647,\"address\":\"I-9/1\",\"uid\":\"241123\"},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\"}]}");

            // Perform API call
            ServerResponse result = null;

            try
            {
                result = await controller.SendModelAsync(model);
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
        /// TODO: Add description for test TestSendModelArray
        /// </summary>
        [Test]
        public async Task TestSendModelArray() 
        {
            // Parameters for the API call
            List<Employee> models = APIHelper.JsonDeserialize<List<Employee>>("[{\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"name\":\"Zeeshan Ejaz\",\"age\":5147483647,\"address\":\"I-9/1\",\"uid\":\"241123\"},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\"}]}, {\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"name\":\"Zeeshan Ejaz\",\"age\":5147483647,\"address\":\"I-9/1\",\"uid\":\"241123\"},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\"}]}]");

            // Perform API call
            ServerResponse result = null;

            try
            {
                result = await controller.SendModelArrayAsync(models);
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
        /// TODO: Add description for test TestSendFile
        /// </summary>
        [Test]
        public async Task TestSendFile() 
        {
            // Parameters for the API call
            FileStreamInfo file = TestHelper.GetFile("https://dl.dropboxusercontent.com/u/31838656/binary.png");

            // Perform API call
            ServerResponse result = null;

            try
            {
                result = await controller.SendFileAsync(file);
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
        /// TODO: Add description for test TestSendMixedArray
        /// </summary>
        [Test]
        public async Task TestSendMixedArray() 
        {
            // Parameters for the API call
            SendMixedArrayInput input = new SendMixedArrayInput();
            input.File = TestHelper.GetFile("https://dl.dropboxusercontent.com/u/31838656/binary.png");
            input.Integers = APIHelper.JsonDeserialize<List<int>>("[1,2,3,4,5]");
            input.Models = APIHelper.JsonDeserialize<List<Employee>>("[{\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"name\":\"Zeeshan Ejaz\",\"age\":5147483647,\"address\":\"I-9/1\",\"uid\":\"241123\"},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\"}]}, {\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"name\":\"Zeeshan Ejaz\",\"age\":5147483647,\"address\":\"I-9/1\",\"uid\":\"241123\"},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\"}]}]");
            input.Strings = APIHelper.JsonDeserialize<List<string>>("[\"abc\", \"def\"]");

            // Perform API call
            ServerResponse result = null;

            try
            {
                result = await controller.SendMixedArrayAsync(input);
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
        /// TODO: Add description for test TestSendString
        /// </summary>
        [Test]
        public async Task TestSendString() 
        {
            // Parameters for the API call
            string mvalue = "TestString";

            // Perform API call
            ServerResponse result = null;

            try
            {
                result = await controller.SendStringAsync(mvalue);
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
        /// TODO: Add description for test TestSendIntegerEnumArray
        /// </summary>
        [Test]
        public async Task TestSendIntegerEnumArray() 
        {
            // Parameters for the API call
            List<SuiteCode> suites = APIHelper.JsonDeserialize<List<SuiteCode>>("[1, 3, 4, 2, 3]");

            // Perform API call
            ServerResponse result = null;

            try
            {
                result = await controller.SendIntegerEnumArrayAsync(suites);
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
        /// TODO: Add description for test TestSendStringEnumArray
        /// </summary>
        [Test]
        public async Task TestSendStringEnumArray() 
        {
            // Parameters for the API call
            List<Days> days = APIHelper.JsonDeserialize<List<Days>>("[\"Tuesday\", \"Saturday\", \"Wednesday\", \"Monday\", \"Sunday\"]");

            // Perform API call
            ServerResponse result = null;

            try
            {
                result = await controller.SendStringEnumArrayAsync(days);
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

    }
}
