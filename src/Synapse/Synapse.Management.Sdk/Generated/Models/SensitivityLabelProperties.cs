// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Synapse.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of a sensitivity label.
    /// </summary>
    public partial class SensitivityLabelProperties
    {
        /// <summary>
        /// Initializes a new instance of the SensitivityLabelProperties class.
        /// </summary>
        public SensitivityLabelProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SensitivityLabelProperties class.
        /// </summary>

        /// <param name="schemaName">The schema name.
        /// </param>

        /// <param name="tableName">The table name.
        /// </param>

        /// <param name="columnName">The column name.
        /// </param>

        /// <param name="labelName">The label name.
        /// </param>

        /// <param name="labelId">The label ID.
        /// </param>

        /// <param name="informationType">The information type.
        /// </param>

        /// <param name="informationTypeId">The information type ID.
        /// </param>

        /// <param name="isDisabled">Is sensitivity recommendation disabled. Applicable for recommended
        /// sensitivity label only. Specifies whether the sensitivity recommendation on
        /// this column is disabled (dismissed) or not.
        /// </param>

        /// <param name="rank">
        /// Possible values include: &#39;None&#39;, &#39;Low&#39;, &#39;Medium&#39;, &#39;High&#39;, &#39;Critical&#39;</param>
        public SensitivityLabelProperties(string schemaName = default(string), string tableName = default(string), string columnName = default(string), string labelName = default(string), string labelId = default(string), string informationType = default(string), string informationTypeId = default(string), bool? isDisabled = default(bool?), SensitivityLabelRank? rank = default(SensitivityLabelRank?))

        {
            this.SchemaName = schemaName;
            this.TableName = tableName;
            this.ColumnName = columnName;
            this.LabelName = labelName;
            this.LabelId = labelId;
            this.InformationType = informationType;
            this.InformationTypeId = informationTypeId;
            this.IsDisabled = isDisabled;
            this.Rank = rank;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the schema name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "schemaName")]
        public string SchemaName {get; private set; }

        /// <summary>
        /// Gets the table name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tableName")]
        public string TableName {get; private set; }

        /// <summary>
        /// Gets the column name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "columnName")]
        public string ColumnName {get; private set; }

        /// <summary>
        /// Gets or sets the label name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "labelName")]
        public string LabelName {get; set; }

        /// <summary>
        /// Gets or sets the label ID.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "labelId")]
        public string LabelId {get; set; }

        /// <summary>
        /// Gets or sets the information type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "informationType")]
        public string InformationType {get; set; }

        /// <summary>
        /// Gets or sets the information type ID.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "informationTypeId")]
        public string InformationTypeId {get; set; }

        /// <summary>
        /// Gets is sensitivity recommendation disabled. Applicable for recommended
        /// sensitivity label only. Specifies whether the sensitivity recommendation on
        /// this column is disabled (dismissed) or not.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isDisabled")]
        public bool? IsDisabled {get; private set; }

        /// <summary>
        /// Gets or sets Possible values include: &#39;None&#39;, &#39;Low&#39;, &#39;Medium&#39;, &#39;High&#39;, &#39;Critical&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "rank")]
        public SensitivityLabelRank? Rank {get; set; }
    }
}