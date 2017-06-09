using UnityEngine;

public class SwapTweenData
{
    public delegate void SwapTweenCallback();
    public SwapTweenCallback OnComplete;

    public GameObject SwapTarget;
    public Vector3 SwapStartPos;
    public bool SwapForward = false;
    public bool SwapBackward = false;
    public float TweenStartTime;
    public Vector3 DeltaPos;
    public bool SwapRound = false;
    public float forwardSpeed = 7f;
    public float backSpeed = 6f;

    public void Complete()
    {
        if (OnComplete != null)
        {
            OnComplete();
        }
    }
}