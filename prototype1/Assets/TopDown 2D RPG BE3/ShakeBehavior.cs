using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeBehavior : MonoBehaviour
{
    // public static ShakeBehavior instance;
    // private float shakeTimeRemaining, shakePower, shakeFadeTime;
    // private float shakeRotation;
    // public float rotationMultiplier = 15f;
    // // Start is called before the first frame update
    // void Start()
    // {
    //     instance = this;
    // }

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
    //
    // // Update is called once per frame
    // void Update()
    // {
    //     if(Input.GetButtonDown("Fire1")){
    //         StartShake(.20f,.20f);
    //     }
    // }
    //
    // private void LateUpdate(){
    //     if ( shakeTimeRemaining > 0 ){
    //         shakeTimeRemaining -= Time.deltaTime;
    //
    //         float xAmount = Random.Range(-.20f,.20f)*shakePower;
    //         float yAmount = Random.Range(-.20f,.20f)*shakePower;
    //
    //         transform.position += new Vector3(xAmount,yAmount,0f);
    //         shakePower = Mathf.MoveTowards(shakePower,0f,shakeFadeTime * Time.deltaTime);
    //
    //         shakeRotation = Mathf.MoveTowards(shakeRotation, 0f, shakeFadeTime*rotationMultiplier);
    //     }
    //     transform.rotation = Quaternion.Euler(0f,0f,shakeRotation* Random.Range(-.1f,.1f));
    // }
    //
    // public void StartShake(float length, float power){
    //     shakeTimeRemaining = length;
    //     shakePower = power;
    //     shakeFadeTime = power/length;
    //
    //     shakeRotation = power * rotationMultiplier;
    // }
}
