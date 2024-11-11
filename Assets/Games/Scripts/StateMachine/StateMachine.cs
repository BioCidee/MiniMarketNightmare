using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private BaseState _currentState;

    private void Start() {
        ChangeState(GetInitialeState());
    }

    private void Update() {
        if(_currentState != null)
            _currentState.UpdateLogic();
    }

    private void LateUpdate() {
        if(_currentState != null)
            _currentState.UpdatePhysics();
    }

    public void ChangeState(BaseState newState) {
        if(_currentState != null)
            _currentState.Exit();

        _currentState = newState;
        _currentState.Enter();
    }

    protected virtual BaseState GetInitialeState() {
        return null;
    }
}
