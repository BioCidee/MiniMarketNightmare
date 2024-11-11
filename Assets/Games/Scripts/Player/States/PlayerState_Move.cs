using UnityEngine;

public class PlayerState_Move : BaseState {
    private PlayerSM sm;

    public PlayerState_Move(PlayerSM stateMachine) : base("Move", stateMachine) {
        sm = (PlayerSM)stateMachine;
    }

    public override void Enter() {
        base.Enter();
        Debug.Log("MOVE STATE");
    }

    public override void UpdateLogic() {
        base.UpdateLogic();
        float xDir = Input.GetAxis("Horizontal");
        float zDir = Input.GetAxis("Vertical");

        if(Mathf.Abs(zDir) < Mathf.Epsilon && Mathf.Abs(xDir) < Mathf.Epsilon) {
            sm.ChangeState(sm._idleState);
        }
    }

    public override void UpdatePhysics() {
        base.UpdatePhysics();
        Movement();
        OnAction();
    }

    public override void Exit() {
        base.Exit();
    }

    private void Movement() {
        float xDir = Input.GetAxis("Horizontal");
        float zDir = Input.GetAxis("Vertical");

        Vector3 newDir = new Vector3(xDir, 0, zDir);
        sm.rb.position += newDir * 2 * Time.deltaTime;

        PlayerRotation(newDir);
    }

    private void PlayerRotation(Vector3 direct) {
        Quaternion toRotate = Quaternion.LookRotation(direct.normalized, Vector3.up);

        sm.rb.rotation = Quaternion.RotateTowards(sm.rb.rotation, toRotate, 200 * Time.deltaTime);
    }

    private void OnAction() {
        if (Input.GetKeyDown(KeyCode.F)) {
            sm.ChangeState(sm._interactState);
        }
    }
}
