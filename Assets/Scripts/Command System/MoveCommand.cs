using UnityEngine;

public class MoveCommand : Command
{
    private Movement movement = null;
    private Direction toMove;

    public MoveCommand(Transform source, Direction toMove) : base(source)
    {
        movement = source.GetComponent<Movement>();
        this.toMove = toMove;
    }

    public override bool Execute()
    {
        movement.Move(toMove);
        return true;
    }
}