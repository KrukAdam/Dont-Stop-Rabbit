using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int health = 3;
    [SerializeField] private PlayerController playerController = null;
    Vector3 positionZero;
    [SerializeField] private PlayMode playMode = null;
    [SerializeField] private PlayerHUD playerHUDHealth = null;

    private void Awake()
    {
        positionZero = new Vector3(0, 0, 0);
        playerHUDHealth.RefreshValue(GetHealth().ToString());
    }
    public void Hit(int damage, GameObject hitEffects)
    {
        GameObject hitEffect = Instantiate(hitEffects, transform.position, Quaternion.identity);
        Destroy(hitEffect, 1f);

        health -= damage;
        playerHUDHealth.RefreshValue(GetHealth().ToString());
        CheckIsLife();
    }
    private void CheckIsLife()
    {
        if(GetHealth() == 0)
        {
            gameObject.SetActive(false);
            playMode.ViewGameOverWindow();
        }
        else
        {
            playerController.RespawnAfterHit(positionZero);
        }
    }
    public int GetHealth()
    {
        if(health < 0)
        {
            return 0;
        }
        else
        {
            return health;
        }
    }
    public void SetHealth(int numberOfLifes)
    {
        health = numberOfLifes;
        playerHUDHealth.RefreshValue(GetHealth().ToString());
    }
}
