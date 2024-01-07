using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour, IInteractable
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

        // Check if the player has the key, if so, unlock the door and finish the game by loading the ending scene
        if (inventory.hasKey)
        {
            interactor.DisplayMessage("Door unlocked");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            interactor.DisplayMessage("Door locked");
        }
        return false;
    }
}
