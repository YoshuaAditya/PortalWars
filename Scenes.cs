using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;


public static class Scenes {

	private static Dictionary<string, string> parameters;

	public static void Load(string sceneName, Dictionary<string, string> parameters = null) {
		Scenes.parameters = parameters;
		SceneManager.LoadScene(sceneName);
	}

	public static void Load(string sceneName, string paramKey, string paramValue) {
		Scenes.parameters = new Dictionary<string, string>();
		Scenes.parameters.Add(paramKey, paramValue);
		SceneManager.LoadScene(sceneName);
	}

	public static Dictionary<string, string> getSceneParameters() {
		return parameters;
	}

	public static string getParam(string paramKey) {
		if (parameters == null) return "";
		return parameters[paramKey];
	}

	public static void editParam(string paramKey, string paramValue) {
		if (parameters != null) {
			if (Scenes.parameters.ContainsKey (paramKey)) {
				Scenes.parameters[paramKey] = paramValue;
			}
		}
	}

	public static void setParam(string paramKey, string paramValue) {
		if (parameters == null)
			Scenes.parameters = new Dictionary<string, string>();
		Scenes.parameters.Add(paramKey, paramValue);
	}

}