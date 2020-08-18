using UnityEngine;
using UnityEngine.UI;

public class ShowPopup : MonoBehaviour
{
    public GameObject popUpBox;
    public Animator popUpAnimator;
    public Text popUpText;

    public void PopUp(string text)
    {
        popUpBox.SetActive(true);
        popUpText.text = text;
        popUpAnimator.SetTrigger("pop");
    }
}
