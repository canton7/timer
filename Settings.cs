using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace timer {
	class Settings {
		private bool alarm;
		public bool Alarm {
			get { return this.alarm; }
			set { this.alarm = value; }
		}

		private bool onTop;
		public bool OnTop {
			get { return this.onTop; }
			set { this.onTop = value; }
		}

		public class SerializedForm {
			public bool Alarm;
			public bool OnTop;
		}

		public Settings() {
			this.initDefault();
		}

		public Settings(SerializedForm serializedForm) {
			if (serializedForm == null) {
				this.initDefault();
				return;
			}
			this.Unserialize(serializedForm);
		}

		private void initDefault() {
			this.alarm = true;
			this.onTop = false;
		}

		public SerializedForm Serialize() {
			SerializedForm serializedForm = new SerializedForm() {
				Alarm = this.alarm,
				OnTop = this.onTop
			};
			return serializedForm;
		}

		public void Unserialize(SerializedForm serializedForm) {
			this.alarm = serializedForm.Alarm;
			this.onTop = serializedForm.OnTop;
		}

	}
}
