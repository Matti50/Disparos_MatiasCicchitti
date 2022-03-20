using System.Collections;
using UnityEngine;

public class Canon : MonoBehaviour
{
    [SerializeField] private KeyCode shootKeyCode;

    [SerializeField] private KeyCode oneTimeKeyCode;

    [SerializeField] private KeyCode twoTimesKeyCode;

    [SerializeField] private KeyCode threeTimeKeyCode;

    private CannonBallSpawner _cannonBallSpawner;

    private void Start()
    {
        _cannonBallSpawner = GetComponentInChildren<CannonBallSpawner>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(shootKeyCode))
        {
            Shoot();
        }

        if (Input.GetKeyDown(oneTimeKeyCode))
        {
            StartCoroutine(Shoot(2));
        }

        if (Input.GetKeyDown(twoTimesKeyCode))
        {
            StartCoroutine(Shoot(3));
        }

        if (Input.GetKeyDown(threeTimeKeyCode))
        {
            StartCoroutine(Shoot(4));
        }
    }

    private void Shoot()
    {
        Debug.Log("Shoot");
        _cannonBallSpawner.SpawnBall();
    }

    private IEnumerator Shoot(int shots)
    {
        for (int i = 0; i < shots; i++)
        {
            Shoot();
            yield return new WaitForSeconds(1);
        }
    }
}
