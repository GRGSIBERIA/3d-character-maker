using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace CMaker
{
	/// <summary>
	/// 選択中のオブジェクトを管理するためのクラス
	/// </summary>
	public class ObjectSelector
	{
		/// <summary>
		/// 選択中のオブジェクト，未選択の場合はnull
		/// </summary>
		public GameObject SelectedObject { get; private set; }

		/// <summary>
		/// あるオブジェクトを選択状態にする
		/// </summary>
		/// <param name="target">選択状態にしたいオブジェクト</param>
		public void SelectObject(GameObject target)
		{
			SelectedObject = target;
		}

		/// <summary>
		/// 未選択状態にする
		/// </summary>
		public void UnSelectObject()
		{
			SelectedObject = null;
		}
	}
}