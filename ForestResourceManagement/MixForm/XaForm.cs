using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForestResourceManagement.Models;

namespace ForestResourceManagement.MixForm
{
    public class XaForm : Form
    {
        public XaTable Xa { get; private set; }

        public XaForm(XaTable xa = null)
        {
            Text = xa == null ? "Thêm Xã" : "Sửa Xã";
            StartPosition = FormStartPosition.CenterScreen;
            Icon = SystemIcons.Application;

            Xa = xa ?? new XaTable();

            var label = new Label { Text = "Tên Xã:", AutoSize = true, Location = new System.Drawing.Point(10, 20) };
            var textBox = new TextBox { Text = Xa.TenXa, Location = new System.Drawing.Point(10, 45), Size = new System.Drawing.Size(200, 20) };
            var buttonOk = new Button { Text = "OK", DialogResult = DialogResult.OK, Location = new System.Drawing.Point(10, 80) };
            var buttonCancel = new Button { Text = "Cancel", DialogResult = DialogResult.Cancel, Location = new System.Drawing.Point(100, 80) };

            Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });

            AcceptButton = buttonOk;
            CancelButton = buttonCancel;

            buttonOk.Click += (sender, args) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Tên xã không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                }
                else
                {
                    Xa.TenXa = textBox.Text;
                }
            };
        }
    }

}
