using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

    private GameObject cameraObject;
    private InputManager inputManager;
    public float upDownRange = 60.0f;
    float verticalRotation = 0;

    [SerializeField]
    private float cameraSensitivity = 5;

    /*
     * Initialize the required components components
     */
    void Start(){
        cameraObject = Camera.main.gameObject;
        //check if the inputmanager is present. If it's not, add it.
        if(!(inputManager = this.GetComponent<InputManager>())){
            inputManager = this.gameObject.AddComponent<InputManager>();
        }
    }

	void Update () {
        //rotate the entire gameobject
        this.transform.Rotate(0, inputManager.GetXRot()* cameraSensitivity, 0);
        //rotate the camera only. 
		cameraObject.transform.Rotate(inputManager.GetYRot() * cameraSensitivity, 0, 0);
	}
}
