using UnityEngine;
using UnityEngine.UI;

public class RabbitSpeedSets : MonoBehaviour
{
    [SerializeField] Dropdown speedDropDown = null;

    public void SetRabbitsSpeed(int valueDropDonw)
    {
        switch (valueDropDonw)
        {
            case 0:
                Time.timeScale = 0.75f;
                return;
            case 1:
                Time.timeScale = 1;
                return;
            case 2:
                Time.timeScale = 1.5f;
                return;
            default:
                Time.timeScale = 1;
                return;
        }
    }
}
