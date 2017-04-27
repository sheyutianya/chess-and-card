// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'


// by artsyli

Shader "Unlit/Transparent Colored Mask"
{
	Properties
	{
		_MainTex ("Base (RGB)", 2D) = "black" {}
		_MaskTex ("Mask Texture (A)", 2D) = "white" {}
		//_GrayValue ("GrayValue", float) = 0
	}
	
	SubShader
	{
		LOD 100

		Tags
		{
			"Queue" = "Transparent"
			"IgnoreProjector" = "True"
			"RenderType" = "Transparent"
		}
		
		Cull Off
		Lighting Off
		ZWrite Off
		Fog { Mode Off }
		Offset -1, -1
		Blend SrcAlpha OneMinusSrcAlpha
		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
				
			#include "UnityCG.cginc"
	
			struct VS_INPUT
			{
				float4 position : POSITION;
				float4 color : COLOR;
				float2 uv : TEXCOORD0;
			};

			struct VS_OUTPUT
			{
				float4 position : SV_POSITION;
				float4 color : COLOR;
				float2 uv : TEXCOORD0;
			};
	
			sampler2D _MainTex;
			sampler2D _MaskTex;
			float4 _MainTex_ST;
			//float _GrayValue;
				
			VS_OUTPUT vert (VS_INPUT In)
			{
				VS_OUTPUT Out;
				Out.position = UnityObjectToClipPos(In.position);
				Out.uv = In.uv.xy * _MainTex_ST.xy + _MainTex_ST.zw;
				Out.color = In.color;
				
				return Out;
			}
				
			float4 frag (VS_OUTPUT In) : COLOR
			{
				//float4 color = tex2D(_MainTex, In.uv) * In.color;
				//color.a *= tex2D(_MaskTex, In.uv).r;
				//return color;
				
				fixed4 col;  
    			if (In.color.r < 0.001)  
    			{  
        			col = tex2D(_MainTex, In.uv);
        			//用灰度计算灰值-----更平缓
        			float grey =col.r+col.g+col.b;
        			grey = grey/3; 
        			col.rgb = float3(grey, grey, grey); 
        			//用亮度计算灰值-----更分明
        			//float grey =dot(col.rgb, float3(0.299, 0.587, 0.114));  
        			//col.rgb = float3(grey, grey, grey);
    			}  
    			else  
    			{  
        			col = tex2D(_MainTex, In.uv) * In.color;  
    			}
    			
    			  col.a  = In.color.a* tex2D(_MaskTex, In.uv).r; 
    			return col;

//				float4 color = tex2D(_MainTex, In.uv) * In.color;
//				color.a *= tex2D(_MaskTex, In.uv).r;
//				  
//                float3 togray = float3(0.299, 0.587, 0.114);
//
//                float3 gray = dot(color.rgb, togray);
//				float grayVal = _GrayValue;
//				color.rgb = lerp(color, float4(gray, 1.0), grayVal).rgb;
//
//				return color;
			}
			ENDCG
		}
	}
}
