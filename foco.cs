using UnityEngine;
using UnityEngine.UI;

public class foco : MonoBehaviour
{
    //Asigna la url de la pagina a la variable url
    public string url = "http://192.168.137.223/off";

    public void OpenWebPage()
    {
        Application.OpenURL(url);
    }
}
