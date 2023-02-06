using System.Collections;

using UnityEngine;

[DisallowMultipleComponent]
[AddComponentMenu("SRF/UI/Animations/Position Tween")]
public class PositionTween : Tween
{
      // T Y P E S
      private enum Direction
      { None, LeftToRight, RightToLeft, TopToBottom, BottomToTop }

      #region Vars
      new private RectTransform transform;

      [Space(10)]
      [SerializeField] private Direction directionIn;
      [SerializeField] private Direction directionOut;
      #endregion


      // M E T H O D S
      private void Awake()
      {
            transform = GetComponent<RectTransform>();
      }

      protected sealed override void WhenEnabled()
      {
            switch (directionIn)
            {
                  case Direction.None: return;

                  case Direction.RightToLeft:
                        transform.localPosition = new Vector2(Screen.width, transform.localPosition.y);
                        transform.LeanMoveLocalX(0, TimeIn).setEase(EaseTypeIn).setDelay(DelayIn);
                        return;

                  case Direction.LeftToRight:
                        transform.localPosition = new Vector2(-Screen.width, transform.localPosition.y);
                        transform.LeanMoveLocalX(0, TimeIn).setEase(EaseTypeIn).setDelay(DelayIn);
                        return;

                  case Direction.TopToBottom:
                        transform.localPosition = new Vector2(transform.localPosition.x, Screen.height);
                        transform.LeanMoveLocalY(0, TimeIn).setEase(EaseTypeIn).setDelay(DelayIn);
                        return;

                  case Direction.BottomToTop:
                        transform.localPosition = new Vector2(transform.localPosition.x, -Screen.height);
                        transform.LeanMoveLocalY(0, TimeIn).setEase(EaseTypeIn).setDelay(DelayIn);
                        return;
            }
      }
      protected sealed override IEnumerator WhenDisabled()
      {
            //transform.localPosition = Vector2.zero;

            switch (directionOut)
            {
                  case Direction.RightToLeft:
                        transform.LeanMoveLocalX(-Screen.width, TimeOut).setEase(EaseTypeOut).setDelay(DelayOut);
                        break;

                  case Direction.LeftToRight:
                        transform.LeanMoveLocalX(Screen.width, TimeOut).setEase(EaseTypeOut).setDelay(DelayOut);
                        break;

                  case Direction.TopToBottom:
                        transform.LeanMoveLocalY(-Screen.height, TimeOut).setEase(EaseTypeOut).setDelay(DelayOut);
                        break;

                  case Direction.BottomToTop:
                        transform.LeanMoveLocalY(Screen.height, TimeOut).setEase(EaseTypeOut).setDelay(DelayOut);
                        break;
            }
            yield return new WaitForSeconds(TimeOut + DelayOut);
            gameObject.SetActive(value: false);
      }
}