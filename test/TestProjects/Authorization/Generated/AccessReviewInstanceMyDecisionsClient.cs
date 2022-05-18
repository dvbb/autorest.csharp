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
    /// <summary> The AccessReviewInstanceMyDecisions service client. </summary>
    public partial class AccessReviewInstanceMyDecisionsClient
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

        /// <summary> Initializes a new instance of AccessReviewInstanceMyDecisionsClient for mocking. </summary>
        protected AccessReviewInstanceMyDecisionsClient()
        {
        }

        /// <summary> Initializes a new instance of AccessReviewInstanceMyDecisionsClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public AccessReviewInstanceMyDecisionsClient(AzureKeyCredential credential) : this(credential, new Uri("https://management.azure.com"), new AuthorizationManagementClientOptions())
        {
        }

        /// <summary> Initializes a new instance of AccessReviewInstanceMyDecisionsClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> or <paramref name="endpoint"/> is null. </exception>
        public AccessReviewInstanceMyDecisionsClient(AzureKeyCredential credential, Uri endpoint, AuthorizationManagementClientOptions options)
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

        /// <summary> Get my single access review instance decision. </summary>
        /// <param name="scheduleDefinitionId"> The id of the access review schedule definition. </param>
        /// <param name="id"> The id of the access review instance. </param>
        /// <param name="decisionId"> The id of the decision record. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleDefinitionId"/>, <paramref name="id"/> or <paramref name="decisionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scheduleDefinitionId"/>, <paramref name="id"/> or <paramref name="decisionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: string,
        ///   name: string,
        ///   type: string,
        ///   properties: {
        ///     principal: {
        ///       type: &quot;user&quot; | &quot;servicePrincipal&quot;,
        ///       id: string,
        ///       displayName: string
        ///     },
        ///     resource: {
        ///       type: &quot;azureRole&quot;,
        ///       id: string,
        ///       displayName: string
        ///     },
        ///     recommendation: &quot;Approve&quot; | &quot;Deny&quot; | &quot;NoInfoAvailable&quot;,
        ///     decision: &quot;Approve&quot; | &quot;Deny&quot; | &quot;NotReviewed&quot; | &quot;DontKnow&quot; | &quot;NotNotified&quot;,
        ///     justification: string,
        ///     reviewedDateTime: string (ISO 8601 Format),
        ///     reviewedBy: {
        ///       principalId: string,
        ///       principalType: &quot;user&quot; | &quot;servicePrincipal&quot;,
        ///       principalName: string,
        ///       userPrincipalName: string
        ///     },
        ///     applyResult: &quot;New&quot; | &quot;Applying&quot; | &quot;AppliedSuccessfully&quot; | &quot;AppliedWithUnknownFailure&quot; | &quot;AppliedSuccessfullyButObjectNotFound&quot; | &quot;ApplyNotSupported&quot;,
        ///     appliedDateTime: string (ISO 8601 Format),
        ///     appliedBy: AccessReviewActorIdentity
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
        public virtual async Task<Response> GetByIdAsync(string scheduleDefinitionId, string id, string decisionId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(scheduleDefinitionId, nameof(scheduleDefinitionId));
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            Argument.AssertNotNullOrEmpty(decisionId, nameof(decisionId));

            using var scope = ClientDiagnostics.CreateScope("AccessReviewInstanceMyDecisionsClient.GetById");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetByIdRequest(scheduleDefinitionId, id, decisionId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get my single access review instance decision. </summary>
        /// <param name="scheduleDefinitionId"> The id of the access review schedule definition. </param>
        /// <param name="id"> The id of the access review instance. </param>
        /// <param name="decisionId"> The id of the decision record. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleDefinitionId"/>, <paramref name="id"/> or <paramref name="decisionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scheduleDefinitionId"/>, <paramref name="id"/> or <paramref name="decisionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: string,
        ///   name: string,
        ///   type: string,
        ///   properties: {
        ///     principal: {
        ///       type: &quot;user&quot; | &quot;servicePrincipal&quot;,
        ///       id: string,
        ///       displayName: string
        ///     },
        ///     resource: {
        ///       type: &quot;azureRole&quot;,
        ///       id: string,
        ///       displayName: string
        ///     },
        ///     recommendation: &quot;Approve&quot; | &quot;Deny&quot; | &quot;NoInfoAvailable&quot;,
        ///     decision: &quot;Approve&quot; | &quot;Deny&quot; | &quot;NotReviewed&quot; | &quot;DontKnow&quot; | &quot;NotNotified&quot;,
        ///     justification: string,
        ///     reviewedDateTime: string (ISO 8601 Format),
        ///     reviewedBy: {
        ///       principalId: string,
        ///       principalType: &quot;user&quot; | &quot;servicePrincipal&quot;,
        ///       principalName: string,
        ///       userPrincipalName: string
        ///     },
        ///     applyResult: &quot;New&quot; | &quot;Applying&quot; | &quot;AppliedSuccessfully&quot; | &quot;AppliedWithUnknownFailure&quot; | &quot;AppliedSuccessfullyButObjectNotFound&quot; | &quot;ApplyNotSupported&quot;,
        ///     appliedDateTime: string (ISO 8601 Format),
        ///     appliedBy: AccessReviewActorIdentity
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
        public virtual Response GetById(string scheduleDefinitionId, string id, string decisionId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(scheduleDefinitionId, nameof(scheduleDefinitionId));
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            Argument.AssertNotNullOrEmpty(decisionId, nameof(decisionId));

            using var scope = ClientDiagnostics.CreateScope("AccessReviewInstanceMyDecisionsClient.GetById");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetByIdRequest(scheduleDefinitionId, id, decisionId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Record a decision. </summary>
        /// <param name="scheduleDefinitionId"> The id of the access review schedule definition. </param>
        /// <param name="id"> The id of the access review instance. </param>
        /// <param name="decisionId"> The id of the decision record. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleDefinitionId"/>, <paramref name="id"/>, <paramref name="decisionId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scheduleDefinitionId"/>, <paramref name="id"/> or <paramref name="decisionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   principal: {
        ///     type: &quot;user&quot; | &quot;servicePrincipal&quot; (required),
        ///     id: string,
        ///     displayName: string
        ///   },
        ///   resource: {
        ///     type: &quot;azureRole&quot; (required),
        ///     id: string,
        ///     displayName: string
        ///   },
        ///   recommendation: &quot;Approve&quot; | &quot;Deny&quot; | &quot;NoInfoAvailable&quot;,
        ///   decision: &quot;Approve&quot; | &quot;Deny&quot; | &quot;NotReviewed&quot; | &quot;DontKnow&quot; | &quot;NotNotified&quot;,
        ///   justification: string,
        ///   reviewedDateTime: string (ISO 8601 Format),
        ///   reviewedBy: {
        ///     principalId: string,
        ///     principalType: &quot;user&quot; | &quot;servicePrincipal&quot;,
        ///     principalName: string,
        ///     userPrincipalName: string
        ///   },
        ///   applyResult: &quot;New&quot; | &quot;Applying&quot; | &quot;AppliedSuccessfully&quot; | &quot;AppliedWithUnknownFailure&quot; | &quot;AppliedSuccessfullyButObjectNotFound&quot; | &quot;ApplyNotSupported&quot;,
        ///   appliedDateTime: string (ISO 8601 Format),
        ///   appliedBy: AccessReviewActorIdentity
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: string,
        ///   name: string,
        ///   type: string,
        ///   properties: {
        ///     principal: {
        ///       type: &quot;user&quot; | &quot;servicePrincipal&quot;,
        ///       id: string,
        ///       displayName: string
        ///     },
        ///     resource: {
        ///       type: &quot;azureRole&quot;,
        ///       id: string,
        ///       displayName: string
        ///     },
        ///     recommendation: &quot;Approve&quot; | &quot;Deny&quot; | &quot;NoInfoAvailable&quot;,
        ///     decision: &quot;Approve&quot; | &quot;Deny&quot; | &quot;NotReviewed&quot; | &quot;DontKnow&quot; | &quot;NotNotified&quot;,
        ///     justification: string,
        ///     reviewedDateTime: string (ISO 8601 Format),
        ///     reviewedBy: {
        ///       principalId: string,
        ///       principalType: &quot;user&quot; | &quot;servicePrincipal&quot;,
        ///       principalName: string,
        ///       userPrincipalName: string
        ///     },
        ///     applyResult: &quot;New&quot; | &quot;Applying&quot; | &quot;AppliedSuccessfully&quot; | &quot;AppliedWithUnknownFailure&quot; | &quot;AppliedSuccessfullyButObjectNotFound&quot; | &quot;ApplyNotSupported&quot;,
        ///     appliedDateTime: string (ISO 8601 Format),
        ///     appliedBy: AccessReviewActorIdentity
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
        public virtual async Task<Response> PatchAsync(string scheduleDefinitionId, string id, string decisionId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(scheduleDefinitionId, nameof(scheduleDefinitionId));
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            Argument.AssertNotNullOrEmpty(decisionId, nameof(decisionId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("AccessReviewInstanceMyDecisionsClient.Patch");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePatchRequest(scheduleDefinitionId, id, decisionId, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Record a decision. </summary>
        /// <param name="scheduleDefinitionId"> The id of the access review schedule definition. </param>
        /// <param name="id"> The id of the access review instance. </param>
        /// <param name="decisionId"> The id of the decision record. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleDefinitionId"/>, <paramref name="id"/>, <paramref name="decisionId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scheduleDefinitionId"/>, <paramref name="id"/> or <paramref name="decisionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   principal: {
        ///     type: &quot;user&quot; | &quot;servicePrincipal&quot; (required),
        ///     id: string,
        ///     displayName: string
        ///   },
        ///   resource: {
        ///     type: &quot;azureRole&quot; (required),
        ///     id: string,
        ///     displayName: string
        ///   },
        ///   recommendation: &quot;Approve&quot; | &quot;Deny&quot; | &quot;NoInfoAvailable&quot;,
        ///   decision: &quot;Approve&quot; | &quot;Deny&quot; | &quot;NotReviewed&quot; | &quot;DontKnow&quot; | &quot;NotNotified&quot;,
        ///   justification: string,
        ///   reviewedDateTime: string (ISO 8601 Format),
        ///   reviewedBy: {
        ///     principalId: string,
        ///     principalType: &quot;user&quot; | &quot;servicePrincipal&quot;,
        ///     principalName: string,
        ///     userPrincipalName: string
        ///   },
        ///   applyResult: &quot;New&quot; | &quot;Applying&quot; | &quot;AppliedSuccessfully&quot; | &quot;AppliedWithUnknownFailure&quot; | &quot;AppliedSuccessfullyButObjectNotFound&quot; | &quot;ApplyNotSupported&quot;,
        ///   appliedDateTime: string (ISO 8601 Format),
        ///   appliedBy: AccessReviewActorIdentity
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: string,
        ///   name: string,
        ///   type: string,
        ///   properties: {
        ///     principal: {
        ///       type: &quot;user&quot; | &quot;servicePrincipal&quot;,
        ///       id: string,
        ///       displayName: string
        ///     },
        ///     resource: {
        ///       type: &quot;azureRole&quot;,
        ///       id: string,
        ///       displayName: string
        ///     },
        ///     recommendation: &quot;Approve&quot; | &quot;Deny&quot; | &quot;NoInfoAvailable&quot;,
        ///     decision: &quot;Approve&quot; | &quot;Deny&quot; | &quot;NotReviewed&quot; | &quot;DontKnow&quot; | &quot;NotNotified&quot;,
        ///     justification: string,
        ///     reviewedDateTime: string (ISO 8601 Format),
        ///     reviewedBy: {
        ///       principalId: string,
        ///       principalType: &quot;user&quot; | &quot;servicePrincipal&quot;,
        ///       principalName: string,
        ///       userPrincipalName: string
        ///     },
        ///     applyResult: &quot;New&quot; | &quot;Applying&quot; | &quot;AppliedSuccessfully&quot; | &quot;AppliedWithUnknownFailure&quot; | &quot;AppliedSuccessfullyButObjectNotFound&quot; | &quot;ApplyNotSupported&quot;,
        ///     appliedDateTime: string (ISO 8601 Format),
        ///     appliedBy: AccessReviewActorIdentity
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
        public virtual Response Patch(string scheduleDefinitionId, string id, string decisionId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(scheduleDefinitionId, nameof(scheduleDefinitionId));
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            Argument.AssertNotNullOrEmpty(decisionId, nameof(decisionId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("AccessReviewInstanceMyDecisionsClient.Patch");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePatchRequest(scheduleDefinitionId, id, decisionId, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get my access review instance decisions. </summary>
        /// <param name="scheduleDefinitionId"> The id of the access review schedule definition. </param>
        /// <param name="id"> The id of the access review instance. </param>
        /// <param name="filter"> The filter to apply on the operation. Other than standard filters, one custom filter option is supported : &apos;assignedToMeToReview()&apos;. When one specified $filter=assignedToMeToReview(), only items that are assigned to the calling user to review are returned. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleDefinitionId"/> or <paramref name="id"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scheduleDefinitionId"/> or <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [
        ///     {
        ///       id: string,
        ///       name: string,
        ///       type: string,
        ///       properties: {
        ///         principal: {
        ///           type: &quot;user&quot; | &quot;servicePrincipal&quot;,
        ///           id: string,
        ///           displayName: string
        ///         },
        ///         resource: {
        ///           type: &quot;azureRole&quot;,
        ///           id: string,
        ///           displayName: string
        ///         },
        ///         recommendation: &quot;Approve&quot; | &quot;Deny&quot; | &quot;NoInfoAvailable&quot;,
        ///         decision: &quot;Approve&quot; | &quot;Deny&quot; | &quot;NotReviewed&quot; | &quot;DontKnow&quot; | &quot;NotNotified&quot;,
        ///         justification: string,
        ///         reviewedDateTime: string (ISO 8601 Format),
        ///         reviewedBy: {
        ///           principalId: string,
        ///           principalType: &quot;user&quot; | &quot;servicePrincipal&quot;,
        ///           principalName: string,
        ///           userPrincipalName: string
        ///         },
        ///         applyResult: &quot;New&quot; | &quot;Applying&quot; | &quot;AppliedSuccessfully&quot; | &quot;AppliedWithUnknownFailure&quot; | &quot;AppliedSuccessfullyButObjectNotFound&quot; | &quot;ApplyNotSupported&quot;,
        ///         appliedDateTime: string (ISO 8601 Format),
        ///         appliedBy: AccessReviewActorIdentity
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
        public virtual AsyncPageable<BinaryData> GetAccessReviewInstanceMyDecisionsAsync(string scheduleDefinitionId, string id, string filter = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(scheduleDefinitionId, nameof(scheduleDefinitionId));
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            return GetAccessReviewInstanceMyDecisionsImplementationAsync("AccessReviewInstanceMyDecisionsClient.GetAccessReviewInstanceMyDecisions", scheduleDefinitionId, id, filter, context);
        }

        private AsyncPageable<BinaryData> GetAccessReviewInstanceMyDecisionsImplementationAsync(string diagnosticsScopeName, string scheduleDefinitionId, string id, string filter, RequestContext context)
        {
            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, ClientDiagnostics, diagnosticsScopeName);
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetAccessReviewInstanceMyDecisionsRequest(scheduleDefinitionId, id, filter, context)
                        : CreateGetAccessReviewInstanceMyDecisionsNextPageRequest(nextLink, scheduleDefinitionId, id, filter, context);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, context, "value", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> Get my access review instance decisions. </summary>
        /// <param name="scheduleDefinitionId"> The id of the access review schedule definition. </param>
        /// <param name="id"> The id of the access review instance. </param>
        /// <param name="filter"> The filter to apply on the operation. Other than standard filters, one custom filter option is supported : &apos;assignedToMeToReview()&apos;. When one specified $filter=assignedToMeToReview(), only items that are assigned to the calling user to review are returned. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleDefinitionId"/> or <paramref name="id"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scheduleDefinitionId"/> or <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [
        ///     {
        ///       id: string,
        ///       name: string,
        ///       type: string,
        ///       properties: {
        ///         principal: {
        ///           type: &quot;user&quot; | &quot;servicePrincipal&quot;,
        ///           id: string,
        ///           displayName: string
        ///         },
        ///         resource: {
        ///           type: &quot;azureRole&quot;,
        ///           id: string,
        ///           displayName: string
        ///         },
        ///         recommendation: &quot;Approve&quot; | &quot;Deny&quot; | &quot;NoInfoAvailable&quot;,
        ///         decision: &quot;Approve&quot; | &quot;Deny&quot; | &quot;NotReviewed&quot; | &quot;DontKnow&quot; | &quot;NotNotified&quot;,
        ///         justification: string,
        ///         reviewedDateTime: string (ISO 8601 Format),
        ///         reviewedBy: {
        ///           principalId: string,
        ///           principalType: &quot;user&quot; | &quot;servicePrincipal&quot;,
        ///           principalName: string,
        ///           userPrincipalName: string
        ///         },
        ///         applyResult: &quot;New&quot; | &quot;Applying&quot; | &quot;AppliedSuccessfully&quot; | &quot;AppliedWithUnknownFailure&quot; | &quot;AppliedSuccessfullyButObjectNotFound&quot; | &quot;ApplyNotSupported&quot;,
        ///         appliedDateTime: string (ISO 8601 Format),
        ///         appliedBy: AccessReviewActorIdentity
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
        public virtual Pageable<BinaryData> GetAccessReviewInstanceMyDecisions(string scheduleDefinitionId, string id, string filter = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(scheduleDefinitionId, nameof(scheduleDefinitionId));
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            return GetAccessReviewInstanceMyDecisionsImplementation("AccessReviewInstanceMyDecisionsClient.GetAccessReviewInstanceMyDecisions", scheduleDefinitionId, id, filter, context);
        }

        private Pageable<BinaryData> GetAccessReviewInstanceMyDecisionsImplementation(string diagnosticsScopeName, string scheduleDefinitionId, string id, string filter, RequestContext context)
        {
            return PageableHelpers.CreatePageable(CreateEnumerable, ClientDiagnostics, diagnosticsScopeName);
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetAccessReviewInstanceMyDecisionsRequest(scheduleDefinitionId, id, filter, context)
                        : CreateGetAccessReviewInstanceMyDecisionsNextPageRequest(nextLink, scheduleDefinitionId, id, filter, context);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, context, "value", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        internal HttpMessage CreateGetAccessReviewInstanceMyDecisionsRequest(string scheduleDefinitionId, string id, string filter, RequestContext context)
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
            uri.AppendPath("/decisions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, false);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetByIdRequest(string scheduleDefinitionId, string id, string decisionId, RequestContext context)
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
            uri.AppendPath("/decisions/", false);
            uri.AppendPath(decisionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreatePatchRequest(string scheduleDefinitionId, string id, string decisionId, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/", false);
            uri.AppendPath(scheduleDefinitionId, true);
            uri.AppendPath("/instances/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/decisions/", false);
            uri.AppendPath(decisionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetAccessReviewInstanceMyDecisionsNextPageRequest(string nextLink, string scheduleDefinitionId, string id, string filter, RequestContext context)
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
