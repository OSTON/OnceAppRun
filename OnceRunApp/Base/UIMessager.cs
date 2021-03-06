﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace OnceRunApp.Base
{
    public class UIMessager
    {
        public static void ShowInfo(string message)
        {
            MessageBox.Show(message, "OnceRunApp Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowError(string message)
        {
            MessageBox.Show(message, "OnceRunApp Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowWarning(string message)
        {
            MessageBox.Show(message, "OnceRunApp Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult ShowConfirm(string message)
        {
            return MessageBox.Show(message, "OnceRunApp Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

    }
}
