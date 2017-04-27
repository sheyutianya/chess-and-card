// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Hero/Transparent/TransitMask" {
	Properties {
		_MainTex1 ("Base1 (RGB)", 2D) = "white" {}
		_MainTex2 ("Base2 (RGB)", 2D) = "white" {}
		_MainTex3 ("Base3 (RGB)", 2D) = "white" {}
		_MaskTex ("AlphaMask", 2D) = "white" {}
		_Level("Brightness", Float) = 1
		_MoveSpeed1("Move Speed1",Float) = 20
		_MoveSpeed2("Move Speed2",Float) = 20
		_MoveSpeed3("Move Speed3",Float) = 20
	}

CGINCLUDE

	#include "UnityCG.cginc"
	
	uniform sampler2D _MainTex1;
	uniform half4 _MainTex1_ST;

	uniform sampler2D _MainTex2;
	uniform half4 _MainTex2_ST;

	uniform sampler2D _MainTex3;
	uniform half4 _MainTex3_ST;

	uniform sampler2D _MaskTex;
	uniform half4 _MaskTex_ST;

	half _Level;
	float _MoveSpeed1;
	float _MoveSpeed2;
	float _MoveSpeed3;

	struct appdata {
		float4 vertex : POSITION;
		half2 texcoord : TEXCOORD0;		
	};

	struct v2f {
		float4 pos : SV_POSITION;
		half2	uv : TEXCOORD0;
		half2   uv1 : TEXCOORD1;
	};	

	v2f vert (appdata v)
	{
		v2f o;
		o.pos = UnityObjectToClipPos (v.vertex);		
		o.uv = TRANSFORM_TEX(v.texcoord, _MainTex1);
		o.uv1 = TRANSFORM_TEX(v.texcoord, _MaskTex);		
		return o;
	}
	
	half4 frag (v2f i) : COLOR
	{
		float u_x1 = i.uv.x + _MoveSpeed1 * _Time;
		float u_x2 = i.uv.x + _MoveSpeed2 * _Time;
		float u_x3 = i.uv.x + _MoveSpeed3 * _Time;

		float2 uv_map1=float2( u_x1 , i.uv.y);
		float2 uv_map2=float2( u_x2 , i.uv.y);
		float2 uv_map3=float2( u_x3 , i.uv.y);
		half4 texcol = tex2D( _MainTex1, uv_map1);
		half4 texcol2 = tex2D(_MainTex2,uv_map2);
		half4 texcol3 = tex2D(_MainTex3,uv_map3);
		texcol = texcol * (1- texcol2.a) + texcol2 * texcol2.a;
		texcol = texcol * (1- texcol3.a) + texcol3 * texcol3.a;

		half alpha = 1 -  tex2D( _MaskTex, i.uv1 ).r;  //  
		texcol *= alpha;
		texcol *= _Level;
		return texcol;
	}

	ENDCG
	
SubShader {
	LOD 100
	Tags { "Queue" = "Transparent+500" "IgnoreProjector"="True"}
	Cull Off
	Lighting Off
	Fog { Mode Off }

	Pass {
		ZWrite Off
		AlphaTest Off
		Blend SrcAlpha OneMinusSrcAlpha    

		CGPROGRAM
		#pragma vertex vert
		#pragma fragment frag
	
		ENDCG
    }
    
}
Fallback Off
} 