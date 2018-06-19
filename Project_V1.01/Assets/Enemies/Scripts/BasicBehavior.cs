using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicBehavior : MonoBehaviour {

    Transform target; // use this variable as the player model
    NavMeshAgent agent;
    public float aggro_range = 10f;



	// Use this for initialization
	void Start () {
        target = playerManager.instance.Player.transform;
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        float distance = Vector3.Distance(target.position, transform.position);

        if(distance <= aggro_range)
        {
            agent.SetDestination(target.position);
        }
	}

 
    // This is where the range is made, it will be a red circle.
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, aggro_range);
    }
}
