using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using System.IO;

public class OpenChat : MonoBehaviour
{
    public void OpenChatURL()
    {
        // Ruta relativa al archivo HTML en la carpeta Assets
        string filePath = Path.Combine(Application.streamingAssetsPath, "chat.html");

        // Convertir la ruta del archivo en una URL
        string url = "file://" + filePath;

        // Abre la URL en el navegador por defecto
        Application.OpenURL(url);
    }
}

