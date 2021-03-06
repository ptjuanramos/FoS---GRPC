// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/flight.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ServerFoS {

  /// <summary>Holder for reflection information generated from Protos/flight.proto</summary>
  public static partial class FlightReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/flight.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FlightReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNQcm90b3MvZmxpZ2h0LnByb3RvIhUKBEd1aWQSDQoFdmFsdWUYASABKAki",
            "RAoRQmluZEZsaWdodFJlcXVlc3QSGQoEdHlwZRgBIAEoDjILLkZsaWdodFR5",
            "cGUSFAoMZmxpZ2h0TnVtYmVyGAIgASgJIlgKEkJpbmRGbGlnaHRSZXNwb25z",
            "ZRIRCgJpZBgBIAEoCzIFLkd1aWQSGQoEdHlwZRgCIAEoDjILLkZsaWdodFR5",
            "cGUSFAoMZmxpZ2h0TnVtYmVyGAMgASgJKi0KCkZsaWdodFR5cGUSDAoIUmVn",
            "aW9uYWwQABIRCg1JbnRlcm5hdGlvbmFsEAEyPwoGRmxpZ2h0EjUKCkJpbmRG",
            "bGlnaHQSEi5CaW5kRmxpZ2h0UmVxdWVzdBoTLkJpbmRGbGlnaHRSZXNwb25z",
            "ZUIMqgIJU2VydmVyRm9TYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::ServerFoS.FlightType), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ServerFoS.Guid), global::ServerFoS.Guid.Parser, new[]{ "Value" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ServerFoS.BindFlightRequest), global::ServerFoS.BindFlightRequest.Parser, new[]{ "Type", "FlightNumber" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ServerFoS.BindFlightResponse), global::ServerFoS.BindFlightResponse.Parser, new[]{ "Id", "Type", "FlightNumber" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum FlightType {
    [pbr::OriginalName("Regional")] Regional = 0,
    [pbr::OriginalName("International")] International = 1,
  }

  #endregion

  #region Messages
  public sealed partial class Guid : pb::IMessage<Guid> {
    private static readonly pb::MessageParser<Guid> _parser = new pb::MessageParser<Guid>(() => new Guid());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Guid> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ServerFoS.FlightReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Guid() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Guid(Guid other) : this() {
      value_ = other.value_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Guid Clone() {
      return new Guid(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private string value_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Value {
      get { return value_; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Guid);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Guid other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Value.Length != 0) hash ^= Value.GetHashCode();
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
      if (Value.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Guid other) {
      if (other == null) {
        return;
      }
      if (other.Value.Length != 0) {
        Value = other.Value;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Value = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class BindFlightRequest : pb::IMessage<BindFlightRequest> {
    private static readonly pb::MessageParser<BindFlightRequest> _parser = new pb::MessageParser<BindFlightRequest>(() => new BindFlightRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BindFlightRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ServerFoS.FlightReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BindFlightRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BindFlightRequest(BindFlightRequest other) : this() {
      type_ = other.type_;
      flightNumber_ = other.flightNumber_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BindFlightRequest Clone() {
      return new BindFlightRequest(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::ServerFoS.FlightType type_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ServerFoS.FlightType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "flightNumber" field.</summary>
    public const int FlightNumberFieldNumber = 2;
    private string flightNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FlightNumber {
      get { return flightNumber_; }
      set {
        flightNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BindFlightRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BindFlightRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (FlightNumber != other.FlightNumber) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != 0) hash ^= Type.GetHashCode();
      if (FlightNumber.Length != 0) hash ^= FlightNumber.GetHashCode();
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
      if (Type != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (FlightNumber.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FlightNumber);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (FlightNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FlightNumber);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BindFlightRequest other) {
      if (other == null) {
        return;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.FlightNumber.Length != 0) {
        FlightNumber = other.FlightNumber;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Type = (global::ServerFoS.FlightType) input.ReadEnum();
            break;
          }
          case 18: {
            FlightNumber = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class BindFlightResponse : pb::IMessage<BindFlightResponse> {
    private static readonly pb::MessageParser<BindFlightResponse> _parser = new pb::MessageParser<BindFlightResponse>(() => new BindFlightResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BindFlightResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ServerFoS.FlightReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BindFlightResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BindFlightResponse(BindFlightResponse other) : this() {
      id_ = other.id_ != null ? other.id_.Clone() : null;
      type_ = other.type_;
      flightNumber_ = other.flightNumber_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BindFlightResponse Clone() {
      return new BindFlightResponse(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private global::ServerFoS.Guid id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ServerFoS.Guid Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private global::ServerFoS.FlightType type_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ServerFoS.FlightType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "flightNumber" field.</summary>
    public const int FlightNumberFieldNumber = 3;
    private string flightNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FlightNumber {
      get { return flightNumber_; }
      set {
        flightNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BindFlightResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BindFlightResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Id, other.Id)) return false;
      if (Type != other.Type) return false;
      if (FlightNumber != other.FlightNumber) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (id_ != null) hash ^= Id.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (FlightNumber.Length != 0) hash ^= FlightNumber.GetHashCode();
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
      if (id_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Id);
      }
      if (Type != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (FlightNumber.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(FlightNumber);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (id_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Id);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (FlightNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FlightNumber);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BindFlightResponse other) {
      if (other == null) {
        return;
      }
      if (other.id_ != null) {
        if (id_ == null) {
          Id = new global::ServerFoS.Guid();
        }
        Id.MergeFrom(other.Id);
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.FlightNumber.Length != 0) {
        FlightNumber = other.FlightNumber;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (id_ == null) {
              Id = new global::ServerFoS.Guid();
            }
            input.ReadMessage(Id);
            break;
          }
          case 16: {
            Type = (global::ServerFoS.FlightType) input.ReadEnum();
            break;
          }
          case 26: {
            FlightNumber = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
