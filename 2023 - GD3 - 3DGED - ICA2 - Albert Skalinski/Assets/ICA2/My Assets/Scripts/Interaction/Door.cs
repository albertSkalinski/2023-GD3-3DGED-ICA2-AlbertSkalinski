using System.Runtime.CompilerServices;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    [SerializeField] private string prompt;
    public string InteractionText => prompt;

    public bool Interact(Interactor interactor)
    {
        Debug.Log("Door opened");
        return true;
    }
}
