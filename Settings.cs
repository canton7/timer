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

		private bool icon;
		public bool Icon {
			get { return this.icon; }
			set { this.icon = value; }
		}

		public class SerializedForm {
			public bool Alarm;
			public bool OnTop;
			public bool Icon;
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
			this.icon = true;
		}

		public SerializedForm Serialize() {
			SerializedForm serializedForm = new SerializedForm() {
				Alarm = this.alarm,
				OnTop = this.onTop,
				Icon = this.icon
			};
			return serializedForm;
		}

		public void Unserialize(SerializedForm serializedForm) {
			this.alarm = serializedForm.Alarm;
			this.onTop = serializedForm.OnTop;
			this.icon = serializedForm.Icon;
		}

	}
}
