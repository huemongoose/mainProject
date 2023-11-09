using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class Textbox : MonoBehaviour
{
    public TextMeshProUGUI TextMeshProUGUI;
    public string[] lines;
    private int index;
    public float textspeed;


    private void Start()
    {
        TextMeshProUGUI.text = string.Empty;
        StartDialogue();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(TextMeshProUGUI.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();    
                TextMeshProUGUI.text = lines[index];
            }
        }
    }
    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());

    }
    IEnumerator TypeLine()
    {
        foreach(char c in lines[index].ToCharArray())
        {
            TextMeshProUGUI.text += c;
            yield return new WaitForSeconds(textspeed);
        }
    }

    void NextLine()
    {
        if(index < lines.Length - 1)
        {
            index++;
            TextMeshProUGUI.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
    


}
