using UnityEngine;

public class Barrel : MonoBehaviour, IInteractable
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

        interactor.DisplayMessage("Barrel opened, you find a mace!");

        inventory.ObtainMace();

        return true;
    }
}