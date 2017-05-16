using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour {

	// **Amend to APC parts as needed
	// Public Floats - Char Move / Aiming
	public float movementSpeed = 0.2f;
	public float rotateSpeed = 2;
	public float turretRotateSpeed = 2;
	public float bulletSpeed = 20;
	public GameObject turret;

	// Amend to local controls for Xbone Controller
	public GameObject bulletPrefab;
	public Transform bulletSpawnPoint;
	public KeyCode forwardsKey = KeyCode.W;
	public KeyCode backwardsKey = KeyCode.S;
	public KeyCode rotateLeftKey = KeyCode.A;
	public KeyCode rotateRightKey = KeyCode.D;
	public KeyCode rotateTurretLeftKey = KeyCode.LeftArrow;
	public KeyCode rotateTurretRightKey = KeyCode.RightArrow;
	public KeyCode fireKey = KeyCode.Space;





	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (rotateTurretLeftKey)) {
			turret.transform.Rotate (Vector3.up * -turretRotateSpeed);

		}

		if (Input.GetKey (rotateTurretRightKey)) {
			turret.transform.Rotate (Vector3.up * turretRotateSpeed);

		}

		if (Input.GetKey (forwardsKey)) {
			transform.position += transform.forward * movementSpeed;

		}

		if (Input.GetKey (backwardsKey)) {
			transform.position += transform.forward * -movementSpeed;

		}

		if (Input.GetKey (rotateLeftKey)) {
			transform.Rotate (Vector3.up * -rotateSpeed);

		}

		if (Input.GetKey (rotateRightKey)) {
			transform.Rotate (Vector3.up * rotateSpeed);

		}
			
		if (Input.GetKey (fireKey)) {
			GameObject GO = Instantiate (bulletPrefab,
			bulletSpawnPoint.position, Quaternion.identity) as GameObject;
			GO.GetComponent<Rigidbody> ().AddForce
			(turret.transform.forward * bulletSpeed, ForceMode.Impulse);

		}
			
			


		
	}
}

