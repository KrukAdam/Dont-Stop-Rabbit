using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private string sceneToLoad = "Menu";

    public void LoadAScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
