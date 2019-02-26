using UnityEngine;

public class CameraController : MonoBehaviour {

	[SerializeField] private float _sensibility;
	private float _yawn = 0.0f;
	private float _pitch = 0.0f;
	
	void Update()
	{
		_yawn += Input.GetAxis("Mouse X") * _sensibility;
		_pitch -= Input.GetAxis("Mouse Y") * _sensibility;
		if (_pitch < -90f) _pitch = -90f;
		else if (_pitch > 90f) _pitch = 90f;
		transform.eulerAngles = new Vector3(_pitch, _yawn, 0f);
	}
}
