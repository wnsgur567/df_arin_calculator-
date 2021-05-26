using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Init();
        }

        public ConstValues g_values;
        public int g_dealTime;
        public ulong g_BossHP;
        public ulong g_Damage;
        public int g_BossHpPercent;
        public int g_arinDecreasePercent;
        ResultForm result_from;

        public void Init()
        {
            this.Text = "아린계산기";

            PlayerDamageLabel.Text = "40초 유저 데미지";

            button1.Text = "계산";

            DamageTextBox.Text = "10000000000000";
            arinTextBox.Text = "20";

            g_values = new ConstValues();

            this.radioButton2.Checked = true;

            // 임시
            this.radioButton1.Enabled = false;
            this.radioButton2.Enabled = false;
            // 임시 end

            HPTextBox.Enabled = false;
            List<string> combobox_data = new List<string>(g_values.m_bosshp_dic.Count);
            foreach (var item in g_values.m_bosshp_dic.Keys)
            {
                combobox_data.Add(item.ToString());
            }
            comboBox1.Items.AddRange(combobox_data.ToArray());
            comboBox1.SelectedIndex = 2;    // 사용자 입력
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            string[] combobox_data2 = {
                "100%",
                "90%",
                "80%",
                "70%",
                "60%",
                "50%",
            };
            g_BossHpPercent = 100;

            PercentComboBox.Items.AddRange(combobox_data2);
            PercentComboBox.SelectedIndex = 0;    // 100%;
            PercentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }



        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                g_BossHP = GetHPFromTextBox();
                g_Damage = GetUserDamageFromTextBox();
                g_arinDecreasePercent = GetArinDecreasing();
            }
            catch (Exception)
            {

                // ....
                return;
            }

            // TODO : RESULT FORM 2

            result_from = new ResultForm(g_dealTime, g_Damage, g_BossHP, g_BossHpPercent, g_arinDecreasePercent);
            result_from.Show();
        }

        ulong GetHPFromTextBox()
        {
            ulong hp = 0;
            string hp_str = HPTextBox.Text;

            try
            {
                hp = ulong.Parse(hp_str);
                Console.WriteLine(hp);
            }
            catch (Exception)
            {
                MessageBox.Show("hp 입력값 확인");
                throw new Exception();
            }

            return hp;
        }
        ulong GetUserDamageFromTextBox()
        {
            ulong damage = 0;
            string damage_str = DamageTextBox.Text;

            try
            {
                damage = ulong.Parse(damage_str);
                Console.WriteLine(damage);
            }
            catch (Exception)
            {
                MessageBox.Show("damage 입력값 확인");
                throw new Exception();
            }

            return damage;
        }
        int GetArinDecreasing()
        {
            int decrease = 0;
            string arin_str = arinTextBox.Text;

            try
            {
                decrease = int.Parse(arin_str);
                if (decrease < 0 || decrease > 100)
                    throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("arin 감소 수치 확인");
                throw new Exception();
            }

            return decrease;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cur_index = comboBox1.SelectedIndex;

            if (cur_index == 0)
            {
                HPTextBox.Enabled = true;
                HPTextBox.Text = g_values.cur_input_value.ToString();
            }
            else
            {
                HPTextBox.Enabled = false;
                HPTextBox.Text = g_values.m_bosshp_dic[(E_Combobox_num)cur_index].ToString();
            }
        }
        private void PercentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {       

            g_BossHpPercent = int.Parse((((string)PercentComboBox.SelectedItem).Trim('%')));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            g_dealTime = 25;
            PlayerDamageLabel.Text = "25초 유저 데미지";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            g_dealTime = 40;
            PlayerDamageLabel.Text = "40초 유저 데미지";
        }


    }
}
