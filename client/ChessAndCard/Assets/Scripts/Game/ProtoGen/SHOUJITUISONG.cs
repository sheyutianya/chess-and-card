//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: shoujituisong.proto
namespace deploy
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SHOUJITUISONG")]
  public partial class SHOUJITUISONG : global::ProtoBuf.IExtensible
  {
    public SHOUJITUISONG() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _tuisong_id = (int)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"tuisong_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int tuisong_id
    {
      get { return _tuisong_id; }
      set { _tuisong_id = value; }
    }
    private int _biaoti;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"biaoti", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int biaoti
    {
      get { return _biaoti; }
      set { _biaoti = value; }
    }
    private int _ticker_tips;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ticker_tips", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ticker_tips
    {
      get { return _ticker_tips; }
      set { _ticker_tips = value; }
    }
    private int _youxianji = (int)0;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"youxianji", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int youxianji
    {
      get { return _youxianji; }
      set { _youxianji = value; }
    }
    private int _tuisong_mubiao = (int)0;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"tuisong_mubiao", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int tuisong_mubiao
    {
      get { return _tuisong_mubiao; }
      set { _tuisong_mubiao = value; }
    }
    private int _tuisong_fangshi = (int)0;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"tuisong_fangshi", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int tuisong_fangshi
    {
      get { return _tuisong_fangshi; }
      set { _tuisong_fangshi = value; }
    }
    private string _tuisong_shijian = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"tuisong_shijian", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tuisong_shijian
    {
      get { return _tuisong_shijian; }
      set { _tuisong_shijian = value; }
    }
    private int _tuisong = (int)0;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"tuisong", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int tuisong
    {
      get { return _tuisong; }
      set { _tuisong = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SHOUJITUISONG_ARRAY")]
  public partial class SHOUJITUISONG_ARRAY : global::ProtoBuf.IExtensible
  {
    public SHOUJITUISONG_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<deploy.SHOUJITUISONG> _items = new global::System.Collections.Generic.List<deploy.SHOUJITUISONG>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.SHOUJITUISONG> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}