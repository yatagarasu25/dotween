﻿using UnityEngine;
using System.Collections;
using DG.Tweening;
using TMPro;

public class ExternalPlugins_TextMeshPro : BrainBase
{
	public TextMeshPro[] texts;
	public TextMeshProUGUI[] uguiTexts;

	[TextArea(5, 10)]
	public string replaceWText = "This <#00ff00>rich <b>bold</b>+<i>italic</i> text</color> is <#ff0000>gonna appear</color> with a tween, <#f38013>yabadabadoo!</color>";
	bool richTextEnabled = true;
	string[] orTexts;
	string[] orGuiTexts;

	void Start()
	{
		DOTween.Init();

		orTexts = new string[texts.Length];
		for (int i = 0; i < texts.Length; ++i) orTexts[i] = texts[i].text;
		orGuiTexts = new string[uguiTexts.Length];
		for (int i = 0; i < uguiTexts.Length; ++i) orGuiTexts[i] = uguiTexts[i].text;
 	}

	void OnGUI()
	{
		if (GUILayout.Button("Rich Text Support: " + (richTextEnabled ? "ON" : "OFF"))) richTextEnabled = !richTextEnabled;

		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Color To Green")) {
			foreach (TextMeshPro t in texts) t.DOColor(Color.green, 1).SetEase(Ease.Linear);
			foreach (TextMeshProUGUI t in uguiTexts) t.DOColor(Color.green, 1).SetEase(Ease.Linear);
		}
		if (GUILayout.Button("Color To Red")) {
			foreach (TextMeshPro t in texts) t.DOColor(Color.red, 1).SetEase(Ease.Linear);
			foreach (TextMeshProUGUI t in uguiTexts) t.DOColor(Color.red, 1).SetEase(Ease.Linear);
		}
		if (GUILayout.Button("Fade Out")) {
			foreach (TextMeshPro t in texts) t.DOFade(0, 1).SetEase(Ease.Linear);
			foreach (TextMeshProUGUI t in uguiTexts) t.DOFade(0, 1).SetEase(Ease.Linear);
		}
		if (GUILayout.Button("Fade In")) {
			foreach (TextMeshPro t in texts) t.DOFade(1, 1).SetEase(Ease.Linear);
			foreach (TextMeshProUGUI t in uguiTexts) t.DOFade(1, 1).SetEase(Ease.Linear);
		}
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Face Color To Green")) {
			foreach (TextMeshPro t in texts) t.DOFaceColor(Color.green, 1).SetEase(Ease.Linear);
			foreach (TextMeshProUGUI t in uguiTexts) t.DOFaceColor(Color.green, 1).SetEase(Ease.Linear);
		}
		if (GUILayout.Button("Face Color To Red")) {
			foreach (TextMeshPro t in texts) t.DOFaceColor(Color.red, 1).SetEase(Ease.Linear);
			foreach (TextMeshProUGUI t in uguiTexts) t.DOFaceColor(Color.red, 1).SetEase(Ease.Linear);
		}
		if (GUILayout.Button("Face Fade Out")) {
			foreach (TextMeshPro t in texts) t.DOFaceFade(0, 1).SetEase(Ease.Linear);
			foreach (TextMeshProUGUI t in uguiTexts) t.DOFaceFade(0, 1).SetEase(Ease.Linear);
		}
		if (GUILayout.Button("Face Fade In")) {
			foreach (TextMeshPro t in texts) t.DOFaceFade(1, 1).SetEase(Ease.Linear);
			foreach (TextMeshProUGUI t in uguiTexts) t.DOFaceFade(1, 1).SetEase(Ease.Linear);
		}
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Glow Color To Green")) {
			foreach (TextMeshPro t in texts) t.DOGlowColor(Color.green, 1).SetEase(Ease.Linear);
			foreach (TextMeshProUGUI t in uguiTexts) t.DOGlowColor(Color.green, 1).SetEase(Ease.Linear);
		}
		if (GUILayout.Button("Glow Color To Red")) {
			foreach (TextMeshPro t in texts) t.DOGlowColor(Color.red, 1).SetEase(Ease.Linear);
			foreach (TextMeshProUGUI t in uguiTexts) t.DOGlowColor(Color.red, 1).SetEase(Ease.Linear);
		}
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Outline Color To Green")) {
			foreach (TextMeshPro t in texts) t.DOOutlineColor(Color.green, 1).SetEase(Ease.Linear);
			foreach (TextMeshProUGUI t in uguiTexts) t.DOOutlineColor(Color.green, 1).SetEase(Ease.Linear);
		}
		if (GUILayout.Button("Outline Color To Red")) {
			foreach (TextMeshPro t in texts) t.DOOutlineColor(Color.red, 1).SetEase(Ease.Linear);
			foreach (TextMeshProUGUI t in uguiTexts) t.DOOutlineColor(Color.red, 1).SetEase(Ease.Linear);
		}
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Font Resize Down")) {
			foreach (TextMeshPro t in texts) t.DOFontSize(10, 1);
			foreach (TextMeshProUGUI t in uguiTexts) t.DOFontSize(10, 1);
		}
		if (GUILayout.Button("Font Resize Up")) {
			foreach (TextMeshPro t in texts) t.DOFontSize(32, 1);
			foreach (TextMeshProUGUI t in uguiTexts) t.DOFontSize(32, 1);
		}
		if (GUILayout.Button("Scale to 1.5")) {
			foreach (TextMeshPro t in texts) t.DOScale(1.5f, 1);
			foreach (TextMeshProUGUI t in uguiTexts) t.DOScale(1.5f, 1);
		}
		if (GUILayout.Button("Trim Max Visible Characters")) {
			foreach (TextMeshPro t in texts) t.DOMaxVisibleCharacters(22, 1);
			foreach (TextMeshProUGUI t in uguiTexts) t.DOMaxVisibleCharacters(22, 1);
		}
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Text Reset")) {
			DOTween.KillAll();
			for (int i = 0; i < texts.Length; ++i) texts[i].text = orTexts[i];
			for (int i = 0; i < uguiTexts.Length; ++i) uguiTexts[i].text = orGuiTexts[i];
		}
		if (GUILayout.Button("Text Replace")) {
			foreach (TextMeshPro t in texts) t.DOText(replaceWText, 5, richTextEnabled).SetEase(Ease.Linear);
			foreach (TextMeshProUGUI t in uguiTexts) t.DOText(replaceWText, 5, richTextEnabled).SetEase(Ease.Linear);
		}
		if (GUILayout.Button("Text Replace Add")) {
			foreach (TextMeshPro t in texts) t.DOText(" " + replaceWText, 5, richTextEnabled).SetRelative().SetEase(Ease.Linear);
			foreach (TextMeshProUGUI t in uguiTexts) t.DOText(" " + replaceWText, 5, richTextEnabled).SetRelative().SetEase(Ease.Linear);
		}
		if (GUILayout.Button("Text Replace W Scramble")) {
			foreach (TextMeshPro t in texts) t.DOText(replaceWText, 5, richTextEnabled, ScrambleMode.Lowercase).SetEase(Ease.Linear);
			foreach (TextMeshProUGUI t in uguiTexts) t.DOText(replaceWText, 5, richTextEnabled, ScrambleMode.Lowercase).SetEase(Ease.Linear);
		}
		if (GUILayout.Button("Text Replace Add W Scramble")) {
			foreach (TextMeshPro t in texts) t.DOText(" " + replaceWText, 5, richTextEnabled, ScrambleMode.Lowercase).SetRelative().SetEase(Ease.Linear);
			foreach (TextMeshProUGUI t in uguiTexts) t.DOText(" " + replaceWText, 5, richTextEnabled, ScrambleMode.Lowercase).SetRelative().SetEase(Ease.Linear);
		}
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		if (GUILayout.Button("TogglePause")) DOTween.TogglePauseAll();
		if (GUILayout.Button("Flip")) DOTween.FlipAll();
		GUILayout.EndHorizontal();
	}
}