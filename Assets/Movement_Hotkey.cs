// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// public class Box_input : MonoBehaviour {
// float speed = 3;
// // Use this for initialization
// void Start () {
    
// }
// // Update is called once per frame
// void Update () {
//     float v = Input.GetAxis ("Vertical");
//     float h = Input.GetAxis ("Horizontal");
//     this.transform.Translate (new Vector3(h,0,v) * Time.deltaTime * speed);
// }
// }

using UnityEngine;
using System.Collections;
public class sc_input2 : MonoBehaviour {
float speed = 2f;
// Use this for initialization
void Start () {
}
// Update is called once per frame
void Update () {
if (Input.GetKey (KeyCode.LeftArrow)) {
this.transform.Translate (new Vector3 (-1, 0, 0) * Time.deltaTime * speed);
} else if (Input.GetKey (KeyCode.RightArrow)) {
this.transform.Translate (new Vector3 (1, 0, 0) * Time.deltaTime * speed);
}
if (Input.GetKey (KeyCode.UpArrow)) {
this.transform.Translate (new Vector3 (0, 0, 1) * Time.deltaTime * speed);
} else if (Input.GetKey (KeyCode.DownArrow)) {
this.transform.Translate (new Vector3 (0, 0, -1) * Time.deltaTime * speed);
}
}
}