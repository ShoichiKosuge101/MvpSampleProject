using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class GaugeModel : MonoBehaviour
{
    private readonly FloatReactiveProperty _gaugeValue = new FloatReactiveProperty(0);
    public IReadOnlyReactiveProperty<float> GaugeValue => _gaugeValue;

    public void IncreaseGauge(float amount)
    {
        _gaugeValue.Value = Mathf.Clamp(_gaugeValue.Value + amount, 0, 1);
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
