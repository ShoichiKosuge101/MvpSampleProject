using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class ScoreReactivePresenter : MonoBehaviour
{
    [SerializeField] private ScoreModel _scoreModel;
    [SerializeField] private ScoreView _scoreView;

    // Start is called before the first frame update
    void Start()
    {
       // �{�^���������ꂽ�Ƃ�
       _scoreView.OnIncrementButtonClick
            .Subscribe(_ => { _scoreModel.IncrementScore(); })
            .AddTo(this);

        // �X�R�A���f
        _scoreModel.Score
            .Subscribe(_scoreView.SetScore)
            .AddTo(this);
    }

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
