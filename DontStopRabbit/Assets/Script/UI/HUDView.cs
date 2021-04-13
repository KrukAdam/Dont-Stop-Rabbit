using UnityEngine;

public class HUDView : MonoBehaviour
{
    [SerializeField] GameObject[] playersHud = null;

    public void SetActiveHUD(NumberOfPlayers numberOfPlayers)
    {
        switch (numberOfPlayers)
        {
            case NumberOfPlayers.ONE:
                playersHud[0].SetActive(true);
                playersHud[1].SetActive(false);
                playersHud[2].SetActive(false);
                playersHud[3].SetActive(false);
                return;
            case NumberOfPlayers.TWO:
                playersHud[0].SetActive(true);
                playersHud[1].SetActive(true);
                playersHud[2].SetActive(false);
                playersHud[3].SetActive(false);
                return;
            case NumberOfPlayers.THREE:
                playersHud[0].SetActive(true);
                playersHud[1].SetActive(true);
                playersHud[2].SetActive(true);
                playersHud[3].SetActive(false);
                return;
            case NumberOfPlayers.FOUR:
                playersHud[0].SetActive(true);
                playersHud[1].SetActive(true);
                playersHud[2].SetActive(true);
                playersHud[3].SetActive(true);
                return;
            default:
                return;
        }
    }
}
