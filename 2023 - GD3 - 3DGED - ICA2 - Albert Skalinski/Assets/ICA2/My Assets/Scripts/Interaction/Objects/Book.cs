using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour, IInteractable
{
    [SerializeField] private string prompt;
    public string InteractionText => prompt;
    public AudioSource soundEffectSource;

    public bool Interact(Interactor interactor)
    {
        soundEffectSource.Play();
        interactor.DisplayMessage("'Many soldiers keep their maces in barrels'");

        return true;
    }
}
