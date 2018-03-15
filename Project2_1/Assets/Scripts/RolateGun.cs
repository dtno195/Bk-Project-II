using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RolateGun : MonoBehaviour
{

    // Use this for initialization
    public Vector3 target;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    void LookAtCursor()
    {	
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);// tao tia di vuong goc voi man hinh
		RaycastHit hit;
		if(Physics.Raycast(ray,out hit)){
			target = hit.point;//toa do cham lay ra target de nhin  theo
		}
        transform.LookAt(target);
    }
}
