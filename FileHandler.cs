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

		private string taskFile;

		private FileHandler() {
			//First look in the local directory, then AppConfig
			if (File.Exists("tasks.json"))
				this.taskFile = "tasks.json";
			else {
				string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "timer");
				if (!Directory.Exists(path))
					Directory.CreateDirectory(path);
				this.taskFile = Path.Combine(path, "tasks.json");
			}
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

	}
}
