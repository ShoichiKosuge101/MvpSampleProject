using UnityEngine;
using TMPro;

public class ButtonClick : MonoBehaviour
{
    public TextMeshProUGUI buttonText;
    private int clickCount = 0;

    void Start()
    {
        // 初期化
        buttonText.text = "0";
    }

    public void OnClick()
    {
        // クリックしたときに呼ばれる
        clickCount++;
        buttonText.text = clickCount.ToString();
    }
}
