using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private LayerMask unwalkableMask;
    private RaycastHit2D[] hits = new RaycastHit2D[2];

    public bool Move(Direction toMove)
    {
        Vector2 dir;
        switch (toMove)
        {
            case Direction.Up:
                dir = Vector2.up;
                break;
            case Direction.Right:
                dir = Vector2.right;
                break;
            case Direction.Down:
                dir = Vector2.down;
                break;
            case Direction.Left:
                dir = Vector2.left;
                break;
            case Direction.None:
            default:
                throw new System.Exception("invalid direction");
        }

        if (Physics2D.RaycastNonAlloc(this.transform.position, dir, hits, unwalkableMask) > 0)
        {
            return false;
        }

        this.transform.Translate(dir);
        return true;
    }
}
