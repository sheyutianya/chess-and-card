//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: guide_chess.proto
namespace deploy
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GUIDE_CHESS")]
  public partial class GUIDE_CHESS : global::ProtoBuf.IExtensible
  {
    public GUIDE_CHESS() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _chess_list = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"chess_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string chess_list
    {
      get { return _chess_list; }
      set { _chess_list = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GUIDE_CHESS_ARRAY")]
  public partial class GUIDE_CHESS_ARRAY : global::ProtoBuf.IExtensible
  {
    public GUIDE_CHESS_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<deploy.GUIDE_CHESS> _items = new global::System.Collections.Generic.List<deploy.GUIDE_CHESS>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.GUIDE_CHESS> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}