using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformOptimizationScript : MonoBehaviour
{
	//	public Transform _transform;
	//	public Renderer _rend;
	//
	//	void Start ()
	//	{
	//		//Caching
	//		this._transform = this.GetComponent<Transform> ();
	//		this._rend = this.GetComponent<Renderer> ();
	//	}
	//
	//
	//	void Update ()
	//	{
	//		if (posX != 1f) { //Call function when necessary only.
	//
	//			RandomFunction ();
	//		}
	//
	//		List<GameObject> items = new List<GameObject> ();
	//		items.Clear ();
	//
	//		Debug.Log (string.Format ("What is this? Optimizing heap. {0}", gameObject.name)); //Boxing, don't do this.
	//	}
	//
	//	IEnumerator Sequence ()
	//	{
	//	float delay = 1f;
	//
	//	yield return delay;
	//	yield return new WaitForSeconds(1) //Don't do this!
	//	}
}
