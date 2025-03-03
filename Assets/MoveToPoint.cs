using UnityEngine;

public class MoveToPoint : MonoBehaviour
{
    [SerializeField] Vector2[] PointCords;
    [SerializeField] float speed;
    public int NumberOfPoint;
    public bool DoMove;

    protected void FixedUpdate()
    {
        if(DoMove)
        {
            transform.position = Vector2.MoveTowards(transform.position, PointCords[NumberOfPoint], speed * Time.fixedDeltaTime);
        }
        if(transform.position.x == PointCords[NumberOfPoint].x)
        {
            Finish();
        }
    }
    public virtual void Finish()
    {
        DoMove = false;
    }
}
