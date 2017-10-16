using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
/// <summary>
/// this is model
/// </summary>
public class Model {
	private string name;
	private int hp;
	public event EventHandler HPADD;
	public int HP
	{
		get{ return hp;}
		set{ 
			hp += value;
			if (HPADD!=null) {
				HPADD (this, new EventArgs ());
			}
		}
	}


}
