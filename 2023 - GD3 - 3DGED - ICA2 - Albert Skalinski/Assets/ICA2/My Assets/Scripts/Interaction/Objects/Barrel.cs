using UnityEngine;

public class Barrel : MonoBehaviour, IInteractable
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

        interactor.DisplayMessage("Barrel opened, you find a mace!");

        inventory.ObtainMace();

        return true;
    }
}