using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyController : MonoBehaviour
{


	public float lookRadius = 10f;
	Transform target;
	NavMeshAgent agent;



	// Start is called before the first frame update
	void Start()
	{
		target = PlayerManager.instance.player.transform;
		agent = GetComponent<NavMeshAgent>();


	}

	// Update is called once per frame
	void Update()
	{
		float distance = vector3.Distance(target.position, transform.position);

		if (distance <= lookRadius)
		{
			agent.SetDestination(target.position);
		}
	}
	void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.postiton, lookRadius);
	}
}



