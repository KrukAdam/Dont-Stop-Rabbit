using UnityEngine;

public class PlayersSettings : MonoBehaviour
{
    [SerializeField] Sprite[] imagesRabbits = null;
    [SerializeField] GameObject[] playersPanelColor = null;
    private PlayersSet playersSet = null;

    private void Start()
    {
        InitPlayersSet();
    }
    private void InitPlayersSet()
    {
        GameObject playerSetsObject = GameObject.FindGameObjectWithTag("PlayerSets");
        if (playerSetsObject != null)
            playersSet = playerSetsObject.GetComponent<PlayersSet>();
    }
    public PlayersSet GetPlayersSet()
    {
        if(playersSet == null)
        {
            InitPlayersSet();
        }
        return playersSet;
    }
    public Sprite GetImageRabbit(int idImage)
    {
        return imagesRabbits[idImage];
    }
    public void ActivePlayersPanelColor(int numberActivePanel)
    {
        for (int i = 0; i < playersPanelColor.Length; i++)
        {
            if(numberActivePanel >= i)
            {
                playersPanelColor[i].SetActive(true);
            }
            else
            {
                playersPanelColor[i].SetActive(false);
            }

        }
    }
    public void PlayersLifes(int numberLife)
    {
        playersSet.SetLifesPlayers(numberLife);
    }
    public int GetPlayerLife()
    {
        if (playersSet == null)
        {
            InitPlayersSet();
        }
        return playersSet.GetCurrentLifeValue();
    }
}
