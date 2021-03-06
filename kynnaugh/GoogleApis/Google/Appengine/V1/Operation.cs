// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/appengine/v1/operation.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Appengine.V1 {

  /// <summary>Holder for reflection information generated from google/appengine/v1/operation.proto</summary>
  public static partial class OperationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/appengine/v1/operation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OperationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNnb29nbGUvYXBwZW5naW5lL3YxL29wZXJhdGlvbi5wcm90bxITZ29vZ2xl",
            "LmFwcGVuZ2luZS52MRocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90bxof",
            "Z29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byKiAQoTT3BlcmF0aW9u",
            "TWV0YWRhdGFWMRIOCgZtZXRob2QYASABKAkSLwoLaW5zZXJ0X3RpbWUYAiAB",
            "KAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wEiwKCGVuZF90aW1lGAMg",
            "ASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBIMCgR1c2VyGAQgASgJ",
            "Eg4KBnRhcmdldBgFIAEoCUJpChdjb20uZ29vZ2xlLmFwcGVuZ2luZS52MUIO",
            "T3BlcmF0aW9uUHJvdG9QAVo8Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8v",
            "Z29vZ2xlYXBpcy9hcHBlbmdpbmUvdjE7YXBwZW5naW5lYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Appengine.V1.OperationMetadataV1), global::Google.Appengine.V1.OperationMetadataV1.Parser, new[]{ "Method", "InsertTime", "EndTime", "User", "Target" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  Metadata for the given [google.longrunning.Operation][google.longrunning.Operation].
  /// </summary>
  public sealed partial class OperationMetadataV1 : pb::IMessage<OperationMetadataV1> {
    private static readonly pb::MessageParser<OperationMetadataV1> _parser = new pb::MessageParser<OperationMetadataV1>(() => new OperationMetadataV1());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OperationMetadataV1> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Appengine.V1.OperationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperationMetadataV1() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperationMetadataV1(OperationMetadataV1 other) : this() {
      method_ = other.method_;
      InsertTime = other.insertTime_ != null ? other.InsertTime.Clone() : null;
      EndTime = other.endTime_ != null ? other.EndTime.Clone() : null;
      user_ = other.user_;
      target_ = other.target_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperationMetadataV1 Clone() {
      return new OperationMetadataV1(this);
    }

    /// <summary>Field number for the "method" field.</summary>
    public const int MethodFieldNumber = 1;
    private string method_ = "";
    /// <summary>
    ///  API method that initiated this operation. Example:
    ///  `google.appengine.v1.Versions.CreateVersion`.
    ///
    ///  @OutputOnly
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Method {
      get { return method_; }
      set {
        method_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "insert_time" field.</summary>
    public const int InsertTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp insertTime_;
    /// <summary>
    ///  Time that this operation was created.
    ///
    ///  @OutputOnly
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp InsertTime {
      get { return insertTime_; }
      set {
        insertTime_ = value;
      }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp endTime_;
    /// <summary>
    ///  Time that this operation completed.
    ///
    ///  @OutputOnly
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    /// <summary>Field number for the "user" field.</summary>
    public const int UserFieldNumber = 4;
    private string user_ = "";
    /// <summary>
    ///  User who requested this operation.
    ///
    ///  @OutputOnly
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string User {
      get { return user_; }
      set {
        user_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "target" field.</summary>
    public const int TargetFieldNumber = 5;
    private string target_ = "";
    /// <summary>
    ///  Name of the resource that this operation is acting on. Example:
    ///  `apps/myapp/services/default`.
    ///
    ///  @OutputOnly
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Target {
      get { return target_; }
      set {
        target_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OperationMetadataV1);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OperationMetadataV1 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Method != other.Method) return false;
      if (!object.Equals(InsertTime, other.InsertTime)) return false;
      if (!object.Equals(EndTime, other.EndTime)) return false;
      if (User != other.User) return false;
      if (Target != other.Target) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Method.Length != 0) hash ^= Method.GetHashCode();
      if (insertTime_ != null) hash ^= InsertTime.GetHashCode();
      if (endTime_ != null) hash ^= EndTime.GetHashCode();
      if (User.Length != 0) hash ^= User.GetHashCode();
      if (Target.Length != 0) hash ^= Target.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Method.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Method);
      }
      if (insertTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(InsertTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(EndTime);
      }
      if (User.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(User);
      }
      if (Target.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Target);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Method.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Method);
      }
      if (insertTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InsertTime);
      }
      if (endTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EndTime);
      }
      if (User.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(User);
      }
      if (Target.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Target);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OperationMetadataV1 other) {
      if (other == null) {
        return;
      }
      if (other.Method.Length != 0) {
        Method = other.Method;
      }
      if (other.insertTime_ != null) {
        if (insertTime_ == null) {
          insertTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        InsertTime.MergeFrom(other.InsertTime);
      }
      if (other.endTime_ != null) {
        if (endTime_ == null) {
          endTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        EndTime.MergeFrom(other.EndTime);
      }
      if (other.User.Length != 0) {
        User = other.User;
      }
      if (other.Target.Length != 0) {
        Target = other.Target;
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
            Method = input.ReadString();
            break;
          }
          case 18: {
            if (insertTime_ == null) {
              insertTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(insertTime_);
            break;
          }
          case 26: {
            if (endTime_ == null) {
              endTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(endTime_);
            break;
          }
          case 34: {
            User = input.ReadString();
            break;
          }
          case 42: {
            Target = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
