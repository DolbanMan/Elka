using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private Toy _toy;

    private void Start()
    {
        _toy = GetComponent<Toy>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Toy toy))
            toy.Crash();
    }
}
