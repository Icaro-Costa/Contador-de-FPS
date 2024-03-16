using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadordeFPS : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
   
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();

        InvokeRepeating(nameof(CalcularFPS), 0, 1f);
    }
    private void CalcularFPS()
    {
        textMesh.text = (1f / Time.deltaTime).ToString("00");
    }
}
