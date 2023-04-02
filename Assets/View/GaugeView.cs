using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class GaugeView : MonoBehaviour
{
    [SerializeField] private Button _increaseButton;
    [SerializeField] private Slider _gaugeImage;

    public IObservable<Unit> OnIncreaseButtonClick => _increaseButton.OnClickAsObservable();

    public void SetGaugeValue(float value)
    {
        _gaugeImage.value = value;
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
