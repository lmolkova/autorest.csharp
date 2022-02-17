// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using MgmtParamOrdering.Models;

namespace MgmtParamOrdering
{
    /// <summary> A Class representing a VirtualMachineScaleSet along with the instance operations that can be performed on it. </summary>
    public partial class VirtualMachineScaleSet : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="VirtualMachineScaleSet"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vmScaleSetName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _virtualMachineScaleSetClientDiagnostics;
        private readonly VirtualMachineScaleSetsRestOperations _virtualMachineScaleSetRestClient;
        private readonly VirtualMachineScaleSetData _data;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSet"/> class for mocking. </summary>
        protected VirtualMachineScaleSet()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "VirtualMachineScaleSet"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal VirtualMachineScaleSet(ArmClient client, VirtualMachineScaleSetData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSet"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VirtualMachineScaleSet(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualMachineScaleSetClientDiagnostics = new ClientDiagnostics("MgmtParamOrdering", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string virtualMachineScaleSetApiVersion);
            _virtualMachineScaleSetRestClient = new VirtualMachineScaleSetsRestOperations(_virtualMachineScaleSetClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, virtualMachineScaleSetApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/virtualMachineScaleSets";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VirtualMachineScaleSetData Data
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
        /// Display information about a virtual machine scale set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// Operation Id: VirtualMachineScaleSets_Get
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;UserData&apos; retrieves the UserData property of the VM scale set that was provided by the user during the VM scale set Create/Update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<VirtualMachineScaleSet>> GetAsync(ExpandTypesForGetVMScaleSets? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSet.Get");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _virtualMachineScaleSetClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualMachineScaleSet(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Display information about a virtual machine scale set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// Operation Id: VirtualMachineScaleSets_Get
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;UserData&apos; retrieves the UserData property of the VM scale set that was provided by the user during the VM scale set Create/Update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualMachineScaleSet> Get(ExpandTypesForGetVMScaleSets? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSet.Get");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw _virtualMachineScaleSetClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSet(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a VM scale set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// Operation Id: VirtualMachineScaleSets_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="forceDeletion"> Optional parameter to force delete a VM scale set. (Feature in Preview). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, bool forceDeletion, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSet.Delete");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, forceDeletion, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtParamOrderingArmOperation(_virtualMachineScaleSetClientDiagnostics, Pipeline, _virtualMachineScaleSetRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, forceDeletion).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
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
        /// Deletes a VM scale set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// Operation Id: VirtualMachineScaleSets_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="forceDeletion"> Optional parameter to force delete a VM scale set. (Feature in Preview). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, bool forceDeletion, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSet.Delete");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, forceDeletion, cancellationToken);
                var operation = new MgmtParamOrderingArmOperation(_virtualMachineScaleSetClientDiagnostics, Pipeline, _virtualMachineScaleSetRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, forceDeletion).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// optional body, no query; Update a VM scale set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// Operation Id: VirtualMachineScaleSets_Update
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="options"> The scale set object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation<VirtualMachineScaleSet>> UpdateAsync(bool waitForCompletion, VirtualMachineScaleSetUpdateOptions options = null, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSet.Update");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtParamOrderingArmOperation<VirtualMachineScaleSet>(new VirtualMachineScaleSetOperationSource(Client), _virtualMachineScaleSetClientDiagnostics, Pipeline, _virtualMachineScaleSetRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
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
        /// optional body, no query; Update a VM scale set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// Operation Id: VirtualMachineScaleSets_Update
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="options"> The scale set object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<VirtualMachineScaleSet> Update(bool waitForCompletion, VirtualMachineScaleSetUpdateOptions options = null, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSet.Update");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options, cancellationToken);
                var operation = new MgmtParamOrderingArmOperation<VirtualMachineScaleSet>(new VirtualMachineScaleSetOperationSource(Client), _virtualMachineScaleSetClientDiagnostics, Pipeline, _virtualMachineScaleSetRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
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
        /// optional body, optional query; Deallocates specific virtual machines in a VM scale set. Shuts down the virtual machines and releases the compute resources. You are not billed for the compute resources that this virtual machine scale set deallocates.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/deallocate
        /// Operation Id: VirtualMachineScaleSets_Deallocate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="vmInstanceIDs"> A list of virtual machine instance IDs from the VM scale set. </param>
        /// <param name="expand"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeallocateAsync(bool waitForCompletion, VirtualMachineScaleSetVMInstanceIDs vmInstanceIDs = null, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSet.Deallocate");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetRestClient.DeallocateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmInstanceIDs, expand, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtParamOrderingArmOperation(_virtualMachineScaleSetClientDiagnostics, Pipeline, _virtualMachineScaleSetRestClient.CreateDeallocateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmInstanceIDs, expand).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
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
        /// optional body, optional query; Deallocates specific virtual machines in a VM scale set. Shuts down the virtual machines and releases the compute resources. You are not billed for the compute resources that this virtual machine scale set deallocates.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/deallocate
        /// Operation Id: VirtualMachineScaleSets_Deallocate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="vmInstanceIDs"> A list of virtual machine instance IDs from the VM scale set. </param>
        /// <param name="expand"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Deallocate(bool waitForCompletion, VirtualMachineScaleSetVMInstanceIDs vmInstanceIDs = null, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSet.Deallocate");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetRestClient.Deallocate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmInstanceIDs, expand, cancellationToken);
                var operation = new MgmtParamOrderingArmOperation(_virtualMachineScaleSetClientDiagnostics, Pipeline, _virtualMachineScaleSetRestClient.CreateDeallocateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmInstanceIDs, expand).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// required body, optional query; Deletes virtual machines in a VM scale set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/delete
        /// Operation Id: VirtualMachineScaleSets_DeleteInstances
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="vmInstanceIDs"> A list of virtual machine instance IDs from the VM scale set. </param>
        /// <param name="forceDeletion"> Optional parameter to force delete virtual machines from the VM scale set. (Feature in Preview). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmInstanceIDs"/> is null. </exception>
        public async virtual Task<ArmOperation> DeleteInstancesAsync(bool waitForCompletion, VirtualMachineScaleSetVMInstanceRequiredIDs vmInstanceIDs, bool? forceDeletion = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(vmInstanceIDs, nameof(vmInstanceIDs));

            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSet.DeleteInstances");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetRestClient.DeleteInstancesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmInstanceIDs, forceDeletion, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtParamOrderingArmOperation(_virtualMachineScaleSetClientDiagnostics, Pipeline, _virtualMachineScaleSetRestClient.CreateDeleteInstancesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmInstanceIDs, forceDeletion).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
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
        /// required body, optional query; Deletes virtual machines in a VM scale set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/delete
        /// Operation Id: VirtualMachineScaleSets_DeleteInstances
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="vmInstanceIDs"> A list of virtual machine instance IDs from the VM scale set. </param>
        /// <param name="forceDeletion"> Optional parameter to force delete virtual machines from the VM scale set. (Feature in Preview). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmInstanceIDs"/> is null. </exception>
        public virtual ArmOperation DeleteInstances(bool waitForCompletion, VirtualMachineScaleSetVMInstanceRequiredIDs vmInstanceIDs, bool? forceDeletion = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(vmInstanceIDs, nameof(vmInstanceIDs));

            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSet.DeleteInstances");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetRestClient.DeleteInstances(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmInstanceIDs, forceDeletion, cancellationToken);
                var operation = new MgmtParamOrderingArmOperation(_virtualMachineScaleSetClientDiagnostics, Pipeline, _virtualMachineScaleSetRestClient.CreateDeleteInstancesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmInstanceIDs, forceDeletion).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// No body, mixed parameters; Gets the status of a VM scale set instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/instanceView
        /// Operation Id: VirtualMachineScaleSets_GetInstanceView
        /// </summary>
        /// <param name="filter"> The String to use. </param>
        /// <param name="expand"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filter"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineScaleSetInstanceView>> GetInstanceViewAsync(string filter, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(filter, nameof(filter));

            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSet.GetInstanceView");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetRestClient.GetInstanceViewAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, expand, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// No body, mixed parameters; Gets the status of a VM scale set instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/instanceView
        /// Operation Id: VirtualMachineScaleSets_GetInstanceView
        /// </summary>
        /// <param name="filter"> The String to use. </param>
        /// <param name="expand"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filter"/> is null. </exception>
        public virtual Response<VirtualMachineScaleSetInstanceView> GetInstanceView(string filter, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(filter, nameof(filter));

            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSet.GetInstanceView");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetRestClient.GetInstanceView(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, expand, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// Operation Id: VirtualMachineScaleSets_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineScaleSet>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSet.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _virtualMachineScaleSetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new VirtualMachineScaleSet(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// Operation Id: VirtualMachineScaleSets_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<VirtualMachineScaleSet> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSet.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _virtualMachineScaleSetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new VirtualMachineScaleSet(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// Operation Id: VirtualMachineScaleSets_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineScaleSet>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSet.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(true, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _virtualMachineScaleSetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new VirtualMachineScaleSet(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// Operation Id: VirtualMachineScaleSets_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<VirtualMachineScaleSet> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSet.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(true, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _virtualMachineScaleSetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new VirtualMachineScaleSet(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// Operation Id: VirtualMachineScaleSets_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineScaleSet>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSet.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _virtualMachineScaleSetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new VirtualMachineScaleSet(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// Operation Id: VirtualMachineScaleSets_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<VirtualMachineScaleSet> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _virtualMachineScaleSetClientDiagnostics.CreateScope("VirtualMachineScaleSet.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _virtualMachineScaleSetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new VirtualMachineScaleSet(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
