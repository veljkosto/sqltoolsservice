//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using System.Collections.Generic;

namespace Microsoft.SqlTools.ServiceLayer.Admin.Contracts
{
    public class TableInfo
    {
        /// <summary>
        /// Gets or sets the options
        /// </summary>
        public Dictionary<string, object> Options { get; set; }

        public TableInfo()
        {
            Options = new Dictionary<string, object>();
        }
        
    }
}
