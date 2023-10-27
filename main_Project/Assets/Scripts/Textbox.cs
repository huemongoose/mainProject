using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Textbox : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TextMeshProUGUI;
    public bool isDisplayed = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)&& !isDisplayed)
        {
            isDisplayed = true;
            Destroy(TextMeshProUGUI.gameObject);

        }
    }


}
