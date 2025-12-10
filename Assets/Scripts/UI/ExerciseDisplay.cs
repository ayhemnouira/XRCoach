using UnityEngine;
using TMPro;

public class ExerciseDisplay : MonoBehaviour
{
    public TMP_Text exerciseText;
    
    void Start()
    {
           // Démarrer une session quand on entre dans ExerciseScene
    //DataManager.Instance.StartSession();
        // Récupérer l'exercice choisi
        int exerciseType = PlayerPrefs.GetInt("SelectedExercise", 0);
        
        string exerciseName = "";
        switch(exerciseType)
        {
            case 0: exerciseName = "SQUATS"; break;
            case 1: exerciseName = "FENTES"; break;
            case 2: exerciseName = "POMPES"; break;
        }
        
        exerciseText.text = "Exercice : " + exerciseName;
        Debug.Log("📋 Exercice sélectionné : " + exerciseName);
    }
}