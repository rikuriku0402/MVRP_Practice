using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUse : MonoBehaviour
{
    [SerializeField]
    PlayerData _playerData;

    public void PortionUse()
    {
        _playerData.PortionUse(1);
        _playerData.HPItem(3);
    }

    public void AntidoteUse() => _playerData.AntidoteUse(1);
}
