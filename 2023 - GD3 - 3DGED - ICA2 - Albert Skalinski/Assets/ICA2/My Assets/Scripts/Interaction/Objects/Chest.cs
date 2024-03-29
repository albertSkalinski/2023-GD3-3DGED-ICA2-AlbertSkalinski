using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
    [SerializeField] private string prompt;
    public string InteractionText => prompt;
    public AudioSource soundEffectSource;

    public bool Interact(Interactor interactor)
    {
        soundEffectSource.Play();
        var inventory = interactor.GetComponent<Inventory>();

        if (inventory == null)
        {
            return false;
        }

        //checks for mace in inventory, if true, unlocks chest and gives key, if false, says chest is locked
        if (inventory.hasMace)
        {
            interactor.DisplayMessage("Chest's lock smashed, you get a key!");

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