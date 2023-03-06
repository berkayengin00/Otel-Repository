using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Otel.UI.Validation
{
	public static class ValidationTool
	{
		/// <summary>
		/// Değerler null, space ve uzunluğu 2 karakterden azsa false döner, değilse true döner 
		/// </summary>
		/// <param name="texts"></param>
		/// <returns></returns>
		public static bool BosMu(params string[] texts)
		{
			foreach (var item in texts)
			{
				//boş ise girer
				if (item.Any(char.IsWhiteSpace) ||string.IsNullOrWhiteSpace(item) || item.Length < 2)
				{
					return false;
				}
			}
			//boş değil
			return true;
		}

		/// <summary>
		/// Değerlerin içinde sayı varsa false, yoksa true döner
		/// </summary>
		/// <param name="texts"></param>
		/// <returns></returns>
		public static bool SayiVarMi(params string[] texts)
		{
			foreach (var item in texts)
			{
				//sayi varsa girer
				if (item.Any(char.IsDigit))
				{
					return false;
				}
			}
			//sayi yok
			return true;
		}

		/// <summary>
		/// Email kontrolü doğruysa true, değilse false döner
		/// </summary>
		/// <param name="email"></param>
		/// <returns></returns>
		public static bool EmailKontrol(string email)
		{
			//büyük küçük harfe duyarsız
			return Regex.IsMatch(email,
				@"\A(?:[a-z!#$%&'*+0-9/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
		}

		/// <summary>
		/// Telefon numarası kontrolü doğruysa true değilse false döner
		/// </summary>
		/// <param name="telefonNo"></param>
		/// <returns></returns>
		public static bool TelefonNoKontrol(string telefonNo)
		{
			return Regex.IsMatch(telefonNo, @"^(5(\d{2})-(\d{3})-(\d{2})-(\d{2}))$", RegexOptions.IgnoreCase);
		}

		/// <summary>
		/// Türkiye Cumhuriyeti Kimlik Numarası doğruysa true, değilse false döner
		/// </summary>
		/// <param name="tc"></param>
		/// <returns></returns>
		public static bool TcKontrol(string tc)
		{
			return (tc.Length == 11 && tc.Substring(0, 1) != "0" && tc.Substring(10, 1) != "1" && tc.Substring(10, 1) != "1" && tc.Substring(10, 1) != "3" && tc.Substring(10, 1) != "5" && tc.Substring(10, 1) != "7" && tc.Substring(10, 1) != "9");
			#region uzun if
			//if (tc.Length == 11 && tc.Substring(0, 1) != "0" && tc.Substring(10, 1) != "1" && tc.Substring(10, 1) != "1" && tc.Substring(10, 1) != "3" && tc.Substring(10, 1) != "5" && tc.Substring(10, 1) != "7" && tc.Substring(10, 1) != "9")
			//{
			//	return true;
			//}
			//return false;
			#endregion
		}

		public static void ResetAllControls(Control form)
		{
			foreach (Control control in form.Controls)
			{
				RecursiveResetForm(control);
			}
		}

		private static void RecursiveResetForm(Control control)
		{
			if (control.HasChildren)
			{
				foreach (Control subControl in control.Controls)
				{
					RecursiveResetForm(subControl);
				}
			}
			switch (control.GetType().Name)
			{
				case "TextBox":
					TextBox textBox = (TextBox)control;
					textBox.Text = null;
					break;

				case "ComboBox":
					ComboBox comboBox = (ComboBox)control;
					if (comboBox.Items.Count > 0)
						comboBox.SelectedIndex = 0;
					break;

				case "CheckBox":
					CheckBox checkBox = (CheckBox)control;
					checkBox.Checked = false;
					break;

				case "ListBox":
					ListBox listBox = (ListBox)control;
					listBox.ClearSelected();
					break;

				case "MaskedTextBox":
					MaskedTextBox maskedTextBox = (MaskedTextBox)control;
					maskedTextBox.Clear();
					break;
				case "DateTimePicker":
					DateTimePicker dateTimePicker = (DateTimePicker)control;
					dateTimePicker.Value = DateTime.Now;
					break;
			}
		}

	}
}
