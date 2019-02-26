using UnityEngine;

public class LightingController : MonoBehaviour
{

	[SerializeField] private float _speed;
	
	void Update()
	{
		transform.Rotate(new Vector3(_speed, _speed * 1.3f, 0f));
	}
}
