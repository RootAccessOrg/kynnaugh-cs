// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/audit/audit_log.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Audit {

  /// <summary>Holder for reflection information generated from google/cloud/audit/audit_log.proto</summary>
  public static partial class AuditLogReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/audit/audit_log.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AuditLogReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJnb29nbGUvY2xvdWQvYXVkaXQvYXVkaXRfbG9nLnByb3RvEhJnb29nbGUu",
            "Y2xvdWQuYXVkaXQaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8aGWdv",
            "b2dsZS9wcm90b2J1Zi9hbnkucHJvdG8aHGdvb2dsZS9wcm90b2J1Zi9zdHJ1",
            "Y3QucHJvdG8aF2dvb2dsZS9ycGMvc3RhdHVzLnByb3RvItQDCghBdWRpdExv",
            "ZxIUCgxzZXJ2aWNlX25hbWUYByABKAkSEwoLbWV0aG9kX25hbWUYCCABKAkS",
            "FQoNcmVzb3VyY2VfbmFtZRgLIAEoCRIaChJudW1fcmVzcG9uc2VfaXRlbXMY",
            "DCABKAMSIgoGc3RhdHVzGAIgASgLMhIuZ29vZ2xlLnJwYy5TdGF0dXMSQwoT",
            "YXV0aGVudGljYXRpb25faW5mbxgDIAEoCzImLmdvb2dsZS5jbG91ZC5hdWRp",
            "dC5BdXRoZW50aWNhdGlvbkluZm8SQQoSYXV0aG9yaXphdGlvbl9pbmZvGAkg",
            "AygLMiUuZ29vZ2xlLmNsb3VkLmF1ZGl0LkF1dGhvcml6YXRpb25JbmZvEj0K",
            "EHJlcXVlc3RfbWV0YWRhdGEYBCABKAsyIy5nb29nbGUuY2xvdWQuYXVkaXQu",
            "UmVxdWVzdE1ldGFkYXRhEigKB3JlcXVlc3QYECABKAsyFy5nb29nbGUucHJv",
            "dG9idWYuU3RydWN0EikKCHJlc3BvbnNlGBEgASgLMhcuZ29vZ2xlLnByb3Rv",
            "YnVmLlN0cnVjdBIqCgxzZXJ2aWNlX2RhdGEYDyABKAsyFC5nb29nbGUucHJv",
            "dG9idWYuQW55Ii0KEkF1dGhlbnRpY2F0aW9uSW5mbxIXCg9wcmluY2lwYWxf",
            "ZW1haWwYASABKAkiSgoRQXV0aG9yaXphdGlvbkluZm8SEAoIcmVzb3VyY2UY",
            "ASABKAkSEgoKcGVybWlzc2lvbhgCIAEoCRIPCgdncmFudGVkGAMgASgIIkgK",
            "D1JlcXVlc3RNZXRhZGF0YRIRCgljYWxsZXJfaXAYASABKAkSIgoaY2FsbGVy",
            "X3N1cHBsaWVkX3VzZXJfYWdlbnQYAiABKAlCYgoWY29tLmdvb2dsZS5jbG91",
            "ZC5hdWRpdEINQXVkaXRMb2dQcm90b1ABWjdnb29nbGUuZ29sYW5nLm9yZy9n",
            "ZW5wcm90by9nb29nbGVhcGlzL2Nsb3VkL2F1ZGl0O2F1ZGl0YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Google.Rpc.StatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Audit.AuditLog), global::Google.Cloud.Audit.AuditLog.Parser, new[]{ "ServiceName", "MethodName", "ResourceName", "NumResponseItems", "Status", "AuthenticationInfo", "AuthorizationInfo", "RequestMetadata", "Request", "Response", "ServiceData" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Audit.AuthenticationInfo), global::Google.Cloud.Audit.AuthenticationInfo.Parser, new[]{ "PrincipalEmail" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Audit.AuthorizationInfo), global::Google.Cloud.Audit.AuthorizationInfo.Parser, new[]{ "Resource", "Permission", "Granted" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Audit.RequestMetadata), global::Google.Cloud.Audit.RequestMetadata.Parser, new[]{ "CallerIp", "CallerSuppliedUserAgent" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  Common audit log format for Google Cloud Platform API operations.
  /// </summary>
  public sealed partial class AuditLog : pb::IMessage<AuditLog> {
    private static readonly pb::MessageParser<AuditLog> _parser = new pb::MessageParser<AuditLog>(() => new AuditLog());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AuditLog> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Audit.AuditLogReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuditLog() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuditLog(AuditLog other) : this() {
      serviceName_ = other.serviceName_;
      methodName_ = other.methodName_;
      resourceName_ = other.resourceName_;
      numResponseItems_ = other.numResponseItems_;
      Status = other.status_ != null ? other.Status.Clone() : null;
      AuthenticationInfo = other.authenticationInfo_ != null ? other.AuthenticationInfo.Clone() : null;
      authorizationInfo_ = other.authorizationInfo_.Clone();
      RequestMetadata = other.requestMetadata_ != null ? other.RequestMetadata.Clone() : null;
      Request = other.request_ != null ? other.Request.Clone() : null;
      Response = other.response_ != null ? other.Response.Clone() : null;
      ServiceData = other.serviceData_ != null ? other.ServiceData.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuditLog Clone() {
      return new AuditLog(this);
    }

    /// <summary>Field number for the "service_name" field.</summary>
    public const int ServiceNameFieldNumber = 7;
    private string serviceName_ = "";
    /// <summary>
    ///  The name of the API service performing the operation. For example,
    ///  `"datastore.googleapis.com"`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ServiceName {
      get { return serviceName_; }
      set {
        serviceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "method_name" field.</summary>
    public const int MethodNameFieldNumber = 8;
    private string methodName_ = "";
    /// <summary>
    ///  The name of the service method or operation.
    ///  For API calls, this should be the name of the API method.
    ///  For example,
    ///
    ///      "google.datastore.v1.Datastore.RunQuery"
    ///      "google.logging.v1.LoggingService.DeleteLog"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MethodName {
      get { return methodName_; }
      set {
        methodName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 11;
    private string resourceName_ = "";
    /// <summary>
    ///  The resource or collection that is the target of the operation.
    ///  The name is a scheme-less URI, not including the API service name.
    ///  For example:
    ///
    ///      "shelves/SHELF_ID/books"
    ///      "shelves/SHELF_ID/books/BOOK_ID"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "num_response_items" field.</summary>
    public const int NumResponseItemsFieldNumber = 12;
    private long numResponseItems_;
    /// <summary>
    ///  The number of items returned from a List or Query API method,
    ///  if applicable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long NumResponseItems {
      get { return numResponseItems_; }
      set {
        numResponseItems_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 2;
    private global::Google.Rpc.Status status_;
    /// <summary>
    ///  The status of the overall operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Rpc.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "authentication_info" field.</summary>
    public const int AuthenticationInfoFieldNumber = 3;
    private global::Google.Cloud.Audit.AuthenticationInfo authenticationInfo_;
    /// <summary>
    ///  Authentication information.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Audit.AuthenticationInfo AuthenticationInfo {
      get { return authenticationInfo_; }
      set {
        authenticationInfo_ = value;
      }
    }

    /// <summary>Field number for the "authorization_info" field.</summary>
    public const int AuthorizationInfoFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Google.Cloud.Audit.AuthorizationInfo> _repeated_authorizationInfo_codec
        = pb::FieldCodec.ForMessage(74, global::Google.Cloud.Audit.AuthorizationInfo.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Audit.AuthorizationInfo> authorizationInfo_ = new pbc::RepeatedField<global::Google.Cloud.Audit.AuthorizationInfo>();
    /// <summary>
    ///  Authorization information. If there are multiple
    ///  resources or permissions involved, then there is
    ///  one AuthorizationInfo element for each {resource, permission} tuple.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.Audit.AuthorizationInfo> AuthorizationInfo {
      get { return authorizationInfo_; }
    }

    /// <summary>Field number for the "request_metadata" field.</summary>
    public const int RequestMetadataFieldNumber = 4;
    private global::Google.Cloud.Audit.RequestMetadata requestMetadata_;
    /// <summary>
    ///  Metadata about the operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Audit.RequestMetadata RequestMetadata {
      get { return requestMetadata_; }
      set {
        requestMetadata_ = value;
      }
    }

    /// <summary>Field number for the "request" field.</summary>
    public const int RequestFieldNumber = 16;
    private global::Google.Protobuf.WellKnownTypes.Struct request_;
    /// <summary>
    ///  The operation request. This may not include all request parameters,
    ///  such as those that are too large, privacy-sensitive, or duplicated
    ///  elsewhere in the log record.
    ///  It should never include user-generated data, such as file contents.
    ///  When the JSON object represented here has a proto equivalent, the proto
    ///  name will be indicated in the `@type` property.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Struct Request {
      get { return request_; }
      set {
        request_ = value;
      }
    }

    /// <summary>Field number for the "response" field.</summary>
    public const int ResponseFieldNumber = 17;
    private global::Google.Protobuf.WellKnownTypes.Struct response_;
    /// <summary>
    ///  The operation response. This may not include all response elements,
    ///  such as those that are too large, privacy-sensitive, or duplicated
    ///  elsewhere in the log record.
    ///  It should never include user-generated data, such as file contents.
    ///  When the JSON object represented here has a proto equivalent, the proto
    ///  name will be indicated in the `@type` property.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Struct Response {
      get { return response_; }
      set {
        response_ = value;
      }
    }

    /// <summary>Field number for the "service_data" field.</summary>
    public const int ServiceDataFieldNumber = 15;
    private global::Google.Protobuf.WellKnownTypes.Any serviceData_;
    /// <summary>
    ///  Other service-specific data about the request, response, and other
    ///  activities.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Any ServiceData {
      get { return serviceData_; }
      set {
        serviceData_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AuditLog);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AuditLog other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ServiceName != other.ServiceName) return false;
      if (MethodName != other.MethodName) return false;
      if (ResourceName != other.ResourceName) return false;
      if (NumResponseItems != other.NumResponseItems) return false;
      if (!object.Equals(Status, other.Status)) return false;
      if (!object.Equals(AuthenticationInfo, other.AuthenticationInfo)) return false;
      if(!authorizationInfo_.Equals(other.authorizationInfo_)) return false;
      if (!object.Equals(RequestMetadata, other.RequestMetadata)) return false;
      if (!object.Equals(Request, other.Request)) return false;
      if (!object.Equals(Response, other.Response)) return false;
      if (!object.Equals(ServiceData, other.ServiceData)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ServiceName.Length != 0) hash ^= ServiceName.GetHashCode();
      if (MethodName.Length != 0) hash ^= MethodName.GetHashCode();
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (NumResponseItems != 0L) hash ^= NumResponseItems.GetHashCode();
      if (status_ != null) hash ^= Status.GetHashCode();
      if (authenticationInfo_ != null) hash ^= AuthenticationInfo.GetHashCode();
      hash ^= authorizationInfo_.GetHashCode();
      if (requestMetadata_ != null) hash ^= RequestMetadata.GetHashCode();
      if (request_ != null) hash ^= Request.GetHashCode();
      if (response_ != null) hash ^= Response.GetHashCode();
      if (serviceData_ != null) hash ^= ServiceData.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (status_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Status);
      }
      if (authenticationInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(AuthenticationInfo);
      }
      if (requestMetadata_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(RequestMetadata);
      }
      if (ServiceName.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ServiceName);
      }
      if (MethodName.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(MethodName);
      }
      authorizationInfo_.WriteTo(output, _repeated_authorizationInfo_codec);
      if (ResourceName.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(ResourceName);
      }
      if (NumResponseItems != 0L) {
        output.WriteRawTag(96);
        output.WriteInt64(NumResponseItems);
      }
      if (serviceData_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(ServiceData);
      }
      if (request_ != null) {
        output.WriteRawTag(130, 1);
        output.WriteMessage(Request);
      }
      if (response_ != null) {
        output.WriteRawTag(138, 1);
        output.WriteMessage(Response);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ServiceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ServiceName);
      }
      if (MethodName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MethodName);
      }
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (NumResponseItems != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(NumResponseItems);
      }
      if (status_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Status);
      }
      if (authenticationInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AuthenticationInfo);
      }
      size += authorizationInfo_.CalculateSize(_repeated_authorizationInfo_codec);
      if (requestMetadata_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RequestMetadata);
      }
      if (request_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Request);
      }
      if (response_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Response);
      }
      if (serviceData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ServiceData);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AuditLog other) {
      if (other == null) {
        return;
      }
      if (other.ServiceName.Length != 0) {
        ServiceName = other.ServiceName;
      }
      if (other.MethodName.Length != 0) {
        MethodName = other.MethodName;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.NumResponseItems != 0L) {
        NumResponseItems = other.NumResponseItems;
      }
      if (other.status_ != null) {
        if (status_ == null) {
          status_ = new global::Google.Rpc.Status();
        }
        Status.MergeFrom(other.Status);
      }
      if (other.authenticationInfo_ != null) {
        if (authenticationInfo_ == null) {
          authenticationInfo_ = new global::Google.Cloud.Audit.AuthenticationInfo();
        }
        AuthenticationInfo.MergeFrom(other.AuthenticationInfo);
      }
      authorizationInfo_.Add(other.authorizationInfo_);
      if (other.requestMetadata_ != null) {
        if (requestMetadata_ == null) {
          requestMetadata_ = new global::Google.Cloud.Audit.RequestMetadata();
        }
        RequestMetadata.MergeFrom(other.RequestMetadata);
      }
      if (other.request_ != null) {
        if (request_ == null) {
          request_ = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        Request.MergeFrom(other.Request);
      }
      if (other.response_ != null) {
        if (response_ == null) {
          response_ = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        Response.MergeFrom(other.Response);
      }
      if (other.serviceData_ != null) {
        if (serviceData_ == null) {
          serviceData_ = new global::Google.Protobuf.WellKnownTypes.Any();
        }
        ServiceData.MergeFrom(other.ServiceData);
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
          case 18: {
            if (status_ == null) {
              status_ = new global::Google.Rpc.Status();
            }
            input.ReadMessage(status_);
            break;
          }
          case 26: {
            if (authenticationInfo_ == null) {
              authenticationInfo_ = new global::Google.Cloud.Audit.AuthenticationInfo();
            }
            input.ReadMessage(authenticationInfo_);
            break;
          }
          case 34: {
            if (requestMetadata_ == null) {
              requestMetadata_ = new global::Google.Cloud.Audit.RequestMetadata();
            }
            input.ReadMessage(requestMetadata_);
            break;
          }
          case 58: {
            ServiceName = input.ReadString();
            break;
          }
          case 66: {
            MethodName = input.ReadString();
            break;
          }
          case 74: {
            authorizationInfo_.AddEntriesFrom(input, _repeated_authorizationInfo_codec);
            break;
          }
          case 90: {
            ResourceName = input.ReadString();
            break;
          }
          case 96: {
            NumResponseItems = input.ReadInt64();
            break;
          }
          case 122: {
            if (serviceData_ == null) {
              serviceData_ = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(serviceData_);
            break;
          }
          case 130: {
            if (request_ == null) {
              request_ = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(request_);
            break;
          }
          case 138: {
            if (response_ == null) {
              response_ = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(response_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Authentication information for the operation.
  /// </summary>
  public sealed partial class AuthenticationInfo : pb::IMessage<AuthenticationInfo> {
    private static readonly pb::MessageParser<AuthenticationInfo> _parser = new pb::MessageParser<AuthenticationInfo>(() => new AuthenticationInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AuthenticationInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Audit.AuditLogReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthenticationInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthenticationInfo(AuthenticationInfo other) : this() {
      principalEmail_ = other.principalEmail_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthenticationInfo Clone() {
      return new AuthenticationInfo(this);
    }

    /// <summary>Field number for the "principal_email" field.</summary>
    public const int PrincipalEmailFieldNumber = 1;
    private string principalEmail_ = "";
    /// <summary>
    ///  The email address of the authenticated user making the request.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PrincipalEmail {
      get { return principalEmail_; }
      set {
        principalEmail_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AuthenticationInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AuthenticationInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PrincipalEmail != other.PrincipalEmail) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PrincipalEmail.Length != 0) hash ^= PrincipalEmail.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PrincipalEmail.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PrincipalEmail);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PrincipalEmail.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PrincipalEmail);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AuthenticationInfo other) {
      if (other == null) {
        return;
      }
      if (other.PrincipalEmail.Length != 0) {
        PrincipalEmail = other.PrincipalEmail;
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
            PrincipalEmail = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Authorization information for the operation.
  /// </summary>
  public sealed partial class AuthorizationInfo : pb::IMessage<AuthorizationInfo> {
    private static readonly pb::MessageParser<AuthorizationInfo> _parser = new pb::MessageParser<AuthorizationInfo>(() => new AuthorizationInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AuthorizationInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Audit.AuditLogReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthorizationInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthorizationInfo(AuthorizationInfo other) : this() {
      resource_ = other.resource_;
      permission_ = other.permission_;
      granted_ = other.granted_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthorizationInfo Clone() {
      return new AuthorizationInfo(this);
    }

    /// <summary>Field number for the "resource" field.</summary>
    public const int ResourceFieldNumber = 1;
    private string resource_ = "";
    /// <summary>
    ///  The resource being accessed, as a REST-style string. For example:
    ///
    ///      bigquery.googlapis.com/projects/PROJECTID/datasets/DATASETID
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Resource {
      get { return resource_; }
      set {
        resource_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "permission" field.</summary>
    public const int PermissionFieldNumber = 2;
    private string permission_ = "";
    /// <summary>
    ///  The required IAM permission.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Permission {
      get { return permission_; }
      set {
        permission_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "granted" field.</summary>
    public const int GrantedFieldNumber = 3;
    private bool granted_;
    /// <summary>
    ///  Whether or not authorization for `resource` and `permission`
    ///  was granted.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Granted {
      get { return granted_; }
      set {
        granted_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AuthorizationInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AuthorizationInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Resource != other.Resource) return false;
      if (Permission != other.Permission) return false;
      if (Granted != other.Granted) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Resource.Length != 0) hash ^= Resource.GetHashCode();
      if (Permission.Length != 0) hash ^= Permission.GetHashCode();
      if (Granted != false) hash ^= Granted.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Resource.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Resource);
      }
      if (Permission.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Permission);
      }
      if (Granted != false) {
        output.WriteRawTag(24);
        output.WriteBool(Granted);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Resource.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Resource);
      }
      if (Permission.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Permission);
      }
      if (Granted != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AuthorizationInfo other) {
      if (other == null) {
        return;
      }
      if (other.Resource.Length != 0) {
        Resource = other.Resource;
      }
      if (other.Permission.Length != 0) {
        Permission = other.Permission;
      }
      if (other.Granted != false) {
        Granted = other.Granted;
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
            Resource = input.ReadString();
            break;
          }
          case 18: {
            Permission = input.ReadString();
            break;
          }
          case 24: {
            Granted = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Metadata about the request.
  /// </summary>
  public sealed partial class RequestMetadata : pb::IMessage<RequestMetadata> {
    private static readonly pb::MessageParser<RequestMetadata> _parser = new pb::MessageParser<RequestMetadata>(() => new RequestMetadata());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RequestMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Audit.AuditLogReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestMetadata(RequestMetadata other) : this() {
      callerIp_ = other.callerIp_;
      callerSuppliedUserAgent_ = other.callerSuppliedUserAgent_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestMetadata Clone() {
      return new RequestMetadata(this);
    }

    /// <summary>Field number for the "caller_ip" field.</summary>
    public const int CallerIpFieldNumber = 1;
    private string callerIp_ = "";
    /// <summary>
    ///  The IP address of the caller.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CallerIp {
      get { return callerIp_; }
      set {
        callerIp_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "caller_supplied_user_agent" field.</summary>
    public const int CallerSuppliedUserAgentFieldNumber = 2;
    private string callerSuppliedUserAgent_ = "";
    /// <summary>
    ///  The user agent of the caller.
    ///  This information is not authenticated and should be treated accordingly.
    ///  For example:
    ///
    ///  +   `google-api-python-client/1.4.0`:
    ///      The request was made by the Google API client for Python.
    ///  +   `Cloud SDK Command Line Tool apitools-client/1.0 gcloud/0.9.62`:
    ///      The request was made by the Google Cloud SDK CLI (gcloud).
    ///  +   `AppEngine-Google; (+http://code.google.com/appengine; appid: s~my-project`:
    ///      The request was made from the `my-project` App Engine app.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CallerSuppliedUserAgent {
      get { return callerSuppliedUserAgent_; }
      set {
        callerSuppliedUserAgent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RequestMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RequestMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CallerIp != other.CallerIp) return false;
      if (CallerSuppliedUserAgent != other.CallerSuppliedUserAgent) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CallerIp.Length != 0) hash ^= CallerIp.GetHashCode();
      if (CallerSuppliedUserAgent.Length != 0) hash ^= CallerSuppliedUserAgent.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CallerIp.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CallerIp);
      }
      if (CallerSuppliedUserAgent.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CallerSuppliedUserAgent);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CallerIp.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CallerIp);
      }
      if (CallerSuppliedUserAgent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CallerSuppliedUserAgent);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RequestMetadata other) {
      if (other == null) {
        return;
      }
      if (other.CallerIp.Length != 0) {
        CallerIp = other.CallerIp;
      }
      if (other.CallerSuppliedUserAgent.Length != 0) {
        CallerSuppliedUserAgent = other.CallerSuppliedUserAgent;
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
            CallerIp = input.ReadString();
            break;
          }
          case 18: {
            CallerSuppliedUserAgent = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
