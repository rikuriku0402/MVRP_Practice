using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class LifePresenter : MonoBehaviour
{
    [SerializeField]
    [Header("Player‚Ìƒf[ƒ^")]
    PlayerData _playerData;

    [SerializeField]
    [Header("LifeViwe")]
    LifeView _lifeViwe;

    void Start()
    {
        //_playerData.Life.Subscribe(life =>
        //{
        //    _lifeViwe.SetLife(life);
        //}).AddTo(this);
        _playerData.Life.Subscribe(life => _lifeViwe.SetLife(life)).AddTo(this);
    }
}
