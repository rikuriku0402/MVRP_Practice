using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinView : MonoBehaviour
{
    [SerializeField]
    [Header("�R�C���e�L�X�g")]
    Text _coinText;

    public void SetCoin(int coinCount)
    {
        _coinText.text = coinCount.ToString();
    }
}
