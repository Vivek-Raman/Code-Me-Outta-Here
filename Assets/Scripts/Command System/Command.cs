using UnityEngine;

public abstract class Command
{
    protected Transform source = null;

    public Command(Transform source)
    {
        this.source = source;
    }

    public abstract bool Execute();
}