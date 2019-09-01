using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Recognition
{
    public partial class form_recognition : Form
    {
        public form_recognition()
        {
            InitializeComponent();
        }
        string name_method = "Compare photo";

        private void btn_compare_photo_Click(object sender, EventArgs e)
        {
            lbl_name_method.Text = "Compare photo";
            name_method = lbl_name_method.Text;

            lbl_panel_value_describing_events.Text = "Метод позволяет сравнить два изображения и узнать насколько совпадает портрет этих людей.";
        }

        private void btn_found_in_the_datebase_Click(object sender, EventArgs e)
        {
            lbl_name_method.Text = "Found in the datebase";
            name_method = lbl_name_method.Text;
            lbl_panel_value_describing_events.Text = "Метод осуществляет поиск лиц в базе данных и отображает совпадаения.";
        }

        private void btn_detect_face_Click(object sender, EventArgs e)
        {
            lbl_name_method.Text = "Detect face";
            name_method = lbl_name_method.Text;
            lbl_panel_value_describing_events.Text = "Метод осущствляет поиск лиц на изображении.";
        }
        private form_method _MyClass = new form_method();
        private void btn_start_Click(object sender, EventArgs e)
        {
            switch (name_method)
            {
                
            case "Compare photo":
                    {
                        form_method active_form = new form_method();
                        active_form.Show();
                        //_MyClass.open_tabContol(3);
                        // tabContol_methods.SelectTab(tabPage2);
                        break;
                    }
                case "Found in the datebase":
                    {
                        form_method active_form = new form_method();
                        active_form.Show();
                        break;
                    }
                case "Detect face":
                    {
                        form_method active_form = new form_method();
                        active_form.Show();
                        break;
                    }
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            form_help active_form_help = new form_help();
            active_form_help.Show();
        }

    }//закрытие класса
}
