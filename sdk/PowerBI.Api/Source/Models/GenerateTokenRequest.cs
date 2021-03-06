// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Power BI Generate Token Request
    /// </summary>
    public partial class GenerateTokenRequest
    {
        /// <summary>
        /// Initializes a new instance of the GenerateTokenRequest class.
        /// </summary>
        public GenerateTokenRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GenerateTokenRequest class.
        /// </summary>
        /// <param name="accessLevel">Required access level for EmbedToken
        /// generation. Possible values include: 'View', 'Edit',
        /// 'Create'</param>
        /// <param name="datasetId">Dataset id for report creation. Only
        /// applies when generating EmbedToken for report creation.</param>
        /// <param name="allowSaveAs">Indicates an embedded report can be saved
        /// as a new report. Default value is 'false'. Only applies when
        /// generating EmbedToken for report embedding.</param>
        /// <param name="identities">List of identities to use for RLS
        /// rules.</param>
        public GenerateTokenRequest(TokenAccessLevel? accessLevel = default(TokenAccessLevel?), string datasetId = default(string), bool? allowSaveAs = default(bool?), IList<EffectiveIdentity> identities = default(IList<EffectiveIdentity>))
        {
            AccessLevel = accessLevel;
            DatasetId = datasetId;
            AllowSaveAs = allowSaveAs;
            Identities = identities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets required access level for EmbedToken generation.
        /// Possible values include: 'View', 'Edit', 'Create'
        /// </summary>
        [JsonProperty(PropertyName = "accessLevel")]
        public TokenAccessLevel? AccessLevel { get; set; }

        /// <summary>
        /// Gets or sets dataset id for report creation. Only applies when
        /// generating EmbedToken for report creation.
        /// </summary>
        [JsonProperty(PropertyName = "datasetId")]
        public string DatasetId { get; set; }

        /// <summary>
        /// Gets or sets indicates an embedded report can be saved as a new
        /// report. Default value is 'false'. Only applies when generating
        /// EmbedToken for report embedding.
        /// </summary>
        [JsonProperty(PropertyName = "allowSaveAs")]
        public bool? AllowSaveAs { get; set; }

        /// <summary>
        /// Gets or sets list of identities to use for RLS rules.
        /// </summary>
        [JsonProperty(PropertyName = "identities")]
        public IList<EffectiveIdentity> Identities { get; set; }

    }
}
