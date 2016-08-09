/*
 * Tester.PCL
 *
 * This file was automatically generated for Stamplay by APIMATIC v2.0 ( https://apimatic.io ) on 08/09/2016
 */
using System;
using Tester.PCL.Controllers;

namespace Tester.PCL
{
    public partial interface ITesterClient
    {

        /// <summary>
        /// Singleton access to ResponseTypes controller
        /// </summary>
        IResponseTypesController ResponseTypes { get;}

        /// <summary>
        /// Singleton access to ErrorCodes controller
        /// </summary>
        IErrorCodesController ErrorCodes { get;}

        /// <summary>
        /// Singleton access to BodyParams controller
        /// </summary>
        IBodyParamsController BodyParams { get;}

        /// <summary>
        /// Singleton access to FormParams controller
        /// </summary>
        IFormParamsController FormParams { get;}

        /// <summary>
        /// Singleton access to Echo controller
        /// </summary>
        IEchoController Echo { get;}

        /// <summary>
        /// Singleton access to Header controller
        /// </summary>
        IHeaderController Header { get;}

        /// <summary>
        /// Singleton access to QueryParam controller
        /// </summary>
        IQueryParamController QueryParam { get;}

        /// <summary>
        /// Singleton access to TemplateParams controller
        /// </summary>
        ITemplateParamsController TemplateParams { get;}

    }
}