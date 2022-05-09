// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/enums/customer_pay_per_conversion_eligibility_failure_reason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/enums/customer_pay_per_conversion_eligibility_failure_reason.proto</summary>
  public static partial class CustomerPayPerConversionEligibilityFailureReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/enums/customer_pay_per_conversion_eligibility_failure_reason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerPayPerConversionEligibilityFailureReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cltnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51bXMvY3VzdG9tZXJfcGF5",
            "X3Blcl9jb252ZXJzaW9uX2VsaWdpYmlsaXR5X2ZhaWx1cmVfcmVhc29uLnBy",
            "b3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTAuZW51bXMi0QIKNEN1c3Rv",
            "bWVyUGF5UGVyQ29udmVyc2lvbkVsaWdpYmlsaXR5RmFpbHVyZVJlYXNvbkVu",
            "dW0imAIKMEN1c3RvbWVyUGF5UGVyQ29udmVyc2lvbkVsaWdpYmlsaXR5RmFp",
            "bHVyZVJlYXNvbhIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIaChZO",
            "T1RfRU5PVUdIX0NPTlZFUlNJT05TEAISGwoXQ09OVkVSU0lPTl9MQUdfVE9P",
            "X0hJR0gQAxIjCh9IQVNfQ0FNUEFJR05fV0lUSF9TSEFSRURfQlVER0VUEAQS",
            "IAocSEFTX1VQTE9BRF9DTElDS1NfQ09OVkVSU0lPThAFEiAKHEFWRVJBR0Vf",
            "REFJTFlfU1BFTkRfVE9PX0hJR0gQBhIZChVBTkFMWVNJU19OT1RfQ09NUExF",
            "VEUQBxIJCgVPVEhFUhAIQo8CCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djEwLmVudW1zQjVDdXN0b21lclBheVBlckNvbnZlcnNpb25FbGlnaWJpbGl0",
            "eUZhaWx1cmVSZWFzb25Qcm90b1ABWkNnb29nbGUuZ29sYW5nLm9yZy9nZW5w",
            "cm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjEwL2VudW1zO2VudW1z",
            "ogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjEwLkVudW1zygIeR29v",
            "Z2xlXEFkc1xHb29nbGVBZHNcVjEwXEVudW1z6gIiR29vZ2xlOjpBZHM6Okdv",
            "b2dsZUFkczo6VjEwOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Enums.CustomerPayPerConversionEligibilityFailureReasonEnum), global::Google.Ads.GoogleAds.V10.Enums.CustomerPayPerConversionEligibilityFailureReasonEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Enums.CustomerPayPerConversionEligibilityFailureReasonEnum.Types.CustomerPayPerConversionEligibilityFailureReason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing reasons why a customer is not eligible to use
  /// PaymentMode.CONVERSIONS.
  /// </summary>
  public sealed partial class CustomerPayPerConversionEligibilityFailureReasonEnum : pb::IMessage<CustomerPayPerConversionEligibilityFailureReasonEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerPayPerConversionEligibilityFailureReasonEnum> _parser = new pb::MessageParser<CustomerPayPerConversionEligibilityFailureReasonEnum>(() => new CustomerPayPerConversionEligibilityFailureReasonEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerPayPerConversionEligibilityFailureReasonEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Enums.CustomerPayPerConversionEligibilityFailureReasonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerPayPerConversionEligibilityFailureReasonEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerPayPerConversionEligibilityFailureReasonEnum(CustomerPayPerConversionEligibilityFailureReasonEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerPayPerConversionEligibilityFailureReasonEnum Clone() {
      return new CustomerPayPerConversionEligibilityFailureReasonEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerPayPerConversionEligibilityFailureReasonEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerPayPerConversionEligibilityFailureReasonEnum other) {
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
    public void MergeFrom(CustomerPayPerConversionEligibilityFailureReasonEnum other) {
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
    /// <summary>Container for nested types declared in the CustomerPayPerConversionEligibilityFailureReasonEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible reasons a customer is not eligible to use
      /// PaymentMode.CONVERSIONS.
      /// </summary>
      public enum CustomerPayPerConversionEligibilityFailureReason {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Customer does not have enough conversions.
        /// </summary>
        [pbr::OriginalName("NOT_ENOUGH_CONVERSIONS")] NotEnoughConversions = 2,
        /// <summary>
        /// Customer's conversion lag is too high.
        /// </summary>
        [pbr::OriginalName("CONVERSION_LAG_TOO_HIGH")] ConversionLagTooHigh = 3,
        /// <summary>
        /// Customer uses shared budgets.
        /// </summary>
        [pbr::OriginalName("HAS_CAMPAIGN_WITH_SHARED_BUDGET")] HasCampaignWithSharedBudget = 4,
        /// <summary>
        /// Customer has conversions with ConversionActionType.UPLOAD_CLICKS.
        /// </summary>
        [pbr::OriginalName("HAS_UPLOAD_CLICKS_CONVERSION")] HasUploadClicksConversion = 5,
        /// <summary>
        /// Customer's average daily spend is too high.
        /// </summary>
        [pbr::OriginalName("AVERAGE_DAILY_SPEND_TOO_HIGH")] AverageDailySpendTooHigh = 6,
        /// <summary>
        /// Customer's eligibility has not yet been calculated by the Google Ads
        /// backend. Check back soon.
        /// </summary>
        [pbr::OriginalName("ANALYSIS_NOT_COMPLETE")] AnalysisNotComplete = 7,
        /// <summary>
        /// Customer is not eligible due to other reasons.
        /// </summary>
        [pbr::OriginalName("OTHER")] Other = 8,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
