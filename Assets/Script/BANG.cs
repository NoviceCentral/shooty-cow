using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BANG : MonoBehaviour
{
   public Rigidbody theRb;
    public Transform Movein;


    // Start is called before the first frame update
    void Start()
    {
        Movein = GetComponent<Transform>();
         StartCoroutine(waiter());
        

    }

    // Update is called once per frame
    void Update()
    {
         transform.position = transform.position + new Vector3(-1,0,0);

    }

    IEnumerator waiter()
    {
   
        yield return new WaitForSecondsRealtime(5);
        Debug.Log("TIMER FUNC");
        Object.Destroy(this.gameObject);
    }
}
