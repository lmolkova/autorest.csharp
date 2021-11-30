// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using MgmtScopeResource.Models;

namespace MgmtScopeResource
{
    /// <summary> A class to add extension methods to Tenant. </summary>
    public static partial class TenantExtensions
    {
        #region PolicyAssignment
        /// <summary> Gets an object representing a PolicyAssignmentCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="PolicyAssignmentCollection" /> object. </returns>
        public static PolicyAssignmentCollection GetPolicyAssignments(this Tenant tenant)
        {
            return new PolicyAssignmentCollection(tenant);
        }
        #endregion

        #region DeploymentExtended
        /// <summary> Gets an object representing a DeploymentExtendedCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="DeploymentExtendedCollection" /> object. </returns>
        public static DeploymentExtendedCollection GetDeploymentExtendeds(this Tenant tenant)
        {
            return new DeploymentExtendedCollection(tenant);
        }
        #endregion

        #region ResourceLink
        /// <summary> Gets an object representing a ResourceLinkCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="ResourceLinkCollection" /> object. </returns>
        public static ResourceLinkCollection GetResourceLinks(this Tenant tenant)
        {
            return new ResourceLinkCollection(tenant);
        }
        #endregion

        private static DeploymentsRestOperations GetDeploymentsRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, Uri endpoint = null)
        {
            return new DeploymentsRestOperations(clientDiagnostics, pipeline, clientOptions, endpoint);
        }

        /// RequestPath: /providers/Microsoft.Resources/calculateTemplateHash
        /// ContextualPath: /
        /// OperationId: Deployments_CalculateTemplateHash
        /// <summary> Calculate the hash of the given template. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <param name="template"> The template provided to calculate hash. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="template"/> is null. </exception>
        public static async Task<Response<TemplateHashResult>> CalculateTemplateHashDeploymentAsync(this Tenant tenant, object template, CancellationToken cancellationToken = default)
        {
            if (template == null)
            {
                throw new ArgumentNullException(nameof(template));
            }

            return await tenant.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("TenantExtensions.CalculateTemplateHashDeployment");
                scope.Start();
                try
                {
                    var restOperations = GetDeploymentsRestOperations(clientDiagnostics, credential, options, pipeline, baseUri);
                    var response = await restOperations.CalculateTemplateHashAsync(template, cancellationToken).ConfigureAwait(false);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            ).ConfigureAwait(false);
        }

        /// RequestPath: /providers/Microsoft.Resources/calculateTemplateHash
        /// ContextualPath: /
        /// OperationId: Deployments_CalculateTemplateHash
        /// <summary> Calculate the hash of the given template. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <param name="template"> The template provided to calculate hash. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="template"/> is null. </exception>
        public static Response<TemplateHashResult> CalculateTemplateHashDeployment(this Tenant tenant, object template, CancellationToken cancellationToken = default)
        {
            if (template == null)
            {
                throw new ArgumentNullException(nameof(template));
            }

            return tenant.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("TenantExtensions.CalculateTemplateHashDeployment");
                scope.Start();
                try
                {
                    var restOperations = GetDeploymentsRestOperations(clientDiagnostics, credential, options, pipeline, baseUri);
                    var response = restOperations.CalculateTemplateHash(template, cancellationToken);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }
    }
}
