using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerView : MonoBehaviour, IPlayerView
{
    public Text healthText;
    public Text scoreText;

    public void UpdateUI(int health, int score)
    {
        healthText.text = "Health:" + health;
        scoreText.text = "Score:" + score;

        Debug.LogFormat("## UI Update ##");
        Debug.LogFormat("Halth:{0}", healthText.text);
        Debug.LogFormat("Score:{0}", scoreText.text);
    }
}
