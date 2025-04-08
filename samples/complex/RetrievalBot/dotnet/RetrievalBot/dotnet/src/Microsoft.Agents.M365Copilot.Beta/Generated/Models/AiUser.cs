// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Agents.M365Copilot.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AiUser : global::Microsoft.Agents.M365Copilot.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The interactionHistory property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Agents.M365Copilot.Beta.Models.AiInteractionHistory? InteractionHistory
        {
            get { return BackingStore?.Get<global::Microsoft.Agents.M365Copilot.Beta.Models.AiInteractionHistory?>("interactionHistory"); }
            set { BackingStore?.Set("interactionHistory", value); }
        }
#nullable restore
#else
        public global::Microsoft.Agents.M365Copilot.Beta.Models.AiInteractionHistory InteractionHistory
        {
            get { return BackingStore?.Get<global::Microsoft.Agents.M365Copilot.Beta.Models.AiInteractionHistory>("interactionHistory"); }
            set { BackingStore?.Set("interactionHistory", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Agents.M365Copilot.Beta.Models.AiUser"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Agents.M365Copilot.Beta.Models.AiUser CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Agents.M365Copilot.Beta.Models.AiUser();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "interactionHistory", n => { InteractionHistory = n.GetObjectValue<global::Microsoft.Agents.M365Copilot.Beta.Models.AiInteractionHistory>(global::Microsoft.Agents.M365Copilot.Beta.Models.AiInteractionHistory.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<global::Microsoft.Agents.M365Copilot.Beta.Models.AiInteractionHistory>("interactionHistory", InteractionHistory);
        }
    }
}
#pragma warning restore CS0618
