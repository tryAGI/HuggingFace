
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestWatchedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestWatchedItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestWatchedItemType), TypeInfoPropertyName = "CreateSettingsWebhooksRequestWatchedItemType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1, global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2>), TypeInfoPropertyName = "OneOfCreateSettingsWebhooksRequestJobVariant1CreateSettingsWebhooksRequestJobVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Flavor), TypeInfoPropertyName = "CreateSettingsWebhooksRequestJobVariant1Flavor2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Arch), TypeInfoPropertyName = "CreateSettingsWebhooksRequestJobVariant1Arch2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Volume>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Volume))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1VolumeType), TypeInfoPropertyName = "CreateSettingsWebhooksRequestJobVariant1VolumeType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Expose))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Ssh))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Network))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Flavor), TypeInfoPropertyName = "CreateSettingsWebhooksRequestJobVariant2Flavor2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Arch), TypeInfoPropertyName = "CreateSettingsWebhooksRequestJobVariant2Arch2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Volume>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Volume))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2VolumeType), TypeInfoPropertyName = "CreateSettingsWebhooksRequestJobVariant2VolumeType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Expose))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Ssh))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Network))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestDomain), TypeInfoPropertyName = "CreateSettingsWebhooksRequestDomain2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestWatchedItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestWatchedItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestWatchedItemType2), TypeInfoPropertyName = "CreateSettingsWebhooksRequestWatchedItemType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant12, global::HuggingFace.CreateSettingsWebhooksRequestJobVariant22>), TypeInfoPropertyName = "OneOfCreateSettingsWebhooksRequestJobVariant12CreateSettingsWebhooksRequestJobVariant222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Flavor2), TypeInfoPropertyName = "CreateSettingsWebhooksRequestJobVariant1Flavor22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Arch2), TypeInfoPropertyName = "CreateSettingsWebhooksRequestJobVariant1Arch22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Volume2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Volume2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1VolumeType2), TypeInfoPropertyName = "CreateSettingsWebhooksRequestJobVariant1VolumeType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Expose2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Ssh2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Network2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Flavor2), TypeInfoPropertyName = "CreateSettingsWebhooksRequestJobVariant2Flavor22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Arch2), TypeInfoPropertyName = "CreateSettingsWebhooksRequestJobVariant2Arch22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Volume2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Volume2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2VolumeType2), TypeInfoPropertyName = "CreateSettingsWebhooksRequestJobVariant2VolumeType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Expose2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Ssh2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Network2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestDomain2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestDomain2), TypeInfoPropertyName = "CreateSettingsWebhooksRequestDomain22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<bool?, string>), TypeInfoPropertyName = "AnyOfBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksAction), TypeInfoPropertyName = "CreateSettingsWebhooksAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsWebhooksResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant1, global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant2>), TypeInfoPropertyName = "OneOfGetSettingsWebhooksResponseItemJobVariant1GetSettingsWebhooksResponseItemJobVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant1Flavor), TypeInfoPropertyName = "GetSettingsWebhooksResponseItemJobVariant1Flavor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant2Flavor), TypeInfoPropertyName = "GetSettingsWebhooksResponseItemJobVariant2Flavor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsWebhooksResponseItemWatchedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseItemWatchedItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseItemWatchedItemType), TypeInfoPropertyName = "GetSettingsWebhooksResponseItemWatchedItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsWebhooksResponseItemDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseItemDomain), TypeInfoPropertyName = "GetSettingsWebhooksResponseItemDomain2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1, global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2>), TypeInfoPropertyName = "OneOfCreateSettingsWebhooksResponseWebhookJobVariant1CreateSettingsWebhooksResponseWebhookJobVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor), TypeInfoPropertyName = "CreateSettingsWebhooksResponseWebhookJobVariant1Flavor2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor), TypeInfoPropertyName = "CreateSettingsWebhooksResponseWebhookJobVariant2Flavor2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType), TypeInfoPropertyName = "CreateSettingsWebhooksResponseWebhookWatchedItemType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain), TypeInfoPropertyName = "CreateSettingsWebhooksResponseWebhookDomain2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant1, global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant2>), TypeInfoPropertyName = "OneOfGetSettingsWebhooksResponseWebhookJobVariant1GetSettingsWebhooksResponseWebhookJobVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant1Flavor), TypeInfoPropertyName = "GetSettingsWebhooksResponseWebhookJobVariant1Flavor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant2Flavor), TypeInfoPropertyName = "GetSettingsWebhooksResponseWebhookJobVariant2Flavor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsWebhooksResponseWebhookWatchedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookWatchedItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookWatchedItemType), TypeInfoPropertyName = "GetSettingsWebhooksResponseWebhookWatchedItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsWebhooksResponseWebhookDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookDomain), TypeInfoPropertyName = "GetSettingsWebhooksResponseWebhookDomain2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhook2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant12, global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant22>), TypeInfoPropertyName = "OneOfCreateSettingsWebhooksResponseWebhookJobVariant12CreateSettingsWebhooksResponseWebhookJobVariant222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor2), TypeInfoPropertyName = "CreateSettingsWebhooksResponseWebhookJobVariant1Flavor22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor2), TypeInfoPropertyName = "CreateSettingsWebhooksResponseWebhookJobVariant2Flavor22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType2), TypeInfoPropertyName = "CreateSettingsWebhooksResponseWebhookWatchedItemType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain2), TypeInfoPropertyName = "CreateSettingsWebhooksResponseWebhookDomain22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.DeleteSettingsWebhooksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhook3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant13, global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant23>), TypeInfoPropertyName = "OneOfCreateSettingsWebhooksResponseWebhookJobVariant13CreateSettingsWebhooksResponseWebhookJobVariant232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor3), TypeInfoPropertyName = "CreateSettingsWebhooksResponseWebhookJobVariant1Flavor32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant23))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor3), TypeInfoPropertyName = "CreateSettingsWebhooksResponseWebhookJobVariant2Flavor32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType3), TypeInfoPropertyName = "CreateSettingsWebhooksResponseWebhookWatchedItemType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain3), TypeInfoPropertyName = "CreateSettingsWebhooksResponseWebhookDomain32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksReplayResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestWatchedItemType?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksRequestWatchedItemType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1, global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2>?), TypeInfoPropertyName = "NullableOneOfCreateSettingsWebhooksRequestJobVariant1CreateSettingsWebhooksRequestJobVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Flavor?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksRequestJobVariant1Flavor2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Arch?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksRequestJobVariant1Arch2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1VolumeType?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksRequestJobVariant1VolumeType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Flavor?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksRequestJobVariant2Flavor2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Arch?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksRequestJobVariant2Arch2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2VolumeType?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksRequestJobVariant2VolumeType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestDomain?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksRequestDomain2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestWatchedItemType2?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksRequestWatchedItemType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant12, global::HuggingFace.CreateSettingsWebhooksRequestJobVariant22>?), TypeInfoPropertyName = "NullableOneOfCreateSettingsWebhooksRequestJobVariant12CreateSettingsWebhooksRequestJobVariant222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Flavor2?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksRequestJobVariant1Flavor22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Arch2?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksRequestJobVariant1Arch22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1VolumeType2?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksRequestJobVariant1VolumeType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Flavor2?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksRequestJobVariant2Flavor22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Arch2?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksRequestJobVariant2Arch22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2VolumeType2?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksRequestJobVariant2VolumeType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksRequestDomain2?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksRequestDomain22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<bool?, string>?), TypeInfoPropertyName = "NullableAnyOfBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksAction?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant1, global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant2>?), TypeInfoPropertyName = "NullableOneOfGetSettingsWebhooksResponseItemJobVariant1GetSettingsWebhooksResponseItemJobVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant1Flavor?), TypeInfoPropertyName = "NullableGetSettingsWebhooksResponseItemJobVariant1Flavor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant2Flavor?), TypeInfoPropertyName = "NullableGetSettingsWebhooksResponseItemJobVariant2Flavor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseItemWatchedItemType?), TypeInfoPropertyName = "NullableGetSettingsWebhooksResponseItemWatchedItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseItemDomain?), TypeInfoPropertyName = "NullableGetSettingsWebhooksResponseItemDomain2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1, global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2>?), TypeInfoPropertyName = "NullableOneOfCreateSettingsWebhooksResponseWebhookJobVariant1CreateSettingsWebhooksResponseWebhookJobVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksResponseWebhookJobVariant1Flavor2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksResponseWebhookJobVariant2Flavor2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksResponseWebhookWatchedItemType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksResponseWebhookDomain2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant1, global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant2>?), TypeInfoPropertyName = "NullableOneOfGetSettingsWebhooksResponseWebhookJobVariant1GetSettingsWebhooksResponseWebhookJobVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant1Flavor?), TypeInfoPropertyName = "NullableGetSettingsWebhooksResponseWebhookJobVariant1Flavor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant2Flavor?), TypeInfoPropertyName = "NullableGetSettingsWebhooksResponseWebhookJobVariant2Flavor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookWatchedItemType?), TypeInfoPropertyName = "NullableGetSettingsWebhooksResponseWebhookWatchedItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookDomain?), TypeInfoPropertyName = "NullableGetSettingsWebhooksResponseWebhookDomain2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant12, global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant22>?), TypeInfoPropertyName = "NullableOneOfCreateSettingsWebhooksResponseWebhookJobVariant12CreateSettingsWebhooksResponseWebhookJobVariant222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor2?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksResponseWebhookJobVariant1Flavor22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor2?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksResponseWebhookJobVariant2Flavor22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType2?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksResponseWebhookWatchedItemType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain2?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksResponseWebhookDomain22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant13, global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant23>?), TypeInfoPropertyName = "NullableOneOfCreateSettingsWebhooksResponseWebhookJobVariant13CreateSettingsWebhooksResponseWebhookJobVariant232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor3?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksResponseWebhookJobVariant1Flavor32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor3?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksResponseWebhookJobVariant2Flavor32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType3?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksResponseWebhookWatchedItemType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain3?), TypeInfoPropertyName = "NullableCreateSettingsWebhooksResponseWebhookDomain32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksRequestWatchedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Volume>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Volume>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksRequestDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksRequestWatchedItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Volume2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Volume2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksRequestDomain2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSettingsWebhooksResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSettingsWebhooksResponseItemWatchedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSettingsWebhooksResponseItemDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSettingsWebhooksResponseWebhookWatchedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSettingsWebhooksResponseWebhookDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain3>))]
    internal sealed partial class WebhooksSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhooksSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static WebhooksSourceGenerationContext Default { get; } = new(DefaultOptions);

        private WebhooksSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::HuggingFace.JsonConverters.OneOfJsonConverter<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1, global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.OneOfJsonConverter<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant12, global::HuggingFace.CreateSettingsWebhooksRequestJobVariant22>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<int?, double?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<int?, double?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<int?, double?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<int?, double?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.Dictionary<string, string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.OneOfJsonConverter<global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant1, global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant2>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.OneOfJsonConverter<global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1, global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.OneOfJsonConverter<global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant1, global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant2>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.OneOfJsonConverter<global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant12, global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant22>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.OneOfJsonConverter<global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant13, global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant23>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, bool?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestWatchedItemType)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestWatchedItemType?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Flavor)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Flavor?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Arch)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Arch?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1VolumeType)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1VolumeType?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Flavor)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Flavor?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Arch)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Arch?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2VolumeType)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2VolumeType?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestDomain)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestDomain?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestWatchedItemType2)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestWatchedItemType2?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Flavor2)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Flavor2?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Arch2)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Arch2?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1VolumeType2)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1VolumeType2?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Flavor2)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Flavor2?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Arch2)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Arch2?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2VolumeType2)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2VolumeType2?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestDomain2)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestDomain2?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksAction)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksAction?)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant1Flavor)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant1Flavor?)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant2Flavor)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant2Flavor?)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseItemWatchedItemType)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseItemWatchedItemType?)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseItemDomain)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseItemDomain?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain?)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant1Flavor)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant1Flavor?)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant2Flavor)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant2Flavor?)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookWatchedItemType)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookWatchedItemType?)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookDomain)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookDomain?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor2)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor2?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor2)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor2?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType2)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType2?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain2)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain2?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor3)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor3?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor3)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor3?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType3)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType3?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain3)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain3?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestWatchedItemType))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestWatchedItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestWatchedItemType?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestWatchedItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Flavor))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant1FlavorJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Flavor?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant1FlavorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Arch))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant1ArchJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Arch?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant1ArchNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1VolumeType))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant1VolumeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1VolumeType?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant1VolumeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Flavor))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant2FlavorJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Flavor?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant2FlavorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Arch))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant2ArchJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Arch?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant2ArchNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2VolumeType))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant2VolumeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2VolumeType?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant2VolumeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestDomain))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestDomainJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestDomain?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestDomainNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestWatchedItemType2))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestWatchedItemType2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestWatchedItemType2?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestWatchedItemType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Flavor2))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant1Flavor2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Flavor2?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant1Flavor2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Arch2))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant1Arch2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Arch2?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant1Arch2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1VolumeType2))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant1VolumeType2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1VolumeType2?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant1VolumeType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Flavor2))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant2Flavor2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Flavor2?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant2Flavor2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Arch2))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant2Arch2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Arch2?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant2Arch2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2VolumeType2))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant2VolumeType2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2VolumeType2?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant2VolumeType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestDomain2))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestDomain2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksRequestDomain2?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestDomain2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksAction))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksActionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksAction?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant1Flavor))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsWebhooksResponseItemJobVariant1FlavorJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant1Flavor?))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsWebhooksResponseItemJobVariant1FlavorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant2Flavor))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsWebhooksResponseItemJobVariant2FlavorJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant2Flavor?))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsWebhooksResponseItemJobVariant2FlavorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseItemWatchedItemType))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsWebhooksResponseItemWatchedItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseItemWatchedItemType?))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsWebhooksResponseItemWatchedItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseItemDomain))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsWebhooksResponseItemDomainJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseItemDomain?))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsWebhooksResponseItemDomainNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookJobVariant1FlavorJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookJobVariant1FlavorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookJobVariant2FlavorJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookJobVariant2FlavorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookWatchedItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookWatchedItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookDomainJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookDomainNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant1Flavor))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsWebhooksResponseWebhookJobVariant1FlavorJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant1Flavor?))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsWebhooksResponseWebhookJobVariant1FlavorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant2Flavor))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsWebhooksResponseWebhookJobVariant2FlavorJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant2Flavor?))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsWebhooksResponseWebhookJobVariant2FlavorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookWatchedItemType))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsWebhooksResponseWebhookWatchedItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookWatchedItemType?))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsWebhooksResponseWebhookWatchedItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookDomain))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsWebhooksResponseWebhookDomainJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsWebhooksResponseWebhookDomain?))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsWebhooksResponseWebhookDomainNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor2))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor2?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor2))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor2?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType2))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookWatchedItemType2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType2?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookWatchedItemType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain2))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookDomain2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain2?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookDomain2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor3))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor3JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor3?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor3))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor3JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor3?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType3))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookWatchedItemType3JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType3?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookWatchedItemType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain3))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookDomain3JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain3?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsWebhooksResponseWebhookDomain3NullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new WebhooksSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}