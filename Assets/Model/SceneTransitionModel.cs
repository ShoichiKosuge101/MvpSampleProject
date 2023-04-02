using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.SceneManagement;
using System;

public class SceneTransitionModel : MonoBehaviour
{
    public ReactiveCommand<string> LoadSceneCommand { get; }
    public SceneTransitionModel()
    {
        LoadSceneCommand= new ReactiveCommand<string>();
        LoadSceneCommand.Subscribe(sceneName => SceneManager.LoadScene(sceneName));
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
