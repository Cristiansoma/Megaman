using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class numOfEnemies : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = "Enemies left: " + GameObject.FindGameObjectsWithTag("Enemy").Length.ToString();
    }
}
