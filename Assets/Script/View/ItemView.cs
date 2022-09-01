using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemView : MonoBehaviour
{
    [SerializeField]
    [Header("Šƒ|[ƒVƒ‡ƒ“")]
    List<Image> _portions;

    [SerializeField]
    [Header("Š‰ğ“ÅÜ")]
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
