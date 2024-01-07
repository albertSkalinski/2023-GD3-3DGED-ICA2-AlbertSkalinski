using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sewer : MonoBehaviour, IInteractable
{
    [SerializeField] private string prompt;
    public string InteractionText => prompt;

    public bool Interact(Interactor interactor)
    {

        interactor.DisplayMessage("Stinky!");

        return true;
    }
}
