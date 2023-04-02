using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;
using System;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private Button _incrementButton;
    [SerializeField] private Text _scoreText;

    public IObservable<Unit> OnIncrementButtonClick => _incrementButton.OnClickAsObservable();

    public void SetScore(int score)
    {
        _scoreText.text = $"Score: {score}";
    }

    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
