using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Transform tujuan1;
    [SerializeField] Transform tujuan2;
    float kecepatan = 3f;

    Transform target;

    void Start() {
        // mulai dari tujuan1
        target = tujuan1;
    }

    void Update()
    {
    
        transform.position = Vector3.MoveTowards(transform.position, target.position, kecepatan * Time.deltaTime);
        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            target = (target == tujuan1) ? tujuan2 : tujuan1;
        }
    }
}
