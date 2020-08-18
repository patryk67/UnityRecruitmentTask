using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    public float timeBeforeHidingText = 3f;
    public Animator textAnimator;

    bool canAnimate = true;

    public void Show(Text textField)
    {
        //Debug.Log("\"Show Text\" button has been pressed");
        if (canAnimate)
        {
            Debug.Log("Text showing animation started");
            textAnimator.SetTrigger("show");
            canAnimate = false;
            Invoke("Hide", timeBeforeHidingText);
        }
    }

    public void Hide()
    {
        Debug.Log("Text hiding animation started");
        canAnimate = true;
        textAnimator.SetTrigger("hide");
    }
}
