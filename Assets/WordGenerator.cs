using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = {"trucks","bore","spy","breathe","lackadaisical","songs","fail", "trains", 
                                        "dust","eggnog","coach","statement","industry","eye","rightful","memorize",
                                        "mouth","boot","knowing","capable","domineering","oven","grease","homeless",
                                        "powerful","rely","decay","scare","circle","puny","soggy","versed","wasteful",
                                        "irritate","milky","bury","belligerent","challenge","sudden","protest","clear",
                                        "teeth","basketball","rainstorm","adjustment","chemical","stem","blink","gigantic",
                                        "trace","pumped","depressed","vagabond","behave","physical","befitting","glove",
                                        "various","grape","produce","squash","teaching","nervous","flow","comb","adhesive",
                                        "cold","guitar","normal","fasten","bone","well-off","copy","market","heal","payment",
                                        "obtainable","mother","history","hour","statuesque","hollow","unwieldy","flashy",
                                        "fancy","knee","pushy","check","sedate","dazzling","wealthy","edge","equable","fix",
                                        "support","letter","imported","tail","momentous","handsome"};
    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
