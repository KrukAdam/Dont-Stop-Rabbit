using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] AudioSets audioSets = null;

    private void Start()
    {
        audioSets.Play();
    }
}
