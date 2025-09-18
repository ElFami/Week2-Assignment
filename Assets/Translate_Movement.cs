using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate_ : MonoBehaviour
{
    [SerializeField] Transform tujuan1;
    [SerializeField] Transform tujuan2;
    float kecepatan = 3f;
    Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gerakkan5();
    }

    void gerakkan5() {
        // this.transform.Translate(Vector3.forward * Time.deltaTime, Space.World);
        this.transform.Translate(Vector3.forward * Time.deltaTime, Space.Self);
        this.transform.Rotate(Vector3.up * 1f);
    }
}
