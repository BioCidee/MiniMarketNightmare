using UnityEngine;

public class DoorKey : MonoBehaviour
{
    [SerializeField] private LayerMask playerLayer;

    void OnTriggerEnter(Collider other)
    {
        if ((playerLayer.value & (1 << other.gameObject.layer)) != 0)
        {
            other.gameObject.GetComponent<PlayerSM>().PlayerGetKey();
            Destroy(this.gameObject);
        }
    }
}
