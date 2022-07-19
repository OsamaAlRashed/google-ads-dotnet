// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/errors/campaign_experiment_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/errors/campaign_experiment_error.proto</summary>
  public static partial class CampaignExperimentErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/errors/campaign_experiment_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignExperimentErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9nb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvZXJyb3JzL2NhbXBhaWduX2V4",
            "cGVyaW1lbnRfZXJyb3IucHJvdG8SH2dvb2dsZS5hZHMuZ29vZ2xlYWRzLnYx",
            "MS5lcnJvcnMigAQKG0NhbXBhaWduRXhwZXJpbWVudEVycm9yRW51bSLgAwoX",
            "Q2FtcGFpZ25FeHBlcmltZW50RXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdV",
            "TktOT1dOEAESEgoORFVQTElDQVRFX05BTUUQAhIWChJJTlZBTElEX1RSQU5T",
            "SVRJT04QAxIvCitDQU5OT1RfQ1JFQVRFX0VYUEVSSU1FTlRfV0lUSF9TSEFS",
            "RURfQlVER0VUEAQSNgoyQ0FOTk9UX0NSRUFURV9FWFBFUklNRU5UX0ZPUl9S",
            "RU1PVkVEX0JBU0VfQ0FNUEFJR04QBRIzCi9DQU5OT1RfQ1JFQVRFX0VYUEVS",
            "SU1FTlRfRk9SX05PTl9QUk9QT1NFRF9EUkFGVBAGEiUKIUNVU1RPTUVSX0NB",
            "Tk5PVF9DUkVBVEVfRVhQRVJJTUVOVBAHEiUKIUNBTVBBSUdOX0NBTk5PVF9D",
            "UkVBVEVfRVhQRVJJTUVOVBAIEikKJUVYUEVSSU1FTlRfRFVSQVRJT05TX01V",
            "U1RfTk9UX09WRVJMQVAQCRI4CjRFWFBFUklNRU5UX0RVUkFUSU9OX01VU1Rf",
            "QkVfV0lUSElOX0NBTVBBSUdOX0RVUkFUSU9OEAoSKgomQ0FOTk9UX01VVEFU",
            "RV9FWFBFUklNRU5UX0RVRV9UT19TVEFUVVMQC0L8AQojY29tLmdvb2dsZS5h",
            "ZHMuZ29vZ2xlYWRzLnYxMS5lcnJvcnNCHENhbXBhaWduRXhwZXJpbWVudEVy",
            "cm9yUHJvdG9QAVpFZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9hZHMvZ29vZ2xlYWRzL3YxMS9lcnJvcnM7ZXJyb3JzogIDR0FBqgIf",
            "R29vZ2xlLkFkcy5Hb29nbGVBZHMuVjExLkVycm9yc8oCH0dvb2dsZVxBZHNc",
            "R29vZ2xlQWRzXFYxMVxFcnJvcnPqAiNHb29nbGU6OkFkczo6R29vZ2xlQWRz",
            "OjpWMTE6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Errors.CampaignExperimentErrorEnum), global::Google.Ads.GoogleAds.V11.Errors.CampaignExperimentErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V11.Errors.CampaignExperimentErrorEnum.Types.CampaignExperimentError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible campaign experiment errors.
  /// </summary>
  public sealed partial class CampaignExperimentErrorEnum : pb::IMessage<CampaignExperimentErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignExperimentErrorEnum> _parser = new pb::MessageParser<CampaignExperimentErrorEnum>(() => new CampaignExperimentErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignExperimentErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Errors.CampaignExperimentErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignExperimentErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignExperimentErrorEnum(CampaignExperimentErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignExperimentErrorEnum Clone() {
      return new CampaignExperimentErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignExperimentErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignExperimentErrorEnum other) {
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
    public void MergeFrom(CampaignExperimentErrorEnum other) {
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
    /// <summary>Container for nested types declared in the CampaignExperimentErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible campaign experiment errors.
      /// </summary>
      public enum CampaignExperimentError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// An active campaign or experiment with this name already exists.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_NAME")] DuplicateName = 2,
        /// <summary>
        /// Experiment cannot be updated from the current state to the
        /// requested target state. For example, an experiment can only graduate
        /// if its status is ENABLED.
        /// </summary>
        [pbr::OriginalName("INVALID_TRANSITION")] InvalidTransition = 3,
        /// <summary>
        /// Cannot create an experiment from a campaign using an explicitly shared
        /// budget.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_EXPERIMENT_WITH_SHARED_BUDGET")] CannotCreateExperimentWithSharedBudget = 4,
        /// <summary>
        /// Cannot create an experiment for a removed base campaign.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_EXPERIMENT_FOR_REMOVED_BASE_CAMPAIGN")] CannotCreateExperimentForRemovedBaseCampaign = 5,
        /// <summary>
        /// Cannot create an experiment from a draft, which has a status other than
        /// proposed.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_EXPERIMENT_FOR_NON_PROPOSED_DRAFT")] CannotCreateExperimentForNonProposedDraft = 6,
        /// <summary>
        /// This customer is not allowed to create an experiment.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_CANNOT_CREATE_EXPERIMENT")] CustomerCannotCreateExperiment = 7,
        /// <summary>
        /// This campaign is not allowed to create an experiment.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_CANNOT_CREATE_EXPERIMENT")] CampaignCannotCreateExperiment = 8,
        /// <summary>
        /// Trying to set an experiment duration which overlaps with another
        /// experiment.
        /// </summary>
        [pbr::OriginalName("EXPERIMENT_DURATIONS_MUST_NOT_OVERLAP")] ExperimentDurationsMustNotOverlap = 9,
        /// <summary>
        /// All non-removed experiments must start and end within their campaign's
        /// duration.
        /// </summary>
        [pbr::OriginalName("EXPERIMENT_DURATION_MUST_BE_WITHIN_CAMPAIGN_DURATION")] ExperimentDurationMustBeWithinCampaignDuration = 10,
        /// <summary>
        /// The experiment cannot be modified because its status is in a terminal
        /// state, such as REMOVED.
        /// </summary>
        [pbr::OriginalName("CANNOT_MUTATE_EXPERIMENT_DUE_TO_STATUS")] CannotMutateExperimentDueToStatus = 11,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code