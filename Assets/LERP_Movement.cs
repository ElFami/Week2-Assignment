using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LERP_Movement : MonoBehaviour
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
        // gerakkan1();
        // gerakan2();
        gerakkan3();
    }
    void gerakkan1() {
        if (Vector3.Distance(this.transform.position, tujuan1.transform.position) > 0.1f) {
            Vector3 pos = this.transform.position;
            pos.z += kecepatan * Time.deltaTime;
            this.transform.position = pos;  
        }
    }
    void gerakkan2() {
        this.transform.position = Vector3.Lerp(this.transform.position,
        tujuan1.transform.position, 1f * Time.deltaTime);
    }
    void gerakkan3() {
        this.transform.position = Vector3.MoveTowards(this.transform.position,tujuan1.transform.position, 1f * Time.deltaTime);
    }


}
