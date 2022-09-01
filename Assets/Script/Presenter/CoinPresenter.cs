using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class CoinPresenter : MonoBehaviour
{
    [SerializeField]
    [Header("Player‚Ìƒf[ƒ^")]
    PlayerData _playerData;

    [SerializeField]
    [Header("CoinViwe")]
    CoinView _coinViwe;

    void Start()
    {
        //_playerData.Life.Subscribe(life =>
        //{
        //    _lifeViwe.SetLife(life);
        //}).AddTo(this);
        _playerData.Coin.Subscribe(coin => _coinViwe.SetCoin(coin)).AddTo(this);
    }
}
