using UnityEngine;
using UnityEngine.UI;

public class PlayerButtonPresenter : MonoBehaviour
{
    public PlayerPresenter playerPresenter;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            playerPresenter.OnButtonClick();
        });
    }
}