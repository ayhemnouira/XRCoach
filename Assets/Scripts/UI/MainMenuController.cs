using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Appelé quand on clique sur un bouton
    public void StartSquat()
    {
        Debug.Log("🏋️ Lancement Squats");
        PlayerPrefs.SetInt("SelectedExercise", 0); // 0 = Squat
        SceneManager.LoadScene("ExerciseScene");
    }
    
    public void StartLunge()
    {
        Debug.Log("🏃 Lancement Fentes");
        PlayerPrefs.SetInt("SelectedExercise", 1); // 1 = Lunge
        SceneManager.LoadScene("ExerciseScene");
    }
    
    public void StartPushup()
    {
        Debug.Log("💪 Lancement Pompes");
        PlayerPrefs.SetInt("SelectedExercise", 2); // 2 = Pushup
        SceneManager.LoadScene("ExerciseScene");
    }
    public void OpenHistory()
{
    SceneManager.LoadScene("HistoryScene");
}
}