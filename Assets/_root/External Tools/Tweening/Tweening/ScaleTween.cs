using System.Collections;

using UnityEngine;
[DisallowMultipleComponent]
[AddComponentMenu("SRF/UI/Animations/Scale Tween")]
public class ScaleTween : Tween
{
    // T Y P E S
    private enum ScaleType
    { None, Horizontal, Vertical, Depth }

    #region Vars
    new private RectTransform transform;

    [Space(10)]
    [SerializeField] private ScaleType scaleTypeIn;
    [SerializeField] private ScaleType scaleTypeOut;
    #endregion


    // M E T H O D S
    private void Awake()
    {
        transform = GetComponent<RectTransform>();
    }

    protected sealed override void WhenEnabled()
    {
        switch (scaleTypeIn)
        {
            case ScaleType.None:
                transform.localScale = Vector3.one;
                return;

            case ScaleType.Horizontal:
                transform.localScale = new Vector3(Offset, 1, 1);
                transform.LeanScaleX(1, TimeIn).setEase(EaseTypeIn).setDelay(DelayIn);
                return;

            case ScaleType.Vertical:
                transform.localScale = new Vector3(1, Offset, 1);
                transform.LeanScaleY(1, TimeIn).setEase(EaseTypeIn).setDelay(DelayIn);
                return;

            case ScaleType.Depth:
                transform.localScale = new Vector3(Offset, Offset, 1);
                transform.LeanScaleX(1, TimeIn).setEase(EaseTypeIn).setDelay(DelayIn);
                transform.LeanScaleY(1, TimeIn).setEase(EaseTypeIn).setDelay(DelayIn);
                return;
        }
    }
    protected sealed override IEnumerator WhenDisabled()
    {
        transform.localScale = Vector3.one;
        switch (scaleTypeOut)
        {
            case ScaleType.None:
                break;

            case ScaleType.Horizontal:
                transform.LeanScaleX(0, TimeOut).setEase(EaseTypeOut).setDelay(DelayOut);
                break;

            case ScaleType.Vertical:
                transform.localScale = new Vector3(1, 0, 1);
                transform.LeanScaleY(0, TimeOut).setEase(EaseTypeOut).setDelay(DelayOut);
                break;

            case ScaleType.Depth:
                transform.localScale = new Vector3(1, 1, 1);
                transform.LeanScaleX(Offset, TimeOut).setEase(EaseTypeOut).setDelay(DelayOut);
                transform.LeanScaleY(Offset, TimeOut).setEase(EaseTypeOut).setDelay(DelayOut);
                break;
        }
        yield return new WaitForSeconds(TimeOut + DelayOut);
        gameObject.SetActive(value: false);
    }
}