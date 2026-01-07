using UnityEngine;

public class MenuInicial : MonoBehaviour
{
    public GameObject cameraManagerMenu;
    public GameObject cameraManagerPorcoNovo;
    public GameObject cameraManagerPorcoMeio;
    public GameObject cameraManagerPorcoVelho;
    public GameObject cameraManagerLobo;

    public void EscolherPerspectivaPorcoNovo()
    {
        cameraManagerMenu.SetActive(false);
        cameraManagerPorcoNovo.SetActive(true);
    }

    public void EscolherPerspectivaPorcoMeio()
    {
        cameraManagerMenu.SetActive(false);
        cameraManagerPorcoMeio.SetActive(true);
    }

    public void EscolherPerspectivaPorcoVelho()
    {
        cameraManagerMenu.SetActive(false);
        cameraManagerPorcoVelho.SetActive(true);
    }

    public void EscolherPerspectivaLobo()
    {
        cameraManagerMenu.SetActive(false);
        cameraManagerLobo.SetActive(true);
    }
}
