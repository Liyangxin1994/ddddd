using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
public class Controller  {
	View currentView;
	Model currentModel;
//	ExpView currentExpView;
	public Controller()
	{
		currentView = GameObject.Find ("MainGUI").GetComponent<View>();
//		currentExpView = GameObject.Find ("Panel").GetComponent<ExpView>();
		currentModel = new Model ();
		currentModel.HPADD += updateLabel;
//		currentModel.HPADD += updateLabel;

		currentModel.HPADD += (s, a) => Debug.Log ("cccc");
		currentView.Onclick += (s,a) => {
			currentModel.HP = 50;
		};
		updateLabel (null, null);
	}



	void updateLabel(object sender,EventArgs arg)
	{
		currentView.Text1 = System.Convert.ToString (currentModel.HP);
//		currentExpView.EXPtext = System.Convert.ToString (currentModel.HP);
	}

}

