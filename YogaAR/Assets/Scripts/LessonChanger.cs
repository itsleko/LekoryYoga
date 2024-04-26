using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LessonChanger : MonoBehaviour
{
    [SerializeField] private List<GameObject> BGs;
    private int LessonIndex;

    public void EndLesson()
    {
        LessonIndex++;

        if (LessonIndex >= BGs.Count)
        {
            SceneManager.LoadScene(0);
        }

        ChooseBG(LessonIndex);
    }

    private void ChooseBG(int bgIndex)
    {
        foreach (GameObject bg in BGs) { bg.SetActive(false); }

        BGs[bgIndex].SetActive(true);
    }
}
