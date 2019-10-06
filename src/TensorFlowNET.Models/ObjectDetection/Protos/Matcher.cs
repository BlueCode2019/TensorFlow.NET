// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: object_detection/protos/matcher.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow.Models.ObjectDetection.Protos {

  /// <summary>Holder for reflection information generated from object_detection/protos/matcher.proto</summary>
  public static partial class MatcherReflection {

    #region Descriptor
    /// <summary>File descriptor for object_detection/protos/matcher.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MatcherReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVvYmplY3RfZGV0ZWN0aW9uL3Byb3Rvcy9tYXRjaGVyLnByb3RvEhdvYmpl",
            "Y3RfZGV0ZWN0aW9uLnByb3Rvcxosb2JqZWN0X2RldGVjdGlvbi9wcm90b3Mv",
            "YXJnbWF4X21hdGNoZXIucHJvdG8aL29iamVjdF9kZXRlY3Rpb24vcHJvdG9z",
            "L2JpcGFydGl0ZV9tYXRjaGVyLnByb3RvIqQBCgdNYXRjaGVyEkAKDmFyZ21h",
            "eF9tYXRjaGVyGAEgASgLMiYub2JqZWN0X2RldGVjdGlvbi5wcm90b3MuQXJn",
            "TWF4TWF0Y2hlckgAEkYKEWJpcGFydGl0ZV9tYXRjaGVyGAIgASgLMikub2Jq",
            "ZWN0X2RldGVjdGlvbi5wcm90b3MuQmlwYXJ0aXRlTWF0Y2hlckgAQg8KDW1h",
            "dGNoZXJfb25lb2ZiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Tensorflow.Models.ObjectDetection.Protos.ArgmaxMatcherReflection.Descriptor, global::Tensorflow.Models.ObjectDetection.Protos.BipartiteMatcherReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Models.ObjectDetection.Protos.Matcher), global::Tensorflow.Models.ObjectDetection.Protos.Matcher.Parser, new[]{ "ArgmaxMatcher", "BipartiteMatcher" }, new[]{ "MatcherOneof" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Configuration proto for the matcher to be used in the object detection
  /// pipeline. See core/matcher.py for details.
  /// </summary>
  public sealed partial class Matcher : pb::IMessage<Matcher> {
    private static readonly pb::MessageParser<Matcher> _parser = new pb::MessageParser<Matcher>(() => new Matcher());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Matcher> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Models.ObjectDetection.Protos.MatcherReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Matcher() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Matcher(Matcher other) : this() {
      switch (other.MatcherOneofCase) {
        case MatcherOneofOneofCase.ArgmaxMatcher:
          ArgmaxMatcher = other.ArgmaxMatcher.Clone();
          break;
        case MatcherOneofOneofCase.BipartiteMatcher:
          BipartiteMatcher = other.BipartiteMatcher.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Matcher Clone() {
      return new Matcher(this);
    }

    /// <summary>Field number for the "argmax_matcher" field.</summary>
    public const int ArgmaxMatcherFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.Models.ObjectDetection.Protos.ArgMaxMatcher ArgmaxMatcher {
      get { return matcherOneofCase_ == MatcherOneofOneofCase.ArgmaxMatcher ? (global::Tensorflow.Models.ObjectDetection.Protos.ArgMaxMatcher) matcherOneof_ : null; }
      set {
        matcherOneof_ = value;
        matcherOneofCase_ = value == null ? MatcherOneofOneofCase.None : MatcherOneofOneofCase.ArgmaxMatcher;
      }
    }

    /// <summary>Field number for the "bipartite_matcher" field.</summary>
    public const int BipartiteMatcherFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.Models.ObjectDetection.Protos.BipartiteMatcher BipartiteMatcher {
      get { return matcherOneofCase_ == MatcherOneofOneofCase.BipartiteMatcher ? (global::Tensorflow.Models.ObjectDetection.Protos.BipartiteMatcher) matcherOneof_ : null; }
      set {
        matcherOneof_ = value;
        matcherOneofCase_ = value == null ? MatcherOneofOneofCase.None : MatcherOneofOneofCase.BipartiteMatcher;
      }
    }

    private object matcherOneof_;
    /// <summary>Enum of possible cases for the "matcher_oneof" oneof.</summary>
    public enum MatcherOneofOneofCase {
      None = 0,
      ArgmaxMatcher = 1,
      BipartiteMatcher = 2,
    }
    private MatcherOneofOneofCase matcherOneofCase_ = MatcherOneofOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MatcherOneofOneofCase MatcherOneofCase {
      get { return matcherOneofCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearMatcherOneof() {
      matcherOneofCase_ = MatcherOneofOneofCase.None;
      matcherOneof_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Matcher);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Matcher other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ArgmaxMatcher, other.ArgmaxMatcher)) return false;
      if (!object.Equals(BipartiteMatcher, other.BipartiteMatcher)) return false;
      if (MatcherOneofCase != other.MatcherOneofCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (matcherOneofCase_ == MatcherOneofOneofCase.ArgmaxMatcher) hash ^= ArgmaxMatcher.GetHashCode();
      if (matcherOneofCase_ == MatcherOneofOneofCase.BipartiteMatcher) hash ^= BipartiteMatcher.GetHashCode();
      hash ^= (int) matcherOneofCase_;
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
      if (matcherOneofCase_ == MatcherOneofOneofCase.ArgmaxMatcher) {
        output.WriteRawTag(10);
        output.WriteMessage(ArgmaxMatcher);
      }
      if (matcherOneofCase_ == MatcherOneofOneofCase.BipartiteMatcher) {
        output.WriteRawTag(18);
        output.WriteMessage(BipartiteMatcher);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (matcherOneofCase_ == MatcherOneofOneofCase.ArgmaxMatcher) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ArgmaxMatcher);
      }
      if (matcherOneofCase_ == MatcherOneofOneofCase.BipartiteMatcher) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BipartiteMatcher);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Matcher other) {
      if (other == null) {
        return;
      }
      switch (other.MatcherOneofCase) {
        case MatcherOneofOneofCase.ArgmaxMatcher:
          if (ArgmaxMatcher == null) {
            ArgmaxMatcher = new global::Tensorflow.Models.ObjectDetection.Protos.ArgMaxMatcher();
          }
          ArgmaxMatcher.MergeFrom(other.ArgmaxMatcher);
          break;
        case MatcherOneofOneofCase.BipartiteMatcher:
          if (BipartiteMatcher == null) {
            BipartiteMatcher = new global::Tensorflow.Models.ObjectDetection.Protos.BipartiteMatcher();
          }
          BipartiteMatcher.MergeFrom(other.BipartiteMatcher);
          break;
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
            global::Tensorflow.Models.ObjectDetection.Protos.ArgMaxMatcher subBuilder = new global::Tensorflow.Models.ObjectDetection.Protos.ArgMaxMatcher();
            if (matcherOneofCase_ == MatcherOneofOneofCase.ArgmaxMatcher) {
              subBuilder.MergeFrom(ArgmaxMatcher);
            }
            input.ReadMessage(subBuilder);
            ArgmaxMatcher = subBuilder;
            break;
          }
          case 18: {
            global::Tensorflow.Models.ObjectDetection.Protos.BipartiteMatcher subBuilder = new global::Tensorflow.Models.ObjectDetection.Protos.BipartiteMatcher();
            if (matcherOneofCase_ == MatcherOneofOneofCase.BipartiteMatcher) {
              subBuilder.MergeFrom(BipartiteMatcher);
            }
            input.ReadMessage(subBuilder);
            BipartiteMatcher = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
