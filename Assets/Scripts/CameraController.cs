using UnityEngine;

public class CameraController : MonoBehaviour {

	[SerializeField] private float _sensibility;
	private float _yawn = 0.0f;
	private float _pitch = 0.0f;
	
	void Update()
	{
		_yawn += Input.GetAxis("Mouse X") * _sensibility;
		_pitch -= Input.GetAxis("Mouse Y") * _sensibility;
		transform.eulerAngles = new Vector3(_pitch, _yawn, 0f);
	}
}
