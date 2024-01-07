using UnityEngine;
using UnityEngine.AI;

//https://www.youtube.com/watch?v=7eAwVUsiqZU, Accessed On: <07/01>, Using Line Numbers: 6-37

public class CharacterController : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent player;
    public Animator playerAnimator;
    public GameObject targetDest;

    void Update()
    {
        //checks the click
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint;

            if(Physics.Raycast(ray,out hitPoint))
            {
                //moves the player to the clicked location
                player.SetDestination(hitPoint.point);
                targetDest.transform.position = hitPoint.point;
            }
        }

        //animation states
        if(player.velocity != Vector3.zero)
        {
            playerAnimator.SetBool("isRunning", true);
        }
        else if (player.velocity == Vector3.zero)
        {
            playerAnimator.SetBool("isRunning", false);
        }
    }
}
