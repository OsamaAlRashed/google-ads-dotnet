// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v15/enums/bidding_strategy_system_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V15.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v15/enums/bidding_strategy_system_status.proto</summary>
  public static partial class BiddingStrategySystemStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v15/enums/bidding_strategy_system_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BiddingStrategySystemStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNnb29nbGUvYWRzL2dvb2dsZWFkcy92MTUvZW51bXMvYmlkZGluZ19zdHJh",
            "dGVneV9zeXN0ZW1fc3RhdHVzLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52MTUuZW51bXMijQYKH0JpZGRpbmdTdHJhdGVneVN5c3RlbVN0YXR1c0Vu",
            "dW0i6QUKG0JpZGRpbmdTdHJhdGVneVN5c3RlbVN0YXR1cxIPCgtVTlNQRUNJ",
            "RklFRBAAEgsKB1VOS05PV04QARILCgdFTkFCTEVEEAISEAoMTEVBUk5JTkdf",
            "TkVXEAMSGwoXTEVBUk5JTkdfU0VUVElOR19DSEFOR0UQBBIaChZMRUFSTklO",
            "R19CVURHRVRfQ0hBTkdFEAUSHwobTEVBUk5JTkdfQ09NUE9TSVRJT05fQ0hB",
            "TkdFEAYSIwofTEVBUk5JTkdfQ09OVkVSU0lPTl9UWVBFX0NIQU5HRRAHEiYK",
            "IkxFQVJOSU5HX0NPTlZFUlNJT05fU0VUVElOR19DSEFOR0UQCBIeChpMSU1J",
            "VEVEX0JZX0NQQ19CSURfQ0VJTElORxAJEhwKGExJTUlURURfQllfQ1BDX0JJ",
            "RF9GTE9PUhAKEhMKD0xJTUlURURfQllfREFUQRALEhUKEUxJTUlURURfQllf",
            "QlVER0VUEAwSIQodTElNSVRFRF9CWV9MT1dfUFJJT1JJVFlfU1BFTkQQDRIa",
            "ChZMSU1JVEVEX0JZX0xPV19RVUFMSVRZEA4SGAoUTElNSVRFRF9CWV9JTlZF",
            "TlRPUlkQDxIiCh5NSVNDT05GSUdVUkVEX1pFUk9fRUxJR0lCSUxJVFkQEBIi",
            "Ch5NSVNDT05GSUdVUkVEX0NPTlZFUlNJT05fVFlQRVMQERIlCiFNSVNDT05G",
            "SUdVUkVEX0NPTlZFUlNJT05fU0VUVElOR1MQEhIfChtNSVNDT05GSUdVUkVE",
            "X1NIQVJFRF9CVURHRVQQExIfChtNSVNDT05GSUdVUkVEX1NUUkFURUdZX1RZ",
            "UEUQFBIKCgZQQVVTRUQQFRIPCgtVTkFWQUlMQUJMRRAWEhUKEU1VTFRJUExF",
            "X0xFQVJOSU5HEBcSFAoQTVVMVElQTEVfTElNSVRFRBAYEhoKFk1VTFRJUExF",
            "X01JU0NPTkZJR1VSRUQQGRIMCghNVUxUSVBMRRAaQvoBCiJjb20uZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjE1LmVudW1zQiBCaWRkaW5nU3RyYXRlZ3lTeXN0",
            "ZW1TdGF0dXNQcm90b1ABWkNnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9n",
            "b29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjE1L2VudW1zO2VudW1zogIDR0FB",
            "qgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjE1LkVudW1zygIeR29vZ2xlXEFk",
            "c1xHb29nbGVBZHNcVjE1XEVudW1z6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFk",
            "czo6VjE1OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V15.Enums.BiddingStrategySystemStatusEnum), global::Google.Ads.GoogleAds.V15.Enums.BiddingStrategySystemStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V15.Enums.BiddingStrategySystemStatusEnum.Types.BiddingStrategySystemStatus) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Message describing BiddingStrategy system statuses.
  /// </summary>
  public sealed partial class BiddingStrategySystemStatusEnum : pb::IMessage<BiddingStrategySystemStatusEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BiddingStrategySystemStatusEnum> _parser = new pb::MessageParser<BiddingStrategySystemStatusEnum>(() => new BiddingStrategySystemStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BiddingStrategySystemStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V15.Enums.BiddingStrategySystemStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BiddingStrategySystemStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BiddingStrategySystemStatusEnum(BiddingStrategySystemStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BiddingStrategySystemStatusEnum Clone() {
      return new BiddingStrategySystemStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BiddingStrategySystemStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BiddingStrategySystemStatusEnum other) {
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
    public void MergeFrom(BiddingStrategySystemStatusEnum other) {
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
    /// <summary>Container for nested types declared in the BiddingStrategySystemStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The possible system statuses of a BiddingStrategy.
      /// </summary>
      public enum BiddingStrategySystemStatus {
        /// <summary>
        /// Signals that an unexpected error occurred, for example, no bidding
        /// strategy type was found, or no status information was found.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The bid strategy is active, and AdWords cannot find any specific issues
        /// with the strategy.
        /// </summary>
        [pbr::OriginalName("ENABLED")] Enabled = 2,
        /// <summary>
        /// The bid strategy is learning because it has been recently created or
        /// recently reactivated.
        /// </summary>
        [pbr::OriginalName("LEARNING_NEW")] LearningNew = 3,
        /// <summary>
        /// The bid strategy is learning because of a recent setting change.
        /// </summary>
        [pbr::OriginalName("LEARNING_SETTING_CHANGE")] LearningSettingChange = 4,
        /// <summary>
        /// The bid strategy is learning because of a recent budget change.
        /// </summary>
        [pbr::OriginalName("LEARNING_BUDGET_CHANGE")] LearningBudgetChange = 5,
        /// <summary>
        /// The bid strategy is learning because of recent change in number of
        /// campaigns, ad groups or keywords attached to it.
        /// </summary>
        [pbr::OriginalName("LEARNING_COMPOSITION_CHANGE")] LearningCompositionChange = 6,
        /// <summary>
        /// The bid strategy depends on conversion reporting and the customer
        /// recently modified conversion types that were relevant to the
        /// bid strategy.
        /// </summary>
        [pbr::OriginalName("LEARNING_CONVERSION_TYPE_CHANGE")] LearningConversionTypeChange = 7,
        /// <summary>
        /// The bid strategy depends on conversion reporting and the customer
        /// recently changed their conversion settings.
        /// </summary>
        [pbr::OriginalName("LEARNING_CONVERSION_SETTING_CHANGE")] LearningConversionSettingChange = 8,
        /// <summary>
        /// The bid strategy is limited by its bid ceiling.
        /// </summary>
        [pbr::OriginalName("LIMITED_BY_CPC_BID_CEILING")] LimitedByCpcBidCeiling = 9,
        /// <summary>
        /// The bid strategy is limited by its bid floor.
        /// </summary>
        [pbr::OriginalName("LIMITED_BY_CPC_BID_FLOOR")] LimitedByCpcBidFloor = 10,
        /// <summary>
        /// The bid strategy is limited because there was not enough conversion
        /// traffic over the past weeks.
        /// </summary>
        [pbr::OriginalName("LIMITED_BY_DATA")] LimitedByData = 11,
        /// <summary>
        /// A significant fraction of keywords in this bid strategy are limited by
        /// budget.
        /// </summary>
        [pbr::OriginalName("LIMITED_BY_BUDGET")] LimitedByBudget = 12,
        /// <summary>
        /// The bid strategy cannot reach its target spend because its spend has
        /// been de-prioritized.
        /// </summary>
        [pbr::OriginalName("LIMITED_BY_LOW_PRIORITY_SPEND")] LimitedByLowPrioritySpend = 13,
        /// <summary>
        /// A significant fraction of keywords in this bid strategy have a low
        /// Quality Score.
        /// </summary>
        [pbr::OriginalName("LIMITED_BY_LOW_QUALITY")] LimitedByLowQuality = 14,
        /// <summary>
        /// The bid strategy cannot fully spend its budget because of narrow
        /// targeting.
        /// </summary>
        [pbr::OriginalName("LIMITED_BY_INVENTORY")] LimitedByInventory = 15,
        /// <summary>
        /// Missing conversion tracking (no pings present) and/or remarketing lists
        /// for SSC.
        /// </summary>
        [pbr::OriginalName("MISCONFIGURED_ZERO_ELIGIBILITY")] MisconfiguredZeroEligibility = 16,
        /// <summary>
        /// The bid strategy depends on conversion reporting and the customer is
        /// lacking conversion types that might be reported against this strategy.
        /// </summary>
        [pbr::OriginalName("MISCONFIGURED_CONVERSION_TYPES")] MisconfiguredConversionTypes = 17,
        /// <summary>
        /// The bid strategy depends on conversion reporting and the customer's
        /// conversion settings are misconfigured.
        /// </summary>
        [pbr::OriginalName("MISCONFIGURED_CONVERSION_SETTINGS")] MisconfiguredConversionSettings = 18,
        /// <summary>
        /// There are campaigns outside the bid strategy that share budgets with
        /// campaigns included in the strategy.
        /// </summary>
        [pbr::OriginalName("MISCONFIGURED_SHARED_BUDGET")] MisconfiguredSharedBudget = 19,
        /// <summary>
        /// The campaign has an invalid strategy type and is not serving.
        /// </summary>
        [pbr::OriginalName("MISCONFIGURED_STRATEGY_TYPE")] MisconfiguredStrategyType = 20,
        /// <summary>
        /// The bid strategy is not active. Either there are no active campaigns,
        /// ad groups or keywords attached to the bid strategy. Or there are no
        /// active budgets connected to the bid strategy.
        /// </summary>
        [pbr::OriginalName("PAUSED")] Paused = 21,
        /// <summary>
        /// This bid strategy currently does not support status reporting.
        /// </summary>
        [pbr::OriginalName("UNAVAILABLE")] Unavailable = 22,
        /// <summary>
        /// There were multiple LEARNING_* system statuses for this bid strategy
        /// during the time in question.
        /// </summary>
        [pbr::OriginalName("MULTIPLE_LEARNING")] MultipleLearning = 23,
        /// <summary>
        /// There were multiple LIMITED_* system statuses for this bid strategy
        /// during the time in question.
        /// </summary>
        [pbr::OriginalName("MULTIPLE_LIMITED")] MultipleLimited = 24,
        /// <summary>
        /// There were multiple MISCONFIGURED_* system statuses for this bid strategy
        /// during the time in question.
        /// </summary>
        [pbr::OriginalName("MULTIPLE_MISCONFIGURED")] MultipleMisconfigured = 25,
        /// <summary>
        /// There were multiple system statuses for this bid strategy during the
        /// time in question.
        /// </summary>
        [pbr::OriginalName("MULTIPLE")] Multiple = 26,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
