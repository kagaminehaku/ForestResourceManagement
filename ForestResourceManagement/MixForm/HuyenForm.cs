using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForestResourceManagement.Models;

namespace ForestResourceManagement.MixForm
{
    public class HuyenForm : Form
    {
        public HuyenTable Huyen { get; private set; }

        public HuyenForm(HuyenTable huyen = null)
        {
            Text = huyen == null ? "Thêm Huyện" : "Sửa Huyện";
            StartPosition = FormStartPosition.CenterScreen;
            Icon = SystemIcons.Application;

            Huyen = huyen ?? new HuyenTable();

            var label = new Label { Text = "Tên Huyện:", AutoSize = true, Location = new System.Drawing.Point(10, 20) };
            var textBox = new TextBox { Text = Huyen.TenHuyen, Location = new System.Drawing.Point(10, 45), Size = new System.Drawing.Size(200, 20) };
            var buttonOk = new Button { Text = "OK", DialogResult = DialogResult.OK, Location = new System.Drawing.Point(10, 80) };
            var buttonCancel = new Button { Text = "Cancel", DialogResult = DialogResult.Cancel, Location = new System.Drawing.Point(100, 80) };

            Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });

            AcceptButton = buttonOk;
            CancelButton = buttonCancel;

            buttonOk.Click += (sender, args) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Tên huyện không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                }
                else
                {
                    Huyen.TenHuyen = textBox.Text;
                }
            };
        }

        private void InitializeComponent()
        {

        }
    }
}
