// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v15/errors/media_upload_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V15.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v15/errors/media_upload_error.proto</summary>
  public static partial class MediaUploadErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v15/errors/media_upload_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MediaUploadErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92MTUvZXJyb3JzL21lZGlhX3VwbG9h",
            "ZF9lcnJvci5wcm90bxIfZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE1LmVycm9y",
            "cyL+CAoUTWVkaWFVcGxvYWRFcnJvckVudW0i5QgKEE1lZGlhVXBsb2FkRXJy",
            "b3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESEAoMRklMRV9UT09f",
            "QklHEAISFQoRVU5QQVJTRUFCTEVfSU1BR0UQAxIeChpBTklNQVRFRF9JTUFH",
            "RV9OT1RfQUxMT1dFRBAEEhYKEkZPUk1BVF9OT1RfQUxMT1dFRBAFEhwKGEVY",
            "VEVSTkFMX1VSTF9OT1RfQUxMT1dFRBAGEhkKFUlOVkFMSURfVVJMX1JFRkVS",
            "RU5DRRAHEiYKIk1JU1NJTkdfUFJJTUFSWV9NRURJQV9CVU5ETEVfRU5UUlkQ",
            "CBIaChZBTklNQVRFRF9WSVNVQUxfRUZGRUNUEAkSFgoSQU5JTUFUSU9OX1RP",
            "T19MT05HEAoSHAoYQVNQRUNUX1JBVElPX05PVF9BTExPV0VEEAsSJQohQVVE",
            "SU9fTk9UX0FMTE9XRURfSU5fTUVESUFfQlVORExFEAwSGQoVQ01ZS19KUEVH",
            "X05PVF9BTExPV0VEEA0SFQoRRkxBU0hfTk9UX0FMTE9XRUQQDhIXChNGUkFN",
            "RV9SQVRFX1RPT19ISUdIEA8SLgoqR09PR0xFX1dFQl9ERVNJR05FUl9aSVBf",
            "RklMRV9OT1RfUFVCTElTSEVEEBASHgoaSU1BR0VfQ09OU1RSQUlOVFNfVklP",
            "TEFURUQQERIYChRJTlZBTElEX01FRElBX0JVTkRMRRASEh4KGklOVkFMSURf",
            "TUVESUFfQlVORExFX0VOVFJZEBMSFQoRSU5WQUxJRF9NSU1FX1RZUEUQFBIQ",
            "CgxJTlZBTElEX1BBVEgQFRISCg5MQVlPVVRfUFJPQkxFTRAWEhEKDU1BTEZP",
            "Uk1FRF9VUkwQFxIcChhNRURJQV9CVU5ETEVfTk9UX0FMTE9XRUQQGBIvCitN",
            "RURJQV9CVU5ETEVfTk9UX0NPTVBBVElCTEVfVE9fUFJPRFVDVF9UWVBFEBkS",
            "MQotTUVESUFfQlVORExFX1JFSkVDVEVEX0JZX01VTFRJUExFX0FTU0VUX1NQ",
            "RUNTEBoSIgoeVE9PX01BTllfRklMRVNfSU5fTUVESUFfQlVORExFEBsSLwor",
            "VU5TVVBQT1JURURfR09PR0xFX1dFQl9ERVNJR05FUl9FTlZJUk9OTUVOVBAc",
            "Eh0KGVVOU1VQUE9SVEVEX0hUTUw1X0ZFQVRVUkUQHRIpCiVVUkxfSU5fTUVE",
            "SUFfQlVORExFX05PVF9TU0xfQ09NUExJQU5UEB4SHAoYVklERU9fRklMRV9O",
            "QU1FX1RPT19MT05HEB8SJwojVklERU9fTVVMVElQTEVfRklMRVNfV0lUSF9T",
            "QU1FX05BTUUQIBIlCiFWSURFT19OT1RfQUxMT1dFRF9JTl9NRURJQV9CVU5E",
            "TEUQIRIoCiRDQU5OT1RfVVBMT0FEX01FRElBX1RZUEVfVEhST1VHSF9BUEkQ",
            "IhIaChZESU1FTlNJT05TX05PVF9BTExPV0VEECNC9QEKI2NvbS5nb29nbGUu",
            "YWRzLmdvb2dsZWFkcy52MTUuZXJyb3JzQhVNZWRpYVVwbG9hZEVycm9yUHJv",
            "dG9QAVpFZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9h",
            "ZHMvZ29vZ2xlYWRzL3YxNS9lcnJvcnM7ZXJyb3JzogIDR0FBqgIfR29vZ2xl",
            "LkFkcy5Hb29nbGVBZHMuVjE1LkVycm9yc8oCH0dvb2dsZVxBZHNcR29vZ2xl",
            "QWRzXFYxNVxFcnJvcnPqAiNHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTU6",
            "OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V15.Errors.MediaUploadErrorEnum), global::Google.Ads.GoogleAds.V15.Errors.MediaUploadErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V15.Errors.MediaUploadErrorEnum.Types.MediaUploadError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible media uploading errors.
  /// </summary>
  public sealed partial class MediaUploadErrorEnum : pb::IMessage<MediaUploadErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MediaUploadErrorEnum> _parser = new pb::MessageParser<MediaUploadErrorEnum>(() => new MediaUploadErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MediaUploadErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V15.Errors.MediaUploadErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MediaUploadErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MediaUploadErrorEnum(MediaUploadErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MediaUploadErrorEnum Clone() {
      return new MediaUploadErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MediaUploadErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MediaUploadErrorEnum other) {
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
    public void MergeFrom(MediaUploadErrorEnum other) {
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
    /// <summary>Container for nested types declared in the MediaUploadErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible media uploading errors.
      /// </summary>
      public enum MediaUploadError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The uploaded file is too big.
        /// </summary>
        [pbr::OriginalName("FILE_TOO_BIG")] FileTooBig = 2,
        /// <summary>
        /// Image data is unparseable.
        /// </summary>
        [pbr::OriginalName("UNPARSEABLE_IMAGE")] UnparseableImage = 3,
        /// <summary>
        /// Animated images are not allowed.
        /// </summary>
        [pbr::OriginalName("ANIMATED_IMAGE_NOT_ALLOWED")] AnimatedImageNotAllowed = 4,
        /// <summary>
        /// The image or media bundle format is not allowed.
        /// </summary>
        [pbr::OriginalName("FORMAT_NOT_ALLOWED")] FormatNotAllowed = 5,
        /// <summary>
        /// Cannot reference URL external to the media bundle.
        /// </summary>
        [pbr::OriginalName("EXTERNAL_URL_NOT_ALLOWED")] ExternalUrlNotAllowed = 6,
        /// <summary>
        /// HTML5 ad is trying to reference an asset not in .ZIP file.
        /// </summary>
        [pbr::OriginalName("INVALID_URL_REFERENCE")] InvalidUrlReference = 7,
        /// <summary>
        /// The media bundle contains no primary entry.
        /// </summary>
        [pbr::OriginalName("MISSING_PRIMARY_MEDIA_BUNDLE_ENTRY")] MissingPrimaryMediaBundleEntry = 8,
        /// <summary>
        /// Animation has disallowed visual effects.
        /// </summary>
        [pbr::OriginalName("ANIMATED_VISUAL_EFFECT")] AnimatedVisualEffect = 9,
        /// <summary>
        /// Animation longer than the allowed 30 second limit.
        /// </summary>
        [pbr::OriginalName("ANIMATION_TOO_LONG")] AnimationTooLong = 10,
        /// <summary>
        /// The aspect ratio of the image does not match the expected aspect ratios
        /// provided in the asset spec.
        /// </summary>
        [pbr::OriginalName("ASPECT_RATIO_NOT_ALLOWED")] AspectRatioNotAllowed = 11,
        /// <summary>
        /// Audio files are not allowed in bundle.
        /// </summary>
        [pbr::OriginalName("AUDIO_NOT_ALLOWED_IN_MEDIA_BUNDLE")] AudioNotAllowedInMediaBundle = 12,
        /// <summary>
        /// CMYK jpegs are not supported.
        /// </summary>
        [pbr::OriginalName("CMYK_JPEG_NOT_ALLOWED")] CmykJpegNotAllowed = 13,
        /// <summary>
        /// Flash movies are not allowed.
        /// </summary>
        [pbr::OriginalName("FLASH_NOT_ALLOWED")] FlashNotAllowed = 14,
        /// <summary>
        /// The frame rate of the video is higher than the allowed 5fps.
        /// </summary>
        [pbr::OriginalName("FRAME_RATE_TOO_HIGH")] FrameRateTooHigh = 15,
        /// <summary>
        /// ZIP file from Google Web Designer is not published.
        /// </summary>
        [pbr::OriginalName("GOOGLE_WEB_DESIGNER_ZIP_FILE_NOT_PUBLISHED")] GoogleWebDesignerZipFileNotPublished = 16,
        /// <summary>
        /// Image constraints are violated, but more details (like
        /// DIMENSIONS_NOT_ALLOWED or ASPECT_RATIO_NOT_ALLOWED) can not be provided.
        /// This happens when asset spec contains more than one constraint and
        /// criteria of different constraints are violated.
        /// </summary>
        [pbr::OriginalName("IMAGE_CONSTRAINTS_VIOLATED")] ImageConstraintsViolated = 17,
        /// <summary>
        /// Media bundle data is unrecognizable.
        /// </summary>
        [pbr::OriginalName("INVALID_MEDIA_BUNDLE")] InvalidMediaBundle = 18,
        /// <summary>
        /// There was a problem with one or more of the media bundle entries.
        /// </summary>
        [pbr::OriginalName("INVALID_MEDIA_BUNDLE_ENTRY")] InvalidMediaBundleEntry = 19,
        /// <summary>
        /// The asset has an invalid mime type.
        /// </summary>
        [pbr::OriginalName("INVALID_MIME_TYPE")] InvalidMimeType = 20,
        /// <summary>
        /// The media bundle contains an invalid asset path.
        /// </summary>
        [pbr::OriginalName("INVALID_PATH")] InvalidPath = 21,
        /// <summary>
        /// Image has layout problem.
        /// </summary>
        [pbr::OriginalName("LAYOUT_PROBLEM")] LayoutProblem = 22,
        /// <summary>
        /// An asset had a URL reference that is malformed per RFC 1738 convention.
        /// </summary>
        [pbr::OriginalName("MALFORMED_URL")] MalformedUrl = 23,
        /// <summary>
        /// The uploaded media bundle format is not allowed.
        /// </summary>
        [pbr::OriginalName("MEDIA_BUNDLE_NOT_ALLOWED")] MediaBundleNotAllowed = 24,
        /// <summary>
        /// The media bundle is not compatible with the asset spec product type.
        /// (For example, Gmail, dynamic remarketing, etc.)
        /// </summary>
        [pbr::OriginalName("MEDIA_BUNDLE_NOT_COMPATIBLE_TO_PRODUCT_TYPE")] MediaBundleNotCompatibleToProductType = 25,
        /// <summary>
        /// A bundle being uploaded that is incompatible with multiple assets for
        /// different reasons.
        /// </summary>
        [pbr::OriginalName("MEDIA_BUNDLE_REJECTED_BY_MULTIPLE_ASSET_SPECS")] MediaBundleRejectedByMultipleAssetSpecs = 26,
        /// <summary>
        /// The media bundle contains too many files.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_FILES_IN_MEDIA_BUNDLE")] TooManyFilesInMediaBundle = 27,
        /// <summary>
        /// Google Web Designer not created for "Google Ads" environment.
        /// </summary>
        [pbr::OriginalName("UNSUPPORTED_GOOGLE_WEB_DESIGNER_ENVIRONMENT")] UnsupportedGoogleWebDesignerEnvironment = 28,
        /// <summary>
        /// Unsupported HTML5 feature in HTML5 asset.
        /// </summary>
        [pbr::OriginalName("UNSUPPORTED_HTML5_FEATURE")] UnsupportedHtml5Feature = 29,
        /// <summary>
        /// URL in HTML5 entry is not SSL compliant.
        /// </summary>
        [pbr::OriginalName("URL_IN_MEDIA_BUNDLE_NOT_SSL_COMPLIANT")] UrlInMediaBundleNotSslCompliant = 30,
        /// <summary>
        /// Video file name is longer than the 50 allowed characters.
        /// </summary>
        [pbr::OriginalName("VIDEO_FILE_NAME_TOO_LONG")] VideoFileNameTooLong = 31,
        /// <summary>
        /// Multiple videos with same name in a bundle.
        /// </summary>
        [pbr::OriginalName("VIDEO_MULTIPLE_FILES_WITH_SAME_NAME")] VideoMultipleFilesWithSameName = 32,
        /// <summary>
        /// Videos are not allowed in media bundle.
        /// </summary>
        [pbr::OriginalName("VIDEO_NOT_ALLOWED_IN_MEDIA_BUNDLE")] VideoNotAllowedInMediaBundle = 33,
        /// <summary>
        /// This type of media cannot be uploaded through the Google Ads API.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPLOAD_MEDIA_TYPE_THROUGH_API")] CannotUploadMediaTypeThroughApi = 34,
        /// <summary>
        /// The dimensions of the image are not allowed.
        /// </summary>
        [pbr::OriginalName("DIMENSIONS_NOT_ALLOWED")] DimensionsNotAllowed = 35,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
