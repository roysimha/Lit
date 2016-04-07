using UnityEngine;
using System.Collections;

public class mirrorController : MonoBehaviour {
	private float rotation;
	public float maxangle;
    private float minangle;
	private float mousey;
    private LightBeamController lbc;
	// Use this for initialization
	void Start () {
        minangle = transform.eulerAngles.z - maxangle;
		maxangle = maxangle + transform.eulerAngles.z;
        rotation = transform.eulerAngles.z;
        lbc = GameObject.FindGameObjectWithTag("Player").GetComponent<LightBeamController>();

        //turnOffHit ();
    }

    // Update is called once per frame
    void Update () {
		
	}
	void OnMouseDown(){
		mousey = Input.mousePosition.y;
	}
	void OnMouseDrag(){

            lbc.DrawLight();
		float deltay = Input.mousePosition.y - mousey;
        rotation += deltay*0.1f;
        rotation = Mathf.Clamp(rotation, minangle, maxangle);
		mousey = Input.mousePosition.y;
        transform.eulerAngles = new Vector3(0, 0, rotation) ;
	}

	public void turnOnHit(){
		transform.GetChild (1).gameObject.SetActive (true);
	}
	public void turnOffHit(){
		
		transform.GetChild (1).gameObject.SetActive (false);
	}

}
