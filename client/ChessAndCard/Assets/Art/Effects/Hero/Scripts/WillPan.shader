Shader "WillPan"
{
	Properties 
	{
_TX("_TX", 2D) = "black" {}
_sd("_sd", Range(0,5) ) = 0
_nq("_nq", 2D) = "black" {}
_nqpw("_nqpw", Range(-0.5,2) ) = -0.5
_Gloss("_Gloss", Range(0,1) ) = 0.5
_tx("_tx", 2D) = "black" {}

	}
	
	SubShader 
	{
		Tags
		{
"Queue"="Transparent"
"IgnoreProjector"="False"
"RenderType"="Opaque"

		}

		
Cull Off
ZWrite On
ZTest LEqual
ColorMask RGBA
Fog{
}


		CGPROGRAM
#pragma surface surf BlinnPhongEditor  alpha decal:add vertex:vert
#pragma target 2.0


sampler2D _TX;
float _sd;
sampler2D _nq;
float _nqpw;
float _Gloss;
sampler2D _tx;

			struct EditorSurfaceOutput {
				half3 Albedo;
				half3 Normal;
				half3 Emission;
				half3 Gloss;
				half Specular;
				half Alpha;
				half4 Custom;
			};
			
			inline half4 LightingBlinnPhongEditor_PrePass (EditorSurfaceOutput s, half4 light)
			{
half3 spec = light.a * s.Gloss;
half4 c;
c.rgb = (s.Albedo * light.rgb + light.rgb * spec);
c.a = s.Alpha;
return c;

			}

			inline half4 LightingBlinnPhongEditor (EditorSurfaceOutput s, half3 lightDir, half3 viewDir, half atten)
			{
				half3 h = normalize (lightDir + viewDir);
				
				half diff = max (0, dot ( lightDir, s.Normal ));
				
				float nh = max (0, dot (s.Normal, h));
				float spec = pow (nh, s.Specular*128.0);
				
				half4 res;
				res.rgb = _LightColor0.rgb * diff;
				res.w = spec * Luminance (_LightColor0.rgb);
				res *= atten * 2.0;

				return LightingBlinnPhongEditor_PrePass( s, res );
			}
			
			struct Input {
				float2 uv_tx;
float2 uv_TX;
float2 uv_nq;

			};

			void vert (inout appdata_full v, out Input o) {
float4 VertexOutputMaster0_0_NoInput = float4(0,0,0,0);
float4 VertexOutputMaster0_1_NoInput = float4(0,0,0,0);
float4 VertexOutputMaster0_2_NoInput = float4(0,0,0,0);
float4 VertexOutputMaster0_3_NoInput = float4(0,0,0,0);


			}
			

			void surf (Input IN, inout EditorSurfaceOutput o) {
				o.Normal = float3(0.0,0.0,1.0);
				o.Alpha = 1.0;
				o.Albedo = 0.0;
				o.Emission = 0.0;
				o.Gloss = 0.0;
				o.Specular = 0.0;
				o.Custom = 0.0;
				
float4 Tex2D2=tex2D(_tx,(IN.uv_tx.xyxy).xy);
float4 Multiply0=_nqpw.xxxx * float4( -1,-1,-1,-1 );
float4 UV_Pan0=float4((IN.uv_TX.xyxy).x + Multiply0.x,(IN.uv_TX.xyxy).y,(IN.uv_TX.xyxy).z,(IN.uv_TX.xyxy).w);
float4 Tex2D1=tex2D(_nq,(IN.uv_nq.xyxy).xy);
float4 UnpackNormal0=float4(UnpackNormal(Tex2D1).xyz, 1.0);
float4 Multiply3=UnpackNormal0 * _nqpw.xxxx;
float4 Add2=UV_Pan0 + Multiply3;
float4 Tex2D0=tex2D(_TX,Add2.xy);
float4 Add0=Tex2D0 + Tex2D0;
float4 Add1=Add0 + Add0;
float4 Lerp0=lerp(Tex2D0,Add1,_nqpw.xxxx);
float4 Invert0= float4(1.0, 1.0, 1.0, 1.0) - Lerp0;
float4 Add5=Invert0 + Invert0;
float4 Multiply7=Add5 * Tex2D2;
float4 Multiply8=Multiply7 * Tex2D2;
float4 Multiply1=float4( -2,-2,-2,-2 ) * _nqpw.xxxx;
float4 Lerp1=lerp(Multiply7,Multiply8,Multiply1);
float4 Add6=Add5 + Add5;
float4 Add7=Add6 + Add6;
float4 Master0_1_NoInput = float4(0,0,1,1);
float4 Master0_4_NoInput = float4(0,0,0,0);
float4 Master0_7_NoInput = float4(0,0,0,0);
float4 Master0_6_NoInput = float4(1,1,1,1);
o.Albedo = Tex2D2;
o.Emission = Lerp1;
o.Specular = _Gloss.xxxx;
o.Alpha = Add7;

				o.Normal = normalize(o.Normal);
			}
		ENDCG
	}
	Fallback "Diffuse"
}