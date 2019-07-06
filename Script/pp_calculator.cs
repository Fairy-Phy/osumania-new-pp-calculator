// Copyright (Fairy)Phy. licensed under the MIT license.
// Specifically, please see LICENSE file.
// based on mania pp calculator.js

using System;
using System.Collections.Generic;

namespace Mania_new_pp_calculator.Script
{
	class pp_calculator
	{
		public static string PP_calculator(decimal star_dif_d, decimal map_od_d, decimal score_d, decimal map_objects_d, bool easy, bool nofail, bool halftime) {

			double map_objects = (double)map_objects_d,
				   map_od = (double)map_od_d,
				   score = (double)score_d,
				   star_dif = (double)star_dif_d;

			var mods = new Dictionary<string, bool>(){
				{"easy" , easy},
				{"nofail" , nofail},
				{"halftime" , halftime}
			};

			double decline_od = 1,
				   decline_pp = 1,
				   decline_score = 1;

			if (mods["easy"] == true) {
				decline_od *= 0.5;
				decline_pp *= 0.5;
				decline_score *= 0.5;
			}
			if (mods["nofail"] == true) {
				decline_pp *= 0.9;
				decline_score *= 0.5;
			}
			if (mods["halftime"] == true) decline_score *= 0.5;

			map_od /= decline_od;

			score /= decline_score;

			// Main algorithm
			double star_difvalue = Math.Pow( ( 5 * Math.Max(1, star_dif / 0.2) ) - 4, 2.2) / 135;
				   star_difvalue *= 1 + ( 0.1 * Math.Min(1, map_objects / 1500) );

			double strainmultiplier, accuracyvalue;

			if (score < 500000) strainmultiplier = ( score / 500000 ) * 0.1;
			else if (score < 600000) strainmultiplier = ( (score - 500000) / 100000 ) * 0.3;
			else if (score < 700000) strainmultiplier = ( ( (score - 600000) / 100000 ) * 0.25 ) + 0.3;
			else if (score < 800000) strainmultiplier = ( ( (score - 700000) / 100000 ) * 0.2 ) + 0.55;
			else if (score < 900000) strainmultiplier = ( ( (score - 800000) / 100000 ) * 0.15 ) + 0.75;
			else strainmultiplier = ( ( (score - 900000) / 100000 ) * 0.1 ) + 0.9;

			if (score >= 960000) {
				accuracyvalue = map_od * decline_od * 0.02 * star_difvalue * Math.Pow((score - 960000) / 40000, 1.1);
			}
			else accuracyvalue = 0;

			double totalpp = 0.73 * Math.Pow(Math.Pow(accuracyvalue, 1.1) + Math.Pow(star_difvalue * strainmultiplier, 1.1), 1 / 1.1);
				   totalpp = totalpp * 1.1 * decline_pp;

			totalpp = Math.Round(totalpp * 100) / 100;

			string totalpp_s;
			double show_maxpp = 9999999999999999999999.99;

			if (totalpp > show_maxpp) {
				totalpp_s = totalpp.ToString("E") + " pp";
			}
			else totalpp_s = totalpp.ToString() + " pp";

			return totalpp_s;
		}
	}
}
