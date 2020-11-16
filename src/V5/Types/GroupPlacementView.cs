// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v5/resources/group_placement_view.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V5.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v5/resources/group_placement_view.proto</summary>
  public static partial class GroupPlacementViewReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v5/resources/group_placement_view.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GroupPlacementViewReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92NS9yZXNvdXJjZXMvZ3JvdXBfcGxh",
            "Y2VtZW50X3ZpZXcucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY1LnJl",
            "c291cmNlcxoyZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjUvZW51bXMvcGxhY2Vt",
            "ZW50X3R5cGUucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJv",
            "dG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8aHmdvb2dsZS9wcm90b2J1",
            "Zi93cmFwcGVycy5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90",
            "byLWAwoSR3JvdXBQbGFjZW1lbnRWaWV3EkoKDXJlc291cmNlX25hbWUYASAB",
            "KAlCM+BBA/pBLQorZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0dyb3VwUGxh",
            "Y2VtZW50VmlldxI0CglwbGFjZW1lbnQYAiABKAsyHC5nb29nbGUucHJvdG9i",
            "dWYuU3RyaW5nVmFsdWVCA+BBAxI3CgxkaXNwbGF5X25hbWUYAyABKAsyHC5n",
            "b29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWVCA+BBAxI1Cgp0YXJnZXRfdXJs",
            "GAQgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQgPgQQMSWwoO",
            "cGxhY2VtZW50X3R5cGUYBSABKA4yPi5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "NS5lbnVtcy5QbGFjZW1lbnRUeXBlRW51bS5QbGFjZW1lbnRUeXBlQgPgQQM6",
            "cepBbgorZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0dyb3VwUGxhY2VtZW50",
            "VmlldxI/Y3VzdG9tZXJzL3tjdXN0b21lcn0vZ3JvdXBQbGFjZW1lbnRWaWV3",
            "cy97Z3JvdXBfcGxhY2VtZW50X3ZpZXd9QoQCCiVjb20uZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjUucmVzb3VyY2VzQhdHcm91cFBsYWNlbWVudFZpZXdQcm90",
            "b1ABWkpnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fk",
            "cy9nb29nbGVhZHMvdjUvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dBQaoCIUdv",
            "b2dsZS5BZHMuR29vZ2xlQWRzLlY1LlJlc291cmNlc8oCIUdvb2dsZVxBZHNc",
            "R29vZ2xlQWRzXFY1XFJlc291cmNlc+oCJUdvb2dsZTo6QWRzOjpHb29nbGVB",
            "ZHM6OlY1OjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V5.Enums.PlacementTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V5.Resources.GroupPlacementView), global::Google.Ads.GoogleAds.V5.Resources.GroupPlacementView.Parser, new[]{ "ResourceName", "Placement", "DisplayName", "TargetUrl", "PlacementType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A group placement view.
  /// </summary>
  public sealed partial class GroupPlacementView : pb::IMessage<GroupPlacementView>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GroupPlacementView> _parser = new pb::MessageParser<GroupPlacementView>(() => new GroupPlacementView());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GroupPlacementView> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V5.Resources.GroupPlacementViewReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupPlacementView() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupPlacementView(GroupPlacementView other) : this() {
      resourceName_ = other.resourceName_;
      Placement = other.Placement;
      DisplayName = other.DisplayName;
      TargetUrl = other.TargetUrl;
      placementType_ = other.placementType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupPlacementView Clone() {
      return new GroupPlacementView(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the group placement view.
    /// Group placement view resource names have the form:
    ///
    /// `customers/{customer_id}/groupPlacementViews/{ad_group_id}~{base64_placement}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "placement" field.</summary>
    public const int PlacementFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_placement_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string placement_;
    /// <summary>
    /// Output only. The automatic placement string at group level, e. g. web domain, mobile
    /// app ID, or a YouTube channel ID.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Placement {
      get { return placement_; }
      set {
        placement_ = value;
      }
    }


    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_displayName_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string displayName_;
    /// <summary>
    /// Output only. Domain name for websites and YouTube channel name for YouTube channels.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = value;
      }
    }


    /// <summary>Field number for the "target_url" field.</summary>
    public const int TargetUrlFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_targetUrl_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string targetUrl_;
    /// <summary>
    /// Output only. URL of the group placement, e.g. domain, link to the mobile application in
    /// app store, or a YouTube channel URL.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TargetUrl {
      get { return targetUrl_; }
      set {
        targetUrl_ = value;
      }
    }


    /// <summary>Field number for the "placement_type" field.</summary>
    public const int PlacementTypeFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V5.Enums.PlacementTypeEnum.Types.PlacementType placementType_ = global::Google.Ads.GoogleAds.V5.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified;
    /// <summary>
    /// Output only. Type of the placement, e.g. Website, YouTube Channel, Mobile Application.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V5.Enums.PlacementTypeEnum.Types.PlacementType PlacementType {
      get { return placementType_; }
      set {
        placementType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GroupPlacementView);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GroupPlacementView other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Placement != other.Placement) return false;
      if (DisplayName != other.DisplayName) return false;
      if (TargetUrl != other.TargetUrl) return false;
      if (PlacementType != other.PlacementType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (placement_ != null) hash ^= Placement.GetHashCode();
      if (displayName_ != null) hash ^= DisplayName.GetHashCode();
      if (targetUrl_ != null) hash ^= TargetUrl.GetHashCode();
      if (PlacementType != global::Google.Ads.GoogleAds.V5.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified) hash ^= PlacementType.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (placement_ != null) {
        _single_placement_codec.WriteTagAndValue(output, Placement);
      }
      if (displayName_ != null) {
        _single_displayName_codec.WriteTagAndValue(output, DisplayName);
      }
      if (targetUrl_ != null) {
        _single_targetUrl_codec.WriteTagAndValue(output, TargetUrl);
      }
      if (PlacementType != global::Google.Ads.GoogleAds.V5.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) PlacementType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (placement_ != null) {
        _single_placement_codec.WriteTagAndValue(ref output, Placement);
      }
      if (displayName_ != null) {
        _single_displayName_codec.WriteTagAndValue(ref output, DisplayName);
      }
      if (targetUrl_ != null) {
        _single_targetUrl_codec.WriteTagAndValue(ref output, TargetUrl);
      }
      if (PlacementType != global::Google.Ads.GoogleAds.V5.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) PlacementType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (placement_ != null) {
        size += _single_placement_codec.CalculateSizeWithTag(Placement);
      }
      if (displayName_ != null) {
        size += _single_displayName_codec.CalculateSizeWithTag(DisplayName);
      }
      if (targetUrl_ != null) {
        size += _single_targetUrl_codec.CalculateSizeWithTag(TargetUrl);
      }
      if (PlacementType != global::Google.Ads.GoogleAds.V5.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PlacementType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GroupPlacementView other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.placement_ != null) {
        if (placement_ == null || other.Placement != "") {
          Placement = other.Placement;
        }
      }
      if (other.displayName_ != null) {
        if (displayName_ == null || other.DisplayName != "") {
          DisplayName = other.DisplayName;
        }
      }
      if (other.targetUrl_ != null) {
        if (targetUrl_ == null || other.TargetUrl != "") {
          TargetUrl = other.TargetUrl;
        }
      }
      if (other.PlacementType != global::Google.Ads.GoogleAds.V5.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified) {
        PlacementType = other.PlacementType;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
          case 18: {
            string value = _single_placement_codec.Read(input);
            if (placement_ == null || value != "") {
              Placement = value;
            }
            break;
          }
          case 26: {
            string value = _single_displayName_codec.Read(input);
            if (displayName_ == null || value != "") {
              DisplayName = value;
            }
            break;
          }
          case 34: {
            string value = _single_targetUrl_codec.Read(input);
            if (targetUrl_ == null || value != "") {
              TargetUrl = value;
            }
            break;
          }
          case 40: {
            PlacementType = (global::Google.Ads.GoogleAds.V5.Enums.PlacementTypeEnum.Types.PlacementType) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
          case 18: {
            string value = _single_placement_codec.Read(ref input);
            if (placement_ == null || value != "") {
              Placement = value;
            }
            break;
          }
          case 26: {
            string value = _single_displayName_codec.Read(ref input);
            if (displayName_ == null || value != "") {
              DisplayName = value;
            }
            break;
          }
          case 34: {
            string value = _single_targetUrl_codec.Read(ref input);
            if (targetUrl_ == null || value != "") {
              TargetUrl = value;
            }
            break;
          }
          case 40: {
            PlacementType = (global::Google.Ads.GoogleAds.V5.Enums.PlacementTypeEnum.Types.PlacementType) input.ReadEnum();
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