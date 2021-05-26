using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ARIN
{
    public partial class ResultForm : Form
    {
        public ResultForm(int time, ulong user_damage, ulong bossHP, int percent, int decreasPercent)
        {
            g_time = time;
            g_user_damage = (ulong)((user_damage / 100.0) * (100-decreasPercent));
            g_bossMaxHP = bossHP;
            if (percent == 100)
            {
                g_bossHP_origin = g_bossHP = bossHP;
            }
            else
            {
                g_bossHP_origin = g_bossHP = (ulong)(Math.Round((bossHP / 100.0) * percent));
            }

            g_decreasPercent = decreasPercent;

            g_percentOfHp = percent;

            InitializeComponent();

            InitAlloc();
            InitPosition();

            Process();

            InitData();

            ColorProcess();
        }

        float g_f = 0.1f;  // 오차

        int g_time;
        ulong g_user_damage;
        ulong g_bossMaxHP;
        ulong g_bossHP_origin;
        ulong g_bossHP;
        int g_percentOfHp;
        int g_decreasPercent;

        ulong g_arin_damage_1;
        ulong g_arin_damage_2;
        ulong g_arin_damage_3;
        ulong g_arin_damage_4;
        ulong g_arin_damage_5;

        Label user_damage_label;
        Label user_damage;
        Label boss_maxhp_label;
        Label boss_hp_label;

        Label result_1;
        Label result_arin_1;
        Label result_2;
        Label result_arin_2;
        Label result_3;
        Label result_arin_3;
        Label result_4;
        Label result_arin_4;
        Label result_5;
        Label result_arin_5;

        Label ex1;
        Label ex2;
        Label ex3;


        void InitAlloc()
        {
            user_damage_label = new Label();
            user_damage = new Label();

            boss_maxhp_label = new Label();
            boss_hp_label = new Label();

            result_1 = new Label();
            result_arin_1 = new Label();
            result_2 = new Label();
            result_arin_2 = new Label();
            result_3 = new Label();
            result_arin_3 = new Label();
            result_4 = new Label();
            result_arin_4 = new Label();
            result_5 = new Label();
            result_arin_5 = new Label();

            ex1 = new Label();
            ex2 = new Label();
            ex3 = new Label();

            this.Controls.Add(user_damage_label);
            this.Controls.Add(user_damage);
            this.Controls.Add(boss_maxhp_label);
            this.Controls.Add(boss_hp_label);
            this.Controls.Add(result_1);
            this.Controls.Add(result_arin_1);
            this.Controls.Add(result_2);
            this.Controls.Add(result_arin_2);
            this.Controls.Add(result_3);
            this.Controls.Add(result_arin_3);
            this.Controls.Add(result_4);
            this.Controls.Add(result_arin_4);
            this.Controls.Add(result_5);
            this.Controls.Add(result_arin_5);
            this.Controls.Add(ex1);
            this.Controls.Add(ex2);
            this.Controls.Add(ex3);
        }

        void InitPosition()
        {
            Size s = this.Size;
            int padding_LR = 10;
            int padding_UD = 10;

            int label_width = 250;
            int label_height = 15;

            int x_pos = padding_LR;
            int y_pos = padding_UD;

            s.Width = label_width + padding_LR * 2 + 20;

            int term = 15;

            user_damage_label.Location = new Point(x_pos, y_pos);

            user_damage.Location = new Point(x_pos + label_width / 2, y_pos);
            y_pos += 25;

            boss_maxhp_label.Location = new Point(x_pos, y_pos);
            y_pos += term + 5;
            boss_hp_label.Location = new Point(x_pos, y_pos);
            y_pos += 30;

            result_1.Location = new Point(x_pos, y_pos);
            y_pos += term;
            result_arin_1.Location = new Point(x_pos, y_pos);
            y_pos += 35;
            result_2.Location = new Point(x_pos, y_pos);
            y_pos += term;
            result_arin_2.Location = new Point(x_pos, y_pos);
            y_pos += 35;
            result_3.Location = new Point(x_pos, y_pos);
            y_pos += term;
            result_arin_3.Location = new Point(x_pos, y_pos);
            y_pos += 35;
            result_4.Location = new Point(x_pos, y_pos);
            y_pos += term;
            result_arin_4.Location = new Point(x_pos, y_pos);
            y_pos += 35;
            result_5.Location = new Point(x_pos, y_pos);
            y_pos += term;
            result_arin_5.Location = new Point(x_pos, y_pos);
            y_pos += 35;

            ex1.Location = new Point(x_pos, y_pos);
            y_pos += term;
            ex2.Location = new Point(x_pos, y_pos);
            y_pos += term;
            ex3.Location = new Point(x_pos, y_pos);
            y_pos += term;


            s.Height = y_pos + padding_UD * 2 + 30;


            user_damage_label.Size = new Size(label_width / 2, label_height);
            user_damage.Size = new Size(label_width / 2, label_height);
            boss_maxhp_label.Size = new Size(label_width, label_height);
            boss_hp_label.Size = new Size(label_width, label_height);

            result_1.Size = new Size(label_width, label_height);
            result_arin_1.Size = new Size(label_width, label_height);
            result_2.Size = new Size(label_width, label_height);
            result_arin_2.Size = new Size(label_width, label_height);
            result_3.Size = new Size(label_width, label_height);
            result_arin_3.Size = new Size(label_width, label_height);
            result_4.Size = new Size(label_width, label_height);
            result_arin_4.Size = new Size(label_width, label_height);
            result_5.Size = new Size(label_width, label_height);
            result_arin_5.Size = new Size(label_width, label_height);

            ex1.Size = new Size(label_width, label_height);
            ex2.Size = new Size(label_width, label_height);
            ex3.Size = new Size(label_width, label_height);

            this.Size = s;
        }

        void Process()
        {
            ulong sum = 0;

            g_arin_damage_1 = (ulong)(g_bossHP * 0.025f);
            sum += g_arin_damage_1;
            g_bossHP = g_bossHP - g_arin_damage_1;
            g_arin_damage_1 = sum;

            g_arin_damage_2 = (ulong)(g_bossHP * 0.025f);
            sum += g_arin_damage_2;
            g_bossHP = g_bossHP - g_arin_damage_2;
            g_arin_damage_2 = sum;

            g_arin_damage_3 = (ulong)(g_bossHP * 0.025f);
            sum += g_arin_damage_3;
            g_bossHP = g_bossHP - g_arin_damage_3;
            g_arin_damage_3 = sum;

            g_arin_damage_4 = (ulong)(g_bossHP * 0.025f);
            sum += g_arin_damage_4;
            g_bossHP = g_bossHP - g_arin_damage_4;
            g_arin_damage_4 = sum;

            g_arin_damage_5 = (ulong)(g_bossHP * 0.025f);
            sum += g_arin_damage_5;
            g_bossHP = g_bossHP - g_arin_damage_5;
            g_arin_damage_5 = sum;
        }

        void InitData()
        {
            user_damage_label.Text = g_time.ToString() + "초 데미지 (" + (100 - g_decreasPercent).ToString() + "%)";
            user_damage.Text = g_user_damage.MyToString();

            boss_maxhp_label.Text = "Boss Max : " + g_bossMaxHP.MyToString();
            boss_hp_label.Text = "Boss Cur : " + g_bossHP_origin.MyToString() + "(" + g_percentOfHp.ToString() + "%)";

            result_1.Text = "아린 1틱";
            result_2.Text = "아린 2틱";
            result_3.Text = "아린 3틱";
            result_4.Text = "아린 4틱";
            result_5.Text = "아린 5틱";

            result_arin_1.Text = g_arin_damage_1.MyToString();
            result_arin_2.Text = g_arin_damage_2.MyToString();
            result_arin_3.Text = g_arin_damage_3.MyToString();
            result_arin_4.Text = g_arin_damage_4.MyToString();
            result_arin_5.Text = g_arin_damage_5.MyToString();

            ex1.Text = "무지성 아린 장착";
            ex2.Text = "비슷함( +- " + (g_f * 100).ToString() + "% )";
            ex3.Text = "딜 이후 아린 스위칭";
        }

        void ColorProcess()
        {
            result_arin_1.ForeColor = Color.White;
            result_arin_2.ForeColor = Color.White;
            result_arin_3.ForeColor = Color.White;
            result_arin_4.ForeColor = Color.White;
            result_arin_5.ForeColor = Color.White;

            result_arin_1.BackColor = GetColor(Compare(g_arin_damage_1, g_user_damage, g_f));
            result_arin_2.BackColor = GetColor(Compare(g_arin_damage_2, g_user_damage, g_f));
            result_arin_3.BackColor = GetColor(Compare(g_arin_damage_3, g_user_damage, g_f));
            result_arin_4.BackColor = GetColor(Compare(g_arin_damage_4, g_user_damage, g_f));
            result_arin_5.BackColor = GetColor(Compare(g_arin_damage_5, g_user_damage, g_f));

            ex1.ForeColor = Color.White;
            ex1.BackColor = Color.Red;
            ex2.ForeColor = Color.White;
            ex2.BackColor = Color.Blue;
            ex3.ForeColor = Color.White;
            ex3.BackColor = Color.Green;
        }

        // - 1 arin 우세
        // 0 
        // - 1 user 우세
        // f : +-오차 범위
        int Compare(ulong arin, ulong user, float f)
        {
            float diff = user * f;
            ulong lower = user - (ulong)diff;
            ulong upper = user + (ulong)diff;

            if (lower > arin)
                return 1;
            if (arin > upper)
                return -1;
            return 0;
        }

        Color GetColor(int compare_val)
        {
            if (compare_val == -1)
            {
                return Color.Red;
            }
            if (compare_val == 1)
            {
                return Color.Green;
            }
            return Color.Blue;
        }
    }
}
