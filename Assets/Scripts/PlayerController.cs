using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField] private GameObject _player;
	[SerializeField] private float _speed;
	
	void Update()
	{
		Vector2 inputVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		_player.transform.position = new Vector3(_player.transform.position.x + inputVector.x * _speed,
			_player.transform.position.y,
			_player.transform.position.z + inputVector.y * _speed
			);
	}
}
