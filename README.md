# Fermyon.Nomad - the C# library for the Nomad

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.1.4
- SDK version: 0.1.1
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.11.7 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Fermyon.Nomad.Api;
using Fermyon.Nomad.Client;
using Fermyon.Nomad.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Fermyon.Nomad.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fermyon.Nomad.Api;
using Fermyon.Nomad.Client;
using Fermyon.Nomad.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://127.0.0.1:4646/v1";
            // Configure API key authorization: X-Nomad-Token
            config.ApiKey.Add("X-Nomad-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("X-Nomad-Token", "Bearer");

            var apiInstance = new ACLApi(config);
            var policyName = policyName_example;  // string | The ACL policy name.
            var region = region_example;  // string | Filters results based on the specified region. (optional) 
            var _namespace = _namespace_example;  // string | Filters results based on the specified namespace. (optional) 
            var xNomadToken = xNomadToken_example;  // string | A Nomad ACL token. (optional) 
            var idempotencyToken = idempotencyToken_example;  // string | Can be used to ensure operations are only run once. (optional) 

            try
            {
                apiInstance.DeleteACLPolicy(policyName, region, _namespace, xNomadToken, idempotencyToken);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ACLApi.DeleteACLPolicy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://127.0.0.1:4646/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ACLApi* | [**DeleteACLPolicy**](docs/ACLApi.md#deleteaclpolicy) | **DELETE** /acl/policy/{policyName} | 
*ACLApi* | [**DeleteACLToken**](docs/ACLApi.md#deleteacltoken) | **DELETE** /acl/token/{tokenAccessor} | 
*ACLApi* | [**GetACLPolicies**](docs/ACLApi.md#getaclpolicies) | **GET** /acl/policies | 
*ACLApi* | [**GetACLPolicy**](docs/ACLApi.md#getaclpolicy) | **GET** /acl/policy/{policyName} | 
*ACLApi* | [**GetACLToken**](docs/ACLApi.md#getacltoken) | **GET** /acl/token/{tokenAccessor} | 
*ACLApi* | [**GetACLTokenSelf**](docs/ACLApi.md#getacltokenself) | **GET** /acl/token | 
*ACLApi* | [**GetACLTokens**](docs/ACLApi.md#getacltokens) | **GET** /acl/tokens | 
*ACLApi* | [**PostACLBootstrap**](docs/ACLApi.md#postaclbootstrap) | **POST** /acl/bootstrap | 
*ACLApi* | [**PostACLPolicy**](docs/ACLApi.md#postaclpolicy) | **POST** /acl/policy/{policyName} | 
*ACLApi* | [**PostACLToken**](docs/ACLApi.md#postacltoken) | **POST** /acl/token/{tokenAccessor} | 
*ACLApi* | [**PostACLTokenOnetime**](docs/ACLApi.md#postacltokenonetime) | **POST** /acl/token/onetime | 
*ACLApi* | [**PostACLTokenOnetimeExchange**](docs/ACLApi.md#postacltokenonetimeexchange) | **POST** /acl/token/onetime/exchange | 
*AllocationsApi* | [**GetAllocation**](docs/AllocationsApi.md#getallocation) | **GET** /allocation/{allocID} | 
*AllocationsApi* | [**GetAllocationServices**](docs/AllocationsApi.md#getallocationservices) | **GET** /allocation/{allocID}/services | 
*AllocationsApi* | [**GetAllocations**](docs/AllocationsApi.md#getallocations) | **GET** /allocations | 
*AllocationsApi* | [**PostAllocationStop**](docs/AllocationsApi.md#postallocationstop) | **POST** /allocation/{allocID}/stop | 
*ClientsApi* | [**GetAllocationLogs**](docs/ClientsApi.md#getallocationlogs) | **GET** /client/fs/logs/{allocID} | 
*DeploymentsApi* | [**GetDeployment**](docs/DeploymentsApi.md#getdeployment) | **GET** /deployment/{deploymentID} | 
*DeploymentsApi* | [**GetDeploymentAllocations**](docs/DeploymentsApi.md#getdeploymentallocations) | **GET** /deployment/allocations/{deploymentID} | 
*DeploymentsApi* | [**GetDeployments**](docs/DeploymentsApi.md#getdeployments) | **GET** /deployments | 
*DeploymentsApi* | [**PostDeploymentAllocationHealth**](docs/DeploymentsApi.md#postdeploymentallocationhealth) | **POST** /deployment/allocation-health/{deploymentID} | 
*DeploymentsApi* | [**PostDeploymentFail**](docs/DeploymentsApi.md#postdeploymentfail) | **POST** /deployment/fail/{deploymentID} | 
*DeploymentsApi* | [**PostDeploymentPause**](docs/DeploymentsApi.md#postdeploymentpause) | **POST** /deployment/pause/{deploymentID} | 
*DeploymentsApi* | [**PostDeploymentPromote**](docs/DeploymentsApi.md#postdeploymentpromote) | **POST** /deployment/promote/{deploymentID} | 
*DeploymentsApi* | [**PostDeploymentUnblock**](docs/DeploymentsApi.md#postdeploymentunblock) | **POST** /deployment/unblock/{deploymentID} | 
*EnterpriseApi* | [**CreateQuotaSpec**](docs/EnterpriseApi.md#createquotaspec) | **POST** /quota | 
*EnterpriseApi* | [**DeleteQuotaSpec**](docs/EnterpriseApi.md#deletequotaspec) | **DELETE** /quota/{specName} | 
*EnterpriseApi* | [**GetQuotaSpec**](docs/EnterpriseApi.md#getquotaspec) | **GET** /quota/{specName} | 
*EnterpriseApi* | [**GetQuotas**](docs/EnterpriseApi.md#getquotas) | **GET** /quotas | 
*EnterpriseApi* | [**PostQuotaSpec**](docs/EnterpriseApi.md#postquotaspec) | **POST** /quota/{specName} | 
*EvaluationsApi* | [**GetEvaluation**](docs/EvaluationsApi.md#getevaluation) | **GET** /evaluation/{evalID} | 
*EvaluationsApi* | [**GetEvaluationAllocations**](docs/EvaluationsApi.md#getevaluationallocations) | **GET** /evaluation/{evalID}/allocations | 
*EvaluationsApi* | [**GetEvaluations**](docs/EvaluationsApi.md#getevaluations) | **GET** /evaluations | 
*JobsApi* | [**DeleteJob**](docs/JobsApi.md#deletejob) | **DELETE** /job/{jobName} | 
*JobsApi* | [**GetJob**](docs/JobsApi.md#getjob) | **GET** /job/{jobName} | 
*JobsApi* | [**GetJobAllocations**](docs/JobsApi.md#getjoballocations) | **GET** /job/{jobName}/allocations | 
*JobsApi* | [**GetJobDeployment**](docs/JobsApi.md#getjobdeployment) | **GET** /job/{jobName}/deployment | 
*JobsApi* | [**GetJobDeployments**](docs/JobsApi.md#getjobdeployments) | **GET** /job/{jobName}/deployments | 
*JobsApi* | [**GetJobEvaluations**](docs/JobsApi.md#getjobevaluations) | **GET** /job/{jobName}/evaluations | 
*JobsApi* | [**GetJobScaleStatus**](docs/JobsApi.md#getjobscalestatus) | **GET** /job/{jobName}/scale | 
*JobsApi* | [**GetJobSummary**](docs/JobsApi.md#getjobsummary) | **GET** /job/{jobName}/summary | 
*JobsApi* | [**GetJobVersions**](docs/JobsApi.md#getjobversions) | **GET** /job/{jobName}/versions | 
*JobsApi* | [**GetJobs**](docs/JobsApi.md#getjobs) | **GET** /jobs | 
*JobsApi* | [**PostJob**](docs/JobsApi.md#postjob) | **POST** /job/{jobName} | 
*JobsApi* | [**PostJobDispatch**](docs/JobsApi.md#postjobdispatch) | **POST** /job/{jobName}/dispatch | 
*JobsApi* | [**PostJobEvaluate**](docs/JobsApi.md#postjobevaluate) | **POST** /job/{jobName}/evaluate | 
*JobsApi* | [**PostJobParse**](docs/JobsApi.md#postjobparse) | **POST** /jobs/parse | 
*JobsApi* | [**PostJobPeriodicForce**](docs/JobsApi.md#postjobperiodicforce) | **POST** /job/{jobName}/periodic/force | 
*JobsApi* | [**PostJobPlan**](docs/JobsApi.md#postjobplan) | **POST** /job/{jobName}/plan | 
*JobsApi* | [**PostJobRevert**](docs/JobsApi.md#postjobrevert) | **POST** /job/{jobName}/revert | 
*JobsApi* | [**PostJobScalingRequest**](docs/JobsApi.md#postjobscalingrequest) | **POST** /job/{jobName}/scale | 
*JobsApi* | [**PostJobStability**](docs/JobsApi.md#postjobstability) | **POST** /job/{jobName}/stable | 
*JobsApi* | [**PostJobValidateRequest**](docs/JobsApi.md#postjobvalidaterequest) | **POST** /validate/job | 
*JobsApi* | [**RegisterJob**](docs/JobsApi.md#registerjob) | **POST** /jobs | 
*MetricsApi* | [**GetMetricsSummary**](docs/MetricsApi.md#getmetricssummary) | **GET** /metrics | 
*NamespacesApi* | [**CreateNamespace**](docs/NamespacesApi.md#createnamespace) | **POST** /namespace | 
*NamespacesApi* | [**DeleteNamespace**](docs/NamespacesApi.md#deletenamespace) | **DELETE** /namespace/{namespaceName} | 
*NamespacesApi* | [**GetNamespace**](docs/NamespacesApi.md#getnamespace) | **GET** /namespace/{namespaceName} | 
*NamespacesApi* | [**GetNamespaces**](docs/NamespacesApi.md#getnamespaces) | **GET** /namespaces | 
*NamespacesApi* | [**PostNamespace**](docs/NamespacesApi.md#postnamespace) | **POST** /namespace/{namespaceName} | 
*NodesApi* | [**GetNode**](docs/NodesApi.md#getnode) | **GET** /node/{nodeId} | 
*NodesApi* | [**GetNodeAllocations**](docs/NodesApi.md#getnodeallocations) | **GET** /node/{nodeId}/allocations | 
*NodesApi* | [**GetNodes**](docs/NodesApi.md#getnodes) | **GET** /nodes | 
*NodesApi* | [**UpdateNodeDrain**](docs/NodesApi.md#updatenodedrain) | **POST** /node/{nodeId}/drain | 
*NodesApi* | [**UpdateNodeEligibility**](docs/NodesApi.md#updatenodeeligibility) | **POST** /node/{nodeId}/eligibility | 
*NodesApi* | [**UpdateNodePurge**](docs/NodesApi.md#updatenodepurge) | **POST** /node/{nodeId}/purge | 
*OperatorApi* | [**DeleteOperatorRaftPeer**](docs/OperatorApi.md#deleteoperatorraftpeer) | **DELETE** /operator/raft/peer | 
*OperatorApi* | [**GetOperatorAutopilotConfiguration**](docs/OperatorApi.md#getoperatorautopilotconfiguration) | **GET** /operator/autopilot/configuration | 
*OperatorApi* | [**GetOperatorAutopilotHealth**](docs/OperatorApi.md#getoperatorautopilothealth) | **GET** /operator/autopilot/health | 
*OperatorApi* | [**GetOperatorRaftConfiguration**](docs/OperatorApi.md#getoperatorraftconfiguration) | **GET** /operator/raft/configuration | 
*OperatorApi* | [**GetOperatorSchedulerConfiguration**](docs/OperatorApi.md#getoperatorschedulerconfiguration) | **GET** /operator/scheduler/configuration | 
*OperatorApi* | [**PostOperatorSchedulerConfiguration**](docs/OperatorApi.md#postoperatorschedulerconfiguration) | **POST** /operator/scheduler/configuration | 
*OperatorApi* | [**PutOperatorAutopilotConfiguration**](docs/OperatorApi.md#putoperatorautopilotconfiguration) | **PUT** /operator/autopilot/configuration | 
*PluginsApi* | [**GetPluginCSI**](docs/PluginsApi.md#getplugincsi) | **GET** /plugin/csi/{pluginID} | 
*PluginsApi* | [**GetPlugins**](docs/PluginsApi.md#getplugins) | **GET** /plugins | 
*RegionsApi* | [**GetRegions**](docs/RegionsApi.md#getregions) | **GET** /regions | 
*ScalingApi* | [**GetScalingPolicies**](docs/ScalingApi.md#getscalingpolicies) | **GET** /scaling/policies | 
*ScalingApi* | [**GetScalingPolicy**](docs/ScalingApi.md#getscalingpolicy) | **GET** /scaling/policy/{policyID} | 
*SearchApi* | [**GetFuzzySearch**](docs/SearchApi.md#getfuzzysearch) | **POST** /search/fuzzy | 
*SearchApi* | [**GetSearch**](docs/SearchApi.md#getsearch) | **POST** /search | 
*StatusApi* | [**GetStatusLeader**](docs/StatusApi.md#getstatusleader) | **GET** /status/leader | 
*StatusApi* | [**GetStatusPeers**](docs/StatusApi.md#getstatuspeers) | **GET** /status/peers | 
*SystemApi* | [**PutSystemGC**](docs/SystemApi.md#putsystemgc) | **PUT** /system/gc | 
*SystemApi* | [**PutSystemReconcileSummaries**](docs/SystemApi.md#putsystemreconcilesummaries) | **PUT** /system/reconcile/summaries | 
*VolumesApi* | [**CreateVolume**](docs/VolumesApi.md#createvolume) | **POST** /volume/csi/{volumeId}/{action} | 
*VolumesApi* | [**DeleteSnapshot**](docs/VolumesApi.md#deletesnapshot) | **DELETE** /volumes/snapshot | 
*VolumesApi* | [**DeleteVolumeRegistration**](docs/VolumesApi.md#deletevolumeregistration) | **DELETE** /volume/csi/{volumeId} | 
*VolumesApi* | [**DetachOrDeleteVolume**](docs/VolumesApi.md#detachordeletevolume) | **DELETE** /volume/csi/{volumeId}/{action} | 
*VolumesApi* | [**GetExternalVolumes**](docs/VolumesApi.md#getexternalvolumes) | **GET** /volumes/external | 
*VolumesApi* | [**GetSnapshots**](docs/VolumesApi.md#getsnapshots) | **GET** /volumes/snapshot | 
*VolumesApi* | [**GetVolume**](docs/VolumesApi.md#getvolume) | **GET** /volume/csi/{volumeId} | 
*VolumesApi* | [**GetVolumes**](docs/VolumesApi.md#getvolumes) | **GET** /volumes | 
*VolumesApi* | [**PostSnapshot**](docs/VolumesApi.md#postsnapshot) | **POST** /volumes/snapshot | 
*VolumesApi* | [**PostVolume**](docs/VolumesApi.md#postvolume) | **POST** /volumes | 
*VolumesApi* | [**PostVolumeRegistration**](docs/VolumesApi.md#postvolumeregistration) | **POST** /volume/csi/{volumeId} | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ACLPolicy](docs/ACLPolicy.md)
 - [Model.ACLPolicyListStub](docs/ACLPolicyListStub.md)
 - [Model.ACLToken](docs/ACLToken.md)
 - [Model.ACLTokenListStub](docs/ACLTokenListStub.md)
 - [Model.Affinity](docs/Affinity.md)
 - [Model.AllocDeploymentStatus](docs/AllocDeploymentStatus.md)
 - [Model.AllocStopResponse](docs/AllocStopResponse.md)
 - [Model.AllocatedCpuResources](docs/AllocatedCpuResources.md)
 - [Model.AllocatedDeviceResource](docs/AllocatedDeviceResource.md)
 - [Model.AllocatedMemoryResources](docs/AllocatedMemoryResources.md)
 - [Model.AllocatedResources](docs/AllocatedResources.md)
 - [Model.AllocatedSharedResources](docs/AllocatedSharedResources.md)
 - [Model.AllocatedTaskResources](docs/AllocatedTaskResources.md)
 - [Model.Allocation](docs/Allocation.md)
 - [Model.AllocationListStub](docs/AllocationListStub.md)
 - [Model.AllocationLogs](docs/AllocationLogs.md)
 - [Model.AllocationMetric](docs/AllocationMetric.md)
 - [Model.Attribute](docs/Attribute.md)
 - [Model.AutopilotConfiguration](docs/AutopilotConfiguration.md)
 - [Model.CSIControllerInfo](docs/CSIControllerInfo.md)
 - [Model.CSIInfo](docs/CSIInfo.md)
 - [Model.CSIMountOptions](docs/CSIMountOptions.md)
 - [Model.CSINodeInfo](docs/CSINodeInfo.md)
 - [Model.CSIPlugin](docs/CSIPlugin.md)
 - [Model.CSIPluginListStub](docs/CSIPluginListStub.md)
 - [Model.CSISnapshot](docs/CSISnapshot.md)
 - [Model.CSISnapshotCreateRequest](docs/CSISnapshotCreateRequest.md)
 - [Model.CSISnapshotCreateResponse](docs/CSISnapshotCreateResponse.md)
 - [Model.CSISnapshotListResponse](docs/CSISnapshotListResponse.md)
 - [Model.CSITopology](docs/CSITopology.md)
 - [Model.CSITopologyRequest](docs/CSITopologyRequest.md)
 - [Model.CSIVolume](docs/CSIVolume.md)
 - [Model.CSIVolumeCapability](docs/CSIVolumeCapability.md)
 - [Model.CSIVolumeCreateRequest](docs/CSIVolumeCreateRequest.md)
 - [Model.CSIVolumeExternalStub](docs/CSIVolumeExternalStub.md)
 - [Model.CSIVolumeListExternalResponse](docs/CSIVolumeListExternalResponse.md)
 - [Model.CSIVolumeListStub](docs/CSIVolumeListStub.md)
 - [Model.CSIVolumeRegisterRequest](docs/CSIVolumeRegisterRequest.md)
 - [Model.CheckRestart](docs/CheckRestart.md)
 - [Model.Constraint](docs/Constraint.md)
 - [Model.Consul](docs/Consul.md)
 - [Model.ConsulConnect](docs/ConsulConnect.md)
 - [Model.ConsulExposeConfig](docs/ConsulExposeConfig.md)
 - [Model.ConsulExposePath](docs/ConsulExposePath.md)
 - [Model.ConsulGateway](docs/ConsulGateway.md)
 - [Model.ConsulGatewayBindAddress](docs/ConsulGatewayBindAddress.md)
 - [Model.ConsulGatewayProxy](docs/ConsulGatewayProxy.md)
 - [Model.ConsulGatewayTLSConfig](docs/ConsulGatewayTLSConfig.md)
 - [Model.ConsulIngressConfigEntry](docs/ConsulIngressConfigEntry.md)
 - [Model.ConsulIngressListener](docs/ConsulIngressListener.md)
 - [Model.ConsulIngressService](docs/ConsulIngressService.md)
 - [Model.ConsulLinkedService](docs/ConsulLinkedService.md)
 - [Model.ConsulMeshGateway](docs/ConsulMeshGateway.md)
 - [Model.ConsulProxy](docs/ConsulProxy.md)
 - [Model.ConsulSidecarService](docs/ConsulSidecarService.md)
 - [Model.ConsulTerminatingConfigEntry](docs/ConsulTerminatingConfigEntry.md)
 - [Model.ConsulUpstream](docs/ConsulUpstream.md)
 - [Model.DNSConfig](docs/DNSConfig.md)
 - [Model.Deployment](docs/Deployment.md)
 - [Model.DeploymentAllocHealthRequest](docs/DeploymentAllocHealthRequest.md)
 - [Model.DeploymentPauseRequest](docs/DeploymentPauseRequest.md)
 - [Model.DeploymentPromoteRequest](docs/DeploymentPromoteRequest.md)
 - [Model.DeploymentState](docs/DeploymentState.md)
 - [Model.DeploymentUnblockRequest](docs/DeploymentUnblockRequest.md)
 - [Model.DeploymentUpdateResponse](docs/DeploymentUpdateResponse.md)
 - [Model.DesiredTransition](docs/DesiredTransition.md)
 - [Model.DesiredUpdates](docs/DesiredUpdates.md)
 - [Model.DispatchPayloadConfig](docs/DispatchPayloadConfig.md)
 - [Model.DrainMetadata](docs/DrainMetadata.md)
 - [Model.DrainSpec](docs/DrainSpec.md)
 - [Model.DrainStrategy](docs/DrainStrategy.md)
 - [Model.DriverInfo](docs/DriverInfo.md)
 - [Model.EphemeralDisk](docs/EphemeralDisk.md)
 - [Model.EvalOptions](docs/EvalOptions.md)
 - [Model.Evaluation](docs/Evaluation.md)
 - [Model.EvaluationStub](docs/EvaluationStub.md)
 - [Model.FieldDiff](docs/FieldDiff.md)
 - [Model.FuzzyMatch](docs/FuzzyMatch.md)
 - [Model.FuzzySearchRequest](docs/FuzzySearchRequest.md)
 - [Model.FuzzySearchResponse](docs/FuzzySearchResponse.md)
 - [Model.GaugeValue](docs/GaugeValue.md)
 - [Model.HostNetworkInfo](docs/HostNetworkInfo.md)
 - [Model.HostVolumeInfo](docs/HostVolumeInfo.md)
 - [Model.Job](docs/Job.md)
 - [Model.JobChildrenSummary](docs/JobChildrenSummary.md)
 - [Model.JobDeregisterResponse](docs/JobDeregisterResponse.md)
 - [Model.JobDiff](docs/JobDiff.md)
 - [Model.JobDispatchRequest](docs/JobDispatchRequest.md)
 - [Model.JobDispatchResponse](docs/JobDispatchResponse.md)
 - [Model.JobEvaluateRequest](docs/JobEvaluateRequest.md)
 - [Model.JobListStub](docs/JobListStub.md)
 - [Model.JobPlanRequest](docs/JobPlanRequest.md)
 - [Model.JobPlanResponse](docs/JobPlanResponse.md)
 - [Model.JobRegisterRequest](docs/JobRegisterRequest.md)
 - [Model.JobRegisterResponse](docs/JobRegisterResponse.md)
 - [Model.JobRevertRequest](docs/JobRevertRequest.md)
 - [Model.JobScaleStatusResponse](docs/JobScaleStatusResponse.md)
 - [Model.JobStabilityRequest](docs/JobStabilityRequest.md)
 - [Model.JobStabilityResponse](docs/JobStabilityResponse.md)
 - [Model.JobSummary](docs/JobSummary.md)
 - [Model.JobValidateRequest](docs/JobValidateRequest.md)
 - [Model.JobValidateResponse](docs/JobValidateResponse.md)
 - [Model.JobVersionsResponse](docs/JobVersionsResponse.md)
 - [Model.JobsParseRequest](docs/JobsParseRequest.md)
 - [Model.LogConfig](docs/LogConfig.md)
 - [Model.MetricsSummary](docs/MetricsSummary.md)
 - [Model.MigrateStrategy](docs/MigrateStrategy.md)
 - [Model.Multiregion](docs/Multiregion.md)
 - [Model.MultiregionRegion](docs/MultiregionRegion.md)
 - [Model.MultiregionStrategy](docs/MultiregionStrategy.md)
 - [Model.Namespace](docs/Namespace.md)
 - [Model.NamespaceCapabilities](docs/NamespaceCapabilities.md)
 - [Model.NetworkResource](docs/NetworkResource.md)
 - [Model.Node](docs/Node.md)
 - [Model.NodeCpuResources](docs/NodeCpuResources.md)
 - [Model.NodeDevice](docs/NodeDevice.md)
 - [Model.NodeDeviceLocality](docs/NodeDeviceLocality.md)
 - [Model.NodeDeviceResource](docs/NodeDeviceResource.md)
 - [Model.NodeDiskResources](docs/NodeDiskResources.md)
 - [Model.NodeDrainUpdateResponse](docs/NodeDrainUpdateResponse.md)
 - [Model.NodeEligibilityUpdateResponse](docs/NodeEligibilityUpdateResponse.md)
 - [Model.NodeEvent](docs/NodeEvent.md)
 - [Model.NodeListStub](docs/NodeListStub.md)
 - [Model.NodeMemoryResources](docs/NodeMemoryResources.md)
 - [Model.NodePurgeResponse](docs/NodePurgeResponse.md)
 - [Model.NodeReservedCpuResources](docs/NodeReservedCpuResources.md)
 - [Model.NodeReservedDiskResources](docs/NodeReservedDiskResources.md)
 - [Model.NodeReservedMemoryResources](docs/NodeReservedMemoryResources.md)
 - [Model.NodeReservedNetworkResources](docs/NodeReservedNetworkResources.md)
 - [Model.NodeReservedResources](docs/NodeReservedResources.md)
 - [Model.NodeResources](docs/NodeResources.md)
 - [Model.NodeScoreMeta](docs/NodeScoreMeta.md)
 - [Model.NodeUpdateDrainRequest](docs/NodeUpdateDrainRequest.md)
 - [Model.NodeUpdateEligibilityRequest](docs/NodeUpdateEligibilityRequest.md)
 - [Model.ObjectDiff](docs/ObjectDiff.md)
 - [Model.OneTimeToken](docs/OneTimeToken.md)
 - [Model.OneTimeTokenExchangeRequest](docs/OneTimeTokenExchangeRequest.md)
 - [Model.OperatorHealthReply](docs/OperatorHealthReply.md)
 - [Model.ParameterizedJobConfig](docs/ParameterizedJobConfig.md)
 - [Model.PeriodicConfig](docs/PeriodicConfig.md)
 - [Model.PeriodicForceResponse](docs/PeriodicForceResponse.md)
 - [Model.PlanAnnotations](docs/PlanAnnotations.md)
 - [Model.PointValue](docs/PointValue.md)
 - [Model.Port](docs/Port.md)
 - [Model.PortMapping](docs/PortMapping.md)
 - [Model.PreemptionConfig](docs/PreemptionConfig.md)
 - [Model.QuotaLimit](docs/QuotaLimit.md)
 - [Model.QuotaSpec](docs/QuotaSpec.md)
 - [Model.RaftConfiguration](docs/RaftConfiguration.md)
 - [Model.RaftServer](docs/RaftServer.md)
 - [Model.RequestedDevice](docs/RequestedDevice.md)
 - [Model.RescheduleEvent](docs/RescheduleEvent.md)
 - [Model.ReschedulePolicy](docs/ReschedulePolicy.md)
 - [Model.RescheduleTracker](docs/RescheduleTracker.md)
 - [Model.Resources](docs/Resources.md)
 - [Model.RestartPolicy](docs/RestartPolicy.md)
 - [Model.SampledValue](docs/SampledValue.md)
 - [Model.ScalingEvent](docs/ScalingEvent.md)
 - [Model.ScalingPolicy](docs/ScalingPolicy.md)
 - [Model.ScalingPolicyListStub](docs/ScalingPolicyListStub.md)
 - [Model.ScalingRequest](docs/ScalingRequest.md)
 - [Model.SchedulerConfiguration](docs/SchedulerConfiguration.md)
 - [Model.SchedulerConfigurationResponse](docs/SchedulerConfigurationResponse.md)
 - [Model.SchedulerSetConfigurationResponse](docs/SchedulerSetConfigurationResponse.md)
 - [Model.SearchRequest](docs/SearchRequest.md)
 - [Model.SearchResponse](docs/SearchResponse.md)
 - [Model.ServerHealth](docs/ServerHealth.md)
 - [Model.Service](docs/Service.md)
 - [Model.ServiceCheck](docs/ServiceCheck.md)
 - [Model.ServiceRegistration](docs/ServiceRegistration.md)
 - [Model.SidecarTask](docs/SidecarTask.md)
 - [Model.Spread](docs/Spread.md)
 - [Model.SpreadTarget](docs/SpreadTarget.md)
 - [Model.Task](docs/Task.md)
 - [Model.TaskArtifact](docs/TaskArtifact.md)
 - [Model.TaskCSIPluginConfig](docs/TaskCSIPluginConfig.md)
 - [Model.TaskDiff](docs/TaskDiff.md)
 - [Model.TaskEvent](docs/TaskEvent.md)
 - [Model.TaskGroup](docs/TaskGroup.md)
 - [Model.TaskGroupDiff](docs/TaskGroupDiff.md)
 - [Model.TaskGroupScaleStatus](docs/TaskGroupScaleStatus.md)
 - [Model.TaskGroupSummary](docs/TaskGroupSummary.md)
 - [Model.TaskHandle](docs/TaskHandle.md)
 - [Model.TaskLifecycle](docs/TaskLifecycle.md)
 - [Model.TaskState](docs/TaskState.md)
 - [Model.Template](docs/Template.md)
 - [Model.UpdateStrategy](docs/UpdateStrategy.md)
 - [Model.Vault](docs/Vault.md)
 - [Model.VolumeMount](docs/VolumeMount.md)
 - [Model.VolumeRequest](docs/VolumeRequest.md)
 - [Model.WaitConfig](docs/WaitConfig.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="X-Nomad-Token"></a>
### X-Nomad-Token

- **Type**: API key
- **API key parameter name**: X-Nomad-Token
- **Location**: HTTP header
