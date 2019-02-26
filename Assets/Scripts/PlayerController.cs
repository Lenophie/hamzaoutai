using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField] private GameObject _player;
	[SerializeField] private float _speed;
	[SerializeField] private Camera _camera;
	private Rigidbody _playerRigidbody;

	void Start()
	{
		_playerRigidbody = _player.GetComponent<Rigidbody>();
	}
	
	void FixedUpdate()
	{
		Vector3 diffVector = Input.GetAxis("Vertical") * _camera.transform.forward + Input.GetAxis("Horizontal") * _camera.transform.right;
		diffVector.y = 0f;
		_playerRigidbody.MovePosition(_playerRigidbody.position + diffVector * _speed);
	}
}
