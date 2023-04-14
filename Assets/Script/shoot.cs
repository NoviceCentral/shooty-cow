using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject prefab;
    public Transform SHOTTY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
                Debug.Log("works");
                 Instantiate(prefab,SHOTTY.position, prefab.transform.rotation);
            }
    }
}
