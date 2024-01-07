using UnityEngine;
using UnityEngine.AI;

public class CharacterController : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent player;
    public Animator playerAnimator;
    public GameObject targetDest;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint;

            if(Physics.Raycast(ray,out hitPoint))
            {
                player.SetDestination(hitPoint.point);
                targetDest.transform.position = hitPoint.point;
            }
        }

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
