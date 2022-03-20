using UnityEngine;

public class CannonBallSpawner : MonoBehaviour
{
    [SerializeField]
    private CannonBallController _ball;

    public void SpawnBall()
    {
        Instantiate(_ball,transform.position, transform.rotation);
    }
}
