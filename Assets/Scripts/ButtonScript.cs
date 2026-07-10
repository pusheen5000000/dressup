using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private string gameSceneName;
    public void Home()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}
