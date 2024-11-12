using UnityEngine;

public class PlayerSM : StateMachine
{
    [HideInInspector]
    public PlayerState_Idle _idleState;
    [HideInInspector]
    public PlayerState_Move _moveState;
    [HideInInspector]
    public PlaterState_Interact _interactState;

    [SerializeField] private GameObject handRight;
    [SerializeField] private GameObject handLeft;

    public Rigidbody rb;

    private void Awake() {
        Debug.Log("PlayerSM ON");
        _idleState = new PlayerState_Idle(this);
        _moveState = new PlayerState_Move(this);
        _interactState = new PlaterState_Interact(this);
    }

    protected override BaseState GetInitialeState() {
        return _idleState;
    }
}
