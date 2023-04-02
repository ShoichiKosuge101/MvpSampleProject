using UnityEngine;
using TMPro;

public class ButtonClick : MonoBehaviour
{
    public TextMeshProUGUI buttonText;
    private int clickCount = 0;

    void Start()
    {
        // ‰Šú‰»
        buttonText.text = "0";
    }

    public void OnClick()
    {
        // ƒNƒŠƒbƒN‚µ‚½‚Æ‚«‚ÉŒÄ‚Î‚ê‚é
        clickCount++;
        buttonText.text = clickCount.ToString();
    }
}
