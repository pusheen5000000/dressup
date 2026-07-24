using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private string gameSceneName;
    [SerializeField] private float loadDelay = 0.3f; // adjust to match your click sound length

    public void Home()
    {
        Invoke(nameof(LoadHomeScene), loadDelay);
    }

    private void LoadHomeScene()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}