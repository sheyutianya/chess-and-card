// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Alice/Character/RoleSelect"
{
	 Properties 
	 {
        _MainTex ("Base (RGB)",		2D) = "black" {}
		_BumpTex ("Normalmap",		2D) = "bump" {}
		_EnvTex1  ("Env1  (RGB)",	2D) = "black" {}
		_EnvMask  ("EnvMask (RGBA)",2D) = "white" {}
    }

	SubShader
	{
		Tags { "RenderType"="Opaque" "Queue" = "Geometry"}
		LOD 100

		Pass
		{
            Tags { "LightMode"="ForwardBase" }
            Lighting Off
 
            CGPROGRAM
			// Upgrade NOTE: excluded shader from Xbox360; has structs without semantics (struct v2f members lightDirection)
			#pragma exclude_renderers xbox360
            #pragma vertex vert
            #pragma fragment frag
 
            #include "UnityCG.cginc"
 
            sampler2D _MainTex;
			sampler2D _BumpTex;
			sampler2D _EnvTex1;
			sampler2D _EnvMask;

            struct v2f
            {
				half4 pos		: SV_POSITION;
				half2 uv		: TEXCOORD0;
				half3 c0		: TEXCOORD1;
				half3 c1		: TEXCOORD2;
            };
 
            v2f vert (appdata_full v)
            {
				v2f o;
				o.pos = UnityObjectToClipPos(v.vertex);
				o.uv = v.texcoord;

				TANGENT_SPACE_ROTATION;
				o.c0 = mul(rotation, UNITY_MATRIX_IT_MV[0].xyz);
				o.c1 = mul(rotation, UNITY_MATRIX_IT_MV[1].xyz);
				
				return o;
            }
 
            fixed4 frag(v2f v) : COLOR  
            { 
			    fixed4 c  = tex2D (_MainTex, v.uv);
				half3 bumpNormal = UnpackNormal(tex2D(_BumpTex, v.uv));
				half2 envTex = half2(dot(v.c0, bumpNormal), dot(v.c1, bumpNormal)) * 0.25 + 0.25;

				half4 envTex12 = envTex.xyxy + half4(0, 0, 0.5, 0);
				half4 envTex34 = envTex.xyxy + half4(0, 0.5, 0.5, 0.5);

                fixed3 e1 = tex2D (_EnvTex1, envTex12.xy).rgb;
				fixed3 e2 = tex2D (_EnvTex1, envTex12.zw).rgb; 
				fixed3 e3 = tex2D (_EnvTex1, envTex34.xy).rgb; 
				fixed3 e4 = tex2D (_EnvTex1, envTex34.zw).rgb;
				fixed4 mask = tex2D(_EnvMask, v.uv);

				c.rgb += (e1 * mask.r + e2 * mask.g + e3 * mask.b + e4 * mask.a);

				return fixed4(c.rgb, 1.0);
            } 
 
            ENDCG
        }
	}
}
