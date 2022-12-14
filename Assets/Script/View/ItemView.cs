using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemView : MonoBehaviour
{
    [SerializeField]
    [Header("所持ポーション")]
    List<Image> _portions;

    [SerializeField]
    [Header("所持解毒剤")]
    List<Image> _Antidotes;

    public void SetPortion(int portionCount)
    {
        for (int i = 0; i < _portions.Count; i++)
        {
            Image portion = _portions[i];
            portion.gameObject.SetActive(portionCount > i);
        }
    }

    public void SetAntidote(int antidoteCount)
    {
        for (int i = 0; i < _Antidotes.Count; i++)
        {
            Image antidote = _Antidotes[i];
            antidote.gameObject.SetActive(antidoteCount > i);
        }
    }
}
