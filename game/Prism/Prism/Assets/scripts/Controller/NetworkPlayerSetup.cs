using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NetworkPlayerSetup : NetworkBehaviour {

	public Behaviour[] componentsToEnable;
	public Camera playerCamera;
	
	
	public override void OnStartLocalPlayer ()
	{
		
		//Enable Components
		foreach(Behaviour component in componentsToEnable)
		{
			component.enabled = true;
		}
		
		//Enable Camera
		playerCamera.enabled = true;
		playerCamera.GetComponent<AudioListener>().enabled = true;
		
		//Enable CharacterController
		this.GetComponent<CharacterController>().enabled = true;
	
	}
		
}
