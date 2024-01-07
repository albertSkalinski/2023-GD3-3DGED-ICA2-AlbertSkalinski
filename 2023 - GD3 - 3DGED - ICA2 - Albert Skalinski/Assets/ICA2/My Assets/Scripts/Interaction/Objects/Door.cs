using System.Runtime.CompilerServices;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    [SerializeField] private string prompt;
    public string InteractionText => prompt;

    public bool Interact(Interactor interactor)
    {
        var inventory = interactor.GetComponent<Inventory>();

        if (inventory == null)
        {
            return false;
        }

        if (inventory.hasKey)
        {
            // Display message on screen
            interactor.DisplayMessage("Door unlocked");
        }
        else
        {
            // Display message on screen
            interactor.DisplayMessage("Door locked");
        }
        return false;
    }
}
