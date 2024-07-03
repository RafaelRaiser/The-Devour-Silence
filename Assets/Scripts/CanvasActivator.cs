using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasActivator : MonoBehaviour
{
    public GameObject canvas; // Referência ao GameObject do Canvas que você deseja controlar


    void Update()
    {
        // Verifica se a tecla Shift está sendo segurada
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            HideCanvas();
        }
        else
        {
            ShowCanvas();
        }
      
    }

   public void HideCanvas()
    {
        canvas.SetActive(false); // Desativa o Canvas
    }

    void ShowCanvas()
    {
        canvas.SetActive(true); // Ativa o Canvas
    }
}
