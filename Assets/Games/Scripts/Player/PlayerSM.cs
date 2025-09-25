using UnityEngine;

public class PlayerSM : StateMachine
{
    [HideInInspector]
    public PlayerState_Idle _idleState;
    [HideInInspector]
    public PlayerState_Move _moveState;
    [HideInInspector]
    public PlaterState_Interact _interactState;

    [Header("---- Player Hand ----")]
    [SerializeField] private Transform transformHandRight;
    [SerializeField] private GameObject handRight;

    [Header("---- Player Inventory ----")]
    [SerializeField] private bool isPlayerHaveDoorKey = false;

    public Rigidbody rb;

    private void Awake()
    {
        Debug.Log("PlayerSM ON");
        _idleState = new PlayerState_Idle(this);
        _moveState = new PlayerState_Move(this);
        _interactState = new PlaterState_Interact(this);
    }

    protected override BaseState GetInitialeState()
    {
        return _idleState;
    }

    public void SetObjectInHands()
    {
        handRight = null;
    }

    public void DeletObjectInHands()
    {

    }

    public void GiveTypeOfObjectInHands()
    {

    }

    public bool AsHandFree()
    {
        if (handRight == null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // PLayer Key Parameters

    public void PlayerGetKey()
    {
        isPlayerHaveDoorKey = true;
    }

    public bool IsPlayerHaveKey()
    {
        return isPlayerHaveDoorKey;
    }
}
