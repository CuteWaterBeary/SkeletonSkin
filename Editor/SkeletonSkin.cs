using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEditor;

namespace CWB {
	public class SkeletonSkin : EditorWindow{

		private GameObject obj;
		private GameObject bone;
		private readonly GUILayoutOption[] option = new []{GUILayout.Width (256), GUILayout.Height (16)};

		[MenuItem("Mesh+Bones/Armature/SkeletonSkin Placeholder (its a component)")]
		private static void Create(){
			GetWindow<SkeletonSkin>("SkeletonSkin");
		}

		private void OnGUI(){




		}
	}
}
