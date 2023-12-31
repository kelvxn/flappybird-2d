﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCoroutine {

	public static IEnumerator WaitforRealSeconds(float time) {
		float start = Time.realtimeSinceStartup;

		while (Time.realtimeSinceStartup < (start + time)) {
			yield return null;
		}
	}
}
