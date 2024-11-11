using UnityEngine;

public class PlayerState_Idle : BaseState {
    // System
    private PlayerSM sm;

    // Parameters

    public PlayerState_Idle(PlayerSM stateMachine) : base("Idle", stateMachine) {
        sm = (PlayerSM)stateMachine;
    }

    public override void Enter() {
        Debug.Log("IDLE STATE");
        base.Enter();
    }

    public override void UpdateLogic() {
        base.UpdateLogic();
        float xDir = Input.GetAxis("Horizontal");
        float zDir = Input.GetAxis("Vertical");

        if (Mathf.Abs(zDir) > Mathf.Epsilon && Mathf.Abs(xDir) > Mathf.Epsilon) {
            sm.ChangeState(sm._moveState);
        }

        if (Input.GetKeyDown(KeyCode.F)) {
            sm.ChangeState(sm._interactState);
        }
    }

    public override void UpdatePhysics() {
        base.UpdatePhysics();
    }

    public override void Exit() { 
        base.Exit(); 
    }
}
