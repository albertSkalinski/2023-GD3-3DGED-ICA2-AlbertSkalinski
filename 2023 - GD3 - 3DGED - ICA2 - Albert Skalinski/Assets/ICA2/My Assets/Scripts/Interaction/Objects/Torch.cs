using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour, IInteractable
{
    [SerializeField] private string prompt;
    public string InteractionText => prompt;

    //Displays message
    public bool Interact(Interactor interactor)
    {
        interactor.DisplayMessage("You pull it, but nothing happens");
        return true;
    }
}
