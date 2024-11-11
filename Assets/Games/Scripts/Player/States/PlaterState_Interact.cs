using UnityEngine;

public class PlaterState_Interact : BaseState {
    private PlayerSM sm;

    public PlaterState_Interact(PlayerSM stateMachine) : base("Interact", stateMachine) {
        sm = (PlayerSM)stateMachine;
    }

    public override void Enter() {
        Debug.Log("INTERACT STATE");
        base.Enter();
    }

    public override void UpdateLogic() {
        base.UpdateLogic();
    }

    public override void UpdatePhysics() {
        base.UpdatePhysics();
        RaycastHit collide; 
        Physics.Raycast(sm.rb.position, sm.rb.position, out collide, 5f);
        Debug.Log(collide);

        sm.ChangeState(sm._idleState);
    }

    public override void Exit() {
        base.Exit();
    }
}
