/*
 * Nomad
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.1.4
 * Contact: support@hashicorp.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Fermyon.Nomad.Client;
using Fermyon.Nomad.Api;
// uncomment below to import models
//using Fermyon.Nomad.Model;

namespace Fermyon.Nomad.Test.Api
{
    /// <summary>
    ///  Class for testing ScalingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ScalingApiTests : IDisposable
    {
        private ScalingApi instance;

        public ScalingApiTests()
        {
            instance = new ScalingApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ScalingApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ScalingApi
            //Assert.IsType<ScalingApi>(instance);
        }

        /// <summary>
        /// Test GetScalingPolicies
        /// </summary>
        [Fact]
        public void GetScalingPoliciesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? region = null;
            //string? _namespace = null;
            //int? index = null;
            //string? wait = null;
            //string? stale = null;
            //string? prefix = null;
            //string? xNomadToken = null;
            //int? perPage = null;
            //string? nextToken = null;
            //var response = instance.GetScalingPolicies(region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
            //Assert.IsType<List<ScalingPolicyListStub>>(response);
        }

        /// <summary>
        /// Test GetScalingPolicy
        /// </summary>
        [Fact]
        public void GetScalingPolicyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string policyID = null;
            //string? region = null;
            //string? _namespace = null;
            //int? index = null;
            //string? wait = null;
            //string? stale = null;
            //string? prefix = null;
            //string? xNomadToken = null;
            //int? perPage = null;
            //string? nextToken = null;
            //var response = instance.GetScalingPolicy(policyID, region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
            //Assert.IsType<ScalingPolicy>(response);
        }
    }
}
