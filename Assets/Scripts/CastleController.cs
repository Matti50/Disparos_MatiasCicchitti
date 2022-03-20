using Assets.Scripts.Utils;
using System;
using UnityEngine;

public class CastleController : MonoBehaviour
{
    [SerializeField]
    private int _life = 100;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == Tags.CannonBall)
        {
            Debug.Log("Got hit by CannonBall!");

            var cannonBall = other.gameObject.GetComponent<CannonBallController>();

            _life = Math.Max(0, _life - cannonBall.Damage);
            Debug.Log($"Life: {_life}");

            cannonBall.Destroy();
        }
    }
}
