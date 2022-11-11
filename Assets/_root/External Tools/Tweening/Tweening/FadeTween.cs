using System.Collections;

using UnityEngine;
[DisallowMultipleComponent]
[AddComponentMenu("SRF/UI/Animations/Fade Tween")]
[RequireComponent(typeof(CanvasGroup))]
public class FadeTween : Tween
{
      private CanvasGroup Group;


      // M E T H O D S
      private void Awake()
      {
            Group = GetComponent<CanvasGroup>();
      }

      protected sealed override void WhenEnabled()
      {
            Group.alpha = 0;
            Group.LeanAlpha(1, TimeIn).setEase(EaseTypeIn).setDelay(DelayIn);
      }
      protected sealed override IEnumerator WhenDisabled()
      {
            Group.alpha = 1;
            while (Group.alpha > 0)
            {
                  Group.LeanAlpha(0, TimeOut).setEase(EaseTypeOut).setDelay(DelayOut);
                  yield return null;
            }
            gameObject.SetActive(value: false);
      }
}