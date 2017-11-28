// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Management.Fabric.Admin.Models
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Management;
    using Microsoft.AzureStack.Management.Fabric;
    using Microsoft.AzureStack.Management.Fabric.Admin;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The capacity information for a virtual machine.
    /// </summary>
    public partial class InfraRoleInstanceSize
    {
        /// <summary>
        /// Initializes a new instance of the InfraRoleInstanceSize class.
        /// </summary>
        public InfraRoleInstanceSize()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InfraRoleInstanceSize class.
        /// </summary>
        /// <param name="memoryGb">The amount of memory, in GB, currently
        /// assigned to the virtual machine.  In Azure Stack V1, only static
        /// memory is used for infrastructure VMs.</param>
        /// <param name="cores">The number of cores assigned to the virtual
        /// machine.</param>
        public InfraRoleInstanceSize(double? memoryGb = default(double?), int? cores = default(int?))
        {
            MemoryGb = memoryGb;
            Cores = cores;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the amount of memory, in GB, currently assigned to the
        /// virtual machine.  In Azure Stack V1, only static memory is used for
        /// infrastructure VMs.
        /// </summary>
        [JsonProperty(PropertyName = "memoryGb")]
        public double? MemoryGb { get; set; }

        /// <summary>
        /// Gets or sets the number of cores assigned to the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "cores")]
        public int? Cores { get; set; }

    }
}