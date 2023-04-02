using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class TimerReactivePresenter : MonoBehaviour
{
    [SerializeField] private TimerModel _timerModel;
    [SerializeField] private TimerView _timerView;

    private void Start()
    {

        _timerView.OnToggleButtonClick
            .Subscribe(_ => _timerModel.ToggleTimer())
            .AddTo(this);

        _timerView.OnResetButtonClick
            .Subscribe(_ => _timerModel.ResetTimer())
            .AddTo(this);


        _timerModel.TimerValue
            .Subscribe(_timerView.SetTimerValue)
            .AddTo(this);
    }

    private void OnDestroy()
    {
        _timerModel.Dispose();
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
