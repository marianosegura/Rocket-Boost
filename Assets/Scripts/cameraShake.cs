﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShake : MonoBehaviour{

    public IEnumerator Shake(float duration, float magnitude) {
        Vector3 originalPos = transform.localPosition;

        float elapsed = 0.0f;

        while(elapsed < duration){
            float x = Random.Range(1f, 1f) * magnitude;
            float y = Random.Range(1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, originalPos.z);

            elapsed += Time.deltaTime;
            yield return null;//wait until next frame is drawn
        }

        transform.localPosition = originalPos;
    }
}
