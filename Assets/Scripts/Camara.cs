using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {

    
  public GameObject player;
    private Vector3 offset;
    private Camera cam;
    public float field ;
    public float max;
    public float min;
  
    // Use this for initialization
    void Start () {
        cam = GetComponent<Camera>();
        offset = transform.position - player.transform.position;

    }
	
	// Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;

        if (Input.GetKeyDown("m"))
        {
            cam.fieldOfView = field;
            field = 45f;
        }

    }

}
