using UnityEngine;

public class CannonBallController : MonoBehaviour
{
    [SerializeField]
    private Vector3 _direction = new Vector3(0f, 0.025f, 1f);

    [SerializeField]
    private float _speed = 10f;

    public int Damage = 10;

    void Update()
    {
        transform.localPosition += _direction * _speed * Time.deltaTime;
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
