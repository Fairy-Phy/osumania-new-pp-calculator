namespace Mania_new_pp_calculator
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.text_stars = new System.Windows.Forms.Label();
			this.text_od = new System.Windows.Forms.Label();
			this.hint = new System.Windows.Forms.ToolTip(this.components);
			this.text_score = new System.Windows.Forms.Label();
			this.text_objects = new System.Windows.Forms.Label();
			this.text_mods = new System.Windows.Forms.Label();
			this.text_ppshow = new System.Windows.Forms.Label();
			this.but_reset = new System.Windows.Forms.Button();
			this.text_pp = new System.Windows.Forms.Label();
			this.numeric_stars = new System.Windows.Forms.NumericUpDown();
			this.numeric_od = new System.Windows.Forms.NumericUpDown();
			this.numeric_score = new System.Windows.Forms.NumericUpDown();
			this.numeric_objects = new System.Windows.Forms.NumericUpDown();
			this.check_easy = new System.Windows.Forms.CheckBox();
			this.check_nofail = new System.Windows.Forms.CheckBox();
			this.check_halftime = new System.Windows.Forms.CheckBox();
			this.text_copied = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numeric_stars)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_od)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_score)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_objects)).BeginInit();
			this.SuspendLayout();
			// 
			// text_stars
			// 
			resources.ApplyResources(this.text_stars, "text_stars");
			this.text_stars.Name = "text_stars";
			this.hint.SetToolTip(this.text_stars, resources.GetString("text_stars.ToolTip"));
			// 
			// text_od
			// 
			resources.ApplyResources(this.text_od, "text_od");
			this.text_od.Name = "text_od";
			this.hint.SetToolTip(this.text_od, resources.GetString("text_od.ToolTip"));
			// 
			// text_score
			// 
			resources.ApplyResources(this.text_score, "text_score");
			this.text_score.Name = "text_score";
			this.hint.SetToolTip(this.text_score, resources.GetString("text_score.ToolTip"));
			// 
			// text_objects
			// 
			resources.ApplyResources(this.text_objects, "text_objects");
			this.text_objects.Name = "text_objects";
			this.hint.SetToolTip(this.text_objects, resources.GetString("text_objects.ToolTip"));
			// 
			// text_mods
			// 
			resources.ApplyResources(this.text_mods, "text_mods");
			this.text_mods.Name = "text_mods";
			this.hint.SetToolTip(this.text_mods, resources.GetString("text_mods.ToolTip"));
			// 
			// text_ppshow
			// 
			resources.ApplyResources(this.text_ppshow, "text_ppshow");
			this.text_ppshow.Name = "text_ppshow";
			this.hint.SetToolTip(this.text_ppshow, resources.GetString("text_ppshow.ToolTip"));
			this.text_ppshow.Click += new System.EventHandler(this.Text_ppshow_Click);
			// 
			// but_reset
			// 
			resources.ApplyResources(this.but_reset, "but_reset");
			this.but_reset.Name = "but_reset";
			this.hint.SetToolTip(this.but_reset, resources.GetString("but_reset.ToolTip"));
			this.but_reset.UseVisualStyleBackColor = true;
			this.but_reset.Click += new System.EventHandler(this.But_reset_Click);
			// 
			// text_pp
			// 
			resources.ApplyResources(this.text_pp, "text_pp");
			this.text_pp.Name = "text_pp";
			this.hint.SetToolTip(this.text_pp, resources.GetString("text_pp.ToolTip"));
			// 
			// numeric_stars
			// 
			this.numeric_stars.DecimalPlaces = 2;
			resources.ApplyResources(this.numeric_stars, "numeric_stars");
			this.numeric_stars.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numeric_stars.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
			this.numeric_stars.Name = "numeric_stars";
			this.numeric_stars.ValueChanged += new System.EventHandler(this.Numeric_stars_ValueChanged);
			// 
			// numeric_od
			// 
			resources.ApplyResources(this.numeric_od, "numeric_od");
			this.numeric_od.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numeric_od.Name = "numeric_od";
			this.numeric_od.ValueChanged += new System.EventHandler(this.Numeric_od_ValueChanged);
			// 
			// numeric_score
			// 
			resources.ApplyResources(this.numeric_score, "numeric_score");
			this.numeric_score.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numeric_score.Name = "numeric_score";
			this.numeric_score.ValueChanged += new System.EventHandler(this.Numeric_score_ValueChanged);
			// 
			// numeric_objects
			// 
			resources.ApplyResources(this.numeric_objects, "numeric_objects");
			this.numeric_objects.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
			this.numeric_objects.Name = "numeric_objects";
			this.numeric_objects.ValueChanged += new System.EventHandler(this.Numeric_objects_ValueChanged);
			// 
			// check_easy
			// 
			resources.ApplyResources(this.check_easy, "check_easy");
			this.check_easy.Name = "check_easy";
			this.check_easy.UseVisualStyleBackColor = true;
			this.check_easy.CheckedChanged += new System.EventHandler(this.Check_easy_CheckedChanged);
			// 
			// check_nofail
			// 
			resources.ApplyResources(this.check_nofail, "check_nofail");
			this.check_nofail.Name = "check_nofail";
			this.check_nofail.UseVisualStyleBackColor = true;
			this.check_nofail.CheckedChanged += new System.EventHandler(this.Check_nofail_CheckedChanged);
			// 
			// check_halftime
			// 
			resources.ApplyResources(this.check_halftime, "check_halftime");
			this.check_halftime.Name = "check_halftime";
			this.check_halftime.UseVisualStyleBackColor = true;
			this.check_halftime.CheckedChanged += new System.EventHandler(this.Check_halftime_CheckedChanged);
			// 
			// text_copied
			// 
			resources.ApplyResources(this.text_copied, "text_copied");
			this.text_copied.Name = "text_copied";
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.but_reset);
			this.Controls.Add(this.text_copied);
			this.Controls.Add(this.text_ppshow);
			this.Controls.Add(this.text_pp);
			this.Controls.Add(this.check_halftime);
			this.Controls.Add(this.check_nofail);
			this.Controls.Add(this.check_easy);
			this.Controls.Add(this.text_mods);
			this.Controls.Add(this.numeric_objects);
			this.Controls.Add(this.numeric_score);
			this.Controls.Add(this.numeric_od);
			this.Controls.Add(this.numeric_stars);
			this.Controls.Add(this.text_objects);
			this.Controls.Add(this.text_score);
			this.Controls.Add(this.text_od);
			this.Controls.Add(this.text_stars);
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.numeric_stars)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_od)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_score)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_objects)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label text_stars;
		private System.Windows.Forms.ToolTip hint;
		private System.Windows.Forms.Label text_od;
		private System.Windows.Forms.Label text_score;
		private System.Windows.Forms.Label text_objects;
		private System.Windows.Forms.NumericUpDown numeric_stars;
		private System.Windows.Forms.NumericUpDown numeric_od;
		private System.Windows.Forms.NumericUpDown numeric_score;
		private System.Windows.Forms.NumericUpDown numeric_objects;
		private System.Windows.Forms.Label text_mods;
		private System.Windows.Forms.CheckBox check_easy;
		private System.Windows.Forms.CheckBox check_nofail;
		private System.Windows.Forms.CheckBox check_halftime;
		private System.Windows.Forms.Label text_pp;
		private System.Windows.Forms.Label text_ppshow;
		private System.Windows.Forms.Label text_copied;
		private System.Windows.Forms.Button but_reset;
	}
}

