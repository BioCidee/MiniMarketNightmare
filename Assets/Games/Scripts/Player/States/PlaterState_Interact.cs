using UnityEngine;

public class PlaterState_Interact : BaseState {
    private PlayerSM sm;

    public PlaterState_Interact(PlayerSM stateMachine) : base("Interact", stateMachine) {
        sm = (PlayerSM)stateMachine;
    }

    public override void Enter() {
        base.Enter();
    }

    public override void UpdateLogic() {
        base.UpdateLogic();
    }

    public override void UpdatePhysics() {
        base.UpdatePhysics();
        OnInteract();
        sm.ChangeState(sm._idleState);
    }

    public override void Exit() {
        base.Exit();
    }

    private void OnInteract() {
        RaycastHit hitInfo;
        if (Physics.Raycast(new Vector3(sm.rb.position.x, 0.2f, sm.rb.position.z), sm.rb.transform.forward, out hitInfo)) {
            Debug.Log(hitInfo.transform.gameObject.name);
        }
        Debug.DrawRay(new Vector3(sm.rb.position.x, 0.2f, sm.rb.position.z), sm.rb.transform.forward, Color.red);
    }
}
