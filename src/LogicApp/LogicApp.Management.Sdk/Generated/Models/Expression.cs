// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System.Linq;

    public partial class Expression
    {
        /// <summary>
        /// Initializes a new instance of the Expression class.
        /// </summary>
        public Expression()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Expression class.
        /// </summary>

        /// <param name="text">
        /// </param>

        /// <param name="value">Anything
        /// </param>

        /// <param name="subexpressions">
        /// </param>

        /// <param name="error">The azure resource error info.
        /// </param>
        public Expression(string text = default(string), object value = default(object), System.Collections.Generic.IList<Expression> subexpressions = default(System.Collections.Generic.IList<Expression>), AzureResourceErrorInfo error = default(AzureResourceErrorInfo))

        {
            this.Text = text;
            this.Value = value;
            this.Subexpressions = subexpressions;
            this.Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "text")]
        public string Text {get; set; }

        /// <summary>
        /// Gets or sets anything
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public object Value {get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "subexpressions")]
        public System.Collections.Generic.IList<Expression> Subexpressions {get; set; }

        /// <summary>
        /// Gets or sets the azure resource error info.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "error")]
        public AzureResourceErrorInfo Error {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {


            if (this.Subexpressions != null)
            {
                foreach (var element in this.Subexpressions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.Error != null)
            {
                this.Error.Validate();
            }
        }
    }
}