// Copyright (Fairy)Phy. licensed under the MIT license.
// Specifically, please see LICENSE file.

using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mania_new_pp_calculator.Script;


namespace Mania_new_pp_calculator
{
	public partial class Form1 : Form
	{
		
		public Form1()
		{
			InitializeComponent();
		}

		private void Numeric_stars_ValueChanged(object sender, EventArgs e)
		{
			string total_pp = pp_calculator.PP_calculator(numeric_stars.Value, numeric_od.Value, numeric_score.Value, numeric_objects.Value, check_easy.Checked, check_nofail.Checked, check_halftime.Checked);
			text_ppshow.Text = total_pp;
		}

		private void Numeric_od_ValueChanged(object sender, EventArgs e)
		{
			string total_pp = pp_calculator.PP_calculator(numeric_stars.Value, numeric_od.Value, numeric_score.Value, numeric_objects.Value, check_easy.Checked, check_nofail.Checked, check_halftime.Checked);
			text_ppshow.Text = total_pp;
		}

		private void Numeric_score_ValueChanged(object sender, EventArgs e)
		{
			string total_pp = pp_calculator.PP_calculator(numeric_stars.Value, numeric_od.Value, numeric_score.Value, numeric_objects.Value, check_easy.Checked, check_nofail.Checked, check_halftime.Checked);
			text_ppshow.Text = total_pp;
		}

		private void Numeric_objects_ValueChanged(object sender, EventArgs e)
		{
			string total_pp = pp_calculator.PP_calculator(numeric_stars.Value, numeric_od.Value, numeric_score.Value, numeric_objects.Value, check_easy.Checked, check_nofail.Checked, check_halftime.Checked);
			text_ppshow.Text = total_pp;
		}

		private void Check_easy_CheckedChanged(object sender, EventArgs e)
		{
			string total_pp = pp_calculator.PP_calculator(numeric_stars.Value, numeric_od.Value, numeric_score.Value, numeric_objects.Value, check_easy.Checked, check_nofail.Checked, check_halftime.Checked);
			text_ppshow.Text = total_pp;
		}

		private void Check_nofail_CheckedChanged(object sender, EventArgs e)
		{
			string total_pp = pp_calculator.PP_calculator(numeric_stars.Value, numeric_od.Value, numeric_score.Value, numeric_objects.Value, check_easy.Checked, check_nofail.Checked, check_halftime.Checked);
			text_ppshow.Text = total_pp;
		}

		private void Check_halftime_CheckedChanged(object sender, EventArgs e)
		{
			string total_pp = pp_calculator.PP_calculator(numeric_stars.Value, numeric_od.Value, numeric_score.Value, numeric_objects.Value, check_easy.Checked, check_nofail.Checked, check_halftime.Checked);
			text_ppshow.Text = total_pp;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			string total_pp = pp_calculator.PP_calculator(numeric_stars.Value, numeric_od.Value, numeric_score.Value, numeric_objects.Value, check_easy.Checked, check_nofail.Checked, check_halftime.Checked);
			text_ppshow.Text = total_pp;
		}

		private void Text_ppshow_Click(object sender, EventArgs e)
		{
			Del_copy();
		}

		private async void Del_copy() {
			Clipboard.SetText(text_ppshow.Text);
			text_copied.Text = "Copied!";
			await Task.Delay(3000);
			text_copied.Text = "";
		}

		private void But_reset_Click(object sender, EventArgs e)
		{
			numeric_stars.Value = 0;
			numeric_od.Value = 0;
			numeric_score.Value = 0;
			numeric_objects.Value = 0;
			check_easy.Checked = false;
			check_nofail.Checked = false;
			check_halftime.Checked = false;

			string total_pp = pp_calculator.PP_calculator(numeric_stars.Value, numeric_od.Value, numeric_score.Value, numeric_objects.Value, check_easy.Checked, check_nofail.Checked, check_halftime.Checked);
			text_ppshow.Text = total_pp;
		}
	}
}
