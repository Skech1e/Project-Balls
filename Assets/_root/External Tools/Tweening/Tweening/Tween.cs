using System.Collections;

using UnityEngine;
[RequireComponent(typeof(RectTransform))]
public abstract class Tween : MonoBehaviour
{
    #region Vars
    [Space(5)]
    public LeanTweenType EaseTypeIn;
    public LeanTweenType EaseTypeOut;

    [Range(0f, 2f)] public float TimeIn;
    [Range(0f, 2f)] public float TimeOut;
    [Range(0f, 2f)] public float DelayIn;
    [Range(0f, 2f)] public float DelayOut;
    [Range(0f, 1f)] public float Offset;
    #endregion


    // M E T H O D S
    private void OnEnable() => WhenEnabled();
    public void Enable() => gameObject.SetActive(true);
    public void Disable() => StartCoroutine(routine: WhenDisabled());


    // A B S T R A C T   M E T H O D S
    protected abstract void WhenEnabled();
    protected abstract IEnumerator WhenDisabled();
}