using UnityEngine;
using System.Collections;

public class AppManage : MonoBehaviour {

	public GameObject ball;

	// Use this for initialization
	void Start () {

		makeBall ();
	
	}

	void makeBall(){

		// make rand pos
		float range = 5f;
		Vector3 pos = new Vector3 (Random.Range (-0.5f, 0.5f) * range, Random.Range (-0.5f, 0.5f) * range, Random.Range (-0.5f, 0.5f) * 10);
		GameObject b = (GameObject)Instantiate(ball,
		            pos,
		            Quaternion.identity);

		// make rand color
		b.GetComponent<Renderer>().material.color = new Color32( (byte)Random.Range(0,255), (byte)Random.Range(0, 255), (byte)Random.Range(0, 255), 1);
	}

	// Update is called once per frame
	void Update () {

		if (Time.frameCount % 5 == 0){
			makeBall ();
		}

	}
	
}
