using UnityEngine;

public class PlayersSet : MonoBehaviour
{
    [SerializeField] NumberOfPlayers numberOfPlayers = NumberOfPlayers.ONE;
    [SerializeField] PlayerProperties[] playersProperties = null;
    public static PlayersSet instance;
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    private void OnLevelWasLoaded(int level)
    {
        GameObject playModeObject = GameObject.FindGameObjectWithTag("PlayMode");
        if(playModeObject != null)
        {
            PlayMode playMode = playModeObject.GetComponent<PlayMode>();
            playMode.SetRabbitsProporties(playersProperties);
            playMode.SetActivePlayersAndHUD(numberOfPlayers);
        }
    }
    public void SetNumberOfPlayers(int valueDropDown)
    {
        switch (valueDropDown)
        {
            case 0:
                numberOfPlayers = NumberOfPlayers.ONE;
                break;
            case 1:
                numberOfPlayers = NumberOfPlayers.TWO;
                break;
            case 2:
                numberOfPlayers = NumberOfPlayers.THREE;
                break;
            case 3:
                numberOfPlayers = NumberOfPlayers.FOUR;
                break;
            default:
                break;
        }
    }
    public NumberOfPlayers GetNumberOfPlayers()
    {
        return numberOfPlayers;
    }
    public void SetColorPlayer(int valueDropDown, int idPlayer)
    {
        switch (valueDropDown)
        {
            case 0:
                playersProperties[idPlayer].rabbitColor = RabbitColor.BLACK;
                break;
            case 1:
                playersProperties[idPlayer].rabbitColor = RabbitColor.WHITE;
                break;
            case 2:
                playersProperties[idPlayer].rabbitColor = RabbitColor.SNOW;
                break;
            case 3:
                playersProperties[idPlayer].rabbitColor = RabbitColor.SNOWYELLOW;
                break;
            case 4:
                playersProperties[idPlayer].rabbitColor = RabbitColor.SNOWBROWN;
                break;
            case 5:
                playersProperties[idPlayer].rabbitColor = RabbitColor.BROWN;
                break;
            case 6:
                playersProperties[idPlayer].rabbitColor = RabbitColor.WOOD;
                break;
            case 7:
                playersProperties[idPlayer].rabbitColor = RabbitColor.GRAY;
                break;
            default:
                break;
        }
    }
    public int GetIdColorPlayer(int idPlayer)
    {
        switch (playersProperties[idPlayer].rabbitColor)
        {
            case RabbitColor.BLACK:
                return 0;
            case RabbitColor.WHITE:
                playersProperties[idPlayer].rabbitColor = RabbitColor.WHITE;
                return 1;
            case RabbitColor.SNOW:
                playersProperties[idPlayer].rabbitColor = RabbitColor.SNOW;
                return 2;
            case RabbitColor.SNOWYELLOW:
                playersProperties[idPlayer].rabbitColor = RabbitColor.SNOWYELLOW;
                return 3;
            case RabbitColor.SNOWBROWN:
                playersProperties[idPlayer].rabbitColor = RabbitColor.SNOWBROWN;
                return 4;
            case RabbitColor.BROWN:
                playersProperties[idPlayer].rabbitColor = RabbitColor.BROWN;
                return 5;
            case RabbitColor.WOOD:
                playersProperties[idPlayer].rabbitColor = RabbitColor.WOOD;
                return 6;
            case RabbitColor.GRAY:
                playersProperties[idPlayer].rabbitColor = RabbitColor.GRAY;
                return 7;
            default:
                return 0;
        }
    }
    public void SetLifesPlayers(int numberOfLife)
    {
        for (int i = 0; i < playersProperties.Length; i++)
        {
            playersProperties[i].health = numberOfLife;
        }
    }
    public int GetCurrentLifeValue()
    {
        return playersProperties[0].health;
    }
}
