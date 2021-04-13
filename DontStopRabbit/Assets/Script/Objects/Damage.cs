using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private int damage = 1;
    [SerializeField] GameObject hitEffect = null;
    [SerializeField] AudioSets audioSets = null;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSets.Play();
        collision.gameObject.GetComponent<PlayerHealth>().Hit(damage, hitEffect);
    }
}
