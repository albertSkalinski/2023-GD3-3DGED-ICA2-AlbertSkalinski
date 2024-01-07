using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

//https://www.youtube.com/watch?v=THmW4YolDok, Accessed On: <01/24>, Using Line Numbers: 8-67, but modifed to my own needs

public class Interactor : MonoBehaviour
{
    [SerializeField] private Transform interactionPoint;
    [SerializeField] private float interactionRadius = 0.5f;
    [SerializeField] private LayerMask interactionLayerMask;
    [SerializeField] private InteractionPromptUI interactionPromptUI;

    private readonly Collider[] colliders = new Collider[3];
    [SerializeField] private int numFound;

    private IInteractable interactable;

    private void Update()
    {
        numFound = Physics.OverlapSphereNonAlloc(interactionPoint.position,
            interactionRadius, colliders, interactionLayerMask);
        
        //If there is an interactable object, display the message and allow the player to interact with it
        if (numFound > 0)
        {
            interactable = colliders[0].GetComponent<IInteractable>();

            if (interactable != null)
            {
                if (!interactionPromptUI.isDisplayed)
                {
                    interactionPromptUI.SetUp(interactable.InteractionText);
                }

                if (Input.GetKeyDown(KeyCode.F))
                {
                    interactable.Interact(this);
                }
            }
        }
        //If there is no interactable object, doesn't display the message
        else
        {
            if (interactable != null)
            {
                interactable = null;
            }
            if (interactionPromptUI.isDisplayed)
            {
                interactionPromptUI.Close();
            }
        }
    }
    //Displays message from an object
    public void DisplayMessage(string message)
    {
        interactionPromptUI.SetUp(message);
    }

    //Illustrates the interaction radius
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(interactionPoint.position, interactionRadius);
    }
}
