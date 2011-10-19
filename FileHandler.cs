﻿using System;
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

		public void SaveTasks(Main.SerializedForm serializedForm) {
			JsonWriter writer = new JsonWriter();
			writer.PrettyPrint = true;
			JsonMapper.ToJson(serializedForm, writer);
			string json = writer.ToString();
			StreamWriter sr = new StreamWriter("tasks.json");
			sr.Write(json);
			sr.Close();
		}

	}
}
