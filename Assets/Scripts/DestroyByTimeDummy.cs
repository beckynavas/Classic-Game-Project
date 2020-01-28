using UnityEngine;
using System.Collections;

public class DestroyByTimeDummy : MonoBehaviour
{
    public float lifetime;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}