using UnityEngine;
using TMPro;

public class ButtonClick : MonoBehaviour
{
    public TextMeshProUGUI buttonText;
    private int clickCount = 0;

    void Start()
    {
        // ������
        buttonText.text = "0";
    }

    public void OnClick()
    {
        // �N���b�N�����Ƃ��ɌĂ΂��
        clickCount++;
        buttonText.text = clickCount.ToString();
    }
}
