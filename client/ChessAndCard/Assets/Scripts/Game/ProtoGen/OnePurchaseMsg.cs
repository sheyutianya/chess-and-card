//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: OnePurchaseMsg.proto
// Note: requires additional types generated from: GuildMsg.proto
using GuildMsg;
namespace OnePurchaseMsg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2COnePurchase")]
  public partial class S2COnePurchase : global::ProtoBuf.IExtensible
  {
    public S2COnePurchase() {}
    
    private bool _result = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool result
    {
      get { return _result; }
      set { _result = value; }
    }
    private long _activtyEfficientTime = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"activtyEfficientTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long activtyEfficientTime
    {
      get { return _activtyEfficientTime; }
      set { _activtyEfficientTime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2SOnePurchaseBox")]
  public partial class C2SOnePurchaseBox : global::ProtoBuf.IExtensible
  {
    public C2SOnePurchaseBox() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2COnePurchaseBox")]
  public partial class S2COnePurchaseBox : global::ProtoBuf.IExtensible
  {
    public S2COnePurchaseBox() {}
    
    private bool _result = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool result
    {
      get { return _result; }
      set { _result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2COnePurchaseBoxPush")]
  public partial class S2COnePurchaseBoxPush : global::ProtoBuf.IExtensible
  {
    public S2COnePurchaseBoxPush() {}
    
    private int _boxId = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"boxId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int boxId
    {
      get { return _boxId; }
      set { _boxId = value; }
    }
    private long _boxEfficientTime = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"boxEfficientTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long boxEfficientTime
    {
      get { return _boxEfficientTime; }
      set { _boxEfficientTime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2SOnePurchaseOpenBox")]
  public partial class C2SOnePurchaseOpenBox : global::ProtoBuf.IExtensible
  {
    public C2SOnePurchaseOpenBox() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2COnePurchaseOpenBox")]
  public partial class S2COnePurchaseOpenBox : global::ProtoBuf.IExtensible
  {
    public S2COnePurchaseOpenBox() {}
    
    private bool _result = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool result
    {
      get { return _result; }
      set { _result = value; }
    }
    private readonly global::System.Collections.Generic.List<BoxCardInfo> _Infos = new global::System.Collections.Generic.List<BoxCardInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"Infos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<BoxCardInfo> Infos
    {
      get { return _Infos; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BoxCardInfo")]
  public partial class BoxCardInfo : global::ProtoBuf.IExtensible
  {
    public BoxCardInfo() {}
    
    private int _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private Item _item;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Item item
    {
      get { return _item; }
      set { _item = value; }
    }
    private int _heroId = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"heroId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int heroId
    {
      get { return _heroId; }
      set { _heroId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2SOnePurchaseCheckBuy")]
  public partial class C2SOnePurchaseCheckBuy : global::ProtoBuf.IExtensible
  {
    public C2SOnePurchaseCheckBuy() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2COnePurchaseCheckBuy")]
  public partial class S2COnePurchaseCheckBuy : global::ProtoBuf.IExtensible
  {
    public S2COnePurchaseCheckBuy() {}
    
    private int _buyCount = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"buyCount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int buyCount
    {
      get { return _buyCount; }
      set { _buyCount = value; }
    }
    private int _useCount = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"useCount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int useCount
    {
      get { return _useCount; }
      set { _useCount = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}