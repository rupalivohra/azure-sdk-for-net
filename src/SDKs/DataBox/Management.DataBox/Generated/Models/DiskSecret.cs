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
    using System.Linq;

    /// <summary>
    /// Contains all the secrets of a Disk.
    /// </summary>
    public partial class DiskSecret
    {
        /// <summary>
        /// Initializes a new instance of the DiskSecret class.
        /// </summary>
        public DiskSecret()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiskSecret class.
        /// </summary>
        /// <param name="diskSerialNumber">Serial number of the assigned
        /// disk.</param>
        /// <param name="bitLockerKey">Bit Locker key of the disk which can be
        /// used to unlock the disk to copy data.</param>
        public DiskSecret(string diskSerialNumber = default(string), string bitLockerKey = default(string))
        {
            DiskSerialNumber = diskSerialNumber;
            BitLockerKey = bitLockerKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets serial number of the assigned disk.
        /// </summary>
        [JsonProperty(PropertyName = "diskSerialNumber")]
        public string DiskSerialNumber { get; set; }

        /// <summary>
        /// Gets or sets bit Locker key of the disk which can be used to unlock
        /// the disk to copy data.
        /// </summary>
        [JsonProperty(PropertyName = "bitLockerKey")]
        public string BitLockerKey { get; set; }

    }
}
