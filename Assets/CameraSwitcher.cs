using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera cameraAtual;
    public Camera cameraNova;

    public void MudarCamera()
    {
        cameraAtual.enabled = false;
        cameraNova.enabled = true;
    }
}
