using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
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

        if (inventory.hasMace)
        {
            interactor.DisplayMessage("Chest unlocked, you get a key!");

            inventory.ObtainKey();

            return true;
        }
        else
        {
            interactor.DisplayMessage("Chest locked");
            return false;
        }
    }
}