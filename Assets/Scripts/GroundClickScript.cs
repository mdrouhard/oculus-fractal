using UnityEngine;
using System.Collections;

public class GroundClickScript : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		GameObject road = new GameObject ("road", typeof(MeshFilter), typeof(MeshRenderer));
		MeshFilter meshFilter = road.GetComponent<MeshFilter>();
		MeshRenderer meshRenderer = road.GetComponent<MeshRenderer> ();

		Mesh mesh = new Mesh ();

		meshFilter.mesh = mesh;
	}
}
