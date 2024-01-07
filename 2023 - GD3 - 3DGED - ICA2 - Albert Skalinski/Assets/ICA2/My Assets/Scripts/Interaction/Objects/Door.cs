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

        if (inventory.hasKey)
        {
            // Display message on screen
            interactor.DisplayMessage("Door unlocked");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            // Display message on screen
            interactor.DisplayMessage("Door locked");
        }
        return false;
    }
}
