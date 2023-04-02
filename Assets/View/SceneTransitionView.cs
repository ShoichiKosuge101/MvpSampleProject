using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;
using System;
using UnityEngine.Events;

public class SceneTransitionView : MonoBehaviour
{
    [SerializeField] private Button _transitionButton;
    [SerializeField] private string _nextSceneName;

    public IObservable<Unit> OnTransitionButtonClick => _transitionButton.OnClickAsObservable();
    public string NextSceneName => _nextSceneName;
}
