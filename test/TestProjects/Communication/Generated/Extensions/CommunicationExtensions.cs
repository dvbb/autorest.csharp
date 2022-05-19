// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Communication.Models;

namespace Communication
{
    /// <summary> A class to add extension methods to Communication. </summary>
    public static partial class CommunicationExtensions
    {
        private static TenantResourceExtensionClient GetExtensionClient(TenantResource tenantResource)
        {
            return tenantResource.GetCachedClient((client) =>
            {
                return new TenantResourceExtensionClient(client, tenantResource.Id);
            }
            );
        }

        /// <summary>
        /// Gets the current status of an async operation.
        /// Request Path: /providers/Microsoft.Communication/locations/{location}/operationStatuses/{operationId}
        /// Operation Id: OperationStatuses_Get
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="location"> The Azure region. </param>
        /// <param name="operationId"> The ID of an ongoing async operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="operationId"/> is null. </exception>
        public static async Task<Response<OperationStatus>> GetOperationStatusAsync(this TenantResource tenantResource, string location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return await GetExtensionClient(tenantResource).GetOperationStatusAsync(location, operationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the current status of an async operation.
        /// Request Path: /providers/Microsoft.Communication/locations/{location}/operationStatuses/{operationId}
        /// Operation Id: OperationStatuses_Get
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="location"> The Azure region. </param>
        /// <param name="operationId"> The ID of an ongoing async operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="operationId"/> is null. </exception>
        public static Response<OperationStatus> GetOperationStatus(this TenantResource tenantResource, string location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return GetExtensionClient(tenantResource).GetOperationStatus(location, operationId, cancellationToken);
        }

        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Checks that the CommunicationService name is valid and is not already in use.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Communication/checkNameAvailability
        /// Operation Id: CommunicationService_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response<NameAvailability>> CheckNameAvailabilityCommunicationServiceAsync(this SubscriptionResource subscriptionResource, NameAvailabilityContent content = null, CancellationToken cancellationToken = default)
        {
            return await GetExtensionClient(subscriptionResource).CheckNameAvailabilityCommunicationServiceAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks that the CommunicationService name is valid and is not already in use.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Communication/checkNameAvailability
        /// Operation Id: CommunicationService_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response<NameAvailability> CheckNameAvailabilityCommunicationService(this SubscriptionResource subscriptionResource, NameAvailabilityContent content = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).CheckNameAvailabilityCommunicationService(content, cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Communication/communicationServices
        /// Operation Id: CommunicationService_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CommunicationServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<CommunicationServiceResource> GetCommunicationServiceResourcesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetCommunicationServiceResourcesAsync(cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Communication/communicationServices
        /// Operation Id: CommunicationService_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CommunicationServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<CommunicationServiceResource> GetCommunicationServiceResources(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetCommunicationServiceResources(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of CommunicationServiceResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of CommunicationServiceResources and their operations over a CommunicationServiceResource. </returns>
        public static CommunicationServiceResourceCollection GetCommunicationServiceResources(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetCommunicationServiceResources();
        }

        /// <summary>
        /// Get the CommunicationService and its properties.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/communicationServices/{communicationServiceName}
        /// Operation Id: CommunicationService_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationServiceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<CommunicationServiceResource>> GetCommunicationServiceResourceAsync(this ResourceGroupResource resourceGroupResource, string communicationServiceName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetCommunicationServiceResources().GetAsync(communicationServiceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the CommunicationService and its properties.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/communicationServices/{communicationServiceName}
        /// Operation Id: CommunicationService_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationServiceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<CommunicationServiceResource> GetCommunicationServiceResource(this ResourceGroupResource resourceGroupResource, string communicationServiceName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetCommunicationServiceResources().Get(communicationServiceName, cancellationToken);
        }

        #region CommunicationServiceResource
        /// <summary>
        /// Gets an object representing a <see cref="CommunicationServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CommunicationServiceResource.CreateResourceIdentifier" /> to create a <see cref="CommunicationServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CommunicationServiceResource" /> object. </returns>
        public static CommunicationServiceResource GetCommunicationServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                CommunicationServiceResource.ValidateResourceId(id);
                return new CommunicationServiceResource(client, id);
            }
            );
        }
        #endregion
    }
}
