using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tes : MonoBehaviour
{	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Moves this GameObject 2 units a second in the forward direction
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
				
		}
		
    }

    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "object"){
			
		}
    }
}
