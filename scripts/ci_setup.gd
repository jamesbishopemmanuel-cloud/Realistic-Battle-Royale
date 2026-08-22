@tool
extends EditorScript

func _run():
	var settings := EditorSettings.new()

	var sdk_path := OS.get_environment("ANDROID_SDK_ROOT")
	if sdk_path.is_empty():
		sdk_path = OS.get_environment("ANDROID_HOME")

	var java_path := OS.get_environment("JAVA_HOME")

	print("Android SDK: ", sdk_path)
	print("Java SDK: ", java_path)

	if not sdk_path.is_empty():
		settings.set_setting(
			"export/android/android_sdk_path",
			sdk_path
		)

	if not java_path.is_empty():
		settings.set_setting(
			"export/android/java_sdk_path",
			java_path
		)

	settings.set_setting(
		"export/android/adb",
		sdk_path + "/platform-tools/adb"
	)

	settings.save()

	print("Godot Android settings configured.")