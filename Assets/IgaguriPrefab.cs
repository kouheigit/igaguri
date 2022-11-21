using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriPrefab : MonoBehaviour
{
    public GameObject igaguriPrefab;

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            GameObject igaguri = Instantiate(igaguriPrefab);
            igaguri.GetComponent<IgaguriController>().Shoot(new Vector3(0, 200, 2000));
        }
        
    }
}
