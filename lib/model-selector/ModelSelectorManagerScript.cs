using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace CMaker
{
	public class ObjectSelector
	{
		public GameObject SelectedObject { get; private set; }

		public void SetSelectedObject(GameObject target)
		{
			SelectedObject = target;
		}

		public void UnsetSelectedObject()
		{
			SelectedObject = null;
		}
	}
}