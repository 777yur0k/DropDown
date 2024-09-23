using UnityEngine;

public class OptionsController : MonoBehaviour
{
    public DropDownScript ChangeLanguageDrop;
    string[] LanguagesManifest = new[] { "Russian", "English", "French", "Spanish", "Chinese" };
    string CurrentLanguage = "Russian";

    void OnEnable() => ChangeLanguageDrop.Initialize(LanguagesManifest, CurrentLanguage, SetLanguage);

    void SetLanguage(string NewLanguage) => CurrentLanguage = NewLanguage;
}