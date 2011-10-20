using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LitJson;
using System.IO;

namespace timer {
	class FileHandler {
		private static FileHandler instance;

		public static FileHandler Instance {
			get {
				if (instance == null)
					instance = new FileHandler();
				return instance;
			}
		}

		// End of singleton stuff

		private bool inTesting;

		private string taskFile;
		private string configFile;

		private string alarmFile;
		public string AlarmFile {
			get { return this.alarmFile; }
		}

		private FileHandler() {
			this.inTesting = (File.Exists("tasks.json") && File.Exists("config.json"));

			//First look in the local directory, then AppConfig
			if (this.inTesting) {
				this.taskFile = "tasks.json";
				this.configFile = "config.json";
			}
			else {
				string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "timer");
				if (!Directory.Exists(path))
					Directory.CreateDirectory(path);
				this.taskFile = Path.Combine(path, "tasks.json");
				this.configFile = Path.Combine(path, "config.json");
			}

			// Do this seperately
			if (File.Exists("alarm.wav"))
				this.alarmFile = "alarm.wav";
			else
				this.alarmFile = "..\\..\\alarm.wav";
		}

		public void SaveTasks(TaskList.SerializedForm serializedForm) {
			JsonWriter writer = new JsonWriter();
			writer.PrettyPrint = true;
			JsonMapper.ToJson(serializedForm, writer);
			string json = writer.ToString();
			StreamWriter sr = new StreamWriter(this.taskFile);
			sr.Write(json);
			sr.Close();
		}

		public TaskList.SerializedForm LoadTasks() {
			if (!File.Exists(this.taskFile))
				return null;
			StreamReader sr = new StreamReader(this.taskFile);
			TaskList.SerializedForm serializedForm = JsonMapper.ToObject<TaskList.SerializedForm>(sr.ReadToEnd());
			sr.Close();
			return serializedForm;
		}

		public void SaveSettings(Settings.SerializedForm serializedForm) {
			JsonWriter writer = new JsonWriter();
			writer.PrettyPrint = true;
			JsonMapper.ToJson(serializedForm, writer);
			string json = writer.ToString();
			StreamWriter sr = new StreamWriter(this.configFile);
			sr.Write(json);
			sr.Close();
		}

		public Settings.SerializedForm LoadSettings() {
			if (!File.Exists(this.configFile))
				return null;
			StreamReader sr = new StreamReader(this.configFile);
			Settings.SerializedForm serializedForm = JsonMapper.ToObject<Settings.SerializedForm>(sr.ReadToEnd());
			sr.Close();
			return serializedForm;
		}

	}
}
