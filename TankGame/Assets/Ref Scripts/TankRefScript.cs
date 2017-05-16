using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankRefScript : MonoBehaviour {

	public float movementSpeed = 0.1f;
	public float rotateSpeed = 1;
	public float turretRotateSpeed = 2;
	public float bulletSpeed = 20;
	public GameObject turret;


	public GameObject bulletPrefab;
	public Transform bulletSpawnPoint;

	public KeyCode forwardsKey = KeyCode.W;
	public KeyCode backwardsKey = KeyCode.S;
	public KeyCode rotateLeftkey = KeyCode.A;
	public KeyCode rotateRightKey = KeyCode.D;
	public KeyCode rotateTurretleftKey = KeyCode.Q;
	public KeyCode rotateTurretRightKey = KeyCode.E;
	public KeyCode fireKey = KeyCode.Space;



	// Update is called once per frame

	void Update () {

		if (Input.GetKey (rotateTurretRightKey)) {
			turret.transform.Rotate (Vector3.up *
				turretRotateSpeed);
		}

		if (Input.GetKey (rotateTurretleftKey)) {
			turret.transform.Rotate (Vector3.up *
				-turretRotateSpeed);

		}

		if (Input.GetKey (forwardsKey)) {
			transform.position += transform.forward *
				movementSpeed;

		}

		if (Input.GetKey (backwardsKey)) {
			transform.position += transform.forward *
				-movementSpeed;
		}

		if (Input.GetKey (rotateRightKey)) {
			transform.Rotate (Vector3.up * rotateSpeed);

		}

		if (Input.GetKey (rotateLeftkey)) {
			transform.Rotate (Vector3.up * -rotateSpeed);

		}

		if (Input.GetKeyDown (fireKey)) {
			GameObject GO = Instantiate (bulletPrefab,
				bulletSpawnPoint.position, Quaternion.identity) as GameObject;
			GO.GetComponent<Rigidbody> ().AddForce
			(turret.transform.forward * bulletSpeed, ForceMode.Impulse);

		}
	}
}
