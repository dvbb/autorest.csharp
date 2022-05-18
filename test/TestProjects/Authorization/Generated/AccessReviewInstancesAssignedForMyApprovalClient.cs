// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Authorization
{
    /// <summary> The AccessReviewInstancesAssignedForMyApproval service client. </summary>
    public partial class AccessReviewInstancesAssignedForMyApprovalClient
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of AccessReviewInstancesAssignedForMyApprovalClient for mocking. </summary>
        protected AccessReviewInstancesAssignedForMyApprovalClient()
        {
        }

        /// <summary> Initializes a new instance of AccessReviewInstancesAssignedForMyApprovalClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public AccessReviewInstancesAssignedForMyApprovalClient(AzureKeyCredential credential) : this(credential, new Uri("https://management.azure.com"), new AuthorizationManagementClientOptions())
        {
        }

        /// <summary> Initializes a new instance of AccessReviewInstancesAssignedForMyApprovalClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> or <paramref name="endpoint"/> is null. </exception>
        public AccessReviewInstancesAssignedForMyApprovalClient(AzureKeyCredential credential, Uri endpoint, AuthorizationManagementClientOptions options)
        {
            Argument.AssertNotNull(credential, nameof(credential));
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new AuthorizationManagementClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Get single access review instance assigned for my approval. </summary>
        /// <param name="scheduleDefinitionId"> The id of the access review schedule definition. </param>
        /// <param name="id"> The id of the access review instance. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleDefinitionId"/> or <paramref name="id"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scheduleDefinitionId"/> or <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: string,
        ///   name: string,
        ///   type: string,
        ///   properties: {
        ///     status: &quot;NotStarted&quot; | &quot;InProgress&quot; | &quot;Completed&quot; | &quot;Applied&quot; | &quot;Initializing&quot; | &quot;Applying&quot; | &quot;Completing&quot; | &quot;Scheduled&quot; | &quot;AutoReviewing&quot; | &quot;AutoReviewed&quot; | &quot;Starting&quot;,
        ///     startDateTime: string (ISO 8601 Format),
        ///     endDateTime: string (ISO 8601 Format),
        ///     reviewers: [
        ///       {
        ///         principalId: string,
        ///         principalType: &quot;user&quot; | &quot;servicePrincipal&quot;
        ///       }
        ///     ],
        ///     backupReviewers: [AccessReviewReviewer],
        ///     reviewersType: &quot;Assigned&quot; | &quot;Self&quot; | &quot;Managers&quot;
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     message: string,
        ///     code: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetByIdAsync(string scheduleDefinitionId, string id, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(scheduleDefinitionId, nameof(scheduleDefinitionId));
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = ClientDiagnostics.CreateScope("AccessReviewInstancesAssignedForMyApprovalClient.GetById");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetByIdRequest(scheduleDefinitionId, id, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get single access review instance assigned for my approval. </summary>
        /// <param name="scheduleDefinitionId"> The id of the access review schedule definition. </param>
        /// <param name="id"> The id of the access review instance. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleDefinitionId"/> or <paramref name="id"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scheduleDefinitionId"/> or <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: string,
        ///   name: string,
        ///   type: string,
        ///   properties: {
        ///     status: &quot;NotStarted&quot; | &quot;InProgress&quot; | &quot;Completed&quot; | &quot;Applied&quot; | &quot;Initializing&quot; | &quot;Applying&quot; | &quot;Completing&quot; | &quot;Scheduled&quot; | &quot;AutoReviewing&quot; | &quot;AutoReviewed&quot; | &quot;Starting&quot;,
        ///     startDateTime: string (ISO 8601 Format),
        ///     endDateTime: string (ISO 8601 Format),
        ///     reviewers: [
        ///       {
        ///         principalId: string,
        ///         principalType: &quot;user&quot; | &quot;servicePrincipal&quot;
        ///       }
        ///     ],
        ///     backupReviewers: [AccessReviewReviewer],
        ///     reviewersType: &quot;Assigned&quot; | &quot;Self&quot; | &quot;Managers&quot;
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     message: string,
        ///     code: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetById(string scheduleDefinitionId, string id, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(scheduleDefinitionId, nameof(scheduleDefinitionId));
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = ClientDiagnostics.CreateScope("AccessReviewInstancesAssignedForMyApprovalClient.GetById");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetByIdRequest(scheduleDefinitionId, id, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get access review instances assigned for my approval. </summary>
        /// <param name="scheduleDefinitionId"> The id of the access review schedule definition. </param>
        /// <param name="filter"> The filter to apply on the operation. Other than standard filters, one custom filter option is supported : &apos;assignedToMeToReview()&apos;. When one specified $filter=assignedToMeToReview(), only items that are assigned to the calling user to review are returned. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleDefinitionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scheduleDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [
        ///     {
        ///       id: string,
        ///       name: string,
        ///       type: string,
        ///       properties: {
        ///         status: &quot;NotStarted&quot; | &quot;InProgress&quot; | &quot;Completed&quot; | &quot;Applied&quot; | &quot;Initializing&quot; | &quot;Applying&quot; | &quot;Completing&quot; | &quot;Scheduled&quot; | &quot;AutoReviewing&quot; | &quot;AutoReviewed&quot; | &quot;Starting&quot;,
        ///         startDateTime: string (ISO 8601 Format),
        ///         endDateTime: string (ISO 8601 Format),
        ///         reviewers: [
        ///           {
        ///             principalId: string,
        ///             principalType: &quot;user&quot; | &quot;servicePrincipal&quot;
        ///           }
        ///         ],
        ///         backupReviewers: [AccessReviewReviewer],
        ///         reviewersType: &quot;Assigned&quot; | &quot;Self&quot; | &quot;Managers&quot;
        ///       }
        ///     }
        ///   ],
        ///   nextLink: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     message: string,
        ///     code: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual AsyncPageable<BinaryData> GetAccessReviewInstancesAssignedForMyApprovalsAsync(string scheduleDefinitionId, string filter = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(scheduleDefinitionId, nameof(scheduleDefinitionId));

            return GetAccessReviewInstancesAssignedForMyApprovalsImplementationAsync("AccessReviewInstancesAssignedForMyApprovalClient.GetAccessReviewInstancesAssignedForMyApprovals", scheduleDefinitionId, filter, context);
        }

        private AsyncPageable<BinaryData> GetAccessReviewInstancesAssignedForMyApprovalsImplementationAsync(string diagnosticsScopeName, string scheduleDefinitionId, string filter, RequestContext context)
        {
            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, ClientDiagnostics, diagnosticsScopeName);
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetAccessReviewInstancesAssignedForMyApprovalsRequest(scheduleDefinitionId, filter, context)
                        : CreateGetAccessReviewInstancesAssignedForMyApprovalsNextPageRequest(nextLink, scheduleDefinitionId, filter, context);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, context, "value", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> Get access review instances assigned for my approval. </summary>
        /// <param name="scheduleDefinitionId"> The id of the access review schedule definition. </param>
        /// <param name="filter"> The filter to apply on the operation. Other than standard filters, one custom filter option is supported : &apos;assignedToMeToReview()&apos;. When one specified $filter=assignedToMeToReview(), only items that are assigned to the calling user to review are returned. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleDefinitionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scheduleDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [
        ///     {
        ///       id: string,
        ///       name: string,
        ///       type: string,
        ///       properties: {
        ///         status: &quot;NotStarted&quot; | &quot;InProgress&quot; | &quot;Completed&quot; | &quot;Applied&quot; | &quot;Initializing&quot; | &quot;Applying&quot; | &quot;Completing&quot; | &quot;Scheduled&quot; | &quot;AutoReviewing&quot; | &quot;AutoReviewed&quot; | &quot;Starting&quot;,
        ///         startDateTime: string (ISO 8601 Format),
        ///         endDateTime: string (ISO 8601 Format),
        ///         reviewers: [
        ///           {
        ///             principalId: string,
        ///             principalType: &quot;user&quot; | &quot;servicePrincipal&quot;
        ///           }
        ///         ],
        ///         backupReviewers: [AccessReviewReviewer],
        ///         reviewersType: &quot;Assigned&quot; | &quot;Self&quot; | &quot;Managers&quot;
        ///       }
        ///     }
        ///   ],
        ///   nextLink: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     message: string,
        ///     code: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Pageable<BinaryData> GetAccessReviewInstancesAssignedForMyApprovals(string scheduleDefinitionId, string filter = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(scheduleDefinitionId, nameof(scheduleDefinitionId));

            return GetAccessReviewInstancesAssignedForMyApprovalsImplementation("AccessReviewInstancesAssignedForMyApprovalClient.GetAccessReviewInstancesAssignedForMyApprovals", scheduleDefinitionId, filter, context);
        }

        private Pageable<BinaryData> GetAccessReviewInstancesAssignedForMyApprovalsImplementation(string diagnosticsScopeName, string scheduleDefinitionId, string filter, RequestContext context)
        {
            return PageableHelpers.CreatePageable(CreateEnumerable, ClientDiagnostics, diagnosticsScopeName);
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetAccessReviewInstancesAssignedForMyApprovalsRequest(scheduleDefinitionId, filter, context)
                        : CreateGetAccessReviewInstancesAssignedForMyApprovalsNextPageRequest(nextLink, scheduleDefinitionId, filter, context);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, context, "value", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        internal HttpMessage CreateGetAccessReviewInstancesAssignedForMyApprovalsRequest(string scheduleDefinitionId, string filter, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/", false);
            uri.AppendPath(scheduleDefinitionId, true);
            uri.AppendPath("/instances", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, false);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetByIdRequest(string scheduleDefinitionId, string id, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/", false);
            uri.AppendPath(scheduleDefinitionId, true);
            uri.AppendPath("/instances/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetAccessReviewInstancesAssignedForMyApprovalsNextPageRequest(string nextLink, string scheduleDefinitionId, string filter, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
