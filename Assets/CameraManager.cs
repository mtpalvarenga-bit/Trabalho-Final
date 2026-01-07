using UnityEngine;
using UnityEngine.InputSystem;

public class CameraManager : MonoBehaviour
{
    public Camera[] cameras;

    [Header("Referência ao menu")]
    public GameObject cameraManagerMenu;

    private int indiceAtual = 0;

    void Start()
    {
        AtivarCamera(0);
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            ProximaCamera();
        }
    }

    void AtivarCamera(int indice)
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(i == indice);
        }

        indiceAtual = indice;
    }

    void ProximaCamera()
    {
        int proximo = indiceAtual + 1;

        // Se chegou à última página
        if (proximo >= cameras.Length)
        {
            // Voltar ao menu
            cameraManagerMenu.SetActive(true);

            // Desativar esta perspetiva
            this.gameObject.SetActive(false);
            return;
        }

        AtivarCamera(proximo);
    }
}
