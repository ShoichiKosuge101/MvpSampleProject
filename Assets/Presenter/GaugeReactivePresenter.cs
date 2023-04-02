using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class GaugeReactivePresenter : MonoBehaviour
{
    [SerializeField] private GaugeModel _gaugeModel;
    [SerializeField] private GaugeView _gaugeView;

    //// Start is called before the first frame update
    private void Start()
    {
        _gaugeView.OnIncreaseButtonClick
            .Subscribe(_ => { _gaugeModel.IncreaseGauge(0.1f); })
            .AddTo(this);

        _gaugeModel.GaugeValue
            .Subscribe(_gaugeView.SetGaugeValue)
            .AddTo(this);
    }

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
