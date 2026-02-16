using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Авторизация.EFAuto;

namespace Авторизация
{
    public partial class Form1 : Form
    {
        public static Пользователи пользователи;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            пользователи = null;
            Model1 model = new Model1();
            пользователи = model.Пользователи.FirstOrDefault(x => x.Логин == textBoxLogin.Text && x.Пароль == textBoxPassword.Text);
            if (пользователи != null)
            {
                MessageBox.Show("Успешный вход");
            }
            else
            {
                MessageBox.Show("Вы ввели неверный логин или пароль. Пожалуйста проверьте ещё раз введенные данные.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
