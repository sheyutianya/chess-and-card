using UnityEngine;
using System.Collections;

public class UvAnimator : MonoBehaviour
{
	public float tileX = 24;
	public float tileY = 1;
	public float fps = 10.0f;

    private Renderer mRender;
    private bool m_isFirstSetTexture = true;

    void Start() 
    {
        mRender = GetComponent<Renderer>();
    }

	// Update is called once per frame
	void Update ()
    {
		int index = (int)(Time.time * fps);
		index = index % (int)(tileX * tileY);
		Vector2 size = new Vector2(1.0f / tileX, 1.0f / tileY);
		
		int u = (int)(index % tileX);
		int v = (int)(index / tileX);
		
		Vector2 offset = new Vector2(u * size.x, v * size.y);
		
        //GetComponent<Renderer>().material.SetTextureOffset("_MainTex", offset);
        //GetComponent<Renderer>().material.SetTextureScale("_MainTex", size);

        if (m_isFirstSetTexture)
        {
            mRender.material.SetTextureOffset("_MainTex", offset);
            mRender.sharedMaterial.SetTextureScale("_MainTex", size);
            m_isFirstSetTexture = false;
        }
        else 
        {
            mRender.sharedMaterial.SetTextureOffset("_MainTex", offset);
            mRender.sharedMaterial.SetTextureScale("_MainTex", size);
        }
	}
}
