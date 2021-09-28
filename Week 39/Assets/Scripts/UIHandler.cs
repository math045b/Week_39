using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    public void changeScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}