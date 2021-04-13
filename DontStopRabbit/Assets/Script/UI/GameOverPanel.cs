using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GameOverPanel : MonoBehaviour
{
    [SerializeField] private PlayerPoints[] playersPoints = null;
    [SerializeField] private Text[] playersScoreView = null;
    [SerializeField] private Text[] playersNameView = null;
    [SerializeField] private GameObject[] placePanels = null;
    int numberActivePlaces = 0;

    public void SetScore(NumberOfPlayers numberOfPlayers)
    {
        PauseGame();
        SetNumberActive(numberOfPlayers);
        SetActivePlaceAndScoreView();
        playersPoints = playersPoints.OrderBy(go => go.GetPoints()).ToArray();

        for (int i = 0; i < playersPoints.Length; i++)
        {
            if (playersPoints[i].GetViewScore())
            {
                playersNameView[numberActivePlaces].text = playersPoints[i].playerName;
                playersScoreView[numberActivePlaces].text = playersPoints[i].GetPoints().ToString();
                numberActivePlaces--;
            }

        }
    }
    public void PauseGame()
    {
        if (Time.timeScale > 0)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    private void SetNumberActive(NumberOfPlayers numberOfPlayers)
    {
        switch (numberOfPlayers)
        {
            case NumberOfPlayers.ONE:
                numberActivePlaces = 0;
                return;
            case NumberOfPlayers.TWO:
                numberActivePlaces = 1;
                return;
            case NumberOfPlayers.THREE:
                numberActivePlaces = 2;
                return;
            case NumberOfPlayers.FOUR:
                numberActivePlaces = 3;
                return;
            default:
                return;
        }

    }
    private void SetActivePlaceAndScoreView()
    {
        for (int i = 0; i < playersPoints.Length; i++)
        {
            if (numberActivePlaces >= i)
            {
                placePanels[i].SetActive(true);
                playersPoints[i].SetViewScore(true);
            }
        }
    }
}

