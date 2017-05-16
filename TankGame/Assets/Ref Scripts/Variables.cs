using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {

	//These numbers are flaoting point numbers
	public float firstFloat;
	public float secondFloat = 2f;
	public float thirdFloat = 5.3f;
	private float fourthFloat = 364f;

	//whole numbers
	public int firstInt;
	public int secondInt = 3;

	//These numbers are floating point numbers
	public float myFirstFloat;
	public float mySecondFloat = 2f;
	public float myThirdFloat = 5.3f;
	private float myfourthFloat = 364f;

	//whole numbers
	public int myFirstInt;
	public int mySecondInt = -3;

	//String
	public string myString;
	public string mySecondString = "Hello";

	//Other Variable Types
	public Color myColor;
	public bool myBool;
	public char myChar;
	public Vector2 myVector2;
	public Vector3 myVector3;
	public Vector4 myVector4;
	public List<float> myFloatList;
	public List<int> myIntList;

	[HideInInspector]
	public List <Color> myColorlist;

	public List<Vector3> myVectorList;

	}
