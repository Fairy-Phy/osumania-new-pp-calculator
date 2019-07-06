// Copyright (Fairy)Phy. licensed under the MIT license.
// Specifically, please see LICENSE file.

using System;
using System.Windows.Forms;

namespace Mania_new_pp_calculator
{
	static class main
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
