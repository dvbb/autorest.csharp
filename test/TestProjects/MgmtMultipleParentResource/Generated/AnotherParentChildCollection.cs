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

namespace MgmtMultipleParentResource
{
    /// <summary> A class representing collection of AnotherParentChild and their operations over its parent. </summary>
    public partial class AnotherParentChildCollection : ArmCollection, IEnumerable<AnotherParentChildResource>, IAsyncEnumerable<AnotherParentChildResource>
    {
        private readonly ClientDiagnostics _anotherParentChildAnotherChildrenClientDiagnostics;
        private readonly AnotherChildrenRestOperations _anotherParentChildAnotherChildrenRestClient;

        /// <summary> Initializes a new instance of the <see cref="AnotherParentChildCollection"/> class for mocking. </summary>
        protected AnotherParentChildCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AnotherParentChildCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AnotherParentChildCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _anotherParentChildAnotherChildrenClientDiagnostics = new ClientDiagnostics("MgmtMultipleParentResource", AnotherParentChildResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AnotherParentChildResource.ResourceType, out string anotherParentChildAnotherChildrenApiVersion);
            _anotherParentChildAnotherChildrenRestClient = new AnotherChildrenRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, anotherParentChildAnotherChildrenApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AnotherParentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AnotherParentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create or update the run command.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// Operation Id: AnotherChildren_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="childBody"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="childName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="childName"/> or <paramref name="childBody"/> is null. </exception>
        public virtual async Task<ArmOperation<AnotherParentChildResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string childName, ChildBodyData childBody, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(childName, nameof(childName));
            Argument.AssertNotNull(childBody, nameof(childBody));

            using var scope = _anotherParentChildAnotherChildrenClientDiagnostics.CreateScope("AnotherParentChildCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _anotherParentChildAnotherChildrenRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, childName, childBody, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtMultipleParentResourceArmOperation<AnotherParentChildResource>(new AnotherParentChildOperationSource(Client), _anotherParentChildAnotherChildrenClientDiagnostics, Pipeline, _anotherParentChildAnotherChildrenRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, childName, childBody).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to create or update the run command.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// Operation Id: AnotherChildren_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="childBody"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="childName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="childName"/> or <paramref name="childBody"/> is null. </exception>
        public virtual ArmOperation<AnotherParentChildResource> CreateOrUpdate(WaitUntil waitUntil, string childName, ChildBodyData childBody, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(childName, nameof(childName));
            Argument.AssertNotNull(childBody, nameof(childBody));

            using var scope = _anotherParentChildAnotherChildrenClientDiagnostics.CreateScope("AnotherParentChildCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _anotherParentChildAnotherChildrenRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, childName, childBody, cancellationToken);
                var operation = new MgmtMultipleParentResourceArmOperation<AnotherParentChildResource>(new AnotherParentChildOperationSource(Client), _anotherParentChildAnotherChildrenClientDiagnostics, Pipeline, _anotherParentChildAnotherChildrenRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, childName, childBody).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to get the run command.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// Operation Id: AnotherChildren_Get
        /// </summary>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="childName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="childName"/> is null. </exception>
        public virtual async Task<Response<AnotherParentChildResource>> GetAsync(string childName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(childName, nameof(childName));

            using var scope = _anotherParentChildAnotherChildrenClientDiagnostics.CreateScope("AnotherParentChildCollection.Get");
            scope.Start();
            try
            {
                var response = await _anotherParentChildAnotherChildrenRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, childName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AnotherParentChildResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the run command.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// Operation Id: AnotherChildren_Get
        /// </summary>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="childName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="childName"/> is null. </exception>
        public virtual Response<AnotherParentChildResource> Get(string childName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(childName, nameof(childName));

            using var scope = _anotherParentChildAnotherChildrenClientDiagnostics.CreateScope("AnotherParentChildCollection.Get");
            scope.Start();
            try
            {
                var response = _anotherParentChildAnotherChildrenRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, childName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AnotherParentChildResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get all run commands of a Virtual Machine.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children
        /// Operation Id: AnotherChildren_List
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AnotherParentChildResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AnotherParentChildResource> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<AnotherParentChildResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _anotherParentChildAnotherChildrenClientDiagnostics.CreateScope("AnotherParentChildCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _anotherParentChildAnotherChildrenRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AnotherParentChildResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AnotherParentChildResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _anotherParentChildAnotherChildrenClientDiagnostics.CreateScope("AnotherParentChildCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _anotherParentChildAnotherChildrenRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AnotherParentChildResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// The operation to get all run commands of a Virtual Machine.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children
        /// Operation Id: AnotherChildren_List
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AnotherParentChildResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AnotherParentChildResource> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<AnotherParentChildResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _anotherParentChildAnotherChildrenClientDiagnostics.CreateScope("AnotherParentChildCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _anotherParentChildAnotherChildrenRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AnotherParentChildResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AnotherParentChildResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _anotherParentChildAnotherChildrenClientDiagnostics.CreateScope("AnotherParentChildCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _anotherParentChildAnotherChildrenRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AnotherParentChildResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// Operation Id: AnotherChildren_Get
        /// </summary>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="childName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="childName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string childName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(childName, nameof(childName));

            using var scope = _anotherParentChildAnotherChildrenClientDiagnostics.CreateScope("AnotherParentChildCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(childName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// Operation Id: AnotherChildren_Get
        /// </summary>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="childName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="childName"/> is null. </exception>
        public virtual Response<bool> Exists(string childName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(childName, nameof(childName));

            using var scope = _anotherParentChildAnotherChildrenClientDiagnostics.CreateScope("AnotherParentChildCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(childName, expand: expand, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// Operation Id: AnotherChildren_Get
        /// </summary>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="childName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="childName"/> is null. </exception>
        public virtual async Task<Response<AnotherParentChildResource>> GetIfExistsAsync(string childName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(childName, nameof(childName));

            using var scope = _anotherParentChildAnotherChildrenClientDiagnostics.CreateScope("AnotherParentChildCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _anotherParentChildAnotherChildrenRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, childName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<AnotherParentChildResource>(null, response.GetRawResponse());
                return Response.FromValue(new AnotherParentChildResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// Operation Id: AnotherChildren_Get
        /// </summary>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="childName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="childName"/> is null. </exception>
        public virtual Response<AnotherParentChildResource> GetIfExists(string childName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(childName, nameof(childName));

            using var scope = _anotherParentChildAnotherChildrenClientDiagnostics.CreateScope("AnotherParentChildCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _anotherParentChildAnotherChildrenRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, childName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<AnotherParentChildResource>(null, response.GetRawResponse());
                return Response.FromValue(new AnotherParentChildResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AnotherParentChildResource> IEnumerable<AnotherParentChildResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AnotherParentChildResource> IAsyncEnumerable<AnotherParentChildResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
