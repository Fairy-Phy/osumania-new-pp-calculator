// Copyright (Fairy)Phy. licensed under the MIT license.
// Specifically, please see LICENSE file.
// based on http://maniapp.uy.to/

let star_dif = 6.76;
let map_objects = 4279;
let score = 898203;
let map_od = 8;
// 使用したModをtrueにする
let mods = {
    easy: false,
    nofail: false,
    halftime: false
};

// ここから下は入力しない
let decline_od = 1,
    decline_pp = 1,
    decline_score = 1;

if (mods.easy == true) {
    decline_od *= 0.5;
    decline_pp *= 0.5;
    decline_score *= 0.5;
};
if (mods.nofail == true) {
    decline_pp *= 0.9;
    decline_score *= 0.5;
};
if (mods.halftime == true) decline_score *= 0.5;

map_od /= decline_od;

score /= decline_score;

// Main algorithm
let star_difvalue = Math.pow(5 * Math.max(1, star_dif / 0.2) - 4, 2.2) / 135;
    star_difvalue *= 1 + 0.1 * Math.min(1, map_objects / 1500);

let strainmultiplier, accuracyvalue;

if (score < 500000) strainmultiplier = score / 500000 * 0.1;
else if (score < 600000) strainmultiplier = (score - 500000) / 100000 * 0.3;
else if (score < 700000) strainmultiplier = (score - 600000) / 100000 * 0.25 + 0.3;
else if (score < 800000) strainmultiplier = (score - 700000) / 100000 * 0.2 + 0.55;
else if (score < 900000) strainmultiplier = (score - 800000) / 100000 * 0.15 + 0.75;
else strainmultiplier = (score - 900000) / 100000 * 0.1 + 0.9;

if (score >= 960000) accuracyvalue = map_od * decline_od * 0.02 * star_difvalue * Math.pow((score - 960000) / 40000, 1.1)
else accuracyvalue = 0;

let totalpp = 0.73 * Math.pow(Math.pow(accuracyvalue, 1.1) + Math.pow(star_difvalue * strainmultiplier, 1.1), 1 / 1.1)
    totalpp = totalpp * 1.1 * decline_pp;
    totalpp = Math.round(totalpp * 100) / 100;

let show_maxpp = 9999999999999999999999.99;

if (totalpp > show_maxpp) {
    totalpp_s = totalpp.toExponential() + " pp";
}
else totalpp_s = totalpp + " pp";

console.log(totalpp + " pp");