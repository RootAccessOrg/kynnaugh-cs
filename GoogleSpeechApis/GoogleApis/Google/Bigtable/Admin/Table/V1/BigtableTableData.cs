// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/bigtable/admin/table/v1/bigtable_table_data.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Bigtable.Admin.Table.V1 {

  /// <summary>Holder for reflection information generated from google/bigtable/admin/table/v1/bigtable_table_data.proto</summary>
  public static partial class BigtableTableDataReflection {

    #region Descriptor
    /// <summary>File descriptor for google/bigtable/admin/table/v1/bigtable_table_data.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BigtableTableDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYmlndGFibGUvYWRtaW4vdGFibGUvdjEvYmlndGFibGVfdGFi",
            "bGVfZGF0YS5wcm90bxIeZ29vZ2xlLmJpZ3RhYmxlLmFkbWluLnRhYmxlLnYx",
            "GiNnb29nbGUvbG9uZ3J1bm5pbmcvb3BlcmF0aW9ucy5wcm90bxoeZ29vZ2xl",
            "L3Byb3RvYnVmL2R1cmF0aW9uLnByb3RvIv0CCgVUYWJsZRIMCgRuYW1lGAEg",
            "ASgJEjgKEWN1cnJlbnRfb3BlcmF0aW9uGAIgASgLMh0uZ29vZ2xlLmxvbmdy",
            "dW5uaW5nLk9wZXJhdGlvbhJSCg9jb2x1bW5fZmFtaWxpZXMYAyADKAsyOS5n",
            "b29nbGUuYmlndGFibGUuYWRtaW4udGFibGUudjEuVGFibGUuQ29sdW1uRmFt",
            "aWxpZXNFbnRyeRJPCgtncmFudWxhcml0eRgEIAEoDjI6Lmdvb2dsZS5iaWd0",
            "YWJsZS5hZG1pbi50YWJsZS52MS5UYWJsZS5UaW1lc3RhbXBHcmFudWxhcml0",
            "eRpjChNDb2x1bW5GYW1pbGllc0VudHJ5EgsKA2tleRgBIAEoCRI7CgV2YWx1",
            "ZRgCIAEoCzIsLmdvb2dsZS5iaWd0YWJsZS5hZG1pbi50YWJsZS52MS5Db2x1",
            "bW5GYW1pbHk6AjgBIiIKFFRpbWVzdGFtcEdyYW51bGFyaXR5EgoKBk1JTExJ",
            "UxAAImwKDENvbHVtbkZhbWlseRIMCgRuYW1lGAEgASgJEhUKDWdjX2V4cHJl",
            "c3Npb24YAiABKAkSNwoHZ2NfcnVsZRgDIAEoCzImLmdvb2dsZS5iaWd0YWJs",
            "ZS5hZG1pbi50YWJsZS52MS5HY1J1bGUi7QIKBkdjUnVsZRIaChBtYXhfbnVt",
            "X3ZlcnNpb25zGAEgASgFSAASLAoHbWF4X2FnZRgCIAEoCzIZLmdvb2dsZS5w",
            "cm90b2J1Zi5EdXJhdGlvbkgAEksKDGludGVyc2VjdGlvbhgDIAEoCzIzLmdv",
            "b2dsZS5iaWd0YWJsZS5hZG1pbi50YWJsZS52MS5HY1J1bGUuSW50ZXJzZWN0",
            "aW9uSAASPQoFdW5pb24YBCABKAsyLC5nb29nbGUuYmlndGFibGUuYWRtaW4u",
            "dGFibGUudjEuR2NSdWxlLlVuaW9uSAAaRQoMSW50ZXJzZWN0aW9uEjUKBXJ1",
            "bGVzGAEgAygLMiYuZ29vZ2xlLmJpZ3RhYmxlLmFkbWluLnRhYmxlLnYxLkdj",
            "UnVsZRo+CgVVbmlvbhI1CgVydWxlcxgBIAMoCzImLmdvb2dsZS5iaWd0YWJs",
            "ZS5hZG1pbi50YWJsZS52MS5HY1J1bGVCBgoEcnVsZUKDAQoiY29tLmdvb2ds",
            "ZS5iaWd0YWJsZS5hZG1pbi50YWJsZS52MUIWQmlndGFibGVUYWJsZURhdGFQ",
            "cm90b1ABWkNnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlz",
            "L2JpZ3RhYmxlL2FkbWluL3RhYmxlL3YxO3RhYmxlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.LongRunning.OperationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Bigtable.Admin.Table.V1.Table), global::Google.Bigtable.Admin.Table.V1.Table.Parser, new[]{ "Name", "CurrentOperation", "ColumnFamilies", "Granularity" }, null, new[]{ typeof(global::Google.Bigtable.Admin.Table.V1.Table.Types.TimestampGranularity) }, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Bigtable.Admin.Table.V1.ColumnFamily), global::Google.Bigtable.Admin.Table.V1.ColumnFamily.Parser, new[]{ "Name", "GcExpression", "GcRule" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Bigtable.Admin.Table.V1.GcRule), global::Google.Bigtable.Admin.Table.V1.GcRule.Parser, new[]{ "MaxNumVersions", "MaxAge", "Intersection", "Union" }, new[]{ "Rule" }, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Bigtable.Admin.Table.V1.GcRule.Types.Intersection), global::Google.Bigtable.Admin.Table.V1.GcRule.Types.Intersection.Parser, new[]{ "Rules" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Bigtable.Admin.Table.V1.GcRule.Types.Union), global::Google.Bigtable.Admin.Table.V1.GcRule.Types.Union.Parser, new[]{ "Rules" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  A collection of user data indexed by row, column, and timestamp.
  ///  Each table is served using the resources of its parent cluster.
  /// </summary>
  public sealed partial class Table : pb::IMessage<Table> {
    private static readonly pb::MessageParser<Table> _parser = new pb::MessageParser<Table>(() => new Table());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Table> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Bigtable.Admin.Table.V1.BigtableTableDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Table() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Table(Table other) : this() {
      name_ = other.name_;
      CurrentOperation = other.currentOperation_ != null ? other.CurrentOperation.Clone() : null;
      columnFamilies_ = other.columnFamilies_.Clone();
      granularity_ = other.granularity_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Table Clone() {
      return new Table(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    ///  A unique identifier of the form
    ///  &lt;cluster_name>/tables/[_a-zA-Z0-9][-_.a-zA-Z0-9]*
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "current_operation" field.</summary>
    public const int CurrentOperationFieldNumber = 2;
    private global::Google.LongRunning.Operation currentOperation_;
    /// <summary>
    ///  If this Table is in the process of being created, the Operation used to
    ///  track its progress. As long as this operation is present, the Table will
    ///  not accept any Table Admin or Read/Write requests.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.LongRunning.Operation CurrentOperation {
      get { return currentOperation_; }
      set {
        currentOperation_ = value;
      }
    }

    /// <summary>Field number for the "column_families" field.</summary>
    public const int ColumnFamiliesFieldNumber = 3;
    private static readonly pbc::MapField<string, global::Google.Bigtable.Admin.Table.V1.ColumnFamily>.Codec _map_columnFamilies_codec
        = new pbc::MapField<string, global::Google.Bigtable.Admin.Table.V1.ColumnFamily>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::Google.Bigtable.Admin.Table.V1.ColumnFamily.Parser), 26);
    private readonly pbc::MapField<string, global::Google.Bigtable.Admin.Table.V1.ColumnFamily> columnFamilies_ = new pbc::MapField<string, global::Google.Bigtable.Admin.Table.V1.ColumnFamily>();
    /// <summary>
    ///  The column families configured for this table, mapped by column family id.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::Google.Bigtable.Admin.Table.V1.ColumnFamily> ColumnFamilies {
      get { return columnFamilies_; }
    }

    /// <summary>Field number for the "granularity" field.</summary>
    public const int GranularityFieldNumber = 4;
    private global::Google.Bigtable.Admin.Table.V1.Table.Types.TimestampGranularity granularity_ = 0;
    /// <summary>
    ///  The granularity (e.g. MILLIS, MICROS) at which timestamps are stored in
    ///  this table. Timestamps not matching the granularity will be rejected.
    ///  Cannot be changed once the table is created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Bigtable.Admin.Table.V1.Table.Types.TimestampGranularity Granularity {
      get { return granularity_; }
      set {
        granularity_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Table);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Table other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(CurrentOperation, other.CurrentOperation)) return false;
      if (!ColumnFamilies.Equals(other.ColumnFamilies)) return false;
      if (Granularity != other.Granularity) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (currentOperation_ != null) hash ^= CurrentOperation.GetHashCode();
      hash ^= ColumnFamilies.GetHashCode();
      if (Granularity != 0) hash ^= Granularity.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (currentOperation_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CurrentOperation);
      }
      columnFamilies_.WriteTo(output, _map_columnFamilies_codec);
      if (Granularity != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Granularity);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (currentOperation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurrentOperation);
      }
      size += columnFamilies_.CalculateSize(_map_columnFamilies_codec);
      if (Granularity != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Granularity);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Table other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.currentOperation_ != null) {
        if (currentOperation_ == null) {
          currentOperation_ = new global::Google.LongRunning.Operation();
        }
        CurrentOperation.MergeFrom(other.CurrentOperation);
      }
      columnFamilies_.Add(other.columnFamilies_);
      if (other.Granularity != 0) {
        Granularity = other.Granularity;
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (currentOperation_ == null) {
              currentOperation_ = new global::Google.LongRunning.Operation();
            }
            input.ReadMessage(currentOperation_);
            break;
          }
          case 26: {
            columnFamilies_.AddEntriesFrom(input, _map_columnFamilies_codec);
            break;
          }
          case 32: {
            granularity_ = (global::Google.Bigtable.Admin.Table.V1.Table.Types.TimestampGranularity) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Table message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum TimestampGranularity {
        [pbr::OriginalName("MILLIS")] Millis = 0,
      }

    }
    #endregion

  }

  /// <summary>
  ///  A set of columns within a table which share a common configuration.
  /// </summary>
  public sealed partial class ColumnFamily : pb::IMessage<ColumnFamily> {
    private static readonly pb::MessageParser<ColumnFamily> _parser = new pb::MessageParser<ColumnFamily>(() => new ColumnFamily());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ColumnFamily> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Bigtable.Admin.Table.V1.BigtableTableDataReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ColumnFamily() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ColumnFamily(ColumnFamily other) : this() {
      name_ = other.name_;
      gcExpression_ = other.gcExpression_;
      GcRule = other.gcRule_ != null ? other.GcRule.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ColumnFamily Clone() {
      return new ColumnFamily(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    ///  A unique identifier of the form &lt;table_name>/columnFamilies/[-_.a-zA-Z0-9]+
    ///  The last segment is the same as the "name" field in
    ///  google.bigtable.v1.Family.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "gc_expression" field.</summary>
    public const int GcExpressionFieldNumber = 2;
    private string gcExpression_ = "";
    /// <summary>
    ///  Garbage collection expression specified by the following grammar:
    ///    GC = EXPR
    ///       | "" ;
    ///    EXPR = EXPR, "||", EXPR              (* lowest precedence *)
    ///         | EXPR, "&amp;&amp;", EXPR
    ///         | "(", EXPR, ")"                (* highest precedence *)
    ///         | PROP ;
    ///    PROP = "version() >", NUM32
    ///         | "age() >", NUM64, [ UNIT ] ;
    ///    NUM32 = non-zero-digit { digit } ;    (* # NUM32 &lt;= 2^32 - 1 *)
    ///    NUM64 = non-zero-digit { digit } ;    (* # NUM64 &lt;= 2^63 - 1 *)
    ///    UNIT =  "d" | "h" | "m"  (* d=days, h=hours, m=minutes, else micros *)
    ///  GC expressions can be up to 500 characters in length
    ///
    ///  The different types of PROP are defined as follows:
    ///    version() - cell index, counting from most recent and starting at 1
    ///    age() - age of the cell (current time minus cell timestamp)
    ///
    ///  Example: "version() > 3 || (age() > 3d &amp;&amp; version() > 1)"
    ///    drop cells beyond the most recent three, and drop cells older than three
    ///    days unless they're the most recent cell in the row/column
    ///
    ///  Garbage collection executes opportunistically in the background, and so
    ///  it's possible for reads to return a cell even if it matches the active GC
    ///  expression for its family.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string GcExpression {
      get { return gcExpression_; }
      set {
        gcExpression_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "gc_rule" field.</summary>
    public const int GcRuleFieldNumber = 3;
    private global::Google.Bigtable.Admin.Table.V1.GcRule gcRule_;
    /// <summary>
    ///  Garbage collection rule specified as a protobuf.
    ///  Supersedes `gc_expression`.
    ///  Must serialize to at most 500 bytes.
    ///
    ///  NOTE: Garbage collection executes opportunistically in the background, and
    ///  so it's possible for reads to return a cell even if it matches the active
    ///  GC expression for its family.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Bigtable.Admin.Table.V1.GcRule GcRule {
      get { return gcRule_; }
      set {
        gcRule_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ColumnFamily);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ColumnFamily other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (GcExpression != other.GcExpression) return false;
      if (!object.Equals(GcRule, other.GcRule)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (GcExpression.Length != 0) hash ^= GcExpression.GetHashCode();
      if (gcRule_ != null) hash ^= GcRule.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (GcExpression.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(GcExpression);
      }
      if (gcRule_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(GcRule);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (GcExpression.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GcExpression);
      }
      if (gcRule_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GcRule);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ColumnFamily other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.GcExpression.Length != 0) {
        GcExpression = other.GcExpression;
      }
      if (other.gcRule_ != null) {
        if (gcRule_ == null) {
          gcRule_ = new global::Google.Bigtable.Admin.Table.V1.GcRule();
        }
        GcRule.MergeFrom(other.GcRule);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            GcExpression = input.ReadString();
            break;
          }
          case 26: {
            if (gcRule_ == null) {
              gcRule_ = new global::Google.Bigtable.Admin.Table.V1.GcRule();
            }
            input.ReadMessage(gcRule_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Rule for determining which cells to delete during garbage collection.
  /// </summary>
  public sealed partial class GcRule : pb::IMessage<GcRule> {
    private static readonly pb::MessageParser<GcRule> _parser = new pb::MessageParser<GcRule>(() => new GcRule());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GcRule> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Bigtable.Admin.Table.V1.BigtableTableDataReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GcRule() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GcRule(GcRule other) : this() {
      switch (other.RuleCase) {
        case RuleOneofCase.MaxNumVersions:
          MaxNumVersions = other.MaxNumVersions;
          break;
        case RuleOneofCase.MaxAge:
          MaxAge = other.MaxAge.Clone();
          break;
        case RuleOneofCase.Intersection:
          Intersection = other.Intersection.Clone();
          break;
        case RuleOneofCase.Union:
          Union = other.Union.Clone();
          break;
      }

    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GcRule Clone() {
      return new GcRule(this);
    }

    /// <summary>Field number for the "max_num_versions" field.</summary>
    public const int MaxNumVersionsFieldNumber = 1;
    /// <summary>
    ///  Delete all cells in a column except the most recent N.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MaxNumVersions {
      get { return ruleCase_ == RuleOneofCase.MaxNumVersions ? (int) rule_ : 0; }
      set {
        rule_ = value;
        ruleCase_ = RuleOneofCase.MaxNumVersions;
      }
    }

    /// <summary>Field number for the "max_age" field.</summary>
    public const int MaxAgeFieldNumber = 2;
    /// <summary>
    ///  Delete cells in a column older than the given age.
    ///  Values must be at least one millisecond, and will be truncated to
    ///  microsecond granularity.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration MaxAge {
      get { return ruleCase_ == RuleOneofCase.MaxAge ? (global::Google.Protobuf.WellKnownTypes.Duration) rule_ : null; }
      set {
        rule_ = value;
        ruleCase_ = value == null ? RuleOneofCase.None : RuleOneofCase.MaxAge;
      }
    }

    /// <summary>Field number for the "intersection" field.</summary>
    public const int IntersectionFieldNumber = 3;
    /// <summary>
    ///  Delete cells that would be deleted by every nested rule.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Bigtable.Admin.Table.V1.GcRule.Types.Intersection Intersection {
      get { return ruleCase_ == RuleOneofCase.Intersection ? (global::Google.Bigtable.Admin.Table.V1.GcRule.Types.Intersection) rule_ : null; }
      set {
        rule_ = value;
        ruleCase_ = value == null ? RuleOneofCase.None : RuleOneofCase.Intersection;
      }
    }

    /// <summary>Field number for the "union" field.</summary>
    public const int UnionFieldNumber = 4;
    /// <summary>
    ///  Delete cells that would be deleted by any nested rule.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Bigtable.Admin.Table.V1.GcRule.Types.Union Union {
      get { return ruleCase_ == RuleOneofCase.Union ? (global::Google.Bigtable.Admin.Table.V1.GcRule.Types.Union) rule_ : null; }
      set {
        rule_ = value;
        ruleCase_ = value == null ? RuleOneofCase.None : RuleOneofCase.Union;
      }
    }

    private object rule_;
    /// <summary>Enum of possible cases for the "rule" oneof.</summary>
    public enum RuleOneofCase {
      None = 0,
      MaxNumVersions = 1,
      MaxAge = 2,
      Intersection = 3,
      Union = 4,
    }
    private RuleOneofCase ruleCase_ = RuleOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RuleOneofCase RuleCase {
      get { return ruleCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearRule() {
      ruleCase_ = RuleOneofCase.None;
      rule_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GcRule);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GcRule other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MaxNumVersions != other.MaxNumVersions) return false;
      if (!object.Equals(MaxAge, other.MaxAge)) return false;
      if (!object.Equals(Intersection, other.Intersection)) return false;
      if (!object.Equals(Union, other.Union)) return false;
      if (RuleCase != other.RuleCase) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ruleCase_ == RuleOneofCase.MaxNumVersions) hash ^= MaxNumVersions.GetHashCode();
      if (ruleCase_ == RuleOneofCase.MaxAge) hash ^= MaxAge.GetHashCode();
      if (ruleCase_ == RuleOneofCase.Intersection) hash ^= Intersection.GetHashCode();
      if (ruleCase_ == RuleOneofCase.Union) hash ^= Union.GetHashCode();
      hash ^= (int) ruleCase_;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ruleCase_ == RuleOneofCase.MaxNumVersions) {
        output.WriteRawTag(8);
        output.WriteInt32(MaxNumVersions);
      }
      if (ruleCase_ == RuleOneofCase.MaxAge) {
        output.WriteRawTag(18);
        output.WriteMessage(MaxAge);
      }
      if (ruleCase_ == RuleOneofCase.Intersection) {
        output.WriteRawTag(26);
        output.WriteMessage(Intersection);
      }
      if (ruleCase_ == RuleOneofCase.Union) {
        output.WriteRawTag(34);
        output.WriteMessage(Union);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ruleCase_ == RuleOneofCase.MaxNumVersions) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxNumVersions);
      }
      if (ruleCase_ == RuleOneofCase.MaxAge) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MaxAge);
      }
      if (ruleCase_ == RuleOneofCase.Intersection) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Intersection);
      }
      if (ruleCase_ == RuleOneofCase.Union) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Union);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GcRule other) {
      if (other == null) {
        return;
      }
      switch (other.RuleCase) {
        case RuleOneofCase.MaxNumVersions:
          MaxNumVersions = other.MaxNumVersions;
          break;
        case RuleOneofCase.MaxAge:
          MaxAge = other.MaxAge;
          break;
        case RuleOneofCase.Intersection:
          Intersection = other.Intersection;
          break;
        case RuleOneofCase.Union:
          Union = other.Union;
          break;
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
          case 8: {
            MaxNumVersions = input.ReadInt32();
            break;
          }
          case 18: {
            global::Google.Protobuf.WellKnownTypes.Duration subBuilder = new global::Google.Protobuf.WellKnownTypes.Duration();
            if (ruleCase_ == RuleOneofCase.MaxAge) {
              subBuilder.MergeFrom(MaxAge);
            }
            input.ReadMessage(subBuilder);
            MaxAge = subBuilder;
            break;
          }
          case 26: {
            global::Google.Bigtable.Admin.Table.V1.GcRule.Types.Intersection subBuilder = new global::Google.Bigtable.Admin.Table.V1.GcRule.Types.Intersection();
            if (ruleCase_ == RuleOneofCase.Intersection) {
              subBuilder.MergeFrom(Intersection);
            }
            input.ReadMessage(subBuilder);
            Intersection = subBuilder;
            break;
          }
          case 34: {
            global::Google.Bigtable.Admin.Table.V1.GcRule.Types.Union subBuilder = new global::Google.Bigtable.Admin.Table.V1.GcRule.Types.Union();
            if (ruleCase_ == RuleOneofCase.Union) {
              subBuilder.MergeFrom(Union);
            }
            input.ReadMessage(subBuilder);
            Union = subBuilder;
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the GcRule message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      ///  A GcRule which deletes cells matching all of the given rules.
      /// </summary>
      public sealed partial class Intersection : pb::IMessage<Intersection> {
        private static readonly pb::MessageParser<Intersection> _parser = new pb::MessageParser<Intersection>(() => new Intersection());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Intersection> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Bigtable.Admin.Table.V1.GcRule.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Intersection() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Intersection(Intersection other) : this() {
          rules_ = other.rules_.Clone();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Intersection Clone() {
          return new Intersection(this);
        }

        /// <summary>Field number for the "rules" field.</summary>
        public const int RulesFieldNumber = 1;
        private static readonly pb::FieldCodec<global::Google.Bigtable.Admin.Table.V1.GcRule> _repeated_rules_codec
            = pb::FieldCodec.ForMessage(10, global::Google.Bigtable.Admin.Table.V1.GcRule.Parser);
        private readonly pbc::RepeatedField<global::Google.Bigtable.Admin.Table.V1.GcRule> rules_ = new pbc::RepeatedField<global::Google.Bigtable.Admin.Table.V1.GcRule>();
        /// <summary>
        ///  Only delete cells which would be deleted by every element of `rules`.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::Google.Bigtable.Admin.Table.V1.GcRule> Rules {
          get { return rules_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Intersection);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Intersection other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if(!rules_.Equals(other.rules_)) return false;
          return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          hash ^= rules_.GetHashCode();
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          rules_.WriteTo(output, _repeated_rules_codec);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          size += rules_.CalculateSize(_repeated_rules_codec);
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Intersection other) {
          if (other == null) {
            return;
          }
          rules_.Add(other.rules_);
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
                rules_.AddEntriesFrom(input, _repeated_rules_codec);
                break;
              }
            }
          }
        }

      }

      /// <summary>
      ///  A GcRule which deletes cells matching any of the given rules.
      /// </summary>
      public sealed partial class Union : pb::IMessage<Union> {
        private static readonly pb::MessageParser<Union> _parser = new pb::MessageParser<Union>(() => new Union());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Union> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Bigtable.Admin.Table.V1.GcRule.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Union() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Union(Union other) : this() {
          rules_ = other.rules_.Clone();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Union Clone() {
          return new Union(this);
        }

        /// <summary>Field number for the "rules" field.</summary>
        public const int RulesFieldNumber = 1;
        private static readonly pb::FieldCodec<global::Google.Bigtable.Admin.Table.V1.GcRule> _repeated_rules_codec
            = pb::FieldCodec.ForMessage(10, global::Google.Bigtable.Admin.Table.V1.GcRule.Parser);
        private readonly pbc::RepeatedField<global::Google.Bigtable.Admin.Table.V1.GcRule> rules_ = new pbc::RepeatedField<global::Google.Bigtable.Admin.Table.V1.GcRule>();
        /// <summary>
        ///  Delete cells which would be deleted by any element of `rules`.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::Google.Bigtable.Admin.Table.V1.GcRule> Rules {
          get { return rules_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Union);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Union other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if(!rules_.Equals(other.rules_)) return false;
          return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          hash ^= rules_.GetHashCode();
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          rules_.WriteTo(output, _repeated_rules_codec);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          size += rules_.CalculateSize(_repeated_rules_codec);
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Union other) {
          if (other == null) {
            return;
          }
          rules_.Add(other.rules_);
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
                rules_.AddEntriesFrom(input, _repeated_rules_codec);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
