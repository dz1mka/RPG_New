using UnityEngine;

public class EntityState
{
    protected StateMachine stateMachine;
    protected string stateName;

    public EntityState(StateMachine stateMachine, string stateName)
    {
        this.stateMachine = stateMachine;
        this.stateName = stateName;
    }

    public virtual void Enter() 
    {
        Debug.Log($"Entering state: {stateName}");
    }

    public virtual void Update() 
    {
        Debug.Log($"Updating state: {stateName}");
    }

    public virtual void Exit() 
    {
        Debug.Log($"Exiting state: {stateName}");
    }
}
