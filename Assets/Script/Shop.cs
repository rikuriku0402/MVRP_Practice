using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField]
    PlayerData _playerData;

    public void BuyItem(int value)
    {
        _playerData.ReduceCoin(value);
    }
    
    public void GetPortion()
    {
        _playerData.AddPortion(1);
    }
    
    public void GetAntidote()
    {
        _playerData.AddAntidote(1);
    }
}
