using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class TimerModel : MonoBehaviour
{
    private readonly ReactiveProperty<TimeSpan> _timerValue = new ReactiveProperty<TimeSpan>(TimeSpan.Zero);
    private readonly CompositeDisposable _disposable = new CompositeDisposable();
    private bool _isRunning;

    public IReadOnlyReactiveProperty<TimeSpan> TimerValue => _timerValue;

    public void ToggleTimer()
    {
        _isRunning = !_isRunning;

        if (_isRunning)
        {
            Observable.Interval(TimeSpan.FromMilliseconds(10))
                .Where(_ => _isRunning)
                .Subscribe(_ => _timerValue.Value += TimeSpan.FromMilliseconds(10))
                .AddTo(_disposable);
        }
    }

    public void ResetTimer()
    {
        _timerValue.Value = TimeSpan.Zero;
    }

    public void Dispose()
    {
        _disposable.Dispose();
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
