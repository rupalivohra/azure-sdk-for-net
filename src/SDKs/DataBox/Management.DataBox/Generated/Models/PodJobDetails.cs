// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Pod Job Details
    /// </summary>
    [Newtonsoft.Json.JsonObject("Pod")]
    public partial class PodJobDetails : JobDetails
    {
        /// <summary>
        /// Initializes a new instance of the PodJobDetails class.
        /// </summary>
        public PodJobDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PodJobDetails class.
        /// </summary>
        /// <param name="contactDetails">Contact details for notification and
        /// shipping.</param>
        /// <param name="shippingAddress">Shipping address of the
        /// customer.</param>
        /// <param name="expectedDataSizeInTeraBytes">The expected size of the
        /// data, which needs to be transfered in this job, in tera
        /// bytes.</param>
        /// <param name="jobStages">List of stages that run in the job.</param>
        /// <param name="errorDetails">Error details for failure. This is
        /// optional.</param>
        /// <param name="copyProgress">Copy progress per account.</param>
        public PodJobDetails(ContactDetails contactDetails, ShippingAddress shippingAddress, int? expectedDataSizeInTeraBytes = default(int?), IList<JobStages> jobStages = default(IList<JobStages>), IList<JobErrorDetails> errorDetails = default(IList<JobErrorDetails>), IList<CopyProgress> copyProgress = default(IList<CopyProgress>))
            : base(contactDetails, shippingAddress, expectedDataSizeInTeraBytes, jobStages, errorDetails)
        {
            CopyProgress = copyProgress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets copy progress per account.
        /// </summary>
        [JsonProperty(PropertyName = "copyProgress")]
        public IList<CopyProgress> CopyProgress { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
