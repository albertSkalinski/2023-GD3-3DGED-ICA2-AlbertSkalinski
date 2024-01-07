using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour, IInteractable
{
    [SerializeField] private string prompt;
    public string InteractionText => prompt;

    public bool Interact(Interactor interactor)
    {

        interactor.DisplayMessage("'Many soldiers keep their maces in barrels'");

        return true;
    }
}
