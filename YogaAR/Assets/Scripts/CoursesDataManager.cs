using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Course
{
    public string Name;
}

public class CoursesDataManager : MonoBehaviour
{
    [SerializeField] private List<Course> AllCourses;

    [SerializeField] private Transform CoursesButtonsSpawnPos;
    [SerializeField] private GameObject CourseButtonPref;

    private void Awake()
    {
        for (int i = 0; i < AllCourses.Count; i++)
        {
            GameObject newButton = Instantiate(CourseButtonPref, CoursesButtonsSpawnPos);
            newButton.GetComponent<CourseButtonData>().myCourse = AllCourses[i];
        }
    }
}
