using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kodi.Utilities.SampleApp
{
    public delegate void CheckHandler();

    public static class Extensions
    {
        public static void Set<T>(this ComboBox cmb, T value)
        {
            if (value == null)
                return;

            for (int i = 0; i < cmb.Items.Count; i++)
                if (cmb.Items[i] is T)
                    if (((T)cmb.Items[i]).Equals(value))
                    {
                        cmb.SelectedIndex = i;
                        break;
                    }
        }

        public static void AddEnum<T>(this ComboBox cmb)
        {
            cmb.AddArray<T>((T[])Enum.GetValues(typeof(T)));
        }

        public static void AddArray<T>(this ComboBox cmb, T[] Array)
        {
            cmb.AddArray<T>(Array, false);
        }
        public static void AddArray<T>(this ComboBox cmb, T[] Array, bool AddBlank)
        {
            cmb.Items.Clear();
            if (AddBlank && Array.Length > 0)
                cmb.Items.Add(string.Empty);
            foreach (T a in Array)
                cmb.Items.Add(a);
            if (cmb.Items.Count > 0)
                cmb.SelectedIndex = 0;
            else
            {
                cmb.Text = "";
                cmb.SelectedIndex = -1;
            }
        }

        public static void Check(this ComboBox cmb, CheckHandler has, CheckHandler hasNot)
        {
            if (cmb.Items.Count == 0)
            {
                cmb.Enabled = false;
                hasNot.Invoke();
            }
            else
            {
                cmb.Enabled = true;
                has.Invoke();
            }
        }

        public static void Show(this Exception ex)
        {
            MessageBox.Show($"Error : {ex.Message}", ex.GetType().ToString());
        }

    }
}
