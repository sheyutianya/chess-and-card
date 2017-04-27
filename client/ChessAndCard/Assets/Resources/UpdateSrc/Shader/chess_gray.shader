// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Unlit alpha-blended shader.
// - no lighting
// - no lightmap support
// - no per-material color

Shader "Hero/Transparent/Gray" {
Properties {
	_MainTex ("Base (RGB) Trans (A)", 2D) = "white" {}
	//_MainTex2 ("Base2 (RGB)", 2D) = "white" {}
	_Color("Main Color" , Color) = (0.35,0.35,0.35,1)
}

SubShader {
	LOD 100
	Tags { "Queue" = "Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" }
	Cull Off
	Lighting Off
	Fog { Mode Off }
	
	ZWrite Off
	AlphaTest Off
	Blend SrcAlpha OneMinusSrcAlpha  
	
	Pass {  
		CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			struct appdata_t {
				float4 vertex : POSITION;
				float2 texcoord : TEXCOORD0;
			};

			struct v2f {
				float4 vertex : SV_POSITION;
				half2 texcoord : TEXCOORD0;
			};

			sampler2D _MainTex;
			float4 _MainTex_ST;

			//uniform sampler2D _MainTex2;
			//uniform half4 _MainTex2_ST;

			fixed4 _Color;
			v2f vert (appdata_t v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.texcoord = TRANSFORM_TEX(v.texcoord, _MainTex);
				return o;
			}
			
			fixed4 frag (v2f i) : COLOR
			{
				if(_Color.r < 0.001){
					fixed4 col = tex2D(_MainTex, i.texcoord);
					//half4 texcol2 = tex2D(_MainTex2,i.texcoord);
					//col = col * (1- texcol2.a) + texcol2 * texcol2.a;
					//col = col * _Color;
					float grey = dot(col.rgb, float3(0.299, 0.587, 0.114));  
					col.rgb = float3(grey, grey, grey);  
					return col  ;
				}else
				{
					fixed4 col = tex2D(_MainTex, i.texcoord);
					//half4 texcol2 = tex2D(_MainTex2,i.texcoord);
					//col = col * (1- texcol2.a) + texcol2 * texcol2.a;
					col = col * _Color;
					//float grey = dot(col.rgb, float3(0.299, 0.587, 0.114));  
					//col.rgb = float3(grey, grey, grey);  
					return col  ;
				}
				
			}
		ENDCG
	}
}

}
