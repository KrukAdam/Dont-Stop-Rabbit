using UnityEngine;

public class GivePoint : MonoBehaviour
{
    [SerializeField] private int pointsToAdd = 1;
    [SerializeField] AudioSets audioSets = null;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        collision.gameObject.GetComponent<PlayerPoints>().AddPoint(pointsToAdd);
        audioSets.Play();
        Destroy(gameObject);
    }
}
