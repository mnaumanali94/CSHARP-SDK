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
    public class ErrorCodesControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static ErrorCodesController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().ErrorCodes;
            applyConfiguration();
        }

        /// <summary>
        /// TODO: Add description for test TestGet400
        /// </summary>
        [Test]
        public async Task TestGet400() 
        {

            // Perform API call
            dynamic result = null;

            try
            {
                result = await controller.Get400Async();
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(400, httpCallBackHandler.Response.StatusCode,
                    "Status should be 400");

        }

        /// <summary>
        /// TODO: Add description for test TestGet500
        /// </summary>
        [Test]
        public async Task TestGet500() 
        {

            // Perform API call
            dynamic result = null;

            try
            {
                result = await controller.Get500Async();
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(500, httpCallBackHandler.Response.StatusCode,
                    "Status should be 500");

        }

    }
}
