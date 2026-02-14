using UnityEngine;

public class BallWallCollision : MonoBehaviour
{
    public Transform character1;
    public Transform character2;
    public Transform ball;

    public Vector3 character1TargetPos;
    public Vector3 character2TargetPos;
    public Vector3 ballTargetPos;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            character1.position = character1TargetPos;
            character2.position = character2TargetPos;
            ball.position = ballTargetPos;
        }
    }
}