using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;
using System;

public class TimerView : MonoBehaviour
{
    [SerializeField] private Text _timerText;
    [SerializeField] private Button _toggleButton;
    [SerializeField] private Button _resetButton;

    public IObservable<Unit> OnToggleButtonClick => _toggleButton.OnClickAsObservable();
    public IObservable<Unit> OnResetButtonClick => _resetButton.OnClickAsObservable();

    public void SetTimerValue(TimeSpan value)
    {
        _timerText.text = $"{value.Minutes:00}:{value.Seconds:00}.{value.Milliseconds / 10:00}";
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
