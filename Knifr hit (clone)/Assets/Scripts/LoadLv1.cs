using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLv1 : MonoBehaviour
{
    public void OnClickPlay()
    {
        SceneManager.LoadScene("Lv1");
    }
}
