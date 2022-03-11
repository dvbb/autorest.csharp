// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace NoTypeReplacement
{
    /// <summary> A class representing collection of NoTypeReplacementModel3 and their operations over its parent. </summary>
    public partial class NoTypeReplacementModel3Collection : ArmCollection, IEnumerable<NoTypeReplacementModel3>, IAsyncEnumerable<NoTypeReplacementModel3>
    {
        private readonly ClientDiagnostics _noTypeReplacementModel3ClientDiagnostics;
        private readonly NoTypeReplacementModel3SRestOperations _noTypeReplacementModel3RestClient;

        /// <summary> Initializes a new instance of the <see cref="NoTypeReplacementModel3Collection"/> class for mocking. </summary>
        protected NoTypeReplacementModel3Collection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NoTypeReplacementModel3Collection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NoTypeReplacementModel3Collection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _noTypeReplacementModel3ClientDiagnostics = new ClientDiagnostics("NoTypeReplacement", NoTypeReplacementModel3.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(NoTypeReplacementModel3.ResourceType, out string noTypeReplacementModel3ApiVersion);
            _noTypeReplacementModel3RestClient = new NoTypeReplacementModel3SRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, noTypeReplacementModel3ApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/noTypeReplacementModel3s/{noTypeReplacementModel3SName}
        /// Operation Id: NoTypeReplacementModel3s_Put
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="noTypeReplacementModel3SName"> The String to use. </param>
        /// <param name="parameters"> The NoTypeReplacementModel3 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="noTypeReplacementModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="noTypeReplacementModel3SName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<NoTypeReplacementModel3>> CreateOrUpdateAsync(WaitUntil waitUntil, string noTypeReplacementModel3SName, NoTypeReplacementModel3Data parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(noTypeReplacementModel3SName, nameof(noTypeReplacementModel3SName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _noTypeReplacementModel3ClientDiagnostics.CreateScope("NoTypeReplacementModel3Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _noTypeReplacementModel3RestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, noTypeReplacementModel3SName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NoTypeReplacementArmOperation<NoTypeReplacementModel3>(Response.FromValue(new NoTypeReplacementModel3(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/noTypeReplacementModel3s/{noTypeReplacementModel3SName}
        /// Operation Id: NoTypeReplacementModel3s_Put
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="noTypeReplacementModel3SName"> The String to use. </param>
        /// <param name="parameters"> The NoTypeReplacementModel3 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="noTypeReplacementModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="noTypeReplacementModel3SName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<NoTypeReplacementModel3> CreateOrUpdate(WaitUntil waitUntil, string noTypeReplacementModel3SName, NoTypeReplacementModel3Data parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(noTypeReplacementModel3SName, nameof(noTypeReplacementModel3SName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _noTypeReplacementModel3ClientDiagnostics.CreateScope("NoTypeReplacementModel3Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _noTypeReplacementModel3RestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, noTypeReplacementModel3SName, parameters, cancellationToken);
                var operation = new NoTypeReplacementArmOperation<NoTypeReplacementModel3>(Response.FromValue(new NoTypeReplacementModel3(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/noTypeReplacementModel3s/{noTypeReplacementModel3SName}
        /// Operation Id: NoTypeReplacementModel3s_Get
        /// </summary>
        /// <param name="noTypeReplacementModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="noTypeReplacementModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="noTypeReplacementModel3SName"/> is null. </exception>
        public virtual async Task<Response<NoTypeReplacementModel3>> GetAsync(string noTypeReplacementModel3SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(noTypeReplacementModel3SName, nameof(noTypeReplacementModel3SName));

            using var scope = _noTypeReplacementModel3ClientDiagnostics.CreateScope("NoTypeReplacementModel3Collection.Get");
            scope.Start();
            try
            {
                var response = await _noTypeReplacementModel3RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, noTypeReplacementModel3SName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NoTypeReplacementModel3(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/noTypeReplacementModel3s/{noTypeReplacementModel3SName}
        /// Operation Id: NoTypeReplacementModel3s_Get
        /// </summary>
        /// <param name="noTypeReplacementModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="noTypeReplacementModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="noTypeReplacementModel3SName"/> is null. </exception>
        public virtual Response<NoTypeReplacementModel3> Get(string noTypeReplacementModel3SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(noTypeReplacementModel3SName, nameof(noTypeReplacementModel3SName));

            using var scope = _noTypeReplacementModel3ClientDiagnostics.CreateScope("NoTypeReplacementModel3Collection.Get");
            scope.Start();
            try
            {
                var response = _noTypeReplacementModel3RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, noTypeReplacementModel3SName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NoTypeReplacementModel3(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/noTypeReplacementModel3s
        /// Operation Id: NoTypeReplacementModel3s_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NoTypeReplacementModel3" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NoTypeReplacementModel3> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NoTypeReplacementModel3>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _noTypeReplacementModel3ClientDiagnostics.CreateScope("NoTypeReplacementModel3Collection.GetAll");
                scope.Start();
                try
                {
                    var response = await _noTypeReplacementModel3RestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NoTypeReplacementModel3(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/noTypeReplacementModel3s
        /// Operation Id: NoTypeReplacementModel3s_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NoTypeReplacementModel3" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NoTypeReplacementModel3> GetAll(CancellationToken cancellationToken = default)
        {
            Page<NoTypeReplacementModel3> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _noTypeReplacementModel3ClientDiagnostics.CreateScope("NoTypeReplacementModel3Collection.GetAll");
                scope.Start();
                try
                {
                    var response = _noTypeReplacementModel3RestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NoTypeReplacementModel3(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/noTypeReplacementModel3s/{noTypeReplacementModel3SName}
        /// Operation Id: NoTypeReplacementModel3s_Get
        /// </summary>
        /// <param name="noTypeReplacementModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="noTypeReplacementModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="noTypeReplacementModel3SName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string noTypeReplacementModel3SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(noTypeReplacementModel3SName, nameof(noTypeReplacementModel3SName));

            using var scope = _noTypeReplacementModel3ClientDiagnostics.CreateScope("NoTypeReplacementModel3Collection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(noTypeReplacementModel3SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/noTypeReplacementModel3s/{noTypeReplacementModel3SName}
        /// Operation Id: NoTypeReplacementModel3s_Get
        /// </summary>
        /// <param name="noTypeReplacementModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="noTypeReplacementModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="noTypeReplacementModel3SName"/> is null. </exception>
        public virtual Response<bool> Exists(string noTypeReplacementModel3SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(noTypeReplacementModel3SName, nameof(noTypeReplacementModel3SName));

            using var scope = _noTypeReplacementModel3ClientDiagnostics.CreateScope("NoTypeReplacementModel3Collection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(noTypeReplacementModel3SName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/noTypeReplacementModel3s/{noTypeReplacementModel3SName}
        /// Operation Id: NoTypeReplacementModel3s_Get
        /// </summary>
        /// <param name="noTypeReplacementModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="noTypeReplacementModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="noTypeReplacementModel3SName"/> is null. </exception>
        public virtual async Task<Response<NoTypeReplacementModel3>> GetIfExistsAsync(string noTypeReplacementModel3SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(noTypeReplacementModel3SName, nameof(noTypeReplacementModel3SName));

            using var scope = _noTypeReplacementModel3ClientDiagnostics.CreateScope("NoTypeReplacementModel3Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _noTypeReplacementModel3RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, noTypeReplacementModel3SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<NoTypeReplacementModel3>(null, response.GetRawResponse());
                return Response.FromValue(new NoTypeReplacementModel3(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/noTypeReplacementModel3s/{noTypeReplacementModel3SName}
        /// Operation Id: NoTypeReplacementModel3s_Get
        /// </summary>
        /// <param name="noTypeReplacementModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="noTypeReplacementModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="noTypeReplacementModel3SName"/> is null. </exception>
        public virtual Response<NoTypeReplacementModel3> GetIfExists(string noTypeReplacementModel3SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(noTypeReplacementModel3SName, nameof(noTypeReplacementModel3SName));

            using var scope = _noTypeReplacementModel3ClientDiagnostics.CreateScope("NoTypeReplacementModel3Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = _noTypeReplacementModel3RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, noTypeReplacementModel3SName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<NoTypeReplacementModel3>(null, response.GetRawResponse());
                return Response.FromValue(new NoTypeReplacementModel3(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NoTypeReplacementModel3> IEnumerable<NoTypeReplacementModel3>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NoTypeReplacementModel3> IAsyncEnumerable<NoTypeReplacementModel3>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
