using System.Collections;
using UnityEngine;

public class RespawnObjects : MonoBehaviour
{
    [SerializeField] GameObject[] prefabObjects = null;
    [SerializeField] float minimalTimeToResp = 0;
    [SerializeField] float maximumTimeToResp = 10;

    private void Start()
    {
        StartCoroutine(StartResp());
    }
    IEnumerator StartResp()
    {
        float timeToNextResp = Random.Range(minimalTimeToResp, maximumTimeToResp);
        GameObject obiectToResp = prefabObjects[Random.Range(0, prefabObjects.Length)];
        Instantiate(obiectToResp, transform.position, Quaternion.identity);

        yield return new WaitForSeconds(timeToNextResp);

        StartCoroutine(StartResp());
    }
}
