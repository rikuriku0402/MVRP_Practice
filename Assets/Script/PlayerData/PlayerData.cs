using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class PlayerData : MonoBehaviour
{
    public IntReactiveProperty Life => _life;

    public IntReactiveProperty Coin => _coin;

    public IntReactiveProperty Portion => _portion;

    public IntReactiveProperty Antidote => _antidote;


    /// <summary>ライフの初期値</summary>
    [SerializeField]
    IntReactiveProperty _life = new IntReactiveProperty(5);

    /// <summary>コインの初期値</summary>
    [SerializeField]
    IntReactiveProperty _coin = new IntReactiveProperty(0);

    /// <summary>ポーションの初期値</summary>
    [SerializeField]
    IntReactiveProperty _portion = new IntReactiveProperty(0);

    /// <summary>解毒剤の初期値</summary>
    [SerializeField]
    IntReactiveProperty _antidote = new IntReactiveProperty(0);

    public void Damage(int value)
    {
        _life.Value -= value;
        if (value == 0)
        {
            print("GameOver");
        }
    }
    public void HPItem(int value) => _life.Value += value;

    public void AddCoin(int value) => _coin.Value += value;

    public void ReduceCoin(int value) => _coin.Value -= value;

    public void AddPortion(int value) => _portion.Value += value;

    public void AddAntidote(int value) => _antidote.Value += value;

    public void PortionUse(int value) => _portion.Value -= value;

    public void AntidoteUse(int value) => _antidote.Value -= value;


    private void OnDestroy()
    {
        _life.Dispose();
        _coin.Dispose();
        _portion.Dispose();
        _antidote.Dispose();
    }
}
