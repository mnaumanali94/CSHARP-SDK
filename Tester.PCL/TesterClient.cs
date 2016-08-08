/*
 * Tester.PCL
 *
 * This file was automatically generated for Stamplay by APIMATIC v2.0 ( https://apimatic.io ) on 08/08/2016
 */
using System;
using Tester.PCL.Controllers;
using Tester.PCL.Http.Client;

namespace Tester.PCL
{
    public partial class TesterClient
    {

        /// <summary>
        /// Singleton access to ResponseTypes controller
        /// </summary>
        public ResponseTypesController ResponseTypes
        {
            get
            {
                return ResponseTypesController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to ErrorCodes controller
        /// </summary>
        public ErrorCodesController ErrorCodes
        {
            get
            {
                return ErrorCodesController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to BodyParams controller
        /// </summary>
        public BodyParamsController BodyParams
        {
            get
            {
                return BodyParamsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to FormParams controller
        /// </summary>
        public FormParamsController FormParams
        {
            get
            {
                return FormParamsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Echo controller
        /// </summary>
        public EchoController Echo
        {
            get
            {
                return EchoController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Header controller
        /// </summary>
        public HeaderController Header
        {
            get
            {
                return HeaderController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to QueryParam controller
        /// </summary>
        public QueryParamController QueryParam
        {
            get
            {
                return QueryParamController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to TemplateParams controller
        /// </summary>
        public TemplateParamsController TemplateParams
        {
            get
            {
                return TemplateParamsController.Instance;
            }
        }

        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public TesterClient() { }
    }
}