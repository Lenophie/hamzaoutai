using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class BunnyController : MonoBehaviour
{

	private Animator _animator;
	private Rigidbody _rigidbody;
	private Boolean _isMoving;
	[SerializeField] private float _waitTime;
	[SerializeField] private float _speed;
	private float _timer;
	private Vector3 _hopDirection;
	
	void Start()
	{
		_animator = GetComponent<Animator>();
		_rigidbody = GetComponent<Rigidbody>();
		_timer = 0f;
		_hopDirection = GenerateHopDirection();
	}
	
	void Update()
	{
		if (_timer >= _waitTime) {
			_timer -= _waitTime;
			_hopDirection = GenerateHopDirection();
		}
		_rigidbody.MovePosition(_rigidbody.position + _hopDirection * _speed);
		_timer += Time.deltaTime;
	}

	private Vector3 GenerateHopDirection()
	{
		Vector3 hopDirection = Random.onUnitSphere;
		hopDirection.y = 0f;
		return hopDirection;
	}
}
