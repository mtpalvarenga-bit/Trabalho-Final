using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PaginaAudio : MonoBehaviour
{
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnEnable()
    {
        // Sempre que esta página/câmera fica ativa
        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.Stop();
            audioSource.Play();
        }
    }
}
