using UnityEngine;
using UnityEngine.UI;

public class SetNumberOfPlayers : MonoBehaviour
{
    [SerializeField] Dropdown dropdown = null;
    [SerializeField] PlayersSettings playersSettings = null;
    private PlayersSet playersSet = null;

    private void Start()
    {
        playersSet = playersSettings.GetPlayersSet();
        InitDropDownValue();
    }
    public void SetNumberPlayers(int valueDropDown)
    {
        playersSet.SetNumberOfPlayers(valueDropDown);
        playersSettings.ActivePlayersPanelColor(valueDropDown);
    }
    private void InitDropDownValue()
    {
        SetValueDropDown();
        playersSettings.ActivePlayersPanelColor(dropdown.value);
    }
    private void SetValueDropDown()
    {
        switch (playersSet.GetNumberOfPlayers())
        {
            case NumberOfPlayers.ONE:
                dropdown.value = 0;
                return;
            case NumberOfPlayers.TWO:
                dropdown.value = 1;
                return;
            case NumberOfPlayers.THREE:
                dropdown.value = 2;
                return;
            case NumberOfPlayers.FOUR:
                dropdown.value = 3;
                return;
            default:
                return;
        }
    }
}
