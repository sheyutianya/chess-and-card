//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: fenxiang.proto
namespace deploy
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FENXIANG")]
  public partial class FENXIANG : global::ProtoBuf.IExtensible
  {
    public FENXIANG() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _share;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"share", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int share
    {
      get { return _share; }
      set { _share = value; }
    }
    private int _sort = (int)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"sort", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int sort
    {
      get { return _sort; }
      set { _sort = value; }
    }
    private string _icon;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string icon
    {
      get { return _icon; }
      set { _icon = value; }
    }
    private int _times = (int)0;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"times", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int times
    {
      get { return _times; }
      set { _times = value; }
    }
    private string _param = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"param", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string param
    {
      get { return _param; }
      set { _param = value; }
    }
    private int _content_title = (int)0;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"content_title", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int content_title
    {
      get { return _content_title; }
      set { _content_title = value; }
    }
    private int _money = (int)0;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"money", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int money
    {
      get { return _money; }
      set { _money = value; }
    }
    private int _money_times = (int)0;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"money_times", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int money_times
    {
      get { return _money_times; }
      set { _money_times = value; }
    }
    private string _link = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"link", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string link
    {
      get { return _link; }
      set { _link = value; }
    }
    private int _content = (int)0;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int content
    {
      get { return _content; }
      set { _content = value; }
    }
    private int _link_caption = (int)0;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"link_caption", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int link_caption
    {
      get { return _link_caption; }
      set { _link_caption = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FENXIANG_ARRAY")]
  public partial class FENXIANG_ARRAY : global::ProtoBuf.IExtensible
  {
    public FENXIANG_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<deploy.FENXIANG> _items = new global::System.Collections.Generic.List<deploy.FENXIANG>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.FENXIANG> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}