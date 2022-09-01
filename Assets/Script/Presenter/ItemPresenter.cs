using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class ItemPresenter : MonoBehaviour
{
    [SerializeField]
    [Header("Player‚Ìƒf[ƒ^")]
    PlayerData _playerData;

    [SerializeField]
    [Header("LifeViwe")]
    ItemView _itemViwe;

    void Start()
    {
        //_playerData.Life.Subscribe(life =>
        //{
        //    _lifeViwe.SetLife(life);
        //}).AddTo(this);
        _playerData.Portion.Subscribe(item => _itemViwe.SetPortion(item)).AddTo(this);
        _playerData.Antidote.Subscribe(item => _itemViwe.SetAntidote(item)).AddTo(this);
    }
}
