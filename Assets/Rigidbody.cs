using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] Transform tujuan1;
    [SerializeField] Transform tujuan2;
    float kecepatan = 3f;
    Transform target;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Gerakkan();
    }

    void Gerakkan() {
        Vector3 arah = (tujuan1.position - transform.position).normalized;
        rb.AddForce(arah * kecepatan);
    }
}
