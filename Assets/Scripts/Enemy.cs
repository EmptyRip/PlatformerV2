using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Vector3 _spawn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Transform>(out Transform player))
        {
            player.position = _spawn;
        }
    }
}
