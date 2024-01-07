using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

//https://www.youtube.com/watch?v=THmW4YolDok, Accessed On: <01/24>, Using Line Numbers: 9-40

public class InteractionPromptUI : MonoBehaviour
{
    private Camera cam;
    [SerializeField] private GameObject UIPanel;
    [SerializeField] private TextMeshProUGUI promptText;

    private void Start()
    {
        cam = Camera.main;
        UIPanel.SetActive(false);
    }

    private void LateUpdate()
    {
        //makes the UI face the camera
        var rotation = cam.transform.rotation;
        transform.LookAt(transform.position + rotation * Vector3.forward, rotation * Vector3.up);
    }

    public bool isDisplayed = false;

    public void SetUp(string _text)
    {
        promptText.text = _text;
        UIPanel.SetActive(true);
        isDisplayed = true;
    }

    public void Close()
    {
           UIPanel.SetActive(false);
           isDisplayed = false;
    }
}
