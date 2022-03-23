using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainMenu : MonoBehaviour
{
    public void OnClickMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

