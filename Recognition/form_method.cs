using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using MySql.Data.MySqlClient;


namespace Recognition
{
    public partial class form_method : Form
    {
        string webAppConnection_string = "server=mysql102.1gb.ru;user ID=gb_56525;Password=af5b8d8zc89a;database=gb_56525;";
       // string webAppConnection_string = "server=localhost;user ID=root;database=db_recognition;password=123456;"; 
        MySqlConnection conn;
        MySqlCommand cmd;
        bool display_box = true;

        public form_method()
        {
            InitializeComponent();
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_telephone_Click(object sender, EventArgs e)
        {
              uint ot_price=0, do_price=0;
             
             if (tbox_ot.Text != "" && UInt32.TryParse(tbox_ot.Text, out ot_price))
                 ot_price = Convert.ToUInt32(tbox_ot.Text);
             else
                 if (tbox_ot.Text == "")
                     ot_price = 0;
                 else
                 {
                     if (display_box) show_MessageBox(false, "Проверте тип данных в поле цены 'ОТ'");
                     return;
                 }


             if (tbox_do.Text != "" && UInt32.TryParse(tbox_do.Text, out do_price))
                 do_price = Convert.ToUInt32(tbox_do.Text);
             else
                 if (tbox_do.Text == "")
                     do_price = 5000000;
                 else
                 {
                     if (display_box) show_MessageBox(false, "Проверте тип данных в поле цены 'ДО'");
                     return;
                 }


            string add_param_query = "";
            if (checkBox_front_camera.Checked)
            {
                add_param_query = " and r_t_camera.rcg_telephone_front_camera =1";
            }

            conn = new MySqlConnection(webAppConnection_string);
            conn.Open();

            DataSet data = new DataSet();
            data.Locale = System.Globalization.CultureInfo.InvariantCulture;

            //MySqlDataAdapter masterDataAdapter = new MySqlDataAdapter("select rcg_telephone_name from rcg_telephone", conn);
            //выборка из двух таблиц путём связывания с помощью "join on" по имени телефона
           MySqlDataAdapter masterDataAdapter = new MySqlDataAdapter("select rcg_telephone_name as 'Name telephone' from rcg_telephone r_t join rcg_telephone_camera r_t_camera on r_t.rcg_telephone_name = r_t_camera.rcg_telephone_camera_name "+
                " where  (r_t.rcg_telephone_price between " +
                ot_price + " and " + do_price + ") "+add_param_query+";", conn);
            
            masterDataAdapter.Fill(data, "rcg_telephone");


            BindingSource masterBindingSource = new BindingSource();
            BindingSource detailsBindingSource = new BindingSource();

            masterBindingSource.DataSource = data;
            masterBindingSource.DataMember = "rcg_telephone";

            detailsBindingSource.DataSource = masterBindingSource;
            dataGridView_resultSelected.RowHeadersVisible = false;
            dataGridView_resultSelected.DataSource = masterBindingSource;



        }

        private void dataGridView_resultSelected_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //show_MessageBox(true, "кликнули на грид");
            int _index_gridwiewSelect = e.RowIndex;
            string _valueDatagridView_resultSelected = dataGridView_resultSelected[0, _index_gridwiewSelect].Value.ToString();

            conn = new MySqlConnection(webAppConnection_string);
            conn.Open();

            DataSet data = new DataSet();
            data.Locale = System.Globalization.CultureInfo.InvariantCulture;

            //
           string str_query = "select rcg_telephone_name , rcg_telephone_photo from rcg_telephone"+
                 " where  rcg_telephone_name='" + _valueDatagridView_resultSelected + "';";

            cmd = new MySqlCommand(str_query, conn);
            MySqlDataReader data_reader;

            try
            {
                data_reader = cmd.ExecuteReader();
                while (data_reader.Read())
                {
                    lbl_nameActiveTelephone_value.Text = data_reader["rcg_telephone_name"].ToString();
                    try
                    {

                        pictureBox_activeTelephone.Image = new Bitmap(new MemoryStream((byte[])data_reader["rcg_telephone_photo"]));
                    }
                    catch
                    {

                    }
                    /*
                     * вставка изображения в поле
                     * 
                     * 
                     * */
                }


            }
            catch (Exception exp)
            {
                string err_string = "Данные не извечены! Сообщение системы\n\"" + exp.ToString() + "\"";
                if (display_box) show_MessageBox(false, err_string);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_insert_telephone_Click(object sender, EventArgs e)
        {
            string name_telephone="";
            uint price_telephone = 0 ;
            uint value_main_camera=0, value_face_camera=0, value_defenition=0;
            if (tbox_name_telephone.Text == "" || tbox_insert_prise.Text == "")
            {
                if (display_box) show_MessageBox(false, "Поле 'Название телефона' или поле 'Цена' не заполнены");
                return;
            }
            else
            {
                if (UInt32.TryParse(tbox_insert_prise.Text, out price_telephone))
                {
                    name_telephone = tbox_name_telephone.Text;
                    price_telephone = Convert.ToUInt32(tbox_insert_prise.Text);
                }
                else
                {
                    if (display_box) show_MessageBox(false, "В поле цена присутсвуют посторонние символы");
                    return;
                }
            }

            if (chbox_defenition.Checked)
                value_defenition = 1;
            if (chbox_faceCamera.Checked)
                value_face_camera = 1;
            if (chbox_mainCamera.Checked)
                value_main_camera = 1;
            string query_str = "INSERT INTO gb_56525.rcg_telephone_camera(rcg_telephone_camera_name,rcg_telephone_main_camera,rcg_telephone_front_camera,rcg_telephone_defenition) value('" + 
                name_telephone + "'," + value_main_camera + "," + value_face_camera + "," + value_defenition + ");"+
                "insert into gb_56525.rcg_telephone(rcg_telephone_name,rcg_telephone_price, rcg_telephone_photo) value ('" + name_telephone + "'," + price_telephone + ", @rcg_telephone_photoValue);"; 
            //string query_str = "insert into gb_56525.rcg_telephone_camera value('Сfsefsefse',1 , 1 ,1); insert into gb_56525.rcg_telephone value ('" + name_telephone + "', " + price_telephone + ");";

            //добавление данных о изображении
            
            //query_str += arr_img;
            //show_MessageBox(true, arr_img.ToString());


            conn = new MySqlConnection(webAppConnection_string);
            conn.Open();

            cmd = new MySqlCommand(query_str, conn);
            try
            {

                string _pathFileName = openFileDialog_insert_photo.FileName;
                string _fileName = Path.GetFileNameWithoutExtension(_pathFileName);
                byte[] arr_img = func_updImage(_pathFileName, _fileName);
                cmd.Parameters.Add("@rcg_telephone_photoValue", MySqlDbType.Blob).Value = arr_img;
                //show_MessageBox(true, cmd.ExecuteNonQuery().ToString());
                if (cmd.ExecuteNonQuery() == 2)
                {
                    if (display_box) show_MessageBox(true, "Запрос выполнен");

                }
                else
                {
                    if (display_box) show_MessageBox(false, "Запрос не выполнен");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                if (display_box) show_MessageBox(false, ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                pictureBox_insert_imageValue.Image = null;
            }

            /*MySqlDataReader data_reader;
            try
            {
                data_reader = cmd.ExecuteReader();
                if (display_box) show_MessageBox(true, "Данные успешно добавлены!");
            }
            catch (Exception exp)
            {
                string err_string = "Данные не записаны! Сообщение системы\n\"" + exp.ToString() + "\"";
                if (display_box) show_MessageBox(false, err_string);
            }
            finally
            {
                conn.Close();
            }*/
            
        }


        private void btn_selected_Click(object sender, EventArgs e)
        {
            comboBox_telephoneList.Items.Clear(); // Очистка комбобокса
            comboBox_telephoneList.Text = "Выберите модель телефона";
            conn = new MySqlConnection(webAppConnection_string);
            conn.Open();

            string str_query = "select rcg_telephone_name from rcg_telephone";
            cmd = new MySqlCommand(str_query, conn);
            MySqlDataReader data_reader;
            try
            {
                data_reader = cmd.ExecuteReader();
                while (data_reader.Read())
                {
                    comboBox_telephoneList.Items.Add(data_reader["rcg_telephone_name"]);
                }
            }
            catch (Exception exp)
            {
                string err_string = "Данные не извечены! Сообщение системы\n\"" + exp.ToString() + "\"";
                if (display_box) show_MessageBox(false, err_string);
            }
            finally
            {
                conn.Close();
            }
        }

        private void comboBox_telephoneList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_MySql_delete_nameTelephoneValue.Text = comboBox_telephoneList.Text;

            btn_delete.Visible = true;

            lbl_MySql_delete_defenition.Visible = true;
            lbl_MySql_delete_defenitionValue.Visible = true;
            lbl_MySql_delete_faceCamera.Visible = true;
            lbl_MySql_delete_faceCameraValue.Visible = true;
            lbl_MySql_delete_mainCamera.Visible = true;
            lbl_MySql_delete_mainCameraValue.Visible = true;
            lbl_MySql_delete_nameTelephone.Visible = true;
            lbl_MySql_delete_nameTelephoneValue.Visible = true;
            lbl_MySql_delete_priceTelephone.Visible = true;
            lbl_MySql_delete_priceTelephoneValue.Visible = true;
            pictureBox_delete_imageValue.Visible = true;



            conn = new MySqlConnection(webAppConnection_string);
            conn.Open();

            //string str_query = "select rcg_telephone_price from rcg_telephone where rcg_telephone_name='" + comboBox_telephoneList.Text + "';";
            string str_query = "select rcg_telephone_price,rcg_telephone_main_camera,rcg_telephone_front_camera,rcg_telephone_defenition,rcg_telephone_photo from "+
                " rcg_telephone r_t join rcg_telephone_camera r_t_camera on r_t.rcg_telephone_name=r_t_camera.rcg_telephone_camera_name  where r_t.rcg_telephone_name='" + comboBox_telephoneList.Text + "';";
            cmd = new MySqlCommand(str_query, conn);
            MySqlDataReader data_reader;
            try
            {
                data_reader = cmd.ExecuteReader();
                while (data_reader.Read())
                {
                    lbl_MySql_delete_priceTelephoneValue.Text = data_reader["rcg_telephone_price"].ToString();

                    if (Convert.ToUInt32(data_reader["rcg_telephone_main_camera"]) == 1)
                        lbl_MySql_delete_mainCameraValue.Text = "Да";
                        else 
                        lbl_MySql_delete_mainCameraValue.Text = "Нет";

                    if (Convert.ToUInt32(data_reader["rcg_telephone_front_camera"]) == 1)
                         lbl_MySql_delete_faceCameraValue.Text = "Да";
                    else
                        lbl_MySql_delete_faceCameraValue.Text = "Нет";

                    if (Convert.ToUInt32(data_reader["rcg_telephone_defenition"]) == 1)
                        lbl_MySql_delete_defenitionValue.Text = "Да";
                    else
                        lbl_MySql_delete_defenitionValue.Text = "Нет";

                    try
                    {
                        pictureBox_delete_imageValue.Image = new Bitmap(new MemoryStream((byte[])data_reader["rcg_telephone_photo"]));
                    }
                    catch
                    {

                    }

                }


            }
            catch (Exception exp)
            {
                string err_string = "Данные не извечены! Сообщение системы\n\"" + exp.ToString() + "\"";
                if (display_box) show_MessageBox(false, err_string);
            }
            finally
            {
                conn.Close();
            }


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(webAppConnection_string);
            conn.Open();

            string str_query = " delete from rcg_telephone where rcg_telephone_name='"+lbl_MySql_delete_nameTelephoneValue.Text+"'; "+
                "delete from rcg_telephone_camera where rcg_telephone_camera_name='" + lbl_MySql_delete_nameTelephoneValue.Text + "';";
            cmd = new MySqlCommand(str_query, conn);
            MySqlDataReader data_reader;
            try
            {
                data_reader = cmd.ExecuteReader();
                if (display_box) show_MessageBox(true, "Данные успешно удалены!");
                lbl_MySql_delete_defenition.Visible = false;
                lbl_MySql_delete_defenitionValue.Visible = false;
                lbl_MySql_delete_faceCamera.Visible = false;
                lbl_MySql_delete_faceCameraValue.Visible = false;
                lbl_MySql_delete_mainCamera.Visible = false;
                lbl_MySql_delete_mainCameraValue.Visible = false;
                lbl_MySql_delete_nameTelephone.Visible = false;
                lbl_MySql_delete_nameTelephoneValue.Visible = false;
                lbl_MySql_delete_priceTelephone.Visible = false;
                lbl_MySql_delete_priceTelephoneValue.Visible = false;
                btn_delete.Visible = false;
                pictureBox_delete_imageValue.Visible = false;

                comboBox_telephoneList.Text="Выберите модель телефона";
                btn_selected_Click(this, new EventArgs());
            }
            catch (Exception exp)
            {
                string err_string = "Данные не удалены! Сообщение системы\n\"" + exp.ToString() + "\"";
                if (display_box) show_MessageBox(false, err_string);
            }
            finally
            {
                conn.Close();
            }
        }

        private void comboBox_update_telephoneList_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbox_MySql_update_nameTelephoneValue.Text = comboBox_update_telephoneList.Text;

            lbl_MySql_update_nameTelephone.Visible = true;
            tbox_MySql_update_nameTelephoneValue.Visible = true;

            lbl_MySql_update_mainCamera.Visible = true;
            tbox_MySql_update_mainCameraValue.Visible = true;
            lbl_MySql_update_faceCamera.Visible = true;
            tbox_MySql_update_faceCameraValue.Visible = true;
            lbl_MySql_update_defenition.Visible = true;
            tbox_lbl_MySql_update_defenitionValue.Visible = true;
            lbl_MySql_update_priceTelephone.Visible = true;
            tbox_MySql_update_priceTelephoneValue.Visible = true;
            btn_update.Visible= true;
            pictureBox_update_imageValue.Visible = true;

            conn = new MySqlConnection(webAppConnection_string);
            conn.Open();

            //string str_query = "select rcg_telephone_price from rcg_telephone where rcg_telephone_name='" + comboBox_telephoneList.Text + "';";
            string str_query = "select rcg_telephone_price,rcg_telephone_main_camera,rcg_telephone_front_camera,rcg_telephone_defenition, rcg_telephone_photo from " +
                " rcg_telephone r_t join rcg_telephone_camera r_t_camera on r_t.rcg_telephone_name=r_t_camera.rcg_telephone_camera_name  where r_t.rcg_telephone_name='" + comboBox_update_telephoneList.Text + "';";
            cmd = new MySqlCommand(str_query, conn);
            MySqlDataReader data_reader;
            try
            {
                data_reader = cmd.ExecuteReader();
                while (data_reader.Read())
                {
                    tbox_MySql_update_mainCameraValue.Text = data_reader["rcg_telephone_main_camera"].ToString();
                    tbox_MySql_update_faceCameraValue.Text = data_reader["rcg_telephone_front_camera"].ToString();
                    tbox_MySql_update_priceTelephoneValue.Text = data_reader["rcg_telephone_price"].ToString(); ;
                    tbox_lbl_MySql_update_defenitionValue.Text = data_reader["rcg_telephone_defenition"].ToString();
                    try
                    {
                        pictureBox_update_imageValue.Image = new Bitmap(new MemoryStream((byte[])data_reader["rcg_telephone_photo"]));
                    }
                    catch
                    {

                    }
                }
            }
            catch (Exception exp)
            {
                string err_string = "Данные не извечены! Сообщение системы\n\"" + exp.ToString() + "\"";
                if (display_box) show_MessageBox(false, err_string);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btn_selectedOnUpdate_Click(object sender, EventArgs e)
        {
            comboBox_update_telephoneList.Items.Clear(); // Очистка комбобокса
            comboBox_update_telephoneList.Text = "Выберите модель телефона";
            conn = new MySqlConnection(webAppConnection_string);
            conn.Open();

            string str_query = "select rcg_telephone_name from rcg_telephone";
            cmd = new MySqlCommand(str_query, conn);
            MySqlDataReader data_reader;
            try
            {
                data_reader = cmd.ExecuteReader();
                while (data_reader.Read())
                {
                    comboBox_update_telephoneList.Items.Add(data_reader["rcg_telephone_name"]);
                }
            }
            catch (Exception exp)
            {
                string err_string = "Данные не извечены! Сообщение системы\n\"" + exp.ToString() + "\"";
                if (display_box) show_MessageBox(false, err_string);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            comboBox_update_telephoneList.Text = "Выберите модель телефона";
            lbl_MySql_update_nameTelephone.Visible = false;
            tbox_MySql_update_nameTelephoneValue.Visible = false;

            lbl_MySql_update_mainCamera.Visible = false;
            tbox_MySql_update_mainCameraValue.Visible = false;
            lbl_MySql_update_faceCamera.Visible = false;
            tbox_MySql_update_faceCameraValue.Visible = false;
            lbl_MySql_update_defenition.Visible = false;
            tbox_lbl_MySql_update_defenitionValue.Visible = false;
            lbl_MySql_update_priceTelephone.Visible = false;
            tbox_MySql_update_priceTelephoneValue.Visible = false;
            btn_update.Visible = false;
            pictureBox_update_imageValue.Visible = false ;

            string price = tbox_MySql_update_priceTelephoneValue.Text;

            uint price_int= 0;
            uint value_mainCamera = 0;
            uint value_frontCamera = 0;
            uint value_defenition = 0;

            uint update_mainCameraValue =2, update_faceCameraValue = 2, update_defenitionValue = 2;
            if (((UInt32.TryParse(tbox_MySql_update_mainCameraValue.Text, out update_mainCameraValue) && (update_mainCameraValue == 1 || update_mainCameraValue == 0) )
                && 
                 (UInt32.TryParse(tbox_MySql_update_faceCameraValue.Text, out update_faceCameraValue)&& (update_faceCameraValue == 1 || update_faceCameraValue==0))
                &&
                (UInt32.TryParse(tbox_lbl_MySql_update_defenitionValue.Text, out update_defenitionValue)&& (update_defenitionValue== 1 || update_defenitionValue == 0)))
                &&
                UInt32.TryParse(price, out price_int))
            {
                value_mainCamera = update_mainCameraValue;
                value_frontCamera = update_faceCameraValue;
                value_defenition = update_defenitionValue;

                //запрос на обновление параметров камеры
                string query_str = "update rcg_telephone_camera r_t_camera set r_t_camera.rcg_telephone_camera_name = '" + tbox_MySql_update_nameTelephoneValue.Text +
                    "',r_t_camera.rcg_telephone_main_camera=" + value_mainCamera + ", r_t_camera.rcg_telephone_front_camera=" + value_frontCamera + ",r_t_camera.rcg_telephone_defenition=" + value_defenition +
                    " where r_t_camera.rcg_telephone_camera_name ='" + comboBox_update_telephoneList.Text + "';";
                //добавляем запрос на обновление стоимости 
                query_str += " update rcg_telephone r_t set r_t.rcg_telephone_price=" + price_int +
                    ", r_t.rcg_telephone_photo=@rcg_telephone_photoValue where r_t.rcg_telephone_name = '" + tbox_MySql_update_nameTelephoneValue.Text + "';";
                
                conn = new MySqlConnection(webAppConnection_string);
                conn.Open();

                cmd = new MySqlCommand(query_str, conn);
                ///////////////////
                try
                {

                    string _pathFileName = openFileDialog_update_photo.FileName;
                    string _fileName = Path.GetFileNameWithoutExtension(_pathFileName);
                    byte[] arr_img = func_updImage(_pathFileName, _fileName);
                    cmd.Parameters.Add("@rcg_telephone_photoValue", MySqlDbType.Blob).Value = arr_img;
                    //show_MessageBox(true, cmd.ExecuteNonQuery().ToString());
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        if (display_box) show_MessageBox(true, "Данные обновлены");

                    }
                    else
                    {
                        if (display_box) show_MessageBox(false, "Не удалось осуществить обновление данных");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    if (display_box) show_MessageBox(false, ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    pictureBox_update_imageValue.Image = null;

                }

                ///////////////////////
                /*MySqlDataReader data_reader;
                try
                {
                    data_reader = cmd.ExecuteReader();
                    if (display_box) show_MessageBox(true,"Данные успешно обновлены");
                }
                catch (Exception exp)
                {
                    string err_string = "Данные не записаны! Сообщение системы\n\"" + exp.ToString() + "\"";
                    if (display_box) show_MessageBox(false, err_string);
                }
                finally
                {
                    conn.Close();
                }*/

            }
            else
            {
                if (display_box) show_MessageBox(false,"Проверте правильность ввода данных в поля,  в числовых полях не должно присутсвовать букв и значений выходящих за рамки");
            }
        }

        private void chbox_displayMessageBox_CheckedChanged(object sender, EventArgs e)
        {
            display_box = chbox_displayMessageBox.Checked;
        }



        public void show_MessageBox (bool status, string str)
        {
            
            if (status)
            {
                if (MessageBox.Show("<Текс сообщения>", "<Заголовок>", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    //выполняется код если нажата "ОК"
                }
            }
            else
            {
                if(  MessageBox.Show("<Текс сообщения>", "<Заголовок>", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    //выполняется код если нажата "ОК"
                }
            }
        }



        private void pictureBox_insert_imageValue_Click(object sender, EventArgs e)
        {

            openFileDialog_insert_photo.Filter = "Выберите изображение(*.PNG;)|*.png;";
            if (openFileDialog_insert_photo.ShowDialog() == DialogResult.OK)
            {
                string _pathFileName = openFileDialog_insert_photo.FileName;
                pictureBox_insert_imageValue.Image = Image.FromFile(_pathFileName);

            }
        }

        private byte[] func_updImage(string str_pathFileName, string str_fileName)
        {
            MemoryStream ms = new MemoryStream();
            Bitmap img = new Bitmap(str_pathFileName);
            float scaleHeight = (float)100 / (float)img.Height;
            float scaleWindt = (float)100 / (float)img.Width;
            float scale = Math.Min(scaleHeight, scaleWindt);
            int new_width = (int)(img.Width * scale);
            int new_height = (int)(img.Height * scale);

            Image new_img = new Bitmap(img, new Size(new_width, new_height));
            string tmp_name = ""+str_fileName+".png"; //ошибка при повторном сохранение изображения !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            new_img.Save(tmp_name);

            Bitmap update_img = new Bitmap(tmp_name);
            update_img.Save(ms, update_img.RawFormat);
            byte[] arr_img = ms.ToArray();
            return arr_img;

        }

        private void pictureBox_activeTelephone_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_update_imageValue_Click(object sender, EventArgs e)
        {
            openFileDialog_update_photo.Filter = "Выберите изображение(*.PNG;)|*.png;";
            if (openFileDialog_update_photo.ShowDialog() == DialogResult.OK)
            {
                string _pathFileName = openFileDialog_update_photo.FileName;
                pictureBox_update_imageValue.Image = Image.FromFile(_pathFileName);

            }

        }



    }
}
