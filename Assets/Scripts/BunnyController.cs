using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class BunnyController : MonoBehaviour
{
	private Animator _animator;
	private Rigidbody _rigidbody;
	private Boolean _isMoving;
	[SerializeField] private float _minHopTime;
	[SerializeField] private float _maxHopTime;
	private float _hopTime;
	[SerializeField] private float _speed;
	private float _timer;
	private Vector3 _hopDirection;
	
	void Start()
	{
		_animator = GetComponent<Animator>();
		_rigidbody = GetComponent<Rigidbody>();

		_animator.Play(0, -1, Random.value);
		
		_hopTime = Random.Range(_minHopTime, _maxHopTime);
		_timer = 0f;
		_hopDirection = GenerateHopDirection();
	}
	
	void Update()
	{
		if (_timer >= _hopTime) {
			_timer -= _hopTime;
			_hopTime = Random.Range(_minHopTime, _maxHopTime);
			_hopDirection = GenerateHopDirection();
		}
		_rigidbody.MovePosition(_rigidbody.position + _hopDirection * _speed);
		transform.rotation = Quaternion.Slerp(
			transform.rotation,
			Quaternion.LookRotation(_hopDirection),
			0.15f);
		_timer += Time.deltaTime;
	}

	private Vector3 GenerateHopDirection()
	{
		Vector3 hopDirection = Random.onUnitSphere;
		hopDirection.y = 0f;
		return hopDirection;
	}
}
