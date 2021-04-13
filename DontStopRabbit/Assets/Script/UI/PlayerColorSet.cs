using UnityEngine;
using UnityEngine.UI;

public class PlayerColorSet : MonoBehaviour
{
    [SerializeField] Image imagePlayer = null;
    [SerializeField] Dropdown dropdown = null;
    [SerializeField] PlayersSettings playersSettings = null;
    [SerializeField] int playerId = 0;
    private PlayersSet playersSet = null;

    private void Start()
    {
        playersSet = playersSettings.GetPlayersSet();
        SetValueDropDown();
    }
    public void SetColorPlayer(int valueDropDown)
    {
        InitSetColorPlayer(valueDropDown);
    }
    private void InitSetColorPlayer(int dropDownValue)
    {
        playersSet.SetColorPlayer(dropDownValue, playerId);
        imagePlayer.sprite = playersSettings.GetImageRabbit(playersSet.GetIdColorPlayer(playerId));
    }
    private void SetValueDropDown()
    {
        dropdown.value = playersSet.GetIdColorPlayer(playerId);
        imagePlayer.sprite = playersSettings.GetImageRabbit(playersSet.GetIdColorPlayer(playerId));
    }
}
