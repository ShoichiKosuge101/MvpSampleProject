using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface IPlayerView
{
    void UpdateUI(int health, int score);
}
