// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v17/resources/offline_conversion_upload_conversion_action_summary.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V17.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v17/resources/offline_conversion_upload_conversion_action_summary.proto</summary>
  public static partial class OfflineConversionUploadConversionActionSummaryReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v17/resources/offline_conversion_upload_conversion_action_summary.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OfflineConversionUploadConversionActionSummaryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Clxnb29nbGUvYWRzL2dvb2dsZWFkcy92MTcvcmVzb3VyY2VzL29mZmxpbmVf",
            "Y29udmVyc2lvbl91cGxvYWRfY29udmVyc2lvbl9hY3Rpb25fc3VtbWFyeS5w",
            "cm90bxIiZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE3LnJlc291cmNlcxpOZ29v",
            "Z2xlL2Fkcy9nb29nbGVhZHMvdjE3L2VudW1zL29mZmxpbmVfY29udmVyc2lv",
            "bl9kaWFnbm9zdGljX3N0YXR1c19lbnVtLnByb3RvGkVnb29nbGUvYWRzL2dv",
            "b2dsZWFkcy92MTcvZW51bXMvb2ZmbGluZV9ldmVudF91cGxvYWRfY2xpZW50",
            "X2VudW0ucHJvdG8aUWdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxNy9yZXNvdXJj",
            "ZXMvb2ZmbGluZV9jb252ZXJzaW9uX3VwbG9hZF9jbGllbnRfc3VtbWFyeS5w",
            "cm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xl",
            "L2FwaS9yZXNvdXJjZS5wcm90byKUCAouT2ZmbGluZUNvbnZlcnNpb25VcGxv",
            "YWRDb252ZXJzaW9uQWN0aW9uU3VtbWFyeRJmCg1yZXNvdXJjZV9uYW1lGAEg",
            "ASgJQk/gQQP6QUkKR2dvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9PZmZsaW5l",
            "Q29udmVyc2lvblVwbG9hZENvbnZlcnNpb25BY3Rpb25TdW1tYXJ5EmoKBmNs",
            "aWVudBgCIAEoDjJVLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNy5lbnVtcy5P",
            "ZmZsaW5lRXZlbnRVcGxvYWRDbGllbnRFbnVtLk9mZmxpbmVFdmVudFVwbG9h",
            "ZENsaWVudEID4EEDEiEKFGNvbnZlcnNpb25fYWN0aW9uX2lkGAMgASgDQgPg",
            "QQMSIwoWY29udmVyc2lvbl9hY3Rpb25fbmFtZRgEIAEoCUID4EEDEnwKBnN0",
            "YXR1cxgFIAEoDjJnLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNy5lbnVtcy5P",
            "ZmZsaW5lQ29udmVyc2lvbkRpYWdub3N0aWNTdGF0dXNFbnVtLk9mZmxpbmVD",
            "b252ZXJzaW9uRGlhZ25vc3RpY1N0YXR1c0ID4EEDEh4KEXRvdGFsX2V2ZW50",
            "X2NvdW50GAYgASgDQgPgQQMSIwoWc3VjY2Vzc2Z1bF9ldmVudF9jb3VudBgH",
            "IAEoA0ID4EEDEiAKE3BlbmRpbmdfZXZlbnRfY291bnQYCCABKANCA+BBAxIi",
            "ChVsYXN0X3VwbG9hZF9kYXRlX3RpbWUYCSABKAlCA+BBAxJaCg9kYWlseV9z",
            "dW1tYXJpZXMYCiADKAsyPC5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTcucmVz",
            "b3VyY2VzLk9mZmxpbmVDb252ZXJzaW9uU3VtbWFyeUID4EEDElgKDWpvYl9z",
            "dW1tYXJpZXMYCyADKAsyPC5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTcucmVz",
            "b3VyY2VzLk9mZmxpbmVDb252ZXJzaW9uU3VtbWFyeUID4EEDEk8KBmFsZXJ0",
            "cxgMIAMoCzI6Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNy5yZXNvdXJjZXMu",
            "T2ZmbGluZUNvbnZlcnNpb25BbGVydEID4EEDOrUB6kGxAQpHZ29vZ2xlYWRz",
            "Lmdvb2dsZWFwaXMuY29tL09mZmxpbmVDb252ZXJzaW9uVXBsb2FkQ29udmVy",
            "c2lvbkFjdGlvblN1bW1hcnkSZmN1c3RvbWVycy97Y3VzdG9tZXJfaWR9L29m",
            "ZmxpbmVDb252ZXJzaW9uVXBsb2FkQ29udmVyc2lvbkFjdGlvblN1bW1hcmll",
            "cy97Y29udmVyc2lvbl90eXBlX2lkfX57Y2xpZW50fUKlAgomY29tLmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnYxNy5yZXNvdXJjZXNCM09mZmxpbmVDb252ZXJz",
            "aW9uVXBsb2FkQ29udmVyc2lvbkFjdGlvblN1bW1hcnlQcm90b1ABWktnb29n",
            "bGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVh",
            "ZHMvdjE3L3Jlc291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiJHb29nbGUuQWRz",
            "Lkdvb2dsZUFkcy5WMTcuUmVzb3VyY2VzygIiR29vZ2xlXEFkc1xHb29nbGVB",
            "ZHNcVjE3XFJlc291cmNlc+oCJkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYx",
            "Nzo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V17.Enums.OfflineConversionDiagnosticStatusEnumReflection.Descriptor, global::Google.Ads.GoogleAds.V17.Enums.OfflineEventUploadClientEnumReflection.Descriptor, global::Google.Ads.GoogleAds.V17.Resources.OfflineConversionUploadClientSummaryReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V17.Resources.OfflineConversionUploadConversionActionSummary), global::Google.Ads.GoogleAds.V17.Resources.OfflineConversionUploadConversionActionSummary.Parser, new[]{ "ResourceName", "Client", "ConversionActionId", "ConversionActionName", "Status", "TotalEventCount", "SuccessfulEventCount", "PendingEventCount", "LastUploadDateTime", "DailySummaries", "JobSummaries", "Alerts" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Offline conversion upload summary at conversion action level.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class OfflineConversionUploadConversionActionSummary : pb::IMessage<OfflineConversionUploadConversionActionSummary>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OfflineConversionUploadConversionActionSummary> _parser = new pb::MessageParser<OfflineConversionUploadConversionActionSummary>(() => new OfflineConversionUploadConversionActionSummary());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OfflineConversionUploadConversionActionSummary> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V17.Resources.OfflineConversionUploadConversionActionSummaryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflineConversionUploadConversionActionSummary() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflineConversionUploadConversionActionSummary(OfflineConversionUploadConversionActionSummary other) : this() {
      resourceName_ = other.resourceName_;
      client_ = other.client_;
      conversionActionId_ = other.conversionActionId_;
      conversionActionName_ = other.conversionActionName_;
      status_ = other.status_;
      totalEventCount_ = other.totalEventCount_;
      successfulEventCount_ = other.successfulEventCount_;
      pendingEventCount_ = other.pendingEventCount_;
      lastUploadDateTime_ = other.lastUploadDateTime_;
      dailySummaries_ = other.dailySummaries_.Clone();
      jobSummaries_ = other.jobSummaries_.Clone();
      alerts_ = other.alerts_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflineConversionUploadConversionActionSummary Clone() {
      return new OfflineConversionUploadConversionActionSummary(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the offline conversion upload summary at
    /// conversion action level. Offline conversion upload conversion action
    /// summary resource names have the form:
    ///
    /// `customers/{customer_id}/offlineConversionUploadConversionActionSummaries/{conversion_action_id}~{client}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client" field.</summary>
    public const int ClientFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V17.Enums.OfflineEventUploadClientEnum.Types.OfflineEventUploadClient client_ = global::Google.Ads.GoogleAds.V17.Enums.OfflineEventUploadClientEnum.Types.OfflineEventUploadClient.Unspecified;
    /// <summary>
    /// Output only. Client type of the upload event.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V17.Enums.OfflineEventUploadClientEnum.Types.OfflineEventUploadClient Client {
      get { return client_; }
      set {
        client_ = value;
      }
    }

    /// <summary>Field number for the "conversion_action_id" field.</summary>
    public const int ConversionActionIdFieldNumber = 3;
    private long conversionActionId_;
    /// <summary>
    /// Output only. Conversion action id.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long ConversionActionId {
      get { return conversionActionId_; }
      set {
        conversionActionId_ = value;
      }
    }

    /// <summary>Field number for the "conversion_action_name" field.</summary>
    public const int ConversionActionNameFieldNumber = 4;
    private string conversionActionName_ = "";
    /// <summary>
    /// Output only. The name of the conversion action.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ConversionActionName {
      get { return conversionActionName_; }
      set {
        conversionActionName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V17.Enums.OfflineConversionDiagnosticStatusEnum.Types.OfflineConversionDiagnosticStatus status_ = global::Google.Ads.GoogleAds.V17.Enums.OfflineConversionDiagnosticStatusEnum.Types.OfflineConversionDiagnosticStatus.Unspecified;
    /// <summary>
    /// Output only. Overall status for offline conversion upload conversion action
    /// summary. Status is generated from most recent calendar day with upload
    /// stats.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V17.Enums.OfflineConversionDiagnosticStatusEnum.Types.OfflineConversionDiagnosticStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "total_event_count" field.</summary>
    public const int TotalEventCountFieldNumber = 6;
    private long totalEventCount_;
    /// <summary>
    /// Output only. Total count of uploaded events.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long TotalEventCount {
      get { return totalEventCount_; }
      set {
        totalEventCount_ = value;
      }
    }

    /// <summary>Field number for the "successful_event_count" field.</summary>
    public const int SuccessfulEventCountFieldNumber = 7;
    private long successfulEventCount_;
    /// <summary>
    /// Output only. Total count of successful uploaded events.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long SuccessfulEventCount {
      get { return successfulEventCount_; }
      set {
        successfulEventCount_ = value;
      }
    }

    /// <summary>Field number for the "pending_event_count" field.</summary>
    public const int PendingEventCountFieldNumber = 8;
    private long pendingEventCount_;
    /// <summary>
    /// Output only. Total count of pending uploaded events.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long PendingEventCount {
      get { return pendingEventCount_; }
      set {
        pendingEventCount_ = value;
      }
    }

    /// <summary>Field number for the "last_upload_date_time" field.</summary>
    public const int LastUploadDateTimeFieldNumber = 9;
    private string lastUploadDateTime_ = "";
    /// <summary>
    /// Output only. Date for the latest upload batch. The format is "yyyy-mm-dd
    /// hh:mm:ss", and it's in the time zone of the Google Ads account.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LastUploadDateTime {
      get { return lastUploadDateTime_; }
      set {
        lastUploadDateTime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "daily_summaries" field.</summary>
    public const int DailySummariesFieldNumber = 10;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V17.Resources.OfflineConversionSummary> _repeated_dailySummaries_codec
        = pb::FieldCodec.ForMessage(82, global::Google.Ads.GoogleAds.V17.Resources.OfflineConversionSummary.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V17.Resources.OfflineConversionSummary> dailySummaries_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V17.Resources.OfflineConversionSummary>();
    /// <summary>
    /// Output only. Summary of history stats by last N days.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V17.Resources.OfflineConversionSummary> DailySummaries {
      get { return dailySummaries_; }
    }

    /// <summary>Field number for the "job_summaries" field.</summary>
    public const int JobSummariesFieldNumber = 11;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V17.Resources.OfflineConversionSummary> _repeated_jobSummaries_codec
        = pb::FieldCodec.ForMessage(90, global::Google.Ads.GoogleAds.V17.Resources.OfflineConversionSummary.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V17.Resources.OfflineConversionSummary> jobSummaries_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V17.Resources.OfflineConversionSummary>();
    /// <summary>
    /// Output only. Summary of history stats by last N jobs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V17.Resources.OfflineConversionSummary> JobSummaries {
      get { return jobSummaries_; }
    }

    /// <summary>Field number for the "alerts" field.</summary>
    public const int AlertsFieldNumber = 12;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V17.Resources.OfflineConversionAlert> _repeated_alerts_codec
        = pb::FieldCodec.ForMessage(98, global::Google.Ads.GoogleAds.V17.Resources.OfflineConversionAlert.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V17.Resources.OfflineConversionAlert> alerts_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V17.Resources.OfflineConversionAlert>();
    /// <summary>
    /// Output only. Details for each error code. Alerts are generated from most
    /// recent calendar day with upload stats.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V17.Resources.OfflineConversionAlert> Alerts {
      get { return alerts_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OfflineConversionUploadConversionActionSummary);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OfflineConversionUploadConversionActionSummary other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Client != other.Client) return false;
      if (ConversionActionId != other.ConversionActionId) return false;
      if (ConversionActionName != other.ConversionActionName) return false;
      if (Status != other.Status) return false;
      if (TotalEventCount != other.TotalEventCount) return false;
      if (SuccessfulEventCount != other.SuccessfulEventCount) return false;
      if (PendingEventCount != other.PendingEventCount) return false;
      if (LastUploadDateTime != other.LastUploadDateTime) return false;
      if(!dailySummaries_.Equals(other.dailySummaries_)) return false;
      if(!jobSummaries_.Equals(other.jobSummaries_)) return false;
      if(!alerts_.Equals(other.alerts_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (Client != global::Google.Ads.GoogleAds.V17.Enums.OfflineEventUploadClientEnum.Types.OfflineEventUploadClient.Unspecified) hash ^= Client.GetHashCode();
      if (ConversionActionId != 0L) hash ^= ConversionActionId.GetHashCode();
      if (ConversionActionName.Length != 0) hash ^= ConversionActionName.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V17.Enums.OfflineConversionDiagnosticStatusEnum.Types.OfflineConversionDiagnosticStatus.Unspecified) hash ^= Status.GetHashCode();
      if (TotalEventCount != 0L) hash ^= TotalEventCount.GetHashCode();
      if (SuccessfulEventCount != 0L) hash ^= SuccessfulEventCount.GetHashCode();
      if (PendingEventCount != 0L) hash ^= PendingEventCount.GetHashCode();
      if (LastUploadDateTime.Length != 0) hash ^= LastUploadDateTime.GetHashCode();
      hash ^= dailySummaries_.GetHashCode();
      hash ^= jobSummaries_.GetHashCode();
      hash ^= alerts_.GetHashCode();
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
      if (Client != global::Google.Ads.GoogleAds.V17.Enums.OfflineEventUploadClientEnum.Types.OfflineEventUploadClient.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Client);
      }
      if (ConversionActionId != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(ConversionActionId);
      }
      if (ConversionActionName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ConversionActionName);
      }
      if (Status != global::Google.Ads.GoogleAds.V17.Enums.OfflineConversionDiagnosticStatusEnum.Types.OfflineConversionDiagnosticStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (TotalEventCount != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(TotalEventCount);
      }
      if (SuccessfulEventCount != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(SuccessfulEventCount);
      }
      if (PendingEventCount != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(PendingEventCount);
      }
      if (LastUploadDateTime.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(LastUploadDateTime);
      }
      dailySummaries_.WriteTo(output, _repeated_dailySummaries_codec);
      jobSummaries_.WriteTo(output, _repeated_jobSummaries_codec);
      alerts_.WriteTo(output, _repeated_alerts_codec);
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
      if (Client != global::Google.Ads.GoogleAds.V17.Enums.OfflineEventUploadClientEnum.Types.OfflineEventUploadClient.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Client);
      }
      if (ConversionActionId != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(ConversionActionId);
      }
      if (ConversionActionName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ConversionActionName);
      }
      if (Status != global::Google.Ads.GoogleAds.V17.Enums.OfflineConversionDiagnosticStatusEnum.Types.OfflineConversionDiagnosticStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (TotalEventCount != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(TotalEventCount);
      }
      if (SuccessfulEventCount != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(SuccessfulEventCount);
      }
      if (PendingEventCount != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(PendingEventCount);
      }
      if (LastUploadDateTime.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(LastUploadDateTime);
      }
      dailySummaries_.WriteTo(ref output, _repeated_dailySummaries_codec);
      jobSummaries_.WriteTo(ref output, _repeated_jobSummaries_codec);
      alerts_.WriteTo(ref output, _repeated_alerts_codec);
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
      if (Client != global::Google.Ads.GoogleAds.V17.Enums.OfflineEventUploadClientEnum.Types.OfflineEventUploadClient.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Client);
      }
      if (ConversionActionId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ConversionActionId);
      }
      if (ConversionActionName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ConversionActionName);
      }
      if (Status != global::Google.Ads.GoogleAds.V17.Enums.OfflineConversionDiagnosticStatusEnum.Types.OfflineConversionDiagnosticStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (TotalEventCount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TotalEventCount);
      }
      if (SuccessfulEventCount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(SuccessfulEventCount);
      }
      if (PendingEventCount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(PendingEventCount);
      }
      if (LastUploadDateTime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LastUploadDateTime);
      }
      size += dailySummaries_.CalculateSize(_repeated_dailySummaries_codec);
      size += jobSummaries_.CalculateSize(_repeated_jobSummaries_codec);
      size += alerts_.CalculateSize(_repeated_alerts_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OfflineConversionUploadConversionActionSummary other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.Client != global::Google.Ads.GoogleAds.V17.Enums.OfflineEventUploadClientEnum.Types.OfflineEventUploadClient.Unspecified) {
        Client = other.Client;
      }
      if (other.ConversionActionId != 0L) {
        ConversionActionId = other.ConversionActionId;
      }
      if (other.ConversionActionName.Length != 0) {
        ConversionActionName = other.ConversionActionName;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V17.Enums.OfflineConversionDiagnosticStatusEnum.Types.OfflineConversionDiagnosticStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.TotalEventCount != 0L) {
        TotalEventCount = other.TotalEventCount;
      }
      if (other.SuccessfulEventCount != 0L) {
        SuccessfulEventCount = other.SuccessfulEventCount;
      }
      if (other.PendingEventCount != 0L) {
        PendingEventCount = other.PendingEventCount;
      }
      if (other.LastUploadDateTime.Length != 0) {
        LastUploadDateTime = other.LastUploadDateTime;
      }
      dailySummaries_.Add(other.dailySummaries_);
      jobSummaries_.Add(other.jobSummaries_);
      alerts_.Add(other.alerts_);
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
          case 16: {
            Client = (global::Google.Ads.GoogleAds.V17.Enums.OfflineEventUploadClientEnum.Types.OfflineEventUploadClient) input.ReadEnum();
            break;
          }
          case 24: {
            ConversionActionId = input.ReadInt64();
            break;
          }
          case 34: {
            ConversionActionName = input.ReadString();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V17.Enums.OfflineConversionDiagnosticStatusEnum.Types.OfflineConversionDiagnosticStatus) input.ReadEnum();
            break;
          }
          case 48: {
            TotalEventCount = input.ReadInt64();
            break;
          }
          case 56: {
            SuccessfulEventCount = input.ReadInt64();
            break;
          }
          case 64: {
            PendingEventCount = input.ReadInt64();
            break;
          }
          case 74: {
            LastUploadDateTime = input.ReadString();
            break;
          }
          case 82: {
            dailySummaries_.AddEntriesFrom(input, _repeated_dailySummaries_codec);
            break;
          }
          case 90: {
            jobSummaries_.AddEntriesFrom(input, _repeated_jobSummaries_codec);
            break;
          }
          case 98: {
            alerts_.AddEntriesFrom(input, _repeated_alerts_codec);
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
          case 16: {
            Client = (global::Google.Ads.GoogleAds.V17.Enums.OfflineEventUploadClientEnum.Types.OfflineEventUploadClient) input.ReadEnum();
            break;
          }
          case 24: {
            ConversionActionId = input.ReadInt64();
            break;
          }
          case 34: {
            ConversionActionName = input.ReadString();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V17.Enums.OfflineConversionDiagnosticStatusEnum.Types.OfflineConversionDiagnosticStatus) input.ReadEnum();
            break;
          }
          case 48: {
            TotalEventCount = input.ReadInt64();
            break;
          }
          case 56: {
            SuccessfulEventCount = input.ReadInt64();
            break;
          }
          case 64: {
            PendingEventCount = input.ReadInt64();
            break;
          }
          case 74: {
            LastUploadDateTime = input.ReadString();
            break;
          }
          case 82: {
            dailySummaries_.AddEntriesFrom(ref input, _repeated_dailySummaries_codec);
            break;
          }
          case 90: {
            jobSummaries_.AddEntriesFrom(ref input, _repeated_jobSummaries_codec);
            break;
          }
          case 98: {
            alerts_.AddEntriesFrom(ref input, _repeated_alerts_codec);
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
