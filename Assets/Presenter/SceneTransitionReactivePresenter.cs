using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class SceneTransitionReactivePresenter : MonoBehaviour
{
    [SerializeField] private SceneTransitionModel _sceneTransitionModel;
    [SerializeField] private SceneTransitionView _sceneTransitionView;

    // Start is called before the first frame update
    void Start()
    {
        //_sceneTransitionView.OnTransitionButtonClick
        //    .Subscribe(_ =>
        //    {
        //        string nextSceneName = _sceneTransitionView.NextSceneName;
        //        _sceneTransitionModel.LoadSceneCommand.Execute(nextSceneName);
        //    })
        //    .AddTo(this);
        //string nextScene = _sceneTransitionView.NextSceneName;
        //_sceneTransitionModel.LoadScene(nextScene);

        _sceneTransitionView.OnTransitionButtonClick
            .Subscribe(_ =>
            {
                string nextSceneName = _sceneTransitionView.NextSceneName;

                _sceneTransitionModel.LoadScene(nextSceneName);
            })
            .AddTo(this);
    }
}
