using System.Runtime.CompilerServices;
using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
    [SerializeField] private string prompt;
    public string InteractionText => prompt;

    public bool Interact(Interactor interactor)
    {
        Debug.Log("Chest opened");
        return true;
    }
}
