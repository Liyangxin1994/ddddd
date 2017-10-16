using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
public class View : MonoBehaviour {
	public Text hpLabel;
	public Button addButton;

	public string Text1
	{
		get{ return hpLabel.text;}
		set{ hpLabel.text = value;}
	}
	public event EventHandler Onclick;
	public void btnClicked()
	{
		if (Onclick != null) {
			Onclick (this, new EventArgs ());
		}
	}
}
