using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//An interface for objects that can be interacted with
public interface IInteractable
{
    public string InteractionText { get; }
    public bool Interact(Interactor interactor);
}
