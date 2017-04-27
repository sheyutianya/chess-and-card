using UnityEngine;
using System.Collections;

public class UVAnimCtrl : MonoBehaviour
{
    public int[] materialsIndex;
    public float scrollSpeed = 5;
    public float countX = 4;
    public float countY = 4;

    private float offsetX = 0.0f;
    private float offsetY = 0.0f;
    private Vector2 singleTextureSize;
    private float _frame = 0.0f;

	public bool isOffset = false;
	public float ox = 0.0f;
	public float oy = 0.0f;


    void Awake()
    {
        singleTextureSize = new Vector2(1.0f / countX, 1.0f / countY);
        GetComponent<Renderer>().material.mainTextureScale = singleTextureSize;
        foreach (int i in materialsIndex)
        {
            if (i < GetComponent<Renderer>().materials.Length)
            {
                GetComponent<Renderer>().materials[i].mainTextureScale = singleTextureSize;
            }
            else
            {
                if (Debug.isDebugBuild) Debug.Log("UVAnimCtrl: the materialsIndex is large than the materials' length.");
            }
        }
    }

    void Update()
    {
         _frame = Mathf.Floor(Time.time * scrollSpeed);
		if(isOffset)
		{
			offsetX += ox;
			offsetY += oy;
			if(offsetX <-1)	offsetX +=1;
			if(offsetY < -1) offsetY +=1;
		}
		else
		{
            offsetX = _frame / countX;
            offsetY = -(_frame - _frame % countX) / countY / countX;
		}
        foreach (int i in materialsIndex)
        {
            if (i < GetComponent<Renderer>().materials.Length)
            {
                GetComponent<Renderer>().materials[i].SetTextureOffset("_MainTex", new Vector2(offsetX, offsetY));
            }
        }
    }
}
