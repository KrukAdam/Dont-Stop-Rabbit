using UnityEngine;
using UnityEngine.UI;

public class PlayerHUD : MonoBehaviour
{
    [SerializeField] private Text valueStat = null;

    public void RefreshValue(string valueStatToSet)
    {
        valueStat.text = valueStatToSet;
    }
}
