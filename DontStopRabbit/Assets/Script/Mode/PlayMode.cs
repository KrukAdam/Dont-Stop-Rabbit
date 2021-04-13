using UnityEngine;
using UnityEngine.UI;

public enum RabbitColor { WHITE, BLACK, SNOW, SNOWYELLOW, SNOWBROWN, BROWN, GRAY, WOOD}
public enum NumberOfPlayers { ONE, TWO, THREE, FOUR}

public class PlayMode : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel = null;
    [SerializeField] GameObject[] players = null;
    [SerializeField] Image[] playersUiImage = null;
    [SerializeField] Sprite[] kindOfRabbitUiSprite = null;
    [SerializeField] GameObject exitPanel = null;
    [SerializeField] HUDView hUDView = null;
    NumberOfPlayers numberPlayers = NumberOfPlayers.ONE;

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            ExitAndPausePanel();
        }
    }
    public void ExitAndPausePanel()
    {
        if (!exitPanel.activeSelf)
        {
            exitPanel.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            exitPanel.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void SetActivePlayersAndHUD(NumberOfPlayers numberOfPlayers)
    {
        numberPlayers = numberOfPlayers;
        hUDView.SetActiveHUD(numberOfPlayers);
        switch (numberOfPlayers)
        {
            case NumberOfPlayers.ONE:
                players[0].SetActive(true);
                players[1].SetActive(false);
                players[2].SetActive(false);
                players[3].SetActive(false);
                return;
            case NumberOfPlayers.TWO:
                players[0].SetActive(true);
                players[1].SetActive(true);
                players[2].SetActive(false);
                players[3].SetActive(false);
                return;
            case NumberOfPlayers.THREE:
                players[0].SetActive(true);
                players[1].SetActive(true);
                players[2].SetActive(true);
                players[3].SetActive(false);
                return;
            case NumberOfPlayers.FOUR:
                players[0].SetActive(true);
                players[1].SetActive(true);
                players[2].SetActive(true);
                players[3].SetActive(true);
                return;
            default:
                return;
        }
       
    }
    public void ViewGameOverWindow()
    {
        bool endGame = true;
        for (int i = 0; i < players.Length; i++)
        {
            if (players[i].activeSelf)
            {
                endGame = false;
                break;
            }
        }
        if (endGame)
        {
            gameOverPanel.SetActive(true);
            gameOverPanel.GetComponent<GameOverPanel>().SetScore(numberPlayers);
        }
    }
    public void SetRabbitsProporties(PlayerProperties[] playersProperties)
    {
        for (int i = 0; i < players.Length; i++)
        {
            SetRabbitsColor(playersProperties[i].rabbitColor, i);
            SetRabbitsLifes(playersProperties[i].health, i);
        }
    }
    private void SetUiImagePlayer(Sprite kindOfSRbbits, int idPlayer)
    {
        playersUiImage[idPlayer].sprite = kindOfSRbbits;
    }
    private void SetRabbitsColor(RabbitColor rabbitColor, int idRabbit)
    {
        switch (rabbitColor)
        {
            case RabbitColor.WHITE:
                players[idRabbit].GetComponent<Animator>().SetTrigger("White");
                SetUiImagePlayer(kindOfRabbitUiSprite[0], idRabbit);
                return;
            case RabbitColor.BLACK:
                players[idRabbit].GetComponent<Animator>().SetTrigger("Black");
                SetUiImagePlayer(kindOfRabbitUiSprite[1], idRabbit);
                return;
            case RabbitColor.SNOW:
                players[idRabbit].GetComponent<Animator>().SetTrigger("Snow");
                SetUiImagePlayer(kindOfRabbitUiSprite[2], idRabbit);
                return;
            case RabbitColor.SNOWBROWN:
                players[idRabbit].GetComponent<Animator>().SetTrigger("SnowBrown");
                SetUiImagePlayer(kindOfRabbitUiSprite[3], idRabbit);
                return;
            case RabbitColor.SNOWYELLOW:
                players[idRabbit].GetComponent<Animator>().SetTrigger("SnowYellow");
                SetUiImagePlayer(kindOfRabbitUiSprite[4], idRabbit);
                return;
            case RabbitColor.BROWN:
                players[idRabbit].GetComponent<Animator>().SetTrigger("Brown");
                SetUiImagePlayer(kindOfRabbitUiSprite[5], idRabbit);
                return;
            case RabbitColor.GRAY:
                players[idRabbit].GetComponent<Animator>().SetTrigger("Gray");
                SetUiImagePlayer(kindOfRabbitUiSprite[6], idRabbit);
                return;
            case RabbitColor.WOOD:
                players[idRabbit].GetComponent<Animator>().SetTrigger("Wood");
                SetUiImagePlayer(kindOfRabbitUiSprite[7], idRabbit);
                return;
            default:
                return;
        }

    }
    private void SetRabbitsLifes(int numberOfLife, int idRabbit)
    {
        players[idRabbit].GetComponent<PlayerHealth>().SetHealth(numberOfLife);
    }
}
