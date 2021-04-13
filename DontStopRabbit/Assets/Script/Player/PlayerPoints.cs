using UnityEngine;

public class PlayerPoints : MonoBehaviour
{
    public string playerName = "Player Name";
    [SerializeField] int points;
    [SerializeField] PlayerHUD playerHUDScore = null;
    [SerializeField] bool viewScore = false;

    public void AddPoint(int pointsToAdd)
    {
        points += pointsToAdd;
        if(points < 0)
        {
            points = 0;
        }
        playerHUDScore.RefreshValue(points.ToString());
    }
    public int GetPoints()
    {
        return points;
    }
    public void SetViewScore(bool viewScoreRabbit)
    {
        viewScore = viewScoreRabbit;
    }
    public bool GetViewScore()
    {
        return viewScore;
    }
}
