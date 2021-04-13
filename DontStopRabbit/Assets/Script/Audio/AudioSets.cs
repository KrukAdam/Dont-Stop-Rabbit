using UnityEngine;

public class AudioSets : MonoBehaviour
{
    [SerializeField] AudioClip[] clipList = null;
    [SerializeField] AudioSource audioSource = null;
    [SerializeField] GameObject audioObjectPrefab = null;
    [SerializeField] float timeToDestroy = 5;
    [SerializeField] bool dontDestroy = false;
    [SerializeField] bool loop = false;

    public void Play()
    {
        AudioClip clipToPlay = clipList[Random.Range(0, clipList.Length)];
        GameObject audioSpeaker = Instantiate(audioObjectPrefab);
        audioSource = audioSpeaker.GetComponent<AudioSource>();
        audioSource.clip = clipToPlay;
        audioSource.loop = loop;
        audioSource.Play();
        if (!dontDestroy)
        {
            Destroy(audioSpeaker, timeToDestroy);
        }
    }
}
