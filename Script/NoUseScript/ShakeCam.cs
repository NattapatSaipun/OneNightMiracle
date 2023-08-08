using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCam : MonoBehaviour
{
    private void Update()
    {
       
            StartCoroutine(Shake(.15f, .4f));
        
    }
    public IEnumerator Shake (float duration, float mangitude)
    {
        Vector3 originalPos = transform.position;
        float elapsed = 0.0f;
        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f)*mangitude;
            float y = Random.Range(-1f, 1f) * mangitude;

            transform.localPosition = new Vector3(x, y, originalPos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = originalPos;
    }
}
