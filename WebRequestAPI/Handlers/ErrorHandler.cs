using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebRequestAPI.Handlers
{
    public abstract class ErrorHandler
    {
        public static void Throw(Exception ex, int code)
        {
            MessageBox.Show(
                "Something appears to have gone wrong. Please contant"
                    + " the developers with the following information:\n\n"
                    + ex.Message + "\n\n" + ex.StackTrace,
                "Error [" + code.ToString() + "]",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            Environment.Exit(code);
        }
    }
}
