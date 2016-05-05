// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.ApiManagement.SmapiModels
{
    /// <summary>
    /// Parameters supplied to the Save Tenant Configuration operation.
    /// </summary>
    public partial class SaveConfigurationParameter
    {
        private string _branch;
        
        /// <summary>
        /// Required. Gets or sets the name of the Git branch in which to
        /// commit the current configuration snapshot.
        /// </summary>
        public string Branch
        {
            get { return this._branch; }
            set { this._branch = value; }
        }
        
        private bool _force;
        
        /// <summary>
        /// Optional. Gets or sets the value if true, the current configuration
        /// database is committed to the Git repository, even if the Git
        /// repository has newer changes that would be overwritten.
        /// </summary>
        public bool Force
        {
            get { return this._force; }
            set { this._force = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SaveConfigurationParameter class.
        /// </summary>
        public SaveConfigurationParameter()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the SaveConfigurationParameter class
        /// with required arguments.
        /// </summary>
        public SaveConfigurationParameter(string branch)
            : this()
        {
            if (branch == null)
            {
                throw new ArgumentNullException("branch");
            }
            this.Branch = branch;
        }
    }
}
