using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Use this for initialization


    public GameObject smoke;
    public GameObject gunHead;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Fire();
        }
    }

    void Fire()
    {


        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);// tao tia di vuong goc voi man hinh
#if UNITY_IOS || UNITY_ANDROID
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                InSmoke();
                if (hit.transform.tag.Equals("Target"))
                {
                    Destroy(hit.transform.gameObject);
                }
            }
#else
        RaycastHit hit;
        if (Physics.Raycast(gunHead.transform.position, gunHead.transform.forward, out hit))
        {
            InSmoke();
            if (hit.transform.tag.Equals("Target"))
            {
                Destroy(hit.transform.gameObject);
            }
        }
#endif


    }
    void InSmoke()
    {
        GameObject sm = Instantiate(smoke, gunHead.transform.position, gunHead.transform.rotation) as GameObject;
        Destroy(sm, 0.5f);
    }
}
