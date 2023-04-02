using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class ScoreModel : MonoBehaviour
{
    private readonly ReactiveProperty<int> _score = new ReactiveProperty<int>(0);
    public IReadOnlyReactiveProperty<int> Score => _score;

    // 実行すると数値が1増加する
    public void IncrementScore()
    {
        _score.Value += 1;
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
