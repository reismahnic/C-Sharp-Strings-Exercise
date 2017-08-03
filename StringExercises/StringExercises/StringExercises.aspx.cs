using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StringExercises
{
    public partial class StringExercises : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Challenge 1: Reverse my name
            string name = "Reis Mahnic";

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Exercise1lbl.Text += name[i];
            }

            //Challenge 2: Reverse a list of names
            string names = "Luke,Leia,Han,Chewbacca";

            string[] nameList = names.Split(',');
            string results = "";
            for (int i = nameList.Length - 1; i >= 0; i--)
            {
                results += nameList[i] + ",";
            }
            results = results.Remove(results.Length - 1, 1);
            Exercise2lbl.Text = results;

            //Challenge 3: List of names with ASCII art
            string art = "";
            for (int i = 0; i < nameList.Length; i++)
            {
                int leftSide = (14 - nameList[i].Length) / 2;
                string padding = nameList[i].PadLeft(nameList[i].Length + leftSide, '*');
                art += padding.PadRight(14, '*');
                art += "<br />";
                Exercise3lbl.Text = art;
            }

            //Challenge 4: Puzzle

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF THEIR COUNTRY";
            puzzle = puzzle.ToLower();
            puzzle = puzzle.Replace("z", "t");
            puzzle = puzzle.Remove(0, 1);
            puzzle = puzzle.Insert(0, "N");
            puzzle = puzzle.Remove(10, 9);
           


            Exercise4lbl.Text = puzzle;
        }
    }
}