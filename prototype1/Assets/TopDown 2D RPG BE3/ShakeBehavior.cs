using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeBehavior : MonoBehaviour
//Inspired by Brackey's
{
    public IEnumerator Shake (float duration, float magnitude) {
       Vector3 originalPos = transform.localPosition;
       float elapsed = 0.0f;
       while(elapsed < duration) {
           float xAmount = Random.Range(-.25f,.25f)*magnitude;
           float yAmount = Random.Range(-.25f,.25f)*magnitude;

           transform.localPosition = new Vector3(xAmount,yAmount, originalPos.z);
           elapsed += Time.deltaTime;
           yield return null;
       }
       transform.localPosition = originalPos;
    }
}
