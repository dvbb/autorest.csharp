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

namespace Azure.ResourceManager.Sample
{
    /// <summary> A class representing collection of VirtualMachineScaleSetVirtualMachineExtension and their operations over its parent. </summary>
    public partial class VirtualMachineScaleSetVirtualMachineExtensionCollection : ArmCollection, IEnumerable<VirtualMachineScaleSetVirtualMachineExtensionResource>, IAsyncEnumerable<VirtualMachineScaleSetVirtualMachineExtensionResource>
    {
        private readonly ClientDiagnostics _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics;
        private readonly VirtualMachineScaleSetVMExtensionsRestOperations _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetVirtualMachineExtensionCollection"/> class for mocking. </summary>
        protected VirtualMachineScaleSetVirtualMachineExtensionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetVirtualMachineExtensionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualMachineScaleSetVirtualMachineExtensionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sample", VirtualMachineScaleSetVirtualMachineExtensionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualMachineScaleSetVirtualMachineExtensionResource.ResourceType, out string virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsApiVersion);
            _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsRestClient = new VirtualMachineScaleSetVMExtensionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualMachineScaleSetVMResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualMachineScaleSetVMResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create or update the VMSS VM extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}
        /// Operation Id: VirtualMachineScaleSetVMExtensions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Create Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmExtensionName"/> or <paramref name="extensionParameters"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualMachineScaleSetVirtualMachineExtensionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string vmExtensionName, VirtualMachineExtensionData extensionParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));
            Argument.AssertNotNull(extensionParameters, nameof(extensionParameters));

            using var scope = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vmExtensionName, extensionParameters, cancellationToken).ConfigureAwait(false);
                var operation = new SampleArmOperation<VirtualMachineScaleSetVirtualMachineExtensionResource>(new VirtualMachineScaleSetVirtualMachineExtensionOperationSource(Client), _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics, Pipeline, _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vmExtensionName, extensionParameters).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to create or update the VMSS VM extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}
        /// Operation Id: VirtualMachineScaleSetVMExtensions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Create Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmExtensionName"/> or <paramref name="extensionParameters"/> is null. </exception>
        public virtual ArmOperation<VirtualMachineScaleSetVirtualMachineExtensionResource> CreateOrUpdate(WaitUntil waitUntil, string vmExtensionName, VirtualMachineExtensionData extensionParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));
            Argument.AssertNotNull(extensionParameters, nameof(extensionParameters));

            using var scope = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vmExtensionName, extensionParameters, cancellationToken);
                var operation = new SampleArmOperation<VirtualMachineScaleSetVirtualMachineExtensionResource>(new VirtualMachineScaleSetVirtualMachineExtensionOperationSource(Client), _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics, Pipeline, _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vmExtensionName, extensionParameters).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to get the VMSS VM extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}
        /// Operation Id: VirtualMachineScaleSetVMExtensions_Get
        /// </summary>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmExtensionName"/> is null. </exception>
        public virtual async Task<Response<VirtualMachineScaleSetVirtualMachineExtensionResource>> GetAsync(string vmExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));

            using var scope = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vmExtensionName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVirtualMachineExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the VMSS VM extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}
        /// Operation Id: VirtualMachineScaleSetVMExtensions_Get
        /// </summary>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmExtensionName"/> is null. </exception>
        public virtual Response<VirtualMachineScaleSetVirtualMachineExtensionResource> Get(string vmExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));

            using var scope = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vmExtensionName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVirtualMachineExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get all extensions of an instance in Virtual Machine Scaleset.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions
        /// Operation Id: VirtualMachineScaleSetVMExtensions_List
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineScaleSetVirtualMachineExtensionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineScaleSetVirtualMachineExtensionResource> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualMachineScaleSetVirtualMachineExtensionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetVirtualMachineExtensionResource(Client, value)), null, response.GetRawResponse());
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
        /// The operation to get all extensions of an instance in Virtual Machine Scaleset.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions
        /// Operation Id: VirtualMachineScaleSetVMExtensions_List
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineScaleSetVirtualMachineExtensionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineScaleSetVirtualMachineExtensionResource> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<VirtualMachineScaleSetVirtualMachineExtensionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetVirtualMachineExtensionResource(Client, value)), null, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}
        /// Operation Id: VirtualMachineScaleSetVMExtensions_Get
        /// </summary>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmExtensionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vmExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));

            using var scope = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(vmExtensionName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}
        /// Operation Id: VirtualMachineScaleSetVMExtensions_Get
        /// </summary>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmExtensionName"/> is null. </exception>
        public virtual Response<bool> Exists(string vmExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));

            using var scope = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(vmExtensionName, expand: expand, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}
        /// Operation Id: VirtualMachineScaleSetVMExtensions_Get
        /// </summary>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmExtensionName"/> is null. </exception>
        public virtual async Task<Response<VirtualMachineScaleSetVirtualMachineExtensionResource>> GetIfExistsAsync(string vmExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));

            using var scope = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineExtensionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vmExtensionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachineScaleSetVirtualMachineExtensionResource>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVirtualMachineExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}
        /// Operation Id: VirtualMachineScaleSetVMExtensions_Get
        /// </summary>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmExtensionName"/> is null. </exception>
        public virtual Response<VirtualMachineScaleSetVirtualMachineExtensionResource> GetIfExists(string vmExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));

            using var scope = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineExtensionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVMExtensionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vmExtensionName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachineScaleSetVirtualMachineExtensionResource>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVirtualMachineExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualMachineScaleSetVirtualMachineExtensionResource> IEnumerable<VirtualMachineScaleSetVirtualMachineExtensionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualMachineScaleSetVirtualMachineExtensionResource> IAsyncEnumerable<VirtualMachineScaleSetVirtualMachineExtensionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
