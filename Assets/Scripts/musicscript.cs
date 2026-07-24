using UnityEngine;

public class music : MonoBehaviour
{
    public static music instance;

    public AudioSource audioSource;
    public AudioClip musicClip;
    [Range(0f, 1f)]
    public float volume = 0.5f;

    void Awake()
    {
        // Prevent duplicate music players when reloading scenes
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    void Start()
    {
        // If you didn't assign it in the Inspector, get it from this GameObject
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();

        audioSource.clip = musicClip;
        audioSource.loop = true;
        audioSource.playOnAwake = false;
        audioSource.volume = volume;
        audioSource.Play();
    }

    void Update()
    {
        
    }
}