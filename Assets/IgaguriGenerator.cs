using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriGenerator : MonoBehaviour
{
    public GameObject igaguriPrefab;
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject igaguri = Instantiate(igaguriPrefab);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            igaguri.GetComponent<IgaguriController>().Shoot(worldDir.normalized * 2000);
           // igaguri.GetComponent<IgaguriController>().Shoot(new Vector3(0, 200, 2000));
        }
        
    }
}
