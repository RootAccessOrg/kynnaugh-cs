// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/appengine/v1/deploy.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Appengine.V1 {

  /// <summary>Holder for reflection information generated from google/appengine/v1/deploy.proto</summary>
  public static partial class DeployReflection {

    #region Descriptor
    /// <summary>File descriptor for google/appengine/v1/deploy.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DeployReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBnb29nbGUvYXBwZW5naW5lL3YxL2RlcGxveS5wcm90bxITZ29vZ2xlLmFw",
            "cGVuZ2luZS52MRocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byL2AQoK",
            "RGVwbG95bWVudBI5CgVmaWxlcxgBIAMoCzIqLmdvb2dsZS5hcHBlbmdpbmUu",
            "djEuRGVwbG95bWVudC5GaWxlc0VudHJ5EjUKCWNvbnRhaW5lchgCIAEoCzIi",
            "Lmdvb2dsZS5hcHBlbmdpbmUudjEuQ29udGFpbmVySW5mbxIpCgN6aXAYAyAB",
            "KAsyHC5nb29nbGUuYXBwZW5naW5lLnYxLlppcEluZm8aSwoKRmlsZXNFbnRy",
            "eRILCgNrZXkYASABKAkSLAoFdmFsdWUYAiABKAsyHS5nb29nbGUuYXBwZW5n",
            "aW5lLnYxLkZpbGVJbmZvOgI4ASJDCghGaWxlSW5mbxISCgpzb3VyY2VfdXJs",
            "GAEgASgJEhAKCHNoYTFfc3VtGAIgASgJEhEKCW1pbWVfdHlwZRgDIAEoCSIe",
            "Cg1Db250YWluZXJJbmZvEg0KBWltYWdlGAEgASgJIjIKB1ppcEluZm8SEgoK",
            "c291cmNlX3VybBgDIAEoCRITCgtmaWxlc19jb3VudBgEIAEoBUJmChdjb20u",
            "Z29vZ2xlLmFwcGVuZ2luZS52MUILRGVwbG95UHJvdG9QAVo8Z29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hcHBlbmdpbmUvdjE7YXBw",
            "ZW5naW5lYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Appengine.V1.Deployment), global::Google.Appengine.V1.Deployment.Parser, new[]{ "Files", "Container", "Zip" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Appengine.V1.FileInfo), global::Google.Appengine.V1.FileInfo.Parser, new[]{ "SourceUrl", "Sha1Sum", "MimeType" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Appengine.V1.ContainerInfo), global::Google.Appengine.V1.ContainerInfo.Parser, new[]{ "Image" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Appengine.V1.ZipInfo), global::Google.Appengine.V1.ZipInfo.Parser, new[]{ "SourceUrl", "FilesCount" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  Code and application artifacts used to deploy a version to App Engine.
  /// </summary>
  public sealed partial class Deployment : pb::IMessage<Deployment> {
    private static readonly pb::MessageParser<Deployment> _parser = new pb::MessageParser<Deployment>(() => new Deployment());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Deployment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Appengine.V1.DeployReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Deployment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Deployment(Deployment other) : this() {
      files_ = other.files_.Clone();
      Container = other.container_ != null ? other.Container.Clone() : null;
      Zip = other.zip_ != null ? other.Zip.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Deployment Clone() {
      return new Deployment(this);
    }

    /// <summary>Field number for the "files" field.</summary>
    public const int FilesFieldNumber = 1;
    private static readonly pbc::MapField<string, global::Google.Appengine.V1.FileInfo>.Codec _map_files_codec
        = new pbc::MapField<string, global::Google.Appengine.V1.FileInfo>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::Google.Appengine.V1.FileInfo.Parser), 10);
    private readonly pbc::MapField<string, global::Google.Appengine.V1.FileInfo> files_ = new pbc::MapField<string, global::Google.Appengine.V1.FileInfo>();
    /// <summary>
    ///  Manifest of the files stored in Google Cloud Storage that are included
    ///  as part of this version. All files must be readable using the
    ///  credentials supplied with this call.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::Google.Appengine.V1.FileInfo> Files {
      get { return files_; }
    }

    /// <summary>Field number for the "container" field.</summary>
    public const int ContainerFieldNumber = 2;
    private global::Google.Appengine.V1.ContainerInfo container_;
    /// <summary>
    ///  A Docker image that App Engine uses to run the version.
    ///  Only applicable for instances in App Engine flexible environment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Appengine.V1.ContainerInfo Container {
      get { return container_; }
      set {
        container_ = value;
      }
    }

    /// <summary>Field number for the "zip" field.</summary>
    public const int ZipFieldNumber = 3;
    private global::Google.Appengine.V1.ZipInfo zip_;
    /// <summary>
    ///  The zip file for this deployment, if this is a zip deployment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Appengine.V1.ZipInfo Zip {
      get { return zip_; }
      set {
        zip_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Deployment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Deployment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Files.Equals(other.Files)) return false;
      if (!object.Equals(Container, other.Container)) return false;
      if (!object.Equals(Zip, other.Zip)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Files.GetHashCode();
      if (container_ != null) hash ^= Container.GetHashCode();
      if (zip_ != null) hash ^= Zip.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      files_.WriteTo(output, _map_files_codec);
      if (container_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Container);
      }
      if (zip_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Zip);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += files_.CalculateSize(_map_files_codec);
      if (container_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Container);
      }
      if (zip_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Zip);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Deployment other) {
      if (other == null) {
        return;
      }
      files_.Add(other.files_);
      if (other.container_ != null) {
        if (container_ == null) {
          container_ = new global::Google.Appengine.V1.ContainerInfo();
        }
        Container.MergeFrom(other.Container);
      }
      if (other.zip_ != null) {
        if (zip_ == null) {
          zip_ = new global::Google.Appengine.V1.ZipInfo();
        }
        Zip.MergeFrom(other.Zip);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            files_.AddEntriesFrom(input, _map_files_codec);
            break;
          }
          case 18: {
            if (container_ == null) {
              container_ = new global::Google.Appengine.V1.ContainerInfo();
            }
            input.ReadMessage(container_);
            break;
          }
          case 26: {
            if (zip_ == null) {
              zip_ = new global::Google.Appengine.V1.ZipInfo();
            }
            input.ReadMessage(zip_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Single source file that is part of the version to be deployed. Each source
  ///  file that is deployed must be specified separately.
  /// </summary>
  public sealed partial class FileInfo : pb::IMessage<FileInfo> {
    private static readonly pb::MessageParser<FileInfo> _parser = new pb::MessageParser<FileInfo>(() => new FileInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FileInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Appengine.V1.DeployReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FileInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FileInfo(FileInfo other) : this() {
      sourceUrl_ = other.sourceUrl_;
      sha1Sum_ = other.sha1Sum_;
      mimeType_ = other.mimeType_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FileInfo Clone() {
      return new FileInfo(this);
    }

    /// <summary>Field number for the "source_url" field.</summary>
    public const int SourceUrlFieldNumber = 1;
    private string sourceUrl_ = "";
    /// <summary>
    ///  URL source to use to fetch this file. Must be a URL to a resource in
    ///  Google Cloud Storage in the form
    ///  'http(s)://storage.googleapis.com/\&lt;bucket\>/\&lt;object\>'.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SourceUrl {
      get { return sourceUrl_; }
      set {
        sourceUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sha1_sum" field.</summary>
    public const int Sha1SumFieldNumber = 2;
    private string sha1Sum_ = "";
    /// <summary>
    ///  The SHA1 hash of the file, in hex.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Sha1Sum {
      get { return sha1Sum_; }
      set {
        sha1Sum_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "mime_type" field.</summary>
    public const int MimeTypeFieldNumber = 3;
    private string mimeType_ = "";
    /// <summary>
    ///  The MIME type of the file.
    ///
    ///  Defaults to the value from Google Cloud Storage.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MimeType {
      get { return mimeType_; }
      set {
        mimeType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FileInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FileInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SourceUrl != other.SourceUrl) return false;
      if (Sha1Sum != other.Sha1Sum) return false;
      if (MimeType != other.MimeType) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SourceUrl.Length != 0) hash ^= SourceUrl.GetHashCode();
      if (Sha1Sum.Length != 0) hash ^= Sha1Sum.GetHashCode();
      if (MimeType.Length != 0) hash ^= MimeType.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SourceUrl.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SourceUrl);
      }
      if (Sha1Sum.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Sha1Sum);
      }
      if (MimeType.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(MimeType);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SourceUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SourceUrl);
      }
      if (Sha1Sum.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Sha1Sum);
      }
      if (MimeType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MimeType);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FileInfo other) {
      if (other == null) {
        return;
      }
      if (other.SourceUrl.Length != 0) {
        SourceUrl = other.SourceUrl;
      }
      if (other.Sha1Sum.Length != 0) {
        Sha1Sum = other.Sha1Sum;
      }
      if (other.MimeType.Length != 0) {
        MimeType = other.MimeType;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            SourceUrl = input.ReadString();
            break;
          }
          case 18: {
            Sha1Sum = input.ReadString();
            break;
          }
          case 26: {
            MimeType = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Docker image that is used to start a VM container for the version you
  ///  deploy.
  /// </summary>
  public sealed partial class ContainerInfo : pb::IMessage<ContainerInfo> {
    private static readonly pb::MessageParser<ContainerInfo> _parser = new pb::MessageParser<ContainerInfo>(() => new ContainerInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ContainerInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Appengine.V1.DeployReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContainerInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContainerInfo(ContainerInfo other) : this() {
      image_ = other.image_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContainerInfo Clone() {
      return new ContainerInfo(this);
    }

    /// <summary>Field number for the "image" field.</summary>
    public const int ImageFieldNumber = 1;
    private string image_ = "";
    /// <summary>
    ///  URI to the hosted container image in a Docker repository. The URI must be
    ///  fully qualified and include a tag or digest.
    ///  Examples: "gcr.io/my-project/image:tag" or "gcr.io/my-project/image@digest"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Image {
      get { return image_; }
      set {
        image_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ContainerInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ContainerInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Image != other.Image) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Image.Length != 0) hash ^= Image.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Image.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Image);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Image.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Image);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ContainerInfo other) {
      if (other == null) {
        return;
      }
      if (other.Image.Length != 0) {
        Image = other.Image;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Image = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ZipInfo : pb::IMessage<ZipInfo> {
    private static readonly pb::MessageParser<ZipInfo> _parser = new pb::MessageParser<ZipInfo>(() => new ZipInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ZipInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Appengine.V1.DeployReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ZipInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ZipInfo(ZipInfo other) : this() {
      sourceUrl_ = other.sourceUrl_;
      filesCount_ = other.filesCount_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ZipInfo Clone() {
      return new ZipInfo(this);
    }

    /// <summary>Field number for the "source_url" field.</summary>
    public const int SourceUrlFieldNumber = 3;
    private string sourceUrl_ = "";
    /// <summary>
    ///  URL of the zip file to deploy from. Must be a URL to a resource in
    ///  Google Cloud Storage in the form
    ///  'http(s)://storage.googleapis.com/\&lt;bucket\>/\&lt;object\>'.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SourceUrl {
      get { return sourceUrl_; }
      set {
        sourceUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "files_count" field.</summary>
    public const int FilesCountFieldNumber = 4;
    private int filesCount_;
    /// <summary>
    ///  An estimate of the number of files in a zip for a zip deployment.
    ///  If set, must be greater than or equal to the actual number of files.
    ///  Used for optimizing performance; if not provided, deployment may be slow.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int FilesCount {
      get { return filesCount_; }
      set {
        filesCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ZipInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ZipInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SourceUrl != other.SourceUrl) return false;
      if (FilesCount != other.FilesCount) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SourceUrl.Length != 0) hash ^= SourceUrl.GetHashCode();
      if (FilesCount != 0) hash ^= FilesCount.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SourceUrl.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SourceUrl);
      }
      if (FilesCount != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(FilesCount);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SourceUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SourceUrl);
      }
      if (FilesCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FilesCount);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ZipInfo other) {
      if (other == null) {
        return;
      }
      if (other.SourceUrl.Length != 0) {
        SourceUrl = other.SourceUrl;
      }
      if (other.FilesCount != 0) {
        FilesCount = other.FilesCount;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 26: {
            SourceUrl = input.ReadString();
            break;
          }
          case 32: {
            FilesCount = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
