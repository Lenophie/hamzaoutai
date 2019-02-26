using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField] private GameObject _player;
	[SerializeField] private float _speed;
	private Rigidbody _playerRigidbody;

	void Start()
	{
		_playerRigidbody = _player.GetComponent<Rigidbody>();
	}
	
	void FixedUpdate()
	{
		Vector2 inputVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		_playerRigidbody.MovePosition(new Vector3(
			_playerRigidbody.position.x + inputVector.x * _speed,
			_playerRigidbody.position.y,
			_playerRigidbody.position.z + inputVector.y * _speed
		));
	}
}
