using UnityEngine;

public class ReycastTrigger : MonoBehaviour
{
    Camera cam;
    Ray ray;
    RaycastHit hit;
    LineRenderer lineRenderer;
    private void Start()
    {
        cam = Camera.main;
    }
    void LateUpdate()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit, 7))
        {
            ItemPickup interactable = hit.collider.gameObject.GetComponent<ItemPickup>();
            if (interactable)
            {
                interactable.Select();
            }
            OpenCloseRoom close_room = hit.collider.gameObject.GetComponent<OpenCloseRoom>();
            if (close_room)
            {
                close_room.OpenCloseRooms();
            }
            OpenCloseDoor open_door = hit.collider.gameObject.GetComponent<OpenCloseDoor>();
            if (open_door)
            {
                open_door.OpenCloseDoors();
            }
           
            Debug.DrawLine(ray.origin, hit.point, Color.red);
        }
        
    }
}
