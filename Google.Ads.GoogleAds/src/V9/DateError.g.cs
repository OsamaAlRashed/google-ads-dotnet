// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/errors/date_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/errors/date_error.proto</summary>
  public static partial class DateErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/errors/date_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DateErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvYWRzL2dvb2dsZWFkcy92OS9lcnJvcnMvZGF0ZV9lcnJvci5w",
            "cm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkuZXJyb3JzIr8DCg1EYXRl",
            "RXJyb3JFbnVtIq0DCglEYXRlRXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdV",
            "TktOT1dOEAESIAocSU5WQUxJRF9GSUVMRF9WQUxVRVNfSU5fREFURRACEiUK",
            "IUlOVkFMSURfRklFTERfVkFMVUVTX0lOX0RBVEVfVElNRRADEhcKE0lOVkFM",
            "SURfU1RSSU5HX0RBVEUQBBIjCh9JTlZBTElEX1NUUklOR19EQVRFX1RJTUVf",
            "TUlDUk9TEAYSJAogSU5WQUxJRF9TVFJJTkdfREFURV9USU1FX1NFQ09ORFMQ",
            "CxIwCixJTlZBTElEX1NUUklOR19EQVRFX1RJTUVfU0VDT05EU19XSVRIX09G",
            "RlNFVBAMEh0KGUVBUkxJRVJfVEhBTl9NSU5JTVVNX0RBVEUQBxIbChdMQVRF",
            "Ul9USEFOX01BWElNVU1fREFURRAIEjMKL0RBVEVfUkFOR0VfTUlOSU1VTV9E",
            "QVRFX0xBVEVSX1RIQU5fTUFYSU1VTV9EQVRFEAkSMgouREFURV9SQU5HRV9N",
            "SU5JTVVNX0FORF9NQVhJTVVNX0RBVEVTX0JPVEhfTlVMTBAKQukBCiJjb20u",
            "Z29vZ2xlLmFkcy5nb29nbGVhZHMudjkuZXJyb3JzQg5EYXRlRXJyb3JQcm90",
            "b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fk",
            "cy9nb29nbGVhZHMvdjkvZXJyb3JzO2Vycm9yc6ICA0dBQaoCHkdvb2dsZS5B",
            "ZHMuR29vZ2xlQWRzLlY5LkVycm9yc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRz",
            "XFY5XEVycm9yc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY5OjpFcnJv",
            "cnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Errors.DateErrorEnum), global::Google.Ads.GoogleAds.V9.Errors.DateErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V9.Errors.DateErrorEnum.Types.DateError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible date errors.
  /// </summary>
  public sealed partial class DateErrorEnum : pb::IMessage<DateErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DateErrorEnum> _parser = new pb::MessageParser<DateErrorEnum>(() => new DateErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DateErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Errors.DateErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DateErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DateErrorEnum(DateErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DateErrorEnum Clone() {
      return new DateErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DateErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DateErrorEnum other) {
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
    public void MergeFrom(DateErrorEnum other) {
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
    /// <summary>Container for nested types declared in the DateErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible date errors.
      /// </summary>
      public enum DateError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Given field values do not correspond to a valid date.
        /// </summary>
        [pbr::OriginalName("INVALID_FIELD_VALUES_IN_DATE")] InvalidFieldValuesInDate = 2,
        /// <summary>
        /// Given field values do not correspond to a valid date time.
        /// </summary>
        [pbr::OriginalName("INVALID_FIELD_VALUES_IN_DATE_TIME")] InvalidFieldValuesInDateTime = 3,
        /// <summary>
        /// The string date's format should be yyyy-mm-dd.
        /// </summary>
        [pbr::OriginalName("INVALID_STRING_DATE")] InvalidStringDate = 4,
        /// <summary>
        /// The string date time's format should be yyyy-mm-dd hh:mm:ss.ssssss.
        /// </summary>
        [pbr::OriginalName("INVALID_STRING_DATE_TIME_MICROS")] InvalidStringDateTimeMicros = 6,
        /// <summary>
        /// The string date time's format should be yyyy-mm-dd hh:mm:ss.
        /// </summary>
        [pbr::OriginalName("INVALID_STRING_DATE_TIME_SECONDS")] InvalidStringDateTimeSeconds = 11,
        /// <summary>
        /// The string date time's format should be yyyy-mm-dd hh:mm:ss+|-hh:mm.
        /// </summary>
        [pbr::OriginalName("INVALID_STRING_DATE_TIME_SECONDS_WITH_OFFSET")] InvalidStringDateTimeSecondsWithOffset = 12,
        /// <summary>
        /// Date is before allowed minimum.
        /// </summary>
        [pbr::OriginalName("EARLIER_THAN_MINIMUM_DATE")] EarlierThanMinimumDate = 7,
        /// <summary>
        /// Date is after allowed maximum.
        /// </summary>
        [pbr::OriginalName("LATER_THAN_MAXIMUM_DATE")] LaterThanMaximumDate = 8,
        /// <summary>
        /// Date range bounds are not in order.
        /// </summary>
        [pbr::OriginalName("DATE_RANGE_MINIMUM_DATE_LATER_THAN_MAXIMUM_DATE")] DateRangeMinimumDateLaterThanMaximumDate = 9,
        /// <summary>
        /// Both dates in range are null.
        /// </summary>
        [pbr::OriginalName("DATE_RANGE_MINIMUM_AND_MAXIMUM_DATES_BOTH_NULL")] DateRangeMinimumAndMaximumDatesBothNull = 10,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
