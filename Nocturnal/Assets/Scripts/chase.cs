using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour {
//set the values in the inspector
	public Transform target; //drag and stop player object in the inspector
	public float speed;
  
	public void Update(){
     		//get the distance between the player and enemy (this object)
    		float dist = Vector3.Distance(target.position, transform.position);
    		//check if it is within the range you set
    		if(UI.go == true){
      			transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);      
    		}
    		//else, if it is not in rage, it will not follow player
	}
}
