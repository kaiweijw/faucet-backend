// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: parliament_auth_contract.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AElf.Client.ParliamentAuth {

  /// <summary>Holder for reflection information generated from parliament_auth_contract.proto</summary>
  public static partial class ParliamentAuthContractReflection {

    #region Descriptor
    /// <summary>File descriptor for parliament_auth_contract.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ParliamentAuthContractReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5wYXJsaWFtZW50X2F1dGhfY29udHJhY3QucHJvdG8aDGNsaWVudC5wcm90",
            "byI0Cg5Qcm9wb3NhbElkTGlzdBIiCgxwcm9wb3NhbF9pZHMYASADKAsyDC5j",
            "bGllbnQuSGFzaCKkAgoMT3JnYW5pemF0aW9uEiMKG3Byb3Bvc2VyX2F1dGhv",
            "cml0eV9yZXF1aXJlZBgBIAEoCBItChRvcmdhbml6YXRpb25fYWRkcmVzcxgC",
            "IAEoCzIPLmNsaWVudC5BZGRyZXNzEicKEW9yZ2FuaXphdGlvbl9oYXNoGAMg",
            "ASgLMgwuY2xpZW50Lkhhc2gSRAoacHJvcG9zYWxfcmVsZWFzZV90aHJlc2hv",
            "bGQYBCABKAsyIC5jbGllbnQuUHJvcG9zYWxSZWxlYXNlVGhyZXNob2xkEisK",
            "I3BhcmxpYW1lbnRfbWVtYmVyX3Byb3Bvc2luZ19hbGxvd2VkGAUgASgIEiQK",
            "DmNyZWF0aW9uX3Rva2VuGAYgASgLMgwuY2xpZW50Lkhhc2hCHaoCGkFFbGYu",
            "Q2xpZW50LlBhcmxpYW1lbnRBdXRoYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AElf.Client.Proto.ClientReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Client.ParliamentAuth.ProposalIdList), global::AElf.Client.ParliamentAuth.ProposalIdList.Parser, new[]{ "ProposalIds" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Client.ParliamentAuth.Organization), global::AElf.Client.ParliamentAuth.Organization.Parser, new[]{ "ProposerAuthorityRequired", "OrganizationAddress", "OrganizationHash", "ProposalReleaseThreshold", "ParliamentMemberProposingAllowed", "CreationToken" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///parliament_auth
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ProposalIdList : pb::IMessage<ProposalIdList>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProposalIdList> _parser = new pb::MessageParser<ProposalIdList>(() => new ProposalIdList());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProposalIdList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Client.ParliamentAuth.ParliamentAuthContractReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProposalIdList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProposalIdList(ProposalIdList other) : this() {
      proposalIds_ = other.proposalIds_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProposalIdList Clone() {
      return new ProposalIdList(this);
    }

    /// <summary>Field number for the "proposal_ids" field.</summary>
    public const int ProposalIdsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::AElf.Client.Proto.Hash> _repeated_proposalIds_codec
        = pb::FieldCodec.ForMessage(10, global::AElf.Client.Proto.Hash.Parser);
    private readonly pbc::RepeatedField<global::AElf.Client.Proto.Hash> proposalIds_ = new pbc::RepeatedField<global::AElf.Client.Proto.Hash>();
    /// <summary>
    /// The list of proposal ids.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::AElf.Client.Proto.Hash> ProposalIds {
      get { return proposalIds_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProposalIdList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProposalIdList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!proposalIds_.Equals(other.proposalIds_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= proposalIds_.GetHashCode();
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
      proposalIds_.WriteTo(output, _repeated_proposalIds_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      proposalIds_.WriteTo(ref output, _repeated_proposalIds_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += proposalIds_.CalculateSize(_repeated_proposalIds_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProposalIdList other) {
      if (other == null) {
        return;
      }
      proposalIds_.Add(other.proposalIds_);
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
            proposalIds_.AddEntriesFrom(input, _repeated_proposalIds_codec);
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
            proposalIds_.AddEntriesFrom(ref input, _repeated_proposalIds_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Organization : pb::IMessage<Organization>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Organization> _parser = new pb::MessageParser<Organization>(() => new Organization());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Organization> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Client.ParliamentAuth.ParliamentAuthContractReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Organization() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Organization(Organization other) : this() {
      proposerAuthorityRequired_ = other.proposerAuthorityRequired_;
      organizationAddress_ = other.organizationAddress_ != null ? other.organizationAddress_.Clone() : null;
      organizationHash_ = other.organizationHash_ != null ? other.organizationHash_.Clone() : null;
      proposalReleaseThreshold_ = other.proposalReleaseThreshold_ != null ? other.proposalReleaseThreshold_.Clone() : null;
      parliamentMemberProposingAllowed_ = other.parliamentMemberProposingAllowed_;
      creationToken_ = other.creationToken_ != null ? other.creationToken_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Organization Clone() {
      return new Organization(this);
    }

    /// <summary>Field number for the "proposer_authority_required" field.</summary>
    public const int ProposerAuthorityRequiredFieldNumber = 1;
    private bool proposerAuthorityRequired_;
    /// <summary>
    /// Indicates if proposals need authority to be created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ProposerAuthorityRequired {
      get { return proposerAuthorityRequired_; }
      set {
        proposerAuthorityRequired_ = value;
      }
    }

    /// <summary>Field number for the "organization_address" field.</summary>
    public const int OrganizationAddressFieldNumber = 2;
    private global::AElf.Client.Proto.Address organizationAddress_;
    /// <summary>
    /// The organization address.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AElf.Client.Proto.Address OrganizationAddress {
      get { return organizationAddress_; }
      set {
        organizationAddress_ = value;
      }
    }

    /// <summary>Field number for the "organization_hash" field.</summary>
    public const int OrganizationHashFieldNumber = 3;
    private global::AElf.Client.Proto.Hash organizationHash_;
    /// <summary>
    /// The organization id.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AElf.Client.Proto.Hash OrganizationHash {
      get { return organizationHash_; }
      set {
        organizationHash_ = value;
      }
    }

    /// <summary>Field number for the "proposal_release_threshold" field.</summary>
    public const int ProposalReleaseThresholdFieldNumber = 4;
    private global::AElf.Client.Proto.ProposalReleaseThreshold proposalReleaseThreshold_;
    /// <summary>
    /// The threshold for releasing the proposal.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AElf.Client.Proto.ProposalReleaseThreshold ProposalReleaseThreshold {
      get { return proposalReleaseThreshold_; }
      set {
        proposalReleaseThreshold_ = value;
      }
    }

    /// <summary>Field number for the "parliament_member_proposing_allowed" field.</summary>
    public const int ParliamentMemberProposingAllowedFieldNumber = 5;
    private bool parliamentMemberProposingAllowed_;
    /// <summary>
    /// Indicates if parliament member can propose to this organization.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ParliamentMemberProposingAllowed {
      get { return parliamentMemberProposingAllowed_; }
      set {
        parliamentMemberProposingAllowed_ = value;
      }
    }

    /// <summary>Field number for the "creation_token" field.</summary>
    public const int CreationTokenFieldNumber = 6;
    private global::AElf.Client.Proto.Hash creationToken_;
    /// <summary>
    /// The creation token is for organization address generation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AElf.Client.Proto.Hash CreationToken {
      get { return creationToken_; }
      set {
        creationToken_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Organization);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Organization other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProposerAuthorityRequired != other.ProposerAuthorityRequired) return false;
      if (!object.Equals(OrganizationAddress, other.OrganizationAddress)) return false;
      if (!object.Equals(OrganizationHash, other.OrganizationHash)) return false;
      if (!object.Equals(ProposalReleaseThreshold, other.ProposalReleaseThreshold)) return false;
      if (ParliamentMemberProposingAllowed != other.ParliamentMemberProposingAllowed) return false;
      if (!object.Equals(CreationToken, other.CreationToken)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ProposerAuthorityRequired != false) hash ^= ProposerAuthorityRequired.GetHashCode();
      if (organizationAddress_ != null) hash ^= OrganizationAddress.GetHashCode();
      if (organizationHash_ != null) hash ^= OrganizationHash.GetHashCode();
      if (proposalReleaseThreshold_ != null) hash ^= ProposalReleaseThreshold.GetHashCode();
      if (ParliamentMemberProposingAllowed != false) hash ^= ParliamentMemberProposingAllowed.GetHashCode();
      if (creationToken_ != null) hash ^= CreationToken.GetHashCode();
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
      if (ProposerAuthorityRequired != false) {
        output.WriteRawTag(8);
        output.WriteBool(ProposerAuthorityRequired);
      }
      if (organizationAddress_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(OrganizationAddress);
      }
      if (organizationHash_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(OrganizationHash);
      }
      if (proposalReleaseThreshold_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ProposalReleaseThreshold);
      }
      if (ParliamentMemberProposingAllowed != false) {
        output.WriteRawTag(40);
        output.WriteBool(ParliamentMemberProposingAllowed);
      }
      if (creationToken_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CreationToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ProposerAuthorityRequired != false) {
        output.WriteRawTag(8);
        output.WriteBool(ProposerAuthorityRequired);
      }
      if (organizationAddress_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(OrganizationAddress);
      }
      if (organizationHash_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(OrganizationHash);
      }
      if (proposalReleaseThreshold_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ProposalReleaseThreshold);
      }
      if (ParliamentMemberProposingAllowed != false) {
        output.WriteRawTag(40);
        output.WriteBool(ParliamentMemberProposingAllowed);
      }
      if (creationToken_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CreationToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ProposerAuthorityRequired != false) {
        size += 1 + 1;
      }
      if (organizationAddress_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OrganizationAddress);
      }
      if (organizationHash_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OrganizationHash);
      }
      if (proposalReleaseThreshold_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProposalReleaseThreshold);
      }
      if (ParliamentMemberProposingAllowed != false) {
        size += 1 + 1;
      }
      if (creationToken_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreationToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Organization other) {
      if (other == null) {
        return;
      }
      if (other.ProposerAuthorityRequired != false) {
        ProposerAuthorityRequired = other.ProposerAuthorityRequired;
      }
      if (other.organizationAddress_ != null) {
        if (organizationAddress_ == null) {
          OrganizationAddress = new global::AElf.Client.Proto.Address();
        }
        OrganizationAddress.MergeFrom(other.OrganizationAddress);
      }
      if (other.organizationHash_ != null) {
        if (organizationHash_ == null) {
          OrganizationHash = new global::AElf.Client.Proto.Hash();
        }
        OrganizationHash.MergeFrom(other.OrganizationHash);
      }
      if (other.proposalReleaseThreshold_ != null) {
        if (proposalReleaseThreshold_ == null) {
          ProposalReleaseThreshold = new global::AElf.Client.Proto.ProposalReleaseThreshold();
        }
        ProposalReleaseThreshold.MergeFrom(other.ProposalReleaseThreshold);
      }
      if (other.ParliamentMemberProposingAllowed != false) {
        ParliamentMemberProposingAllowed = other.ParliamentMemberProposingAllowed;
      }
      if (other.creationToken_ != null) {
        if (creationToken_ == null) {
          CreationToken = new global::AElf.Client.Proto.Hash();
        }
        CreationToken.MergeFrom(other.CreationToken);
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
          case 8: {
            ProposerAuthorityRequired = input.ReadBool();
            break;
          }
          case 18: {
            if (organizationAddress_ == null) {
              OrganizationAddress = new global::AElf.Client.Proto.Address();
            }
            input.ReadMessage(OrganizationAddress);
            break;
          }
          case 26: {
            if (organizationHash_ == null) {
              OrganizationHash = new global::AElf.Client.Proto.Hash();
            }
            input.ReadMessage(OrganizationHash);
            break;
          }
          case 34: {
            if (proposalReleaseThreshold_ == null) {
              ProposalReleaseThreshold = new global::AElf.Client.Proto.ProposalReleaseThreshold();
            }
            input.ReadMessage(ProposalReleaseThreshold);
            break;
          }
          case 40: {
            ParliamentMemberProposingAllowed = input.ReadBool();
            break;
          }
          case 50: {
            if (creationToken_ == null) {
              CreationToken = new global::AElf.Client.Proto.Hash();
            }
            input.ReadMessage(CreationToken);
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
          case 8: {
            ProposerAuthorityRequired = input.ReadBool();
            break;
          }
          case 18: {
            if (organizationAddress_ == null) {
              OrganizationAddress = new global::AElf.Client.Proto.Address();
            }
            input.ReadMessage(OrganizationAddress);
            break;
          }
          case 26: {
            if (organizationHash_ == null) {
              OrganizationHash = new global::AElf.Client.Proto.Hash();
            }
            input.ReadMessage(OrganizationHash);
            break;
          }
          case 34: {
            if (proposalReleaseThreshold_ == null) {
              ProposalReleaseThreshold = new global::AElf.Client.Proto.ProposalReleaseThreshold();
            }
            input.ReadMessage(ProposalReleaseThreshold);
            break;
          }
          case 40: {
            ParliamentMemberProposingAllowed = input.ReadBool();
            break;
          }
          case 50: {
            if (creationToken_ == null) {
              CreationToken = new global::AElf.Client.Proto.Hash();
            }
            input.ReadMessage(CreationToken);
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
