//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: RankMsg.proto
// Note: requires additional types generated from: GuildMsg.proto
using GuildMsg;
namespace RankMsg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2SHeroTotalFightRank")]
  public partial class C2SHeroTotalFightRank : global::ProtoBuf.IExtensible
  {
    public C2SHeroTotalFightRank() {}
    
    private int _pageNo;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"pageNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int pageNo
    {
      get { return _pageNo; }
      set { _pageNo = value; }
    }
    private int _pageSize;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"pageSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int pageSize
    {
      get { return _pageSize; }
      set { _pageSize = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2CHeroTotalFightRank")]
  public partial class S2CHeroTotalFightRank : global::ProtoBuf.IExtensible
  {
    public S2CHeroTotalFightRank() {}
    
    private int _myRank;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"myRank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int myRank
    {
      get { return _myRank; }
      set { _myRank = value; }
    }
    private int _myValue;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"myValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int myValue
    {
      get { return _myValue; }
      set { _myValue = value; }
    }
    private readonly global::System.Collections.Generic.List<RankHeroTotal> _rankList = new global::System.Collections.Generic.List<RankHeroTotal>();
    [global::ProtoBuf.ProtoMember(3, Name=@"rankList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<RankHeroTotal> rankList
    {
      get { return _rankList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2SStageTotalStarRank")]
  public partial class C2SStageTotalStarRank : global::ProtoBuf.IExtensible
  {
    public C2SStageTotalStarRank() {}
    
    private int _pageNo;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"pageNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int pageNo
    {
      get { return _pageNo; }
      set { _pageNo = value; }
    }
    private int _pageSize;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"pageSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int pageSize
    {
      get { return _pageSize; }
      set { _pageSize = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2CStageTotalStarRank")]
  public partial class S2CStageTotalStarRank : global::ProtoBuf.IExtensible
  {
    public S2CStageTotalStarRank() {}
    
    private int _myRank;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"myRank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int myRank
    {
      get { return _myRank; }
      set { _myRank = value; }
    }
    private int _myValue;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"myValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int myValue
    {
      get { return _myValue; }
      set { _myValue = value; }
    }
    private readonly global::System.Collections.Generic.List<RankStageStar> _rankList = new global::System.Collections.Generic.List<RankStageStar>();
    [global::ProtoBuf.ProtoMember(3, Name=@"rankList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<RankStageStar> rankList
    {
      get { return _rankList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2SHeroSingleFightRank")]
  public partial class C2SHeroSingleFightRank : global::ProtoBuf.IExtensible
  {
    public C2SHeroSingleFightRank() {}
    
    private int _pageNo;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"pageNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int pageNo
    {
      get { return _pageNo; }
      set { _pageNo = value; }
    }
    private int _pageSize;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"pageSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int pageSize
    {
      get { return _pageSize; }
      set { _pageSize = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2CHeroSingleFightRank")]
  public partial class S2CHeroSingleFightRank : global::ProtoBuf.IExtensible
  {
    public S2CHeroSingleFightRank() {}
    
    private int _myRank;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"myRank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int myRank
    {
      get { return _myRank; }
      set { _myRank = value; }
    }
    private RankHeroSingle _myHero;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"myHero", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public RankHeroSingle myHero
    {
      get { return _myHero; }
      set { _myHero = value; }
    }
    private readonly global::System.Collections.Generic.List<RankHeroSingle> _rankList = new global::System.Collections.Generic.List<RankHeroSingle>();
    [global::ProtoBuf.ProtoMember(3, Name=@"rankList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<RankHeroSingle> rankList
    {
      get { return _rankList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2SPVPScoreRank")]
  public partial class C2SPVPScoreRank : global::ProtoBuf.IExtensible
  {
    public C2SPVPScoreRank() {}
    
    private int _pageNo;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"pageNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int pageNo
    {
      get { return _pageNo; }
      set { _pageNo = value; }
    }
    private int _pageSize;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"pageSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int pageSize
    {
      get { return _pageSize; }
      set { _pageSize = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2CPVPScoreRank")]
  public partial class S2CPVPScoreRank : global::ProtoBuf.IExtensible
  {
    public S2CPVPScoreRank() {}
    
    private int _myRank;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"myRank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int myRank
    {
      get { return _myRank; }
      set { _myRank = value; }
    }
    private int _myValue;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"myValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int myValue
    {
      get { return _myValue; }
      set { _myValue = value; }
    }
    private readonly global::System.Collections.Generic.List<RankPvPScore> _rankList = new global::System.Collections.Generic.List<RankPvPScore>();
    [global::ProtoBuf.ProtoMember(3, Name=@"rankList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<RankPvPScore> rankList
    {
      get { return _rankList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2SPVPCupRank")]
  public partial class C2SPVPCupRank : global::ProtoBuf.IExtensible
  {
    public C2SPVPCupRank() {}
    
    private int _pageNo;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"pageNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int pageNo
    {
      get { return _pageNo; }
      set { _pageNo = value; }
    }
    private int _pageSize;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"pageSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int pageSize
    {
      get { return _pageSize; }
      set { _pageSize = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2CPVPCupRank")]
  public partial class S2CPVPCupRank : global::ProtoBuf.IExtensible
  {
    public S2CPVPCupRank() {}
    
    private int _myRank;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"myRank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int myRank
    {
      get { return _myRank; }
      set { _myRank = value; }
    }
    private int _myValue;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"myValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int myValue
    {
      get { return _myValue; }
      set { _myValue = value; }
    }
    private readonly global::System.Collections.Generic.List<RankPvPCup> _rankList = new global::System.Collections.Generic.List<RankPvPCup>();
    [global::ProtoBuf.ProtoMember(3, Name=@"rankList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<RankPvPCup> rankList
    {
      get { return _rankList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2SExpeditionRank")]
  public partial class C2SExpeditionRank : global::ProtoBuf.IExtensible
  {
    public C2SExpeditionRank() {}
    
    private int _pageNo;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"pageNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int pageNo
    {
      get { return _pageNo; }
      set { _pageNo = value; }
    }
    private int _pageSize;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"pageSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int pageSize
    {
      get { return _pageSize; }
      set { _pageSize = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2CExpeditionRank")]
  public partial class S2CExpeditionRank : global::ProtoBuf.IExtensible
  {
    public S2CExpeditionRank() {}
    
    private int _myRank;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"myRank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int myRank
    {
      get { return _myRank; }
      set { _myRank = value; }
    }
    private int _myValue;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"myValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int myValue
    {
      get { return _myValue; }
      set { _myValue = value; }
    }
    private readonly global::System.Collections.Generic.List<RankExpedition> _rankList = new global::System.Collections.Generic.List<RankExpedition>();
    [global::ProtoBuf.ProtoMember(3, Name=@"rankList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<RankExpedition> rankList
    {
      get { return _rankList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2SPlayerCampInfo")]
  public partial class C2SPlayerCampInfo : global::ProtoBuf.IExtensible
  {
    public C2SPlayerCampInfo() {}
    
    private long _targetId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"targetId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long targetId
    {
      get { return _targetId; }
      set { _targetId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2CPlayerCampInfo")]
  public partial class S2CPlayerCampInfo : global::ProtoBuf.IExtensible
  {
    public S2CPlayerCampInfo() {}
    
    private long _playerId = (long)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((long)0)]
    public long playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _iconType = (int)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"iconType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int iconType
    {
      get { return _iconType; }
      set { _iconType = value; }
    }
    private string _icon = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string icon
    {
      get { return _icon; }
      set { _icon = value; }
    }
    private int _level = (int)0;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private int _vipLv = (int)0;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"vipLv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int vipLv
    {
      get { return _vipLv; }
      set { _vipLv = value; }
    }
    private string _unionName = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"unionName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string unionName
    {
      get { return _unionName; }
      set { _unionName = value; }
    }
    private readonly global::System.Collections.Generic.List<HeroInfo> _heroList = new global::System.Collections.Generic.List<HeroInfo>();
    [global::ProtoBuf.ProtoMember(8, Name=@"heroList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<HeroInfo> heroList
    {
      get { return _heroList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RankHeroTotal")]
  public partial class RankHeroTotal : global::ProtoBuf.IExtensible
  {
    public RankHeroTotal() {}
    
    private int _rankNo = (int)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"rankNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int rankNo
    {
      get { return _rankNo; }
      set { _rankNo = value; }
    }
    private long _playerId = (long)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((long)0)]
    public long playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _iconType = (int)0;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"iconType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int iconType
    {
      get { return _iconType; }
      set { _iconType = value; }
    }
    private string _icon = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string icon
    {
      get { return _icon; }
      set { _icon = value; }
    }
    private int _level = (int)0;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private int _vipLv = (int)0;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"vipLv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int vipLv
    {
      get { return _vipLv; }
      set { _vipLv = value; }
    }
    private int _fightVal = (int)0;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"fightVal", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int fightVal
    {
      get { return _fightVal; }
      set { _fightVal = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RankStageStar")]
  public partial class RankStageStar : global::ProtoBuf.IExtensible
  {
    public RankStageStar() {}
    
    private int _rankNo = (int)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"rankNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int rankNo
    {
      get { return _rankNo; }
      set { _rankNo = value; }
    }
    private long _playerId = (long)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((long)0)]
    public long playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _iconType = (int)0;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"iconType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int iconType
    {
      get { return _iconType; }
      set { _iconType = value; }
    }
    private string _icon = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string icon
    {
      get { return _icon; }
      set { _icon = value; }
    }
    private int _level = (int)0;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private int _vipLv = (int)0;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"vipLv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int vipLv
    {
      get { return _vipLv; }
      set { _vipLv = value; }
    }
    private int _stageStar = (int)0;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"stageStar", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int stageStar
    {
      get { return _stageStar; }
      set { _stageStar = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RankHeroSingle")]
  public partial class RankHeroSingle : global::ProtoBuf.IExtensible
  {
    public RankHeroSingle() {}
    
    private int _rankNo = (int)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"rankNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int rankNo
    {
      get { return _rankNo; }
      set { _rankNo = value; }
    }
    private long _playerId = (long)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((long)0)]
    public long playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _iconType = (int)0;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"iconType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int iconType
    {
      get { return _iconType; }
      set { _iconType = value; }
    }
    private string _icon = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string icon
    {
      get { return _icon; }
      set { _icon = value; }
    }
    private int _level = (int)0;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private int _vipLv = (int)0;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"vipLv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int vipLv
    {
      get { return _vipLv; }
      set { _vipLv = value; }
    }
    private int _fightVal = (int)0;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"fightVal", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int fightVal
    {
      get { return _fightVal; }
      set { _fightVal = value; }
    }
    private HeroInfo _heroInfo = null;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"heroInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public HeroInfo heroInfo
    {
      get { return _heroInfo; }
      set { _heroInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RankPvPScore")]
  public partial class RankPvPScore : global::ProtoBuf.IExtensible
  {
    public RankPvPScore() {}
    
    private int _rankNo = (int)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"rankNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int rankNo
    {
      get { return _rankNo; }
      set { _rankNo = value; }
    }
    private long _playerId = (long)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((long)0)]
    public long playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _iconType = (int)0;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"iconType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int iconType
    {
      get { return _iconType; }
      set { _iconType = value; }
    }
    private string _icon = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string icon
    {
      get { return _icon; }
      set { _icon = value; }
    }
    private int _level = (int)0;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private int _vipLv = (int)0;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"vipLv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int vipLv
    {
      get { return _vipLv; }
      set { _vipLv = value; }
    }
    private int _pvpScore = (int)0;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"pvpScore", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int pvpScore
    {
      get { return _pvpScore; }
      set { _pvpScore = value; }
    }
    private int _pvpWin = (int)0;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"pvpWin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int pvpWin
    {
      get { return _pvpWin; }
      set { _pvpWin = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RankPvPCup")]
  public partial class RankPvPCup : global::ProtoBuf.IExtensible
  {
    public RankPvPCup() {}
    
    private int _rankNo = (int)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"rankNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int rankNo
    {
      get { return _rankNo; }
      set { _rankNo = value; }
    }
    private long _playerId = (long)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((long)0)]
    public long playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _iconType = (int)0;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"iconType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int iconType
    {
      get { return _iconType; }
      set { _iconType = value; }
    }
    private string _icon = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string icon
    {
      get { return _icon; }
      set { _icon = value; }
    }
    private int _level = (int)0;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private int _vipLv = (int)0;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"vipLv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int vipLv
    {
      get { return _vipLv; }
      set { _vipLv = value; }
    }
    private int _pvpCup = (int)0;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"pvpCup", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int pvpCup
    {
      get { return _pvpCup; }
      set { _pvpCup = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RankExpedition")]
  public partial class RankExpedition : global::ProtoBuf.IExtensible
  {
    public RankExpedition() {}
    
    private int _rankNo = (int)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"rankNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int rankNo
    {
      get { return _rankNo; }
      set { _rankNo = value; }
    }
    private long _playerId = (long)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((long)0)]
    public long playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _iconType = (int)0;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"iconType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int iconType
    {
      get { return _iconType; }
      set { _iconType = value; }
    }
    private string _icon = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string icon
    {
      get { return _icon; }
      set { _icon = value; }
    }
    private int _level = (int)0;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private int _vipLv = (int)0;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"vipLv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int vipLv
    {
      get { return _vipLv; }
      set { _vipLv = value; }
    }
    private int _sorce = (int)0;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"sorce", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int sorce
    {
      get { return _sorce; }
      set { _sorce = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}