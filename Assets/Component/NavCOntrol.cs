using UnityEngine;
using System.Collections;

public class NavCOntrol : MonoBehaviour {

	public NavMeshAgent navMesh;
	public Transform AimObj;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		navMesh.SetDestination (AimObj.position);
	}
}
