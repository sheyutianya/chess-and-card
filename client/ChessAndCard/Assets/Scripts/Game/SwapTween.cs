using System.Collections.Generic;
using UnityEngine;

public class SwapTween : MonoBehaviour
{
    private float SWAP_FORWARD_SPEED = 7f;
    private float SWAP_BACK_SPEED = 6f;
    public AnimationCurve SwapForwardCurve = AnimationCurve.EaseInOut(0, 0, 1, 1);
    public AnimationCurve SwapBackwardCurve = AnimationCurve.EaseInOut(0, 0, 1, 1);

    private readonly List<SwapTweenData> mSwapTweenDataList = new List<SwapTweenData>();
    private readonly List<SwapTweenData> mRemovedDataList = new List<SwapTweenData>();

    private void Update()
    {
        HandleAllSwapTweens();
        RemoveCompletedTweens();
    }

    private void RemoveCompletedTweens()
    {
        if (mRemovedDataList.Count > 0)
        {
            for (int i = 0; i < mRemovedDataList.Count; i++)
            {
                mSwapTweenDataList.Remove(mRemovedDataList[i]);
            }
            mRemovedDataList.Clear();
        }
    }

    private void HandleAllSwapTweens()
    {
        if (mSwapTweenDataList.Count > 0)
        {
            for (int i = 0; i < mSwapTweenDataList.Count; i++)
            {
                if (mSwapTweenDataList[i].SwapTarget == null)
                {
                    continue;
                }
                HandleSingleSwapTween(mSwapTweenDataList[i]);
            }
        }
    }

    private void HandleSingleSwapTween(SwapTweenData swapTweenData)
    {
        if (swapTweenData.SwapForward)
        {
            var curve = SwapForwardCurve.Evaluate((Time.time - swapTweenData.TweenStartTime) * swapTweenData.forwardSpeed);
            swapTweenData.SwapTarget.transform.position = swapTweenData.SwapStartPos + swapTweenData.DeltaPos*curve;
            if (curve >= 1)
            {
                swapTweenData.SwapForward = false;
                if (swapTweenData.SwapRound)
                {
                    swapTweenData.SwapBackward = true;
                    swapTweenData.TweenStartTime = Time.time;
                    swapTweenData.DeltaPos = swapTweenData.SwapStartPos - swapTweenData.SwapTarget.transform.position;
                    swapTweenData.SwapStartPos = swapTweenData.SwapTarget.transform.position;
                }
                else
                {
                    swapTweenData.Complete();
                    swapTweenData.SwapTarget = null;
                    mRemovedDataList.Add(swapTweenData);
                }
            }
        }
        else if (swapTweenData.SwapBackward)
        {
            var curve = SwapBackwardCurve.Evaluate((Time.time - swapTweenData.TweenStartTime)*swapTweenData.backSpeed);
            swapTweenData.SwapTarget.transform.position = swapTweenData.SwapStartPos + swapTweenData.DeltaPos*curve;
            if (curve >= 1)
            {
                swapTweenData.SwapBackward = false;
                swapTweenData.Complete();
                swapTweenData.SwapTarget = null;
                mRemovedDataList.Add(swapTweenData);
            }
        }
    }

    public void SwapRound(GameObject target, Vector3 desPos, SwapTweenData.SwapTweenCallback callback = null,float forwardSpeed = 7,float backSpeed = 6f)
    {
        SwapTweenData swapTweenData = new SwapTweenData();
        swapTweenData.SwapTarget = target;
        swapTweenData.SwapStartPos = target.transform.position;
        swapTweenData.TweenStartTime = Time.time;
        swapTweenData.DeltaPos = desPos - target.transform.position;
        swapTweenData.SwapRound = true;
        swapTweenData.SwapForward = true;
        swapTweenData.OnComplete = callback;
        swapTweenData.forwardSpeed = forwardSpeed;
        swapTweenData.backSpeed = backSpeed;
        mSwapTweenDataList.Add(swapTweenData);
    }

    public void SwapSingle(GameObject go, Vector3 desPos, SwapTweenData.SwapTweenCallback callback = null,float forwardSpeed = 7,float backSpeed = 6f)
    {
        SwapTweenData swapTweenData = new SwapTweenData();
        swapTweenData.SwapTarget = go;
        swapTweenData.SwapStartPos = go.transform.position;
        swapTweenData.TweenStartTime = Time.time;
        swapTweenData.DeltaPos = desPos - go.transform.position;
        swapTweenData.SwapRound = false;
        swapTweenData.SwapForward = true;
        swapTweenData.OnComplete = callback;
        swapTweenData.forwardSpeed = forwardSpeed;
        swapTweenData.backSpeed = backSpeed;
        mSwapTweenDataList.Add(swapTweenData);
    }
}