using UnityEngine;
using UnityEngine.SceneManagement;

public class CanviaEscenaMenu : MonoBehaviour
{
    public void CanviEscena(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}