// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace MgmtSubscriptionNameParameter
{
    /// <summary> A Class representing a SBSubscription along with the instance operations that can be performed on it. </summary>
    public partial class SBSubscription : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SBSubscription"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string subscriptionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sbSubscriptionSubscriptionsClientDiagnostics;
        private readonly SubscriptionsRestOperations _sbSubscriptionSubscriptionsRestClient;
        private readonly SBSubscriptionData _data;

        /// <summary> Initializes a new instance of the <see cref="SBSubscription"/> class for mocking. </summary>
        protected SBSubscription()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SBSubscription"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SBSubscription(ArmClient client, SBSubscriptionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SBSubscription"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SBSubscription(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sbSubscriptionSubscriptionsClientDiagnostics = new ClientDiagnostics("MgmtSubscriptionNameParameter", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string sbSubscriptionSubscriptionsApiVersion);
            _sbSubscriptionSubscriptionsRestClient = new SubscriptionsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, sbSubscriptionSubscriptionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ServiceBus/subscriptions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SBSubscriptionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Returns a subscription description for the specified topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SBSubscription>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sbSubscriptionSubscriptionsClientDiagnostics.CreateScope("SBSubscription.Get");
            scope.Start();
            try
            {
                var response = await _sbSubscriptionSubscriptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SBSubscription(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a subscription description for the specified topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SBSubscription> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sbSubscriptionSubscriptionsClientDiagnostics.CreateScope("SBSubscription.Get");
            scope.Start();
            try
            {
                var response = _sbSubscriptionSubscriptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SBSubscription(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a subscription from the specified topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sbSubscriptionSubscriptionsClientDiagnostics.CreateScope("SBSubscription.Delete");
            scope.Start();
            try
            {
                var response = await _sbSubscriptionSubscriptionsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtSubscriptionNameParameterArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a subscription from the specified topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sbSubscriptionSubscriptionsClientDiagnostics.CreateScope("SBSubscription.Delete");
            scope.Start();
            try
            {
                var response = _sbSubscriptionSubscriptionsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new MgmtSubscriptionNameParameterArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
