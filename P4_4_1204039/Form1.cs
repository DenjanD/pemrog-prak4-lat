using System.Text.RegularExpressions;

namespace P4_4_1204039
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text != "")
            {
                if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epCorrect.SetError(txtEmail, "Betul!");
                    epWarning.SetError(txtEmail, "");
                    epError.SetError(txtEmail, "");
                }
                else
                {
                    epCorrect.SetError(txtEmail, "");
                    epWarning.SetError(txtEmail, "");
                    epError.SetError(txtEmail, "Format email tidak benar! Co. (alfien@gmail.com)");
                }
            }
            else
            {
                epCorrect.SetError(txtEmail, "");
                epWarning.SetError(txtEmail, "Email masih kosong");
                epError.SetError(txtEmail, "");
            }
        }

        private void txtNoHP_TextChanged(object sender, EventArgs e)
        {
            if (txtNoHP.Text != "")
            {
                if ((txtNoHP.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(txtNoHP, "Betul!");
                    epWarning.SetError(txtNoHP, "");
                    epError.SetError(txtNoHP, "");
                }
                else
                {
                    epCorrect.SetError(txtNoHP, "");
                    epWarning.SetError(txtNoHP, "");
                    epError.SetError(txtNoHP, "Format No HP tidak benar!");
                }
            }
            else
            {
                epCorrect.SetError(txtNoHP, "");
                epWarning.SetError(txtNoHP, "No HP masih kosong");
                epError.SetError(txtNoHP, "");
            }
        }

        private void txtJenisKelamin_TextChanged(object sender, EventArgs e)
        {
            if (txtJenisKelamin.Text != "")
            {
                if (txtJenisKelamin.Text.Length == 1 && (txtJenisKelamin.Text).All(Char.IsLetter))
                {
                    epCorrect.SetError(txtJenisKelamin, "Betul!");
                    epWarning.SetError(txtJenisKelamin, "");
                    epError.SetError(txtJenisKelamin, "");
                }
                else
                {
                    epCorrect.SetError(txtJenisKelamin, "");
                    epWarning.SetError(txtJenisKelamin, "");
                    epError.SetError(txtJenisKelamin, "Format Jenis Kelamin tidak benar!");
                }
            }
            else
            {
                epCorrect.SetError(txtJenisKelamin, "");
                epWarning.SetError(txtJenisKelamin, "Jenis Kelamin masih kosong");
                epError.SetError(txtJenisKelamin, "");
            }
        }

        private void txtTempatLahir_TextChanged(object sender, EventArgs e)
        {
            if (txtTempatLahir.Text != "")
            {
                if (txtTempatLahir.Text == txtTempatLahir.Text.ToUpper())
                {
                    epCorrect.SetError(txtTempatLahir, "Betul!");
                    epWarning.SetError(txtTempatLahir, "");
                    epError.SetError(txtTempatLahir, "");
                }
                else
                {
                    epCorrect.SetError(txtTempatLahir, "");
                    epWarning.SetError(txtTempatLahir, "");
                    epError.SetError(txtTempatLahir, "Format Tempat Lahir tidak benar! (Harus Huruf Kapital Semua)");
                }
            }
            else
            {
                epCorrect.SetError(txtTempatLahir, "");
                epWarning.SetError(txtTempatLahir, "Tempat Lahir masih kosong");
                epError.SetError(txtTempatLahir, "");
            }
        }

        private void txtKegiatan_TextChanged(object sender, EventArgs e)
        {
            if (txtKegiatan.Text != "")
            {
                if (txtKegiatan.Text == txtKegiatan.Text.ToLower())
                {
                    epCorrect.SetError(txtKegiatan, "Betul!");
                    epWarning.SetError(txtKegiatan, "");
                    epError.SetError(txtKegiatan, "");
                }
                else
                {
                    epCorrect.SetError(txtKegiatan, "");
                    epWarning.SetError(txtKegiatan, "");
                    epError.SetError(txtKegiatan, "Format Kegiatan Saat Ini tidak benar! (Harus Huruf Kecil Semua)");
                }
            }
            else
            {
                epCorrect.SetError(txtKegiatan, "");
                epWarning.SetError(txtKegiatan, "Kegiatan Saat Ini masih kosong");
                epError.SetError(txtKegiatan, "");
            }
        }

        private void btnSubmit_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show
                    ("Email : " + txtEmail.Text +
                    "\nNo HP : " + txtNoHP.Text +
                    "\nJenis Kelamin : " + txtJenisKelamin.Text +
                    "\nTempat Lahir : " + txtTempatLahir.Text +
                    "\nKegiatan Saat Ini : " + txtKegiatan.Text,
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}