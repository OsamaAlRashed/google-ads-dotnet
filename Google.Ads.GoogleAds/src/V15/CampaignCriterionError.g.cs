// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v15/errors/campaign_criterion_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V15.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v15/errors/campaign_criterion_error.proto</summary>
  public static partial class CampaignCriterionErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v15/errors/campaign_criterion_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignCriterionErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92MTUvZXJyb3JzL2NhbXBhaWduX2Ny",
            "aXRlcmlvbl9lcnJvci5wcm90bxIfZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE1",
            "LmVycm9ycyLDCgoaQ2FtcGFpZ25Dcml0ZXJpb25FcnJvckVudW0ipAoKFkNh",
            "bXBhaWduQ3JpdGVyaW9uRXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktO",
            "T1dOEAESGgoWQ09OQ1JFVEVfVFlQRV9SRVFVSVJFRBACEhkKFUlOVkFMSURf",
            "UExBQ0VNRU5UX1VSTBADEiAKHENBTk5PVF9FWENMVURFX0NSSVRFUklBX1RZ",
            "UEUQBBInCiNDQU5OT1RfU0VUX1NUQVRVU19GT1JfQ1JJVEVSSUFfVFlQRRAF",
            "EisKJ0NBTk5PVF9TRVRfU1RBVFVTX0ZPUl9FWENMVURFRF9DUklURVJJQRAG",
            "Eh0KGUNBTk5PVF9UQVJHRVRfQU5EX0VYQ0xVREUQBxIXChNUT09fTUFOWV9P",
            "UEVSQVRJT05TEAgSLQopT1BFUkFUT1JfTk9UX1NVUFBPUlRFRF9GT1JfQ1JJ",
            "VEVSSU9OX1RZUEUQCRJDCj9TSE9QUElOR19DQU1QQUlHTl9TQUxFU19DT1VO",
            "VFJZX05PVF9TVVBQT1JURURfRk9SX1NBTEVTX0NIQU5ORUwQChIdChlDQU5O",
            "T1RfQUREX0VYSVNUSU5HX0ZJRUxEEAsSJAogQ0FOTk9UX1VQREFURV9ORUdB",
            "VElWRV9DUklURVJJT04QDBI4CjRDQU5OT1RfU0VUX05FR0FUSVZFX0tFWVdP",
            "UkRfVEhFTUVfQ09OU1RBTlRfQ1JJVEVSSU9OEA0SIgoeSU5WQUxJRF9LRVlX",
            "T1JEX1RIRU1FX0NPTlNUQU5UEA4SPQo5TUlTU0lOR19LRVlXT1JEX1RIRU1F",
            "X0NPTlNUQU5UX09SX0ZSRUVfRk9STV9LRVlXT1JEX1RIRU1FEA8SSQpFQ0FO",
            "Tk9UX1RBUkdFVF9CT1RIX1BST1hJTUlUWV9BTkRfTE9DQVRJT05fQ1JJVEVS",
            "SUFfRk9SX1NNQVJUX0NBTVBBSUdOEBASQAo8Q0FOTk9UX1RBUkdFVF9NVUxU",
            "SVBMRV9QUk9YSU1JVFlfQ1JJVEVSSUFfRk9SX1NNQVJUX0NBTVBBSUdOEBES",
            "NQoxTE9DQVRJT05fTk9UX0xBVU5DSEVEX0ZPUl9MT0NBTF9TRVJWSUNFU19D",
            "QU1QQUlHThASEjAKLExPQ0FUSU9OX0lOVkFMSURfRk9SX0xPQ0FMX1NFUlZJ",
            "Q0VTX0NBTVBBSUdOEBMSNQoxQ0FOTk9UX1RBUkdFVF9DT1VOVFJZX0ZPUl9M",
            "T0NBTF9TRVJWSUNFU19DQU1QQUlHThAUEjwKOExPQ0FUSU9OX05PVF9JTl9I",
            "T01FX0NPVU5UUllfRk9SX0xPQ0FMX1NFUlZJQ0VTX0NBTVBBSUdOEBUSPQo5",
            "Q0FOTk9UX0FERF9PUl9SRU1PVkVfTE9DQVRJT05fRk9SX0xPQ0FMX1NFUlZJ",
            "Q0VTX0NBTVBBSUdOEBYSRwpDQVRfTEVBU1RfT05FX1BPU0lUSVZFX0xPQ0FU",
            "SU9OX1JFUVVJUkVEX0ZPUl9MT0NBTF9TRVJWSUNFU19DQU1QQUlHThAXElAK",
            "TEFUX0xFQVNUX09ORV9MT0NBTF9TRVJWSUNFX0lEX0NSSVRFUklPTl9SRVFV",
            "SVJFRF9GT1JfTE9DQUxfU0VSVklDRVNfQ0FNUEFJR04QGBIrCidMT0NBTF9T",
            "RVJWSUNFX0lEX05PVF9GT1VORF9GT1JfQ0FURUdPUlkQGRI9CjlDQU5OT1Rf",
            "QVRUQUNIX0JSQU5EX0xJU1RfVE9fTk9OX1FVQUxJRklFRF9TRUFSQ0hfQ0FN",
            "UEFJR04QGkL7AQojY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNS5lcnJv",
            "cnNCG0NhbXBhaWduQ3JpdGVyaW9uRXJyb3JQcm90b1ABWkVnb29nbGUuZ29s",
            "YW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjE1",
            "L2Vycm9ycztlcnJvcnOiAgNHQUGqAh9Hb29nbGUuQWRzLkdvb2dsZUFkcy5W",
            "MTUuRXJyb3JzygIfR29vZ2xlXEFkc1xHb29nbGVBZHNcVjE1XEVycm9yc+oC",
            "I0dvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxNTo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V15.Errors.CampaignCriterionErrorEnum), global::Google.Ads.GoogleAds.V15.Errors.CampaignCriterionErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V15.Errors.CampaignCriterionErrorEnum.Types.CampaignCriterionError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible campaign criterion errors.
  /// </summary>
  public sealed partial class CampaignCriterionErrorEnum : pb::IMessage<CampaignCriterionErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignCriterionErrorEnum> _parser = new pb::MessageParser<CampaignCriterionErrorEnum>(() => new CampaignCriterionErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignCriterionErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V15.Errors.CampaignCriterionErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignCriterionErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignCriterionErrorEnum(CampaignCriterionErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignCriterionErrorEnum Clone() {
      return new CampaignCriterionErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignCriterionErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignCriterionErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CampaignCriterionErrorEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the CampaignCriterionErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible campaign criterion errors.
      /// </summary>
      public enum CampaignCriterionError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Concrete type of criterion (keyword v.s. placement) is required for
        /// CREATE and UPDATE operations.
        /// </summary>
        [pbr::OriginalName("CONCRETE_TYPE_REQUIRED")] ConcreteTypeRequired = 2,
        /// <summary>
        /// Invalid placement URL.
        /// </summary>
        [pbr::OriginalName("INVALID_PLACEMENT_URL")] InvalidPlacementUrl = 3,
        /// <summary>
        /// Criteria type can not be excluded for the campaign by the customer. like
        /// AOL account type cannot target site type criteria
        /// </summary>
        [pbr::OriginalName("CANNOT_EXCLUDE_CRITERIA_TYPE")] CannotExcludeCriteriaType = 4,
        /// <summary>
        /// Cannot set the campaign criterion status for this criteria type.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_STATUS_FOR_CRITERIA_TYPE")] CannotSetStatusForCriteriaType = 5,
        /// <summary>
        /// Cannot set the campaign criterion status for an excluded criteria.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_STATUS_FOR_EXCLUDED_CRITERIA")] CannotSetStatusForExcludedCriteria = 6,
        /// <summary>
        /// Cannot target and exclude the same criterion.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_AND_EXCLUDE")] CannotTargetAndExclude = 7,
        /// <summary>
        /// The mutate contained too many operations.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_OPERATIONS")] TooManyOperations = 8,
        /// <summary>
        /// This operator cannot be applied to a criterion of this type.
        /// </summary>
        [pbr::OriginalName("OPERATOR_NOT_SUPPORTED_FOR_CRITERION_TYPE")] OperatorNotSupportedForCriterionType = 9,
        /// <summary>
        /// The Shopping campaign sales country is not supported for
        /// ProductSalesChannel targeting.
        /// </summary>
        [pbr::OriginalName("SHOPPING_CAMPAIGN_SALES_COUNTRY_NOT_SUPPORTED_FOR_SALES_CHANNEL")] ShoppingCampaignSalesCountryNotSupportedForSalesChannel = 10,
        /// <summary>
        /// The existing field can't be updated with CREATE operation. It can be
        /// updated with UPDATE operation only.
        /// </summary>
        [pbr::OriginalName("CANNOT_ADD_EXISTING_FIELD")] CannotAddExistingField = 11,
        /// <summary>
        /// Negative criteria are immutable, so updates are not allowed.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPDATE_NEGATIVE_CRITERION")] CannotUpdateNegativeCriterion = 12,
        /// <summary>
        /// Only free form names are allowed for negative Smart campaign keyword
        /// theme.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_NEGATIVE_KEYWORD_THEME_CONSTANT_CRITERION")] CannotSetNegativeKeywordThemeConstantCriterion = 13,
        /// <summary>
        /// Invalid Smart campaign keyword theme constant criterion.
        /// </summary>
        [pbr::OriginalName("INVALID_KEYWORD_THEME_CONSTANT")] InvalidKeywordThemeConstant = 14,
        /// <summary>
        /// A Smart campaign keyword theme constant or free-form Smart campaign
        /// keyword theme is required.
        /// </summary>
        [pbr::OriginalName("MISSING_KEYWORD_THEME_CONSTANT_OR_FREE_FORM_KEYWORD_THEME")] MissingKeywordThemeConstantOrFreeFormKeywordTheme = 15,
        /// <summary>
        /// A Smart campaign may not target proximity and location criteria
        /// simultaneously.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_BOTH_PROXIMITY_AND_LOCATION_CRITERIA_FOR_SMART_CAMPAIGN")] CannotTargetBothProximityAndLocationCriteriaForSmartCampaign = 16,
        /// <summary>
        /// A Smart campaign may not target multiple proximity criteria.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_MULTIPLE_PROXIMITY_CRITERIA_FOR_SMART_CAMPAIGN")] CannotTargetMultipleProximityCriteriaForSmartCampaign = 17,
        /// <summary>
        /// Location is not launched for Local Services Campaigns.
        /// </summary>
        [pbr::OriginalName("LOCATION_NOT_LAUNCHED_FOR_LOCAL_SERVICES_CAMPAIGN")] LocationNotLaunchedForLocalServicesCampaign = 18,
        /// <summary>
        /// A Local Services campaign may not target certain criteria types.
        /// </summary>
        [pbr::OriginalName("LOCATION_INVALID_FOR_LOCAL_SERVICES_CAMPAIGN")] LocationInvalidForLocalServicesCampaign = 19,
        /// <summary>
        /// Country locations are not supported for Local Services campaign.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_COUNTRY_FOR_LOCAL_SERVICES_CAMPAIGN")] CannotTargetCountryForLocalServicesCampaign = 20,
        /// <summary>
        /// Location is not within the home country of Local Services campaign.
        /// </summary>
        [pbr::OriginalName("LOCATION_NOT_IN_HOME_COUNTRY_FOR_LOCAL_SERVICES_CAMPAIGN")] LocationNotInHomeCountryForLocalServicesCampaign = 21,
        /// <summary>
        /// Local Services profile does not exist for a particular Local Services
        /// campaign.
        /// </summary>
        [pbr::OriginalName("CANNOT_ADD_OR_REMOVE_LOCATION_FOR_LOCAL_SERVICES_CAMPAIGN")] CannotAddOrRemoveLocationForLocalServicesCampaign = 22,
        /// <summary>
        /// Local Services campaign must have at least one target location.
        /// </summary>
        [pbr::OriginalName("AT_LEAST_ONE_POSITIVE_LOCATION_REQUIRED_FOR_LOCAL_SERVICES_CAMPAIGN")] AtLeastOnePositiveLocationRequiredForLocalServicesCampaign = 23,
        /// <summary>
        /// At least one positive local service ID criterion is required for a Local
        /// Services campaign.
        /// </summary>
        [pbr::OriginalName("AT_LEAST_ONE_LOCAL_SERVICE_ID_CRITERION_REQUIRED_FOR_LOCAL_SERVICES_CAMPAIGN")] AtLeastOneLocalServiceIdCriterionRequiredForLocalServicesCampaign = 24,
        /// <summary>
        /// Local service ID is not found under selected categories in local
        /// services campaign setting.
        /// </summary>
        [pbr::OriginalName("LOCAL_SERVICE_ID_NOT_FOUND_FOR_CATEGORY")] LocalServiceIdNotFoundForCategory = 25,
        /// <summary>
        /// For search advertising channel, brand lists can only be applied to
        /// exclusive targeting, broad match campaigns for inclusive targeting or
        /// PMax generated campaigns.
        /// </summary>
        [pbr::OriginalName("CANNOT_ATTACH_BRAND_LIST_TO_NON_QUALIFIED_SEARCH_CAMPAIGN")] CannotAttachBrandListToNonQualifiedSearchCampaign = 26,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
