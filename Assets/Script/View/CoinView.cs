using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinView : MonoBehaviour
{
    [SerializeField]
    [Header("コインテキスト")]
    Text _coinText;

    public void SetCoin(int coinCount)
    {
        _coinText.text = coinCount.ToString();
    }
}
