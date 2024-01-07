using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sewer : MonoBehaviour, IInteractable
{
    [SerializeField] private string prompt;
    public string InteractionText => prompt;
    public AudioSource soundEffectSource;

    //Displays message
    public bool Interact(Interactor interactor)
    {
        soundEffectSource.Play();
        interactor.DisplayMessage("Stinky!");

        return true;
    }
}
