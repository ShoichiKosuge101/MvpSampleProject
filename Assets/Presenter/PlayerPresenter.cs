using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPresenter : MonoBehaviour
{
    private PlayerModel model;
    private IPlayerView view;

    public PlayerPresenter(PlayerModel model, IPlayerView view)
    {
        this.model = model;
        this.view = view;
    }

    public void UpdatePlayerData(int health, int score)
    {
        model.health = health;
        model.score = score;

        view.UpdateUI(model.health, model.score);
    }

    public void OnButtonClick()
    {
        //Debug.Log("CLICK");
        UpdatePlayerData(100, 50);
    }
}
