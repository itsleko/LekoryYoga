using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CourseButtonData : MonoBehaviour
{
    [HideInInspector] public Course myCourse;
    [SerializeField] private TextMeshProUGUI myText;

    private void Start()
    {
        myText.text = myCourse.Name;
    }

    public void ChooseCouse()
    {
        SceneManager.LoadScene(myCourse.Name);
    }
}
