//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: skillbuff.proto
namespace deploy
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SKILLBUFF")]
  public partial class SKILLBUFF : global::ProtoBuf.IExtensible
  {
    public SKILLBUFF() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _desc = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string desc
    {
      get { return _desc; }
      set { _desc = value; }
    }
    private string _buff_icon = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"buff_icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string buff_icon
    {
      get { return _buff_icon; }
      set { _buff_icon = value; }
    }
    private int _skill_ai_id = (int)0;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"skill_ai_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int skill_ai_id
    {
      get { return _skill_ai_id; }
      set { _skill_ai_id = value; }
    }
    private int _pre_buff_flag = (int)0;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"pre_buff_flag", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int pre_buff_flag
    {
      get { return _pre_buff_flag; }
      set { _pre_buff_flag = value; }
    }
    private int _buff_moment = (int)0;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"buff_moment", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int buff_moment
    {
      get { return _buff_moment; }
      set { _buff_moment = value; }
    }
    private int _buff_mode = (int)0;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"buff_mode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int buff_mode
    {
      get { return _buff_mode; }
      set { _buff_mode = value; }
    }
    private int _buff_round = (int)0;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"buff_round", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int buff_round
    {
      get { return _buff_round; }
      set { _buff_round = value; }
    }
    private string _value_grow = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"value_grow", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string value_grow
    {
      get { return _value_grow; }
      set { _value_grow = value; }
    }
    private int _buff_type = (int)0;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"buff_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int buff_type
    {
      get { return _buff_type; }
      set { _buff_type = value; }
    }
    private int _attack_type = (int)0;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"attack_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int attack_type
    {
      get { return _attack_type; }
      set { _attack_type = value; }
    }
    private int _buff_sub_type = (int)0;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"buff_sub_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int buff_sub_type
    {
      get { return _buff_sub_type; }
      set { _buff_sub_type = value; }
    }
    private string _buff_mutex_type = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"buff_mutex_type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string buff_mutex_type
    {
      get { return _buff_mutex_type; }
      set { _buff_mutex_type = value; }
    }
    private int _buff_overlay = (int)0;
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"buff_overlay", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int buff_overlay
    {
      get { return _buff_overlay; }
      set { _buff_overlay = value; }
    }
    private int _damage_type = (int)0;
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"damage_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int damage_type
    {
      get { return _damage_type; }
      set { _damage_type = value; }
    }
    private string _target_type = "";
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"target_type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string target_type
    {
      get { return _target_type; }
      set { _target_type = value; }
    }
    private int _add_num = (int)0;
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"add_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int add_num
    {
      get { return _add_num; }
      set { _add_num = value; }
    }
    private string _hp_match = "";
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"hp_match", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hp_match
    {
      get { return _hp_match; }
      set { _hp_match = value; }
    }
    private int _shield_type = (int)0;
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"shield_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int shield_type
    {
      get { return _shield_type; }
      set { _shield_type = value; }
    }
    private int _combo_plus = (int)0;
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"combo_plus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int combo_plus
    {
      get { return _combo_plus; }
      set { _combo_plus = value; }
    }
    private int _target_num_plus = (int)0;
    [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"target_num_plus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int target_num_plus
    {
      get { return _target_num_plus; }
      set { _target_num_plus = value; }
    }
    private int _prob_base_factor = (int)0;
    [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"prob_base_factor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int prob_base_factor
    {
      get { return _prob_base_factor; }
      set { _prob_base_factor = value; }
    }
    private int _prob_grow_factor = (int)0;
    [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"prob_grow_factor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int prob_grow_factor
    {
      get { return _prob_grow_factor; }
      set { _prob_grow_factor = value; }
    }
    private int _shield_base_life = (int)0;
    [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"shield_base_life", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int shield_base_life
    {
      get { return _shield_base_life; }
      set { _shield_base_life = value; }
    }
    private int _shield_grow_life = (int)0;
    [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"shield_grow_life", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int shield_grow_life
    {
      get { return _shield_grow_life; }
      set { _shield_grow_life = value; }
    }
    private int _buff_factor_type = (int)0;
    [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"buff_factor_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int buff_factor_type
    {
      get { return _buff_factor_type; }
      set { _buff_factor_type = value; }
    }
    private int _buff_base_factor = (int)0;
    [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"buff_base_factor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int buff_base_factor
    {
      get { return _buff_base_factor; }
      set { _buff_base_factor = value; }
    }
    private int _buff_grow_factor = (int)0;
    [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"buff_grow_factor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int buff_grow_factor
    {
      get { return _buff_grow_factor; }
      set { _buff_grow_factor = value; }
    }
    private int _trigger_id = (int)0;
    [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"trigger_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int trigger_id
    {
      get { return _trigger_id; }
      set { _trigger_id = value; }
    }
    private int _trigger_base_factor = (int)0;
    [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"trigger_base_factor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int trigger_base_factor
    {
      get { return _trigger_base_factor; }
      set { _trigger_base_factor = value; }
    }
    private int _trigger_grow_factor = (int)0;
    [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"trigger_grow_factor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int trigger_grow_factor
    {
      get { return _trigger_grow_factor; }
      set { _trigger_grow_factor = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SKILLBUFF_ARRAY")]
  public partial class SKILLBUFF_ARRAY : global::ProtoBuf.IExtensible
  {
    public SKILLBUFF_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<deploy.SKILLBUFF> _items = new global::System.Collections.Generic.List<deploy.SKILLBUFF>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.SKILLBUFF> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}