using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LitJson;
using System.IO;

namespace timer {
	class FileHandler {
		private static FileHandler instance;

		private FileHandler() { }

		public static FileHandler Instance {
			get {
				if (instance == null)
					instance = new FileHandler();
				return instance;
			}
		}

		// End of singleton stuff

		public void SaveTasks(TaskList.SerializedForm serializedForm) {
			JsonWriter writer = new JsonWriter();
			writer.PrettyPrint = true;
			JsonMapper.ToJson(serializedForm, writer);
			string json = writer.ToString();
			StreamWriter sr = new StreamWriter("tasks.json");
			sr.Write(json);
			sr.Close();
		}

		public TaskList.SerializedForm LoadTasks() {
			if (!File.Exists("tasks.json"))
				return null;
			StreamReader sr = new StreamReader("tasks.json");
			TaskList.SerializedForm serializedForm = JsonMapper.ToObject<TaskList.SerializedForm>(sr.ReadToEnd());
			sr.Close();
			return serializedForm;
		}

	}
}
