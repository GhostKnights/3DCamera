using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector3 offset;
    public GameObject person;

    void Start()
    {
       
        person = GameObject.Find("blueobj");

        offset = person.transform.position - this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*this.transform.position = person.transform.position - offset;
        Quaternion angel = Quaternion.LookRotation(person.transform.position - this.transform.position);
        this.transform.rotation = angel;*/
        this.transform.LookAt(person.transform.position);
    }
}
