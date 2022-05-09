// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/resources/paid_organic_search_term_view.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/resources/paid_organic_search_term_view.proto</summary>
  public static partial class PaidOrganicSearchTermViewReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/resources/paid_organic_search_term_view.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PaidOrganicSearchTermViewReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9yZXNvdXJjZXMvcGFpZF9vcmdh",
            "bmljX3NlYXJjaF90ZXJtX3ZpZXcucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnY5LnJlc291cmNlcxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5w",
            "cm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byK9AgoZUGFpZE9yZ2Fu",
            "aWNTZWFyY2hUZXJtVmlldxJRCg1yZXNvdXJjZV9uYW1lGAEgASgJQjrgQQP6",
            "QTQKMmdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9QYWlkT3JnYW5pY1NlYXJj",
            "aFRlcm1WaWV3Eh0KC3NlYXJjaF90ZXJtGAMgASgJQgPgQQNIAIgBATqdAepB",
            "mQEKMmdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9QYWlkT3JnYW5pY1NlYXJj",
            "aFRlcm1WaWV3EmNjdXN0b21lcnMve2N1c3RvbWVyX2lkfS9wYWlkT3JnYW5p",
            "Y1NlYXJjaFRlcm1WaWV3cy97Y2FtcGFpZ25faWR9fnthZF9ncm91cF9pZH1+",
            "e2Jhc2U2NF9zZWFyY2hfdGVybX1CDgoMX3NlYXJjaF90ZXJtQosCCiVjb20u",
            "Z29vZ2xlLmFkcy5nb29nbGVhZHMudjkucmVzb3VyY2VzQh5QYWlkT3JnYW5p",
            "Y1NlYXJjaFRlcm1WaWV3UHJvdG9QAVpKZ29vZ2xlLmdvbGFuZy5vcmcvZ2Vu",
            "cHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y5L3Jlc291cmNlczty",
            "ZXNvdXJjZXOiAgNHQUGqAiFHb29nbGUuQWRzLkdvb2dsZUFkcy5WOS5SZXNv",
            "dXJjZXPKAiFHb29nbGVcQWRzXEdvb2dsZUFkc1xWOVxSZXNvdXJjZXPqAiVH",
            "b29nbGU6OkFkczo6R29vZ2xlQWRzOjpWOTo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Resources.PaidOrganicSearchTermView), global::Google.Ads.GoogleAds.V9.Resources.PaidOrganicSearchTermView.Parser, new[]{ "ResourceName", "SearchTerm" }, new[]{ "SearchTerm" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A paid organic search term view providing a view of search stats across
  /// ads and organic listings aggregated by search term at the ad group level.
  /// </summary>
  public sealed partial class PaidOrganicSearchTermView : pb::IMessage<PaidOrganicSearchTermView>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PaidOrganicSearchTermView> _parser = new pb::MessageParser<PaidOrganicSearchTermView>(() => new PaidOrganicSearchTermView());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PaidOrganicSearchTermView> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Resources.PaidOrganicSearchTermViewReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PaidOrganicSearchTermView() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PaidOrganicSearchTermView(PaidOrganicSearchTermView other) : this() {
      resourceName_ = other.resourceName_;
      searchTerm_ = other.searchTerm_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PaidOrganicSearchTermView Clone() {
      return new PaidOrganicSearchTermView(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the search term view.
    /// Search term view resource names have the form:
    ///
    /// `customers/{customer_id}/paidOrganicSearchTermViews/{campaign_id}~
    /// {ad_group_id}~{URL-base64 search term}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "search_term" field.</summary>
    public const int SearchTermFieldNumber = 3;
    private string searchTerm_;
    /// <summary>
    /// Output only. The search term.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SearchTerm {
      get { return searchTerm_ ?? ""; }
      set {
        searchTerm_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "search_term" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasSearchTerm {
      get { return searchTerm_ != null; }
    }
    /// <summary>Clears the value of the "search_term" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearSearchTerm() {
      searchTerm_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PaidOrganicSearchTermView);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PaidOrganicSearchTermView other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (SearchTerm != other.SearchTerm) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasSearchTerm) hash ^= SearchTerm.GetHashCode();
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
      if (HasSearchTerm) {
        output.WriteRawTag(26);
        output.WriteString(SearchTerm);
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
      if (HasSearchTerm) {
        output.WriteRawTag(26);
        output.WriteString(SearchTerm);
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
      if (HasSearchTerm) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SearchTerm);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PaidOrganicSearchTermView other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasSearchTerm) {
        SearchTerm = other.SearchTerm;
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
          case 26: {
            SearchTerm = input.ReadString();
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
          case 26: {
            SearchTerm = input.ReadString();
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
