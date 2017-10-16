using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ExpView : MonoBehaviour {
	public Text expText;
	public string EXPtext{
		get{ return expText.text;}
		set{ expText.text = value.ToString();}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
