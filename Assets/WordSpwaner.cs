using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpwaner : MonoBehaviour
{
    public GameObject wordPrefab;
    public Transform wordCanvas;

    public bool spwanBool = false;
    float theta;
    float x;
    float y;

    public WordDisplay SpwanWord()
    {
        x = UnityEngine.Random.Range(-10f, 10f);
        y = UnityEngine.Random.Range(-3f, 3f);
        Vector3 randomPosition = new Vector3(x, y);

        GameObject wordObj = Instantiate(wordPrefab, randomPosition, Quaternion.identity, wordCanvas);
        WordDisplay wordDisplay= wordObj.GetComponent<WordDisplay>();


        return wordDisplay;
    }

}
