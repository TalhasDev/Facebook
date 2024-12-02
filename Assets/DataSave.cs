using UnityEngine;
using Firebase.Database;
using System.Collections;
using System;

public class DataSave : MonoBehaviour
{
    //public DatabaseReference reference;

    //public InputField username;
    //public InputField userage;

    //public TextMeshProUGUI scoreTxt;
    //public int score;

    //public person personData;

    //private void Start()
    //{
    //    reference = FirebaseDatabase.DefaultInstance.RootReference;

    //    LoadData();
    //}

    //public void SaveData()
    //{
    //    User user = new User();
    //    user.name = username.text;
    //    user.Age = userage.text;
    //    user.score = score;
    //    string json = JsonUtility.ToJson(user);

    //    reference.Child("User").Child(user.name).SetRawJsonValueAsync(json).ContinueWith(task =>
    //    {
    //        if (task.IsCompleted)
    //        {
    //            Debug.Log("Complete");
    //        }
    //        else
    //        {
    //            Debug.Log("not Complete");
    //        }
    //    });
    //}

    //public void addScore()
    //{
    //    score++;
    //    scoreTxt.text = score.ToString();
    //}

    //public void LoadData()
    //{
    //    StartCoroutine(DataDisply());
    //}

    //IEnumerator DataDisply()
    //{
    //    User user = new User();
    //    var referenceData = reference.Child("User").Child(username.text).GetValueAsync();
    //    yield return new WaitUntil(predicate: () => referenceData.IsCompleted);

    //    Debug.Log("loadData");

    //    DataSnapshot data = referenceData.Result;

    //    string json = data.GetRawJsonValue();

    //    if(json != null)
    //    {
    //        personData = JsonUtility.FromJson<person>(json);
    //        Debug.Log(personData.score);
    //    }

    //}

    //public class User
    //{
    //    public string name;
    //    public string Age;
    //    public int score;
    //}

    //[Serializable]
    //public class  person
    //{
    //    public string name;
    //    public string Age;
    //    public int score;
    //}
}
