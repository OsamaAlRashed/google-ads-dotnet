// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v15/resources/customer_feed.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V15.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v15/resources/customer_feed.proto</summary>
  public static partial class CustomerFeedReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v15/resources/customer_feed.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerFeedReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvYWRzL2dvb2dsZWFkcy92MTUvcmVzb3VyY2VzL2N1c3RvbWVy",
            "X2ZlZWQucHJvdG8SImdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNS5yZXNvdXJj",
            "ZXMaN2dvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxNS9jb21tb24vbWF0Y2hpbmdf",
            "ZnVuY3Rpb24ucHJvdG8aNWdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxNS9lbnVt",
            "cy9mZWVkX2xpbmtfc3RhdHVzLnByb3RvGjVnb29nbGUvYWRzL2dvb2dsZWFk",
            "cy92MTUvZW51bXMvcGxhY2Vob2xkZXJfdHlwZS5wcm90bxofZ29vZ2xlL2Fw",
            "aS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5w",
            "cm90byL6AwoMQ3VzdG9tZXJGZWVkEkQKDXJlc291cmNlX25hbWUYASABKAlC",
            "LeBBBfpBJwolZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0N1c3RvbWVyRmVl",
            "ZBI4CgRmZWVkGAYgASgJQiXgQQX6QR8KHWdvb2dsZWFkcy5nb29nbGVhcGlz",
            "LmNvbS9GZWVkSACIAQESXgoRcGxhY2Vob2xkZXJfdHlwZXMYAyADKA4yQy5n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52MTUuZW51bXMuUGxhY2Vob2xkZXJUeXBl",
            "RW51bS5QbGFjZWhvbGRlclR5cGUSTAoRbWF0Y2hpbmdfZnVuY3Rpb24YBCAB",
            "KAsyMS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTUuY29tbW9uLk1hdGNoaW5n",
            "RnVuY3Rpb24SVgoGc3RhdHVzGAUgASgOMkEuZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjE1LmVudW1zLkZlZWRMaW5rU3RhdHVzRW51bS5GZWVkTGlua1N0YXR1",
            "c0ID4EEDOlvqQVgKJWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DdXN0b21l",
            "ckZlZWQSL2N1c3RvbWVycy97Y3VzdG9tZXJfaWR9L2N1c3RvbWVyRmVlZHMv",
            "e2ZlZWRfaWR9QgcKBV9mZWVkQoMCCiZjb20uZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjE1LnJlc291cmNlc0IRQ3VzdG9tZXJGZWVkUHJvdG9QAVpLZ29vZ2xl",
            "LmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRz",
            "L3YxNS9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIiR29vZ2xlLkFkcy5H",
            "b29nbGVBZHMuVjE1LlJlc291cmNlc8oCIkdvb2dsZVxBZHNcR29vZ2xlQWRz",
            "XFYxNVxSZXNvdXJjZXPqAiZHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTU6",
            "OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V15.Common.MatchingFunctionReflection.Descriptor, global::Google.Ads.GoogleAds.V15.Enums.FeedLinkStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V15.Enums.PlaceholderTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V15.Resources.CustomerFeed), global::Google.Ads.GoogleAds.V15.Resources.CustomerFeed.Parser, new[]{ "ResourceName", "Feed", "PlaceholderTypes", "MatchingFunction", "Status" }, new[]{ "Feed" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A customer feed.
  /// </summary>
  public sealed partial class CustomerFeed : pb::IMessage<CustomerFeed>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerFeed> _parser = new pb::MessageParser<CustomerFeed>(() => new CustomerFeed());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerFeed> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V15.Resources.CustomerFeedReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerFeed() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerFeed(CustomerFeed other) : this() {
      resourceName_ = other.resourceName_;
      feed_ = other.feed_;
      placeholderTypes_ = other.placeholderTypes_.Clone();
      matchingFunction_ = other.matchingFunction_ != null ? other.matchingFunction_.Clone() : null;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerFeed Clone() {
      return new CustomerFeed(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the customer feed.
    /// Customer feed resource names have the form:
    ///
    /// `customers/{customer_id}/customerFeeds/{feed_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "feed" field.</summary>
    public const int FeedFieldNumber = 6;
    private readonly static string FeedDefaultValue = "";

    private string feed_;
    /// <summary>
    /// Immutable. The feed being linked to the customer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Feed {
      get { return feed_ ?? FeedDefaultValue; }
      set {
        feed_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "feed" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasFeed {
      get { return feed_ != null; }
    }
    /// <summary>Clears the value of the "feed" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearFeed() {
      feed_ = null;
    }

    /// <summary>Field number for the "placeholder_types" field.</summary>
    public const int PlaceholderTypesFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V15.Enums.PlaceholderTypeEnum.Types.PlaceholderType> _repeated_placeholderTypes_codec
        = pb::FieldCodec.ForEnum(26, x => (int) x, x => (global::Google.Ads.GoogleAds.V15.Enums.PlaceholderTypeEnum.Types.PlaceholderType) x);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V15.Enums.PlaceholderTypeEnum.Types.PlaceholderType> placeholderTypes_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V15.Enums.PlaceholderTypeEnum.Types.PlaceholderType>();
    /// <summary>
    /// Indicates which placeholder types the feed may populate under the connected
    /// customer. Required.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V15.Enums.PlaceholderTypeEnum.Types.PlaceholderType> PlaceholderTypes {
      get { return placeholderTypes_; }
    }

    /// <summary>Field number for the "matching_function" field.</summary>
    public const int MatchingFunctionFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V15.Common.MatchingFunction matchingFunction_;
    /// <summary>
    /// Matching function associated with the CustomerFeed.
    /// The matching function is used to filter the set of feed items selected.
    /// Required.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V15.Common.MatchingFunction MatchingFunction {
      get { return matchingFunction_; }
      set {
        matchingFunction_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V15.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus status_ = global::Google.Ads.GoogleAds.V15.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus.Unspecified;
    /// <summary>
    /// Output only. Status of the customer feed.
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V15.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerFeed);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerFeed other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Feed != other.Feed) return false;
      if(!placeholderTypes_.Equals(other.placeholderTypes_)) return false;
      if (!object.Equals(MatchingFunction, other.MatchingFunction)) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasFeed) hash ^= Feed.GetHashCode();
      hash ^= placeholderTypes_.GetHashCode();
      if (matchingFunction_ != null) hash ^= MatchingFunction.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V15.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus.Unspecified) hash ^= Status.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      placeholderTypes_.WriteTo(output, _repeated_placeholderTypes_codec);
      if (matchingFunction_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(MatchingFunction);
      }
      if (Status != global::Google.Ads.GoogleAds.V15.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (HasFeed) {
        output.WriteRawTag(50);
        output.WriteString(Feed);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      placeholderTypes_.WriteTo(ref output, _repeated_placeholderTypes_codec);
      if (matchingFunction_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(MatchingFunction);
      }
      if (Status != global::Google.Ads.GoogleAds.V15.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (HasFeed) {
        output.WriteRawTag(50);
        output.WriteString(Feed);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (HasFeed) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Feed);
      }
      size += placeholderTypes_.CalculateSize(_repeated_placeholderTypes_codec);
      if (matchingFunction_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MatchingFunction);
      }
      if (Status != global::Google.Ads.GoogleAds.V15.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomerFeed other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasFeed) {
        Feed = other.Feed;
      }
      placeholderTypes_.Add(other.placeholderTypes_);
      if (other.matchingFunction_ != null) {
        if (matchingFunction_ == null) {
          MatchingFunction = new global::Google.Ads.GoogleAds.V15.Common.MatchingFunction();
        }
        MatchingFunction.MergeFrom(other.MatchingFunction);
      }
      if (other.Status != global::Google.Ads.GoogleAds.V15.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus.Unspecified) {
        Status = other.Status;
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 26:
          case 24: {
            placeholderTypes_.AddEntriesFrom(input, _repeated_placeholderTypes_codec);
            break;
          }
          case 34: {
            if (matchingFunction_ == null) {
              MatchingFunction = new global::Google.Ads.GoogleAds.V15.Common.MatchingFunction();
            }
            input.ReadMessage(MatchingFunction);
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V15.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus) input.ReadEnum();
            break;
          }
          case 50: {
            Feed = input.ReadString();
            break;
          }
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 26:
          case 24: {
            placeholderTypes_.AddEntriesFrom(ref input, _repeated_placeholderTypes_codec);
            break;
          }
          case 34: {
            if (matchingFunction_ == null) {
              MatchingFunction = new global::Google.Ads.GoogleAds.V15.Common.MatchingFunction();
            }
            input.ReadMessage(MatchingFunction);
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V15.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus) input.ReadEnum();
            break;
          }
          case 50: {
            Feed = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
