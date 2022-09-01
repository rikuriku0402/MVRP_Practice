using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class PlayerData : MonoBehaviour
{
    public IntReactiveProperty Life => _life;

    public IntReactiveProperty Coin => _coin;

    /// <summary>ライフの初期値</summary>
    [SerializeField]
    IntReactiveProperty _life = new IntReactiveProperty(5);

    /// <summary>コインの初期値</summary>
    [SerializeField]
    IntReactiveProperty _coin = new IntReactiveProperty(0);

    public void Damage(int value)
    {
        _life.Value -= value;
        if (value == 0)
        {
            print("GameOver");
        }
    }
    public void HPItem(int value)
    {
        _life.Value += value;
    }

    public void AddCoin(int value)
    {
        _coin.Value += value;
    }

    private void OnDestroy()
    {
        _life.Dispose();
        _coin.Dispose();
    }
}
