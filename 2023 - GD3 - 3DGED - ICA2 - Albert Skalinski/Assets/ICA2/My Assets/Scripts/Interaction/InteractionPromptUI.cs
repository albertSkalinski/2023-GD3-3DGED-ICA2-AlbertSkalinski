using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

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
       }}
