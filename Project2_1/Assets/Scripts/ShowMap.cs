using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMap : MonoBehaviour
{
    public GameObject map;
    bool setActive = false;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
		Debug.Log(setActive);
        if (map != null)
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                map.SetActive(true);
            }
			if (Input.GetKeyDown(KeyCode.N))
			{
				map.SetActive(false);
			}
        }
    }
}
