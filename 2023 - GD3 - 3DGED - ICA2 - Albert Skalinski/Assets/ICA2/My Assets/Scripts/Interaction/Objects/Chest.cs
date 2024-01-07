using System.Runtime.CompilerServices;
using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
    [SerializeField] private string prompt;
    public string InteractionText => prompt;

    public bool Interact(Interactor interactor)
    {
        prompt = "Chest opened";
        return true;
    }
}
