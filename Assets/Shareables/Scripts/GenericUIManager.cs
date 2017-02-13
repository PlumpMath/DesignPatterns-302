using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenericUIManager : MonoBehaviour
{
    static Text displayText;
    static string displayTextName = "DisplayText";

    private void Start()
    {
        displayText = GameObject.Find(displayTextName).GetComponent<Text>();
    }

    public static void ChangeText(string value)
    {
        displayText.text = value;
    }

    public static void SetTextColor(Color color)
    {
        displayText.color = color;
    }

}
