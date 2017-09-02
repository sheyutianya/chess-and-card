using UnityEngine;
using System.Collections;

namespace ABE 
{
    public class Modifier
    {
        //Attributes
        //Duration
        //EffectAttachType
      
        //名称	可用参数
        //Attributes	MODIFIER_ATTRIBUTE_IGNORE_INVULNERABLE, MODIFIER_ATTRIBUTE_MULTIPLE, MODIFIER_ATTRIBUTE_NONE, MODIFIER_ATTRIBUTE_PERMANENT
        //属性	忽视无敌，可叠加，无，正常
        //Duration	FloatValue
        //持续时间	浮点值
        //EffectAttachType	follow_origin, follow_overhead, follow_chest, follow_head, start_at_customorigin, world_origin
        //特效附着点类型	原点，头顶，胸膛，头部，自定义原点，世界原点
        //EffectName	StringValue
        //特效名称	字符串(路径+特效名)
        //IsBuff	BooleanValue
        //是否增益魔法	布尔值（1为增益魔法）
        //IsDebuff	BooleanValue
        //是否减益魔法	布尔值（1为减益魔法）
        //IsHidden	BooleanValue
        //是否隐藏	布尔值（1为隐藏）
        //IsPurgable	BooleanValue
        //能否被驱散	布尔值（1为可被驱散）
        //OverrideAnimation	ACT_DOTA_ATTACK, ACT_DOTA_CAST_ABILITY_1 (2, 3, 4, 5, 6), ACT_DOTA_DISABLED, ACT_DOTA_SPAWN, ACT_DOTA_TELEPORT, ACT_DOTA_VICTORY
        //覆盖模型动作	攻击动作，技能释放动作(1~6)，受伤动作，出生动作，回程动作，胜利动作
        //Passive	BooleanValue
        //被动	布尔值（1为被动技能，会自动添加该Modifiers）
        //TextureName	StringValue
        //图标名称	字符串
        //ThinkInterval	FloatValue
        //Think间隔	浮点值
    }
}

