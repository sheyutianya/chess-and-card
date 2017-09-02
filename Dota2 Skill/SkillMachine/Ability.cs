using UnityEngine;
using System.Collections;

namespace ABE 
{
    public class Ability
    {
        enum EAbilityBehavior //行为
        {
            ENone = 1,
        }

        #region Event    
            //触发事件名称	描述
            //OnChannelFinish	当持续性施法完成
            //OnChannelInterrupted	当持续性施法被中断
            //OnChannelSucceeded	当持续性施法成功
            //OnOwnerDied	当拥有者死亡
            //OnOwnerSpawned	当拥有者出生
            //OnProjectileFinish	当弹道粒子特效结束
            //OnProjectileHitUnit	当弹道粒子特效命中单位
            //OnSpellStart	当技能施法开始
            //OnToggleOff	当切换为关闭状态
            //OnToggleOn	当切换为开启状态
            //OnUpgrade	当升级
        #endregion

        //public delegate void Callback(object arg1);
        //public Callback<Ability> OnSkillStartCallback;//事件

        #region Action
            //AddAbility	Target, AbilityName
            //添加技能	目标，技能名称
            //ActOnTargets	Target, Action
            //使目标模型做出某个动作	目标，动作名称
            //ApplyModifier	Target, ModifierName
            //应用Modifier	目标，Modifier名称
            //AttachEffect	EffectName, EffectAttachType, Target, ControlPoints, EffectColorA, EffectColorB, EffectAlphaScale
            //附着点特效	特效名称，特效附着点类型，目标，控制点，特效颜色A，特效颜色B，特效不透明度比例
            //Blink	Target
            //闪烁	目标
            //CleaveAttack	CleavePercent, CleaveRadius
            //范围攻击	分裂伤害，分裂范围
            //CreateThinker	Target, ModifierName
            //创建Thinker(定时器)	目标，Modifier名称
            //Damage	Target, Type, MinDamage/MaxDamage, Damage, CurrentHealthPercentBasedDamage, MaxHealthPercentBasedDamage
            //伤害	目标，伤害类型，最小/最大伤害值，伤害值，基于当前生命百分比伤害，基于最大生命百分比伤害
            //DelayedAction	Delay, Action
            //延迟操作	延迟时间，操作
            //DestroyTrees	Target, Radius
            //摧毁树木	目标，范围
            //FireEffect	EffectName, EffectAttachType, Target, ControlPoints, TargetPoint, EffectRadius, EffectDurationScale, EffectLifeDurationScale, EffectColorA, EffectColorB
            //播放特效	特效名称，特效附着点类型，目标，控制点，目标点，特效范围，特效播放时间比例，特效存活时间比例，特效颜色A，特效颜色B
            //FireSound	EffectName, Target
            //播放声音	音效名称，目标
            //Heal	HealAmount, Target
            //治愈	治疗量，目标
            //Knockback	Target, Center, Duration, Distance, Height, IsFixedDistance, ShouldStun
            //击退	目标，中心，持续时间，距离，高度，固定距离，是否眩晕
            //LevelUpAbility	Target, AbilityName
            //升级技能	目标，技能名称
            //Lifesteal	Target, LifestealPercent
            //吸血	目标，吸血百分比
            //LinearProjectile	Target, EffectName, MoveSpeed, StartRadius, EndRadius, FixedDistance, StartPosition, TargetTeams, TargetTypes, TargetFlags, HasFrontalCone, ProvidesVision, VisionRadius
            //线性投射物	目标，特效名称，移动速度，开始范围，结束范围，固定距离，开始位置，目标队伍，目标类型，目标状态，HasFrontalCone，提供视野，视野范围
            //Random	Chance, PseudoRandom, OnSuccess, OnFailure
            //几率	概率，伪随机，成功时，失败时
            //RemoveAbility	Target, AbilityName
            //移除技能	目标，技能名称
            //RemoveModifier	Target, ModifierName
            //移除Modifier	目标，Modifier名称
            //RunScript	Target, ScriptFile, Function
            //运行脚本	目标，脚本文件，运行函数
            //SpawnUnit	UnitName, UnitCount, UnitLimit, SpawnRadius, Duration, Target, GrantsGold, GrantsXP
            //生产单位	单位名称，单位数量，单位上限，生产范围，持续时间，目标，死亡金钱量，死亡经验量
            //Stun	Target, Duration
            //击晕	目标，持续时间
            //TrackingProjectile	Target, EffectName, Dodgeable, ProvidesVision, VisionRadius, MoveSpeed, SourceAttachment
            //跟踪投射物	目标，特效名称，是否可闪避，提供视野，视野范围，移动速度，起源附着点
        #endregion

        //Target
        //Modifiers ..buff and debuff
    }
}

