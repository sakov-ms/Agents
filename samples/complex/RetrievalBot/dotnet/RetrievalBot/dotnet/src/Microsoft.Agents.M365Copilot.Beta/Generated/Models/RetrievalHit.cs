// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Agents.M365Copilot.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class RetrievalHit : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The extracts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Agents.M365Copilot.Beta.Models.RetrievalExtract>? Extracts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Agents.M365Copilot.Beta.Models.RetrievalExtract>?>("extracts"); }
            set { BackingStore?.Set("extracts", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Agents.M365Copilot.Beta.Models.RetrievalExtract> Extracts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Agents.M365Copilot.Beta.Models.RetrievalExtract>>("extracts"); }
            set { BackingStore?.Set("extracts", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The resourceMetadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Agents.M365Copilot.Beta.Models.SearchResourceMetadataDictionary? ResourceMetadata
        {
            get { return BackingStore?.Get<global::Microsoft.Agents.M365Copilot.Beta.Models.SearchResourceMetadataDictionary?>("resourceMetadata"); }
            set { BackingStore?.Set("resourceMetadata", value); }
        }
#nullable restore
#else
        public global::Microsoft.Agents.M365Copilot.Beta.Models.SearchResourceMetadataDictionary ResourceMetadata
        {
            get { return BackingStore?.Get<global::Microsoft.Agents.M365Copilot.Beta.Models.SearchResourceMetadataDictionary>("resourceMetadata"); }
            set { BackingStore?.Set("resourceMetadata", value); }
        }
#endif
        /// <summary>The resourceType property</summary>
        public global::Microsoft.Agents.M365Copilot.Beta.Models.GroundingEntityType? ResourceType
        {
            get { return BackingStore?.Get<global::Microsoft.Agents.M365Copilot.Beta.Models.GroundingEntityType?>("resourceType"); }
            set { BackingStore?.Set("resourceType", value); }
        }
        /// <summary>The sensitivityLabel property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Agents.M365Copilot.Beta.Models.SearchSensitivityLabelInfo? SensitivityLabel
        {
            get { return BackingStore?.Get<global::Microsoft.Agents.M365Copilot.Beta.Models.SearchSensitivityLabelInfo?>("sensitivityLabel"); }
            set { BackingStore?.Set("sensitivityLabel", value); }
        }
#nullable restore
#else
        public global::Microsoft.Agents.M365Copilot.Beta.Models.SearchSensitivityLabelInfo SensitivityLabel
        {
            get { return BackingStore?.Get<global::Microsoft.Agents.M365Copilot.Beta.Models.SearchSensitivityLabelInfo>("sensitivityLabel"); }
            set { BackingStore?.Set("sensitivityLabel", value); }
        }
#endif
        /// <summary>The webUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl
        {
            get { return BackingStore?.Get<string?>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#nullable restore
#else
        public string WebUrl
        {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Agents.M365Copilot.Beta.Models.RetrievalHit"/> and sets the default values.
        /// </summary>
        public RetrievalHit()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Agents.M365Copilot.Beta.Models.RetrievalHit"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Agents.M365Copilot.Beta.Models.RetrievalHit CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Agents.M365Copilot.Beta.Models.RetrievalHit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "extracts", n => { Extracts = n.GetCollectionOfObjectValues<global::Microsoft.Agents.M365Copilot.Beta.Models.RetrievalExtract>(global::Microsoft.Agents.M365Copilot.Beta.Models.RetrievalExtract.CreateFromDiscriminatorValue)?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "resourceMetadata", n => { ResourceMetadata = n.GetObjectValue<global::Microsoft.Agents.M365Copilot.Beta.Models.SearchResourceMetadataDictionary>(global::Microsoft.Agents.M365Copilot.Beta.Models.SearchResourceMetadataDictionary.CreateFromDiscriminatorValue); } },
                { "resourceType", n => { ResourceType = n.GetEnumValue<global::Microsoft.Agents.M365Copilot.Beta.Models.GroundingEntityType>(); } },
                { "sensitivityLabel", n => { SensitivityLabel = n.GetObjectValue<global::Microsoft.Agents.M365Copilot.Beta.Models.SearchSensitivityLabelInfo>(global::Microsoft.Agents.M365Copilot.Beta.Models.SearchSensitivityLabelInfo.CreateFromDiscriminatorValue); } },
                { "webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Microsoft.Agents.M365Copilot.Beta.Models.RetrievalExtract>("extracts", Extracts);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::Microsoft.Agents.M365Copilot.Beta.Models.SearchResourceMetadataDictionary>("resourceMetadata", ResourceMetadata);
            writer.WriteEnumValue<global::Microsoft.Agents.M365Copilot.Beta.Models.GroundingEntityType>("resourceType", ResourceType);
            writer.WriteObjectValue<global::Microsoft.Agents.M365Copilot.Beta.Models.SearchSensitivityLabelInfo>("sensitivityLabel", SensitivityLabel);
            writer.WriteStringValue("webUrl", WebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
