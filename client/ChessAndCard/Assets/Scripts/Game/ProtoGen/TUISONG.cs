//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: tuisong.proto
namespace deploy
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TUISONG")]
  public partial class TUISONG : global::ProtoBuf.IExtensible
  {
    public TUISONG() {}
    
    private int _items;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int items
    {
      get { return _items; }
      set { _items = value; }
    }
    private string _explain = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"explain", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string explain
    {
      get { return _explain; }
      set { _explain = value; }
    }
    private int _name = (int)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int name
    {
      get { return _name; }
      set { _name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TUISONG_ARRAY")]
  public partial class TUISONG_ARRAY : global::ProtoBuf.IExtensible
  {
    public TUISONG_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<deploy.TUISONG> _items = new global::System.Collections.Generic.List<deploy.TUISONG>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.TUISONG> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}