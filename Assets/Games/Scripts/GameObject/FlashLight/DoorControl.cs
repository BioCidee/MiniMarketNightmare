using UnityEngine;

public class DoorControl : MonoBehaviour
{
    [Header("---- Door Parameters ----")]
    [SerializeField] private float speed;
    [SerializeField] private LayerMask playerLayer;

    [Header("---- Door Status -----")]
    [SerializeField] private bool isDoorOpen = false;


    void OnTriggerEnter(Collider other)
    {
        if ((playerLayer.value & (1 << other.gameObject.layer)) != 0)
        {

            if (other.gameObject.GetComponent<PlayerSM>().IsPlayerHaveKey())
            {
                OpenDoor();
            }
        }
    }

    private void OpenDoor()
    {
        Debug.Log("DOOR IS OPENING");
        Destroy(this.gameObject);
    }
}
